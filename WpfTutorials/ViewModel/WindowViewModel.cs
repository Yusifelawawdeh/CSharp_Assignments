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

        public WindowViewModel(Window window)
        {
            _window = window;
        }

    }
}
