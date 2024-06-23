using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarioo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CProductos objetoProducto = new Clases.CProductos();
            objetoProducto.mostrarProductos(dgvproductos);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            Clases.CProductos objetoProducto = new Clases.CProductos();
            objetoProducto.AgregarProductos(txtnombre, txtdescripcion, txtprecio, DateTime.Now);
            objetoProducto.mostrarProductos(dgvproductos);
        }

        private void dgvproductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)


        {
            Clases.CProductos objetoProducto = new Clases.CProductos();
            objetoProducto.SeleccionarProductos(dgvproductos, txtidProducto, txtnombre, txtdescripcion, txtprecio, DateTime.Now);
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Clases.CProductos objetoProducto = new Clases.CProductos();
            objetoProducto.ModificarProductos(txtidProducto, txtnombre, txtdescripcion, txtprecio, DateTime.Now);
            objetoProducto.mostrarProductos(dgvproductos);
        }


        private void Btn_Eliminar(object sender, EventArgs e)
        {
            Clases.CProductos objetoProducto = new Clases.CProductos();
            objetoProducto.EliminarProductos(txtidProducto);
            objetoProducto.mostrarProductos(dgvproductos);
        }
    }
}
    

 

