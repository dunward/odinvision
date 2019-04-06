using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OdinTheme
{
    public class OdinWindow : Window
    {
        public OdinWindow()
        {
            InitializeCommandBindings();
            Style = FindResource(typeof(OdinWindow)) as Style;
        }

        static OdinWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(OdinWindow), new FrameworkPropertyMetadata(typeof(OdinWindow)));
        }

        #region Command Bindings
        void InitializeCommandBindings()
        {
            CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, CommandBinding_CloseExecuted));
            CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, CommandBinding_MaximizeExecuted));
            CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, CommandBinding_MinimizeExecuted));
            CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, CommandBinding_RestoreExecuted));
        }

        void CommandBinding_RestoreExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.RestoreWindow(this);
        }

        void CommandBinding_MinimizeExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        void CommandBinding_MaximizeExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if(WindowState == WindowState.Maximized)
            {
                SystemCommands.RestoreWindow(this);
            }
            else
            {
                SystemCommands.MaximizeWindow(this);
            }
        }

        void CommandBinding_CloseExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }
        #endregion
    }
}
