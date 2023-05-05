using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentacionGUI
{
    public partial class RetirarVehiculo : Form
    {
        public RetirarVehiculo()
        {
            InitializeComponent();
        }

        private void btAtras2_Click(object sender, EventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();
            registro.Show();
            this.Hide();
        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void lbDatos_Click(object sender, EventArgs e)
        {

        }

        private void RetirarVehiculo_Load(object sender, EventArgs e)
        {
            string[] lineas = File.ReadAllLines("C:\\Users\\57322\\Documents\\Programacion\\PROGRAMACION3\\ProyectoN°1\\Parqueadero\\Presentation\\bin\\Debug\\parqueadero.txt");

            DataTable tabla = new DataTable();
            tabla.Columns.Add("NOMBRE");
            tabla.Columns.Add("APELLIDO");
            tabla.Columns.Add("CARGO");
            tabla.Columns.Add("PARQUEADERO");
            tabla.Columns.Add("VEHICULO");
            tabla.Columns.Add("PLACA");
            tabla.Columns.Add("PUESTO");

            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(',');
                tabla.Rows.Add(campos);
            }

            ListaRegistro.DataSource = tabla; 
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                ListaRegistro.CurrentCell = null;

                foreach (DataGridViewRow r in ListaRegistro.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in ListaRegistro.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(textBuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }

            }
            else
            {
                string[] lineas = File.ReadAllLines("C:\\Users\\57322\\Documents\\Programacion\\PROGRAMACION3\\ProyectoN°1\\Parqueadero\\Presentation\\bin\\Debug\\parqueadero.txt");

                DataTable tabla = new DataTable();
                tabla.Columns.Add("NOMBRE");
                tabla.Columns.Add("APELLIDO");
                tabla.Columns.Add("CARGO");
                tabla.Columns.Add("PARQUEADERO");
                tabla.Columns.Add("VEHICULO");
                tabla.Columns.Add("PLACA");
                tabla.Columns.Add("PUESTO");

                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');
                    tabla.Rows.Add(campos);
                }

                ListaRegistro.DataSource = tabla;
            }

        }

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TotalPagar;
            string datoString = cbHora.SelectedItem.ToString();
            int datoInt = int.Parse(datoString);

            TotalPagar = datoInt * 2000;

            lbPrecio.Text = TotalPagar.ToString();

        }

        private void lbPrecio_Click(object sender, EventArgs e)
        {
            lbPrecio.Text = cbHora.Text;
        }

        private void btRetirar_Click(object sender, EventArgs e)
        {
            if (ListaRegistro.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = ListaRegistro.SelectedRows[0].Index;
                // Eliminar la fila seleccionada del DataGridView
                ListaRegistro.Rows.RemoveAt(rowIndex);

                // Obtener el contenido del archivo de texto en una lista de cadenas
                List<string> lines = File.ReadAllLines("C:\\Users\\57322\\Documents\\Programacion\\PROGRAMACION3\\ProyectoN°1\\Parqueadero\\Presentation\\bin\\Debug\\parqueadero.txt").ToList();

                // Eliminar la línea correspondiente a la fila seleccionada
                lines.RemoveAt(rowIndex);

                // Guardar la lista actualizada en el archivo de texto
                File.WriteAllLines("C:\\Users\\57322\\Documents\\Programacion\\PROGRAMACION3\\ProyectoN°1\\Parqueadero\\Presentation\\bin\\Debug\\parqueadero.txt", lines);
            }

            lbDatos.Text = "";
            cbHora.Text = "";
            lbPrecio.Text = "0";

            MessageBox.Show("El Vehiculo Fue Retirado.....");
        }

        private void textBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void ListaRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void ListaRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = ListaRegistro.Rows[e.RowIndex].Cells[0];
                lbDatos.Text = cell.Value.ToString();
            }
        }

        private void ListaRegistro_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
    }
}
