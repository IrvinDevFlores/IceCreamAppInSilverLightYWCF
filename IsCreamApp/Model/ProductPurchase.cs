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

namespace IsCreamApp.Model
{
    public class ProductPurchase
    {
        public string ProductName { get; set; }
        public bool PurchaseState { get; set; }
        public string Size { get; set; }
        public string SelectedIngredient { get; set; }
        public int Price { get; internal set; }
        public int Cantidad { get; internal set; }
    }
}
