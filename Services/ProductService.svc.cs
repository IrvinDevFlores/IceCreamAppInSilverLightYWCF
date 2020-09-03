using System.Linq;
using IsCreamService.DTOs;
using System.Collections.ObjectModel;
using System;

namespace IsCreamService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "IsCreamProductsService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione IsCreamProductsService.svc o IsCreamProductsService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ProductService : IProductService
    {
        public ObservableCollection<ProductDTO> productos { get; set; }

        public ProductService()
        {
            productos = new ObservableCollection<ProductDTO>();
        }

        public void AgregarProducto(ProductDTO producto)
        {
            productos.Add(producto);
        }

        public decimal CalcularTotal(ProductDTO producto)
        {
            return productos.Select(p => p.Price).Sum();
        }

        public int suma(int x, int y) => x + y;
    }
}
