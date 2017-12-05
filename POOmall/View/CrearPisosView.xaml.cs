using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POOmall.View
{
    /// <summary>
    /// Interaction logic for CrearPisosView.xaml
    /// </summary>
    public partial class CrearPisosView : UserControl
    {
        public CrearPisosView()
        {
            InitializeComponent();
        }

        #region Solo permitir imput numeros
        //https://stackoverflow.com/a/1268648
        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }
        private void OnlyNumbers(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
        #endregion

    }
}
