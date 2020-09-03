using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace IsCreamApp.View
{
    public partial class IsCreamView : UserControl
    {
        
        public IsCreamView()
        {
            InitializeComponent();
            
        }

        private void CallPanelClick(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "MostrarShiftState", true);
        }

        private void BackToMainPanel(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "Normal", true);
        }

        private void CallProductsWindow(object sender, RoutedEventArgs e)
        {
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(QuantityText.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                QuantityText.Text = QuantityText.Text.Remove(QuantityText.Text.Length - 1);

            }

        }
    }
}
