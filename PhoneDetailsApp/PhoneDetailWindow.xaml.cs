using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PhoneDetailsApp
{
    /// <summary>
    /// Interaction logic for PhoneDetailWindow.xaml
    /// </summary>
    public partial class PhoneDetailWindow : Window
    {
        public PhoneDetailWindow(Phone currentPhone)
        {
            InitializeComponent();
            //assign labels the property balues 
            LblDisplay.Content = currentPhone.Display;
            LblMake.Content = currentPhone.Make;
            LblModel.Content = currentPhone.Model;
            LblPrice.Content = currentPhone.Price.ToString("c");
            LblStorage.Content = currentPhone.Storage;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
