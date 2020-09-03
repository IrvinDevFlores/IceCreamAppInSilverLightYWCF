using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IsCreamService.DTOs
{
    [DataContract]
    public class ProductDTO
    {
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public bool IsCheck { get; set; }
        [DataMember]
        public string Size { get; set; }
        [DataMember]
        public string Ingredient { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int Quantity { get; set; }
    }
}