using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            Login login1 = new Login();
            login1.Show();
            this.Hide();
        }

        private void btRegistros_Click(object sender, EventArgs e)
        {
            ReporteSistemas reporte = new ReporteSistemas();
            reporte.Show();
            this.Hide();
        }

        private void brRegistrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textNombre.Text) || String.IsNullOrWhiteSpace(textApellido.Text) || String.IsNullOrWhiteSpace(cbCargo.Text) || String.IsNullOrWhiteSpace(cbParqueadero.Text) || String.IsNullOrWhiteSpace(cbVehiculo.Text))
            {
                MessageBox.Show("Campo Vacio... Agrega Un Valor");
            }
            else
            {
                if (textPlaca.Enabled == true && String.IsNullOrWhiteSpace(textPlaca.Text)) 
                {
                    MessageBox.Show("Campo Vacio... Agrega Un Valor");
                }
                else
                {
                    List<int> numerosGenerados = new List<int>();
                    Random rnd = new Random();
                    int numeroGenerado;
                    do
                    {
                        numeroGenerado = rnd.Next(1, 20); 
                    }
                    while (numerosGenerados.Contains(numeroGenerado));

                    // Agregar el número generado a la lista de números generados
                    numerosGenerados.Add(numeroGenerado);

                    // Utiliza el número generado en tu aplicación

                    MessageBox.Show("     ------------------------------ " +
                                       "\n   | ---------- TICKET ---------- |" +
                                       "\n     ------------------------------ " +
                                     "\n\n    NOMBRE            : " + textNombre.Text +
                                       "\n    PLACA                : " + textPlaca.Text +
                                       "\n    PARQUEADERO : " + cbParqueadero.SelectedItem.ToString() +
                                       "\n    PUESTO              : " + numeroGenerado);

                    string nombre = textNombre.Text; 
                    string apellido = textApellido.Text; 
                    string cargo = cbCargo.Text; 
                    string parqueadero = cbParqueadero.Text; 
                    string vehiculo = cbVehiculo.Text; 
                    string placa = textPlaca.Text; 

                    using (StreamWriter writer = File.AppendText("C:\\Users\\57322\\Documents\\Programacion\\PROGRAMACION3\\ProyectoN°1\\Parqueadero\\Presentation\\bin\\Debug\\parqueadero.txt")) // Abrir el archivo en modo de añadir (append)
                    {
                        // Escribir los datos en una nueva línea separados por comas
                        writer.WriteLine($"{nombre},{apellido},{cargo},{parqueadero},{vehiculo},{placa},{numeroGenerado}");
                    }

                    textNombre.Text = "";
                    textApellido.Text = "";
                    cbCargo.Text = "";
                    cbParqueadero.Text = "";
                    cbVehiculo.Text = "";
                    textPlaca.Text = "";
                }
            }
        }

        private void cbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbVehiculo.Text == "Bicicleta")
            {
                textPlaca.Enabled = false;
                textPlaca.Text = "Null";
            }
            else
            {
                textPlaca.Enabled = true;
                textPlaca.Text = "";
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btRetirar_Click(object sender, EventArgs e)
        {
            RetirarVehiculo retirar = new RetirarVehiculo();
            retirar.Show();
            this.Hide();
            
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtener el carácter presionado
            char ch = e.KeyChar;

            // Permitir la tecla "Backspace" y la tecla "Delete"
            if (ch == 8 || ch == 32)
            {
                e.Handled = false;
                return;
            }
            // Verificar si el carácter es una letra
            if (!Char.IsLetter(ch))
            {
                e.Handled = true;
            }
            // Verifica en enter para agregar
            if (e.KeyChar == (char)Keys.Enter)
            {
                textNombre.Text = "";
                textNombre.Focus();
            }
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtener el carácter presionado
            char ch = e.KeyChar;

            // Permitir la tecla "Backspace" y la tecla "Delete"
            if (ch == 8 || ch == 32)
            {
                e.Handled = false;
                return;
            }
            // Verificar si el carácter es una letra
            if (!Char.IsLetter(ch))
            {
                e.Handled = true;
            }
            // Verifica en enter para agregar
            if (e.KeyChar == (char)Keys.Enter)
            {
                textApellido.Text = "";
                textApellido.Focus();
            }
        }
    }
}
