using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class RepositorioParqueadero
    {

        public string Ruta = "parqueadero.txt";
        public string Agregar(Vehiculo vehiculo, Parqueadero parqueadero, Persona persona)
        {
            StreamWriter streamWriter = new StreamWriter(Ruta, true);
            streamWriter.WriteLine(vehiculo.ToString() + "" + parqueadero.ToString() + "" + persona.ToString());
            streamWriter.Close();

            return $"\nDato {vehiculo.Placa} almacenado\n";
        }

        public List<Vehiculo> ConsultarTodos()
        {
            List<Vehiculo> vehiculo = new List<Vehiculo>();

            StreamReader sr = new StreamReader(Ruta);
            while (!sr.EndOfStream)
            {
                vehiculo.Add(Mapeador(sr.ReadLine()));
            }
            sr.Close();
            return vehiculo;
        }

        public Vehiculo Mapeador(string contacto)
        {
            try
            {
                Vehiculo vehiculo = new Vehiculo();
                String[] strings = contacto.Split(';');

                vehiculo.Placa = strings[0];
                vehiculo.Modelo = strings[1];
                vehiculo.TipoVehiculo = strings[2];


                return vehiculo;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
