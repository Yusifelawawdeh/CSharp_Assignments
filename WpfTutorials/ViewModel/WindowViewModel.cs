using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfTutorials.DataModels;
using WpfTutorials.Window;

namespace WpfTutorials.ViewModel
{
    /// <summary>
    /// view model for the custom flat window
    /// </summary>
    class WindowViewModel : BaseViewModel
    {
        private System.Windows.Window _window;

        private int _outerMarginSize = 3;

        private int _windowRadius = 3;

        public double WindowMinWidth { get; set; } = 400;

        public double WindowMinHeight { get; set; } = 400;

        public int ResizeBorder { get; set; } = 6;

        public Thickness ResizeBorderThinckness => new Thickness(ResizeBorder + OuterMarginSize);

        public Thickness InnerContentPadding => new Thickness(ResizeBorder);

        public int OuterMarginSize
        {
            get => _window.WindowState == WindowState.Maximized ? 0 : _outerMarginSize;
            set => _outerMarginSize = value;
        }

        public Thickness OuterMarginSizeThickness => new Thickness(OuterMarginSize);

        public int WindowRadius
        {
            get => _window.WindowState == WindowState.Maximized ? 0 : _windowRadius;
            set => _windowRadius = value;
        }

        public CornerRadius WindowCornerRadius => new CornerRadius(WindowRadius);

        public int TitleHeight { get; set; } = 25;

        public GridLength TitleHeightGridlength => new GridLength(TitleHeight + ResizeBorder);

        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        #region Button Commands
        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand SystemMenuCommand { get; set; } 
        #endregion

        #region Constructor s

	    public WindowViewModel(System.Windows.Window window)
        {
            _window = window;

            _window.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(ResizeBorderThinckness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };

            MinimizeCommand = new RelayCommand(() => _window.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => _window.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => _window.Close());
            SystemMenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(_window, GetmousePosition()));

            //fix window resize issue 
            var resizer = new WindowResizer(_window);


        }

        #endregion

        #region Private Helpers
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]

        internal static extern bool GetCursorPos(ref Win32Point pt);

        [StructLayout(LayoutKind.Sequential)]
        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };

        private static Point GetmousePosition()
        {
            Win32Point w32Mouse = new Win32Point();
            GetCursorPos(ref w32Mouse);
            return new Point(w32Mouse.X, w32Mouse.Y);
        }

        #endregion
    }
}
