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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace PhoneDetailsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //create a dictionary to hold phone objects
        Dictionary<string, Phone> phoneDict = new Dictionary<string, Phone>();
        public MainWindow()
        {
            InitializeComponent();
            LoadPhones();
            /* Read Read Phones from text file
             * Add the phones to a dictionary
             * Show the phones to the user in the combobox
             * Display the selected phone details to the user in the phone details window.
            */
        }
        /// <summary>
        /// Read the phones from the text file and add teh phones to a dictionary and the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadPhones()
        {
            //streamreader
            StreamReader inputfile;
            try
            {

                inputfile = File.OpenText("phonelist.txt");
                //go through each of the lines of the text file
                while (!inputfile.EndOfStream)
                {
                    string[] tempPhone = inputfile.ReadLine().Split(',');
                    //add the contents of the text file to a dictionary
                    Phone currentPhone = new Phone(tempPhone);

                    phoneDict.Add(currentPhone.Model, currentPhone);
                    //add the model of the phone to the combobox
                    CbPhones.Items.Add(currentPhone.Model);


                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnDetails_Click(object sender, RoutedEventArgs e)
        {
            //makes sure the user has selected something
            if (CbPhones.SelectedIndex != -1)
            {
                string selectedPhone = CbPhones.SelectedItem.ToString();
                if (phoneDict.TryGetValue(selectedPhone, out Phone currentPhone))
                {
                    //instantiate our details window
                    PhoneDetailWindow detailsWindow = new PhoneDetailWindow(currentPhone);
                    //show window as a modal window
                    detailsWindow.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Phone not found.");
                }
                
            }
            else
            {
                MessageBox.Show("Please select a phone.");
            }
            
        }
    }
}
