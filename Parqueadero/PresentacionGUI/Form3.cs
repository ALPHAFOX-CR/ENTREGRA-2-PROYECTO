using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;
using Entity;

namespace PresentacionGUI
{
    public partial class ReporteSistemas : Form
    {
        public ReporteSistemas()
        {
            InitializeComponent();
        }

        private void btAtras1_Click(object sender, EventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();
            registro.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ReporteSistemas_Load(object sender, EventArgs e)
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

            dataGridView1.DataSource = tabla;
        }
    }
}
