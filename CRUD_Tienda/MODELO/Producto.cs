using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Tienda.MODELO
{
    class Producto
    {
        private int codigo_producto;
        private string nombre_producto;
        private int precio_producto;
        private int cantidad_producto;

        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public int Precio_producto { get => precio_producto; set => precio_producto = value; }
        public int Cantidad_producto { get => cantidad_producto; set => cantidad_producto = value; }
    }
}
