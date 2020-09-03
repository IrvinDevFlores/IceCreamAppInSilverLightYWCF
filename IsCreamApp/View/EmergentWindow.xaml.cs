using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using IsCreamApp.ViewModels;
namespace IsCreamApp.View
{
    public partial class EmergentWindow : ChildWindow
    {
        public EmergentWindow()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            Cambio.Text = (int.Parse(PaymentTextbox.Text) - int.Parse(Total.Text)).ToString();

            if (Regex.IsMatch(PaymentTextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                PaymentTextbox.Text = PaymentTextbox.Text.Remove(PaymentTextbox.Text.Length - 1);

            }

            

        }
    }
}

