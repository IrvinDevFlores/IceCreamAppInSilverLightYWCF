using IsCreamService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IsCreamService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IIsCreamProductsService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        decimal CalcularTotal(ProductDTO producto);
        [OperationContract]
        void AgregarProducto(ProductDTO producto);

        [OperationContract]
        int suma(int x, int y);
    }
}
