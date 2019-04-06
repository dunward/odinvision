## OdinWindowTheme
OdinWindowTheme is support your wpf application window design.<br>

![WhiteTheme](./Resources/white-theme.png)

## Tutorial
First. Create WPF app and add reference OdinTheme.dll<br>
Second. Add ``xmlns:o="clr-namespace:OdinTheme;assembly=OdinTheme"`` like this<br>

<b>App.xaml</b>
```
<Application x:Class="WpfApp.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:local="clr-namespace:WpfApp"
             xmlns:o="clr-namespace:OdinTheme;assembly=OdinTheme"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <o:OdinTheme/>
    </Application.Resources>
</Application>
```
<b>MainWindow.xaml</b>
```
<o:OdinWindow x:Class="WpfApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp"
        xmlns:o="clr-namespace:OdinTheme;assembly=OdinTheme"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>

    </Grid>
</o:OdinWindow>
```

Third. Add namespace OdinTheme and Change OdinWindow
```
using OdinTheme;

namespace WpfApp
{
    public partial class MainWindow : OdinWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
```
