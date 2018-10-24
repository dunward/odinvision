using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OdinTheme
{
    public class OdinTheme : ResourceDictionary
    {
        public OdinTheme()
        {
            Source = new Uri("pack://application:,,,/OdinTheme;component/OdinWindow/OdinThemeComponent.xaml");
        }
    }
}