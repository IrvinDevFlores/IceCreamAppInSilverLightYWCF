using GalaSoft.MvvmLight.Command;
using IsCreamApp.Model;
using IsCreamApp.View;
using System.Collections.ObjectModel;
using System.Windows;

namespace IsCreamApp.ViewModels
{
    public class ProductViewModel : BaseINPC
    {
        public decimal Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    
                    if(_amount < (decimal)Total)
                    {
                        MessageBox.Show("El monto no puede ser menor de lo que debe");
                        return;
                    }

                    Change = _amount - (decimal)Total;

                    RaisePropertyChanged(nameof(Amount));
                }
            }
        }
        private decimal _amount;


        private string _productName;
        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (_productName != value)
                {
                    _productName = value;
                    RaisePropertyChanged(nameof(ProductName));
                }
            }
        }

        private bool _isCheck;
        public bool IsChecked
        {
            get { return _isCheck; }
            set
            {
                if (_isCheck != value)
                {
                    _isCheck = value;
                    RaisePropertyChanged(nameof(IsChecked));
                }
            }
        }

        public string Size
        {
            get { return _size; }
            set
            {
                if (_size != value)
                {
                    _size = value;
                    RaisePropertyChanged(nameof(Size));
                }
            }
        }
        private string _size;

        public string Ingredient
        {
            get { return _ingredient; }
            set
            {
                if (_ingredient != value)
                {
                    _ingredient = value;
                    RaisePropertyChanged(nameof(Ingredient));
                }
            }
        }
        private string _ingredient;

        public int Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    RaisePropertyChanged(nameof(Price));
                }
            }
        }
        private int _price;

        public int Quantity
        {
            get { return number; }
            set
            {
                if (number != value)
                {
                    number = value;
                    RaisePropertyChanged(nameof(Quantity));
                }
            }
        }
        private int number;

        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                if (_selectedProduct != value)
                {
                    _selectedProduct = value;
                    RaisePropertyChanged(nameof(SelectedProduct));
                }
            }
        }
        private Product _selectedProduct;
        public ObservableCollection<Product> ProductosInStock
        {
            get { return _productosInStock; }
            set
            {
                if (_productosInStock != value)
                {
                    _productosInStock = value;
                    RaisePropertyChanged(nameof(ProductosInStock));
                }
            }
        }
        private ObservableCollection<Product> _productosInStock;
        public string SelectedSize
        {
            get { return _selectedSize; }
            set
            {
                if (_selectedSize != value)
                {
                    _selectedSize = value;
                    switch (_selectedSize)
                    {
                        case StaticSizes.GRANDE:
                            Price = 40;
                            break;

                        case StaticSizes.MEDIANO:
                            Price = 30;
                            break;

                        case StaticSizes.PEQUE:
                            Price = 20;
                            break;

                    }
                    RaisePropertyChanged(nameof(SelectedSize));
                }
            }
        }
        public string SelectedIngredient
        {
            get { return _selectedIngredient; }
            set
            {
                if (_selectedIngredient != value)
                {
                    _selectedIngredient = value;
                    RaisePropertyChanged(nameof(SelectedIngredient));
                }
            }
        }
        private string _selectedIngredient;
        private string _selectedSize;
        public double Subtotal
        {
            get { return _subtotal; }
            set
            {
                if (_subtotal != value)
                {
                    _subtotal = value;
                    RaisePropertyChanged(nameof(Subtotal));
                }
            }
        }
        private double _subtotal;
        public ObservableCollection<ProductPurchase> ProductosEnCarrito
        {
            get { return _productosEnCarrito; }
            set
            {
                if (_productosEnCarrito != value)
                {
                    _productosEnCarrito = value;
                    RaisePropertyChanged(nameof(ProductosEnCarrito));
                }
            }
        }
        private ObservableCollection<ProductPurchase> _productosEnCarrito;
        public double Total
        {
            get { return _total; }
            set
            {
                if (_total != value)
                {
                    _total = value;
                    RaisePropertyChanged(nameof(Total));
                }
            }
        }
        private double _total;
        public string ProductNameInStock
        {
            get { return productNameInStock; }
            set
            {
                if (productNameInStock != value)
                {
                    productNameInStock = value;
                    RaisePropertyChanged(nameof(ProductNameInStock));
                }
            }
        }
        private string productNameInStock;
        public string ProductSizeInStock
        {
            get { return _productSize; }
            set
            {
                if (_productSize != value)
                {
                    _productSize = value;
                    RaisePropertyChanged(nameof(ProductSizeInStock));
                }
            }
        }
        private string _productSize;
        public int ProductPriceInStock
        {
            get { return _productPrice; }
            set
            {
                if (_productPrice != value)
                {
                    _productPrice = value;
                    RaisePropertyChanged(nameof(ProductPriceInStock));
                }
            }
        }
        private int _productPrice;
        public string ProductIngredient
        {
            get { return _ptoductIngredient; }
            set
            {
                if (_ptoductIngredient != value)
                {
                    _ptoductIngredient = value;
                    RaisePropertyChanged(nameof(ProductIngredient));
                }
            }
        }
        private string _ptoductIngredient;
        public bool PurchaseOk
        {
            get { return _purchaeState; }
            set
            {
                if (_purchaeState != value)
                {
                    _purchaeState = value;
                    RaisePropertyChanged(nameof(PurchaseOk));
                }
            }
        }
        private bool _purchaeState;

        public decimal Change
        {
            get { return _change; }
            set
            {
                if (_change != value)
                {
                    _change = value;
                    RaisePropertyChanged(nameof(Change));
                }
            }
        }
        private decimal _change;


        //
        public RelayCommand AddToCarCommand { get; set; }
        void AddToCard()
        {
            bool fildsAreEmpty = (SelectedIngredient == null && SelectedProduct == null && SelectedSize == null && Price == 0 && Quantity == 0) ?
                                    true : false;
            ProductPurchase product = (fildsAreEmpty) ? null : new ProductPurchase
            {
                ProductName = SelectedProduct.Nombre,
                PurchaseState = PurchaseOk = true,
                SelectedIngredient = SelectedIngredient,
                Price = Price,
                Cantidad = Quantity,
                Size = SelectedSize
            };

            if (product == null)
            {
                MessageBox.Show("No ha elegido nada");
                return;
            }
            ProductosEnCarrito.Add(product);
            Total += Price * Quantity;
            Subtotal = Total+(Total * 0.15);

        }
        //
        public RelayCommand ComandoAgregarProducto { get; set; }
        public void AgregarProducto()
        {
            Product product = (ProductNameInStock == null && ProductPriceInStock == 0 && ProductIngredient == null && ProductSizeInStock == null) ?
                                null : new Product
                                {
                                    Nombre = ProductNameInStock,
                                    Precio = ProductPriceInStock,
                                    TamaniosDisponibles = new string[] { ProductSizeInStock },
                                    IngredientesDisponibles = new string[] { ProductIngredient }
                                };

            if (product == null)
            {
                MessageBox.Show("You haven't selected nothing");
                return;
            }
            ProductosInStock.Add(product);
            MessageBox.Show("Producto agregado correctamente");
        }
        //
        public RelayCommand ComandoLimpiar { get; private set; }
        void Limpiar()
        {
            ProductNameInStock = string.Empty;
            ProductSizeInStock = string.Empty;
            ProductIngredient = string.Empty;
            ProductPriceInStock = 0;
        }
        //
        public RelayCommand ClearAllCommand { get; set; }
        void ClearAll()
        {
            ProductosEnCarrito.Clear();
            Total = 0;
            Subtotal = 0;
            PurchaseOk = false;
        }
        //
        public RelayCommand ComandoMostrarProductos { get; set; }
        void ShowProducts()
        {
            emer = new EmergentWindow();
            emer.Show();
        }
        //
        public RelayCommand PayCommand { get; set; }
        void Pay()
        {
            if(Total == 0)
            {
                MessageBox.Show("No ha comprado nada");
                return;
            }

            if((decimal)Total <= Amount)
            {
                SuccessPurchase purch = new SuccessPurchase();
                emer.Close();
                purch.Show();
            }
        }
        private void InicializarComandos()
        {
            AddToCarCommand = new RelayCommand(AddToCard);
            ComandoAgregarProducto = new RelayCommand(AgregarProducto);
            ComandoLimpiar = new RelayCommand(Limpiar);
            ComandoMostrarProductos = new RelayCommand(ShowProducts);
            ClearAllCommand = new RelayCommand(ClearAll);
            PayCommand = new RelayCommand(Pay);
        }
        private void InicializarPropiedades()
        {

            ProductosInStock = new
                ObservableCollection<Product>()
            {
                new Product { Nombre = "Basito" , IngredientesDisponibles = new string[] { "Fresa", "Menta", "Chocolate"} , Precio = 10 ,
                 TamaniosDisponibles  = new string[] { "Grande","Mediano","Pequeño"} },

                new Product { Nombre = "Paleta" , IngredientesDisponibles = new string[] { "Chocolate", "Pollo", "Agua"} , Precio = 20,
                 TamaniosDisponibles  = new string[] { "Grande","Mediano"} },
            };

            ProductosEnCarrito = new ObservableCollection<ProductPurchase>();
        }
        private EmergentWindow emer;   
        public ProductViewModel()
        {
            InicializarPropiedades();
            InicializarComandos();

        }



    }
}
