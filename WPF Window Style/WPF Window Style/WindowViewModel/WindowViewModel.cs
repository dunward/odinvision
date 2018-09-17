using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_Window_Style
{
    class WindowViewModel : BaseViewModel
    {
        private Window window;

        private int _outerMarginSize = 10;

        public string Test { get; set; } = "My String";
        public int ResizeBorder { get; set; } = 6;

        public int TitleHeight
        {
            get
            {
                return window.WindowState == WindowState.Maximized ? 32 : 26;
            }
        }

        public GridLength TitleHeightGridLenght { get { return new GridLength(TitleHeight); } }

        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        public int OuterMarginSize
        {
            get
            {
                return window.WindowState == WindowState.Maximized ? 0 : _outerMarginSize;
            }
            set
            {
                _outerMarginSize = value;
            }
        }

        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

        public ICommand MinimizeCommand { get; set; }

        public ICommand MaximizeCommand { get; set; }

        public ICommand CloseCommand { get; set; }

        public WindowViewModel(Window _window)
        {
            window = _window;

            window.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(TitleHeight));
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(TitleHeightGridLenght));
            };

            MinimizeCommand = new RelayCommand(() => window.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() =>
            {
                switch (window.WindowState)
                {
                    case WindowState.Maximized:
                        window.WindowState = WindowState.Normal;
                        break;

                    case WindowState.Normal:
                        window.WindowState = WindowState.Maximized;
                        break;
                }
            }
            );
            CloseCommand = new RelayCommand(() => window.Close());
        }
    }
}
