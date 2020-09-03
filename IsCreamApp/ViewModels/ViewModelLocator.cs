using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace IsCreamApp.ViewModels
{
    public class ViewModelLocator
    {
        private ProductViewModel _productViewModel;
        public ProductViewModel ProductViewModel
        {
            get
            {
                return _productViewModel ??
                (_productViewModel = new ProductViewModel());
            }

        }
    }
}
