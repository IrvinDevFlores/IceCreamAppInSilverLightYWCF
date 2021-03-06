﻿using System;
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
    public class Product
    {
        public string Nombre { get; set; }

        public bool EstaComprado { get; set; }

        public string Tamanio { get; set; }

        public string[] TamaniosDisponibles { get; set; }

        public string[] IngredientesDisponibles { get; set; }

        public string IngredienteSeleccionado { get; set; }

        public int Precio { get; set; }

        public int Cantidad { get; set; }
    }
}
