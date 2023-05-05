using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{

    public class Vehiculo : Persona
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string TipoVehiculo { get; set; }


        public override string ToString()
        {
            return $"{Placa};{Modelo};{TipoVehiculo};";
        }
    }
}
