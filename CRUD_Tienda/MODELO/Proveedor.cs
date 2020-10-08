using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Tienda.MODELO
{
    class Proveedor
    {
        private int codigo_proveedor;
        private string nombre_proveedor;
        private int telefono_proveedor;
        private double direccion_proveedor;

        public int Codigo_proveedor { get => codigo_proveedor; set => codigo_proveedor = value; }
        public string Nombre_proveedor { get => nombre_proveedor; set => nombre_proveedor = value; }
        public int Telefono_proveedor { get => telefono_proveedor; set => telefono_proveedor = value; }
        public double Direccion_proveedor { get => direccion_proveedor; set => direccion_proveedor = value; }
    }
}
