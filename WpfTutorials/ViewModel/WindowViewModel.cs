using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfTutorials.ViewModel
{
    /// <summary>
    /// view model for the custom flat window
    /// </summary>
    class WindowViewModel : BaseViewModel
    {
        private Window _window;

        private int _outerMarginSize = 10;

        private int _windowRadius = 10;

        public int ResizeBorder { get; set; } = 6;

        public Thickness ResizeBorderThinckness => new Thickness(ResizeBorder + OuterMarginSize);

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

        public WindowViewModel(Window window)
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

        }

    }
}
