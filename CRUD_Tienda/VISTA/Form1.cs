
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CRUD_Tienda.MODELO;

namespace CRUD_Tienda
{
    public partial class Form1 : Form
    {
        int i = 1;
        int posicionProveedor;
        int posicionProducto;

        ArrayList lista_proveedor = new ArrayList();
        ArrayList lista_producto = new ArrayList();

        Proveedor proveedor;
        Producto producto;
        public Form1()
        {
            InitializeComponent();
            proveedor = null;
            producto = null;
            limpiarProveedor();
            limpiarProducto();
        }
        void limpiarProveedor()
        {

            btnEliminarProveedor.Enabled = false;
            btnModificarProveedor.Enabled = false;
            txtCodigoProveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtTelefonoProveedor.Text = "";
            txtDireccionProveedor.Text = "";


        }
        void limpiarProducto()
        {
            btnEliminarProducto.Enabled = false;
            btnModificarProducto.Enabled = false;
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtCantidadProducto.Text = "";
            comboBoxProveedor.Text = "Seleccione --";
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            proveedor = new Proveedor();
            proveedor.Codigo_proveedor = int.Parse(txtCodigoProveedor.Text);
            proveedor.Nombre_proveedor = txtNombreProveedor.Text;
            proveedor.Telefono_proveedor = int.Parse(txtTelefonoProveedor.Text);
            proveedor.Direccion_proveedor = Double.Parse(txtDireccionProveedor.Text);

            comboBoxProveedor.Items.Add(proveedor.Nombre_proveedor);

            DGVProveedor.Rows.Add(i + "", proveedor.Codigo_proveedor, proveedor.Nombre_proveedor, proveedor.Telefono_proveedor, proveedor.Direccion_proveedor);
            i = i + 1;
            limpiarProveedor();
            lista_proveedor.Add(proveedor);
            MessageBox.Show("PROVEEDOR REGISTRADO");

        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            limpiarProveedor();
            btnRegistrarProveedor.Enabled = true;
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            proveedor = new Proveedor();
            proveedor.Codigo_proveedor = int.Parse(txtCodigoProveedor.Text);
            proveedor.Nombre_proveedor = txtNombreProveedor.Text;
            proveedor.Telefono_proveedor = int.Parse(txtTelefonoProveedor.Text);
            proveedor.Direccion_proveedor = Double.Parse(txtDireccionProveedor.Text);


            DGVProveedor[1, posicionProveedor].Value = txtCodigoProveedor.Text;
            DGVProveedor[2, posicionProveedor].Value = txtNombreProveedor.Text;
            DGVProveedor[3, posicionProveedor].Value = txtTelefonoProveedor.Text;
            DGVProveedor[4, posicionProveedor].Value = txtDireccionProveedor.Text;
        }
        private void DGVProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicionProveedor = DGVProveedor.CurrentRow.Index;
            txtCodigoProveedor.Text = DGVProveedor[1, posicionProveedor].Value.ToString();
            txtNombreProveedor.Text = DGVProveedor[2, posicionProveedor].Value.ToString();
            txtTelefonoProveedor.Text = DGVProveedor[3, posicionProveedor].Value.ToString();
            txtDireccionProveedor.Text = DGVProveedor[4, posicionProveedor].Value.ToString();

            btnRegistrarProveedor.Enabled = false;
            btnModificarProveedor.Enabled = true;
            btnEliminarProveedor.Enabled = true;

        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            DGVProveedor.Rows.RemoveAt(posicionProveedor);
            MessageBox.Show("PROVEEDOR ELIMINADO");
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            producto.Codigo_producto = int.Parse(txtCodigoProducto.Text);
            producto.Nombre_producto = txtNombreProducto.Text;
            producto.Precio_producto = int.Parse(txtPrecioProducto.Text);
            producto.Cantidad_producto = int.Parse(txtCantidadProducto.Text);
            proveedor.Nombre_proveedor = comboBoxProveedor.Text;

            DGVProducto.Rows.Add(i + "", producto.Codigo_producto, producto.Nombre_producto, producto.Precio_producto, producto.Cantidad_producto, proveedor.Nombre_proveedor);
            i = i + 1;
            limpiarProducto();
            lista_producto.Add(producto);
            MessageBox.Show("PRODUCTO REGISTRADO");
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            limpiarProducto();
            btnRegistrarProducto.Enabled = true;
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            producto.Codigo_producto = int.Parse(txtCodigoProducto.Text);
            producto.Nombre_producto = txtNombreProducto.Text;
            producto.Precio_producto = int.Parse(txtPrecioProducto.Text);
            producto.Cantidad_producto = int.Parse(txtCantidadProducto.Text);
            proveedor.Nombre_proveedor = comboBoxProveedor.Text;


            DGVProducto[1, posicionProducto].Value = txtCodigoProducto.Text;
            DGVProducto[2, posicionProducto].Value = txtNombreProducto.Text;
            DGVProducto[3, posicionProducto].Value = txtPrecioProducto.Text;
            DGVProducto[4, posicionProducto].Value = txtCantidadProducto.Text;
            DGVProducto[5, posicionProducto].Value = comboBoxProveedor.Text;
        }
        private void DGVProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicionProducto = DGVProducto.CurrentRow.Index;
            txtCodigoProducto.Text = DGVProducto[1, posicionProducto].Value.ToString();
            txtNombreProducto.Text = DGVProducto[2, posicionProducto].Value.ToString();
            txtPrecioProducto.Text = DGVProducto[3, posicionProducto].Value.ToString();
            txtCantidadProducto.Text = DGVProducto[4, posicionProducto].Value.ToString();


            btnRegistrarProducto.Enabled = false;
            btnModificarProducto.Enabled = true;
            btnEliminarProducto.Enabled = true;

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            DGVProducto.Rows.RemoveAt(posicionProducto);
            MessageBox.Show("PRODUCTO ELIMINADO");
        }

        private void printDocumentProveedor_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.DGVProveedor.Width, this.DGVProveedor.Height);
            DGVProveedor.DrawToBitmap(objBmp, new Rectangle(0, 0, this.DGVProveedor.Width, this.DGVProveedor.Height));

            e.Graphics.DrawImage(objBmp, 90, 90);

            e.Graphics.DrawString(label5.Text, new Font("Century Gothic", 22, FontStyle.Bold), Brushes.Black, new Point(300, 30));
        }

        private void btnImprimirReporte_Click(object sender, EventArgs e)
        {
            printPreviewDialogProveedor.Document = printDocumentProveedor;
            printPreviewDialogProveedor.ShowDialog();
        }

        private void printDocumentProducto_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.DGVProducto.Width, this.DGVProducto.Height);
            DGVProducto.DrawToBitmap(objBmp, new Rectangle(0, 0, this.DGVProducto.Width, this.DGVProducto.Height));

            e.Graphics.DrawImage(objBmp, 90, 90);

            e.Graphics.DrawString(lbListaProducto.Text, new Font("Century Gothic", 22, FontStyle.Bold), Brushes.Black, new Point(300, 30));

        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            printPreviewDialogProducto.Document = printDocumentProducto;
            printPreviewDialogProducto.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
