using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Parqueadero
    {
        public Parqueadero()
        {
        }

        public Parqueadero(string lugar, double horasTotalesParqueo, double tarifaHora, double descuento, double total, double totalPagar)
        {
            Lugar = lugar;
            HorasTotalesParqueo = horasTotalesParqueo;
            TarifaHora = tarifaHora;
            Descuento = descuento;
            Total = total;
            TotalPagar = totalPagar;
        }

        public string Lugar { get; set; }
        public double HorasTotalesParqueo { get; set; }
        public double TarifaHora { get; set; }
        public double Descuento { get; set; }
        public double TotalPagar { get; set; }
        public double Total { get; set; }


        public override string ToString()
        {
            return $"{Lugar};{HorasTotalesParqueo};{TotalPagar}";
        }



        public void CalcularValor()
        {
            Descuento = 0.2;
            TarifaHora = 2000;
            Total = (HorasTotalesParqueo * TarifaHora) * (Descuento);
            TotalPagar = (HorasTotalesParqueo * TarifaHora) - Total;

        }
    }
}
