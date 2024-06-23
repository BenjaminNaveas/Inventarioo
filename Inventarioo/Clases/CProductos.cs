using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudMYSQLCsharp.Clases;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Inventarioo.Clases
{
    internal class CProductos
    {
        public void mostrarProductos(DataGridView tablaProductos)
        {
            try
            {

                CConexion objetoConexion = new CConexion();

                String query = "select * from inventarioo.Productos";
                tablaProductos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaProductos.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos" + ex.ToString());
            }
        }

        public void AgregarProductos(TextBox Nombre, TextBox Descripcion, TextBox Precio, DateTime FechaCreacion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "INSERT INTO Productos (Nombre, Descripcion, Precio, FechaCreacion)" +
                    "values ('" + Nombre.Text + "','" + Descripcion.Text + "','" + Precio.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader myDataReader = myComand.ExecuteReader();
                MessageBox.Show("Se guardo exitosamente el Producto");
                while (myDataReader.Read())
                {
                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se han Mostrado los datos de la base de datos, error: " + ex.ToString());
            }
        }

        public void SeleccionarProductos(DataGridView Tabla_Producto, TextBox id, TextBox Nombre, TextBox Descripcion, TextBox Precio, DateTime FechaCreacion)
        {
            try
            {
                id.Text = Tabla_Producto.CurrentRow.Cells[0].Value.ToString();
                Nombre.Text = Tabla_Producto.CurrentRow.Cells[1].Value.ToString();
                Descripcion.Text = Tabla_Producto.CurrentRow.Cells[3].Value.ToString();
                Precio.Text = Tabla_Producto.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido seleccionar el dato de la base de datos. Error: " + ex.ToString());
            }
        }

        public void ModificarProductos(TextBox Codigo, TextBox Nombre, TextBox Precio, TextBox Descripcion, DateTime FechaCreacion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio, Descripcion = @Descripcion, FechaCreacion = @FechaCreacion WHERE IdProducto = @IdProducto";

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@Nombre", Nombre.Text);
                myCommand.Parameters.AddWithValue("@Precio", Precio.Text);
                myCommand.Parameters.AddWithValue("@Descripcion", Descripcion.Text);
                myCommand.Parameters.AddWithValue("@FechaCreacion", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                myCommand.Parameters.AddWithValue("@IdProducto", Codigo.Text);

                int rowsAffected = myCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Se actualizó el producto exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto");
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar los datos de la base de datos. Error: " + ex.ToString());
            }
        }

        public void EliminarProductos(TextBox Codigo)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "DELETE FROM Productos WHERE IdProducto = @IdProducto";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@IdProducto", Codigo.Text);

                int rowsAffected = myComand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Se eliminó exitosamente el Producto");
                }
                else
                {
                    MessageBox.Show("No se encontró el Producto con ese ID para eliminar");
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha eliminado el Producto de la base de datos. Error: " + ex.ToString());
            }
        }
    }
}
    

