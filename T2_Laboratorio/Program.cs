using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_Laboratorio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public struct Producto
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public double Precio { get; set; }
            public double MontoInvertido { get; set; }

            public Producto (int codigo, string nombre, int cantidad, double precio, double montoInvertido)
            {
                this.Codigo = codigo;
                this.Nombre = nombre;
                this.Cantidad = cantidad;
                this.Precio = precio;
                this.MontoInvertido = montoInvertido;
            }

        }
    }
}
