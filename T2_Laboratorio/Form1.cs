using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_Laboratorio
{
    public partial class Form1 : Form
    {
        ArrayList Productos = new ArrayList();
        T2_Laboratorio.Program.Producto producto = new T2_Laboratorio.Program.Producto();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                errorProvider1.SetError(txtCodigo, "Debe ingresar el código del producto");
                txtCodigo.Focus();
                return;
            }

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar el nombre del producto");
                txtNombre.Focus();
                return;
            }

            if (txtCantidad.Text == "")
            {
                errorProvider1.SetError(txtCantidad, "Debe ingresar la cantidad de productos");
                txtCantidad.Focus();
                return;
            }

            if (txtPrecio.Text == "")
            {
                errorProvider1.SetError(txtPrecio, "Debe ingresar el precio unitario del producto");
                txtPrecio.Focus();
                return;
            }

            //Colocamos Info
            producto.Codigo = Convert.ToInt32(txtCodigo.Text);
            producto.Nombre = txtNombre.Text;
            producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
            producto.Precio = Convert.ToDouble(txtPrecio.Text);
            producto.MontoInvertido = producto.Cantidad * producto.Precio;
            Productos.Add(producto);

            dtgvProductos.DataSource = null;
            dtgvProductos.DataSource = Productos;

            //Limpiamos los txt
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow fila in dtgvProductos.Rows)
            {
                String a = null;
                a = Convert.ToString(fila.Cells[1].Value);
                if (a == txtNombre.Text)
                {
                    MessageBox.Show("Medicamento en stock");
                    break;
                }
                
            }*/

            if (Existe(txtNombre.Text))
            {
                MessageBox.Show("El producto seleccionado tiene stock");
            }

            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow fila in dtgvProductos.Rows)
            {
                String a = null;
                a = Convert.ToString(fila.Cells[0].Value);
                if(a == txtCodigo.Text)
                {
                    dtgvProductos.Rows.Remove(fila);
                }
            }
        }

        private bool Existe(string nombre)
        {
            foreach(T2_Laboratorio.Program.Producto Producto in Productos)
            {
                if (Producto.Nombre == nombre) return true;
            }
            return false;
        }
    }
}
