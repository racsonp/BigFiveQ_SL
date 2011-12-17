using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BigFiveQ.Controls.ExamenBfqUi
{
    public class SwitcherControl : UserControl
    {
        public void SwitchPage(UserControl oPage)
        {
            oPage.Background = new SolidColorBrush(Colors.Transparent);
            oPage.Margin = new Thickness(5, 5, 5, 5);

            Content = oPage;
        }
    }
}