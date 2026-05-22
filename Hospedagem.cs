using System;

namespace AppHotel
{
    public class Hospedagem
    {

        public string SuiteSelecionada { get; set; } = string.Empty;
        public DateTime FechaCheckin { get; set; }
        public DateTime FechaCheckout { get; set; }
        public int QuantidadeHospedes { get; set; }

        public int TotalDias
        {
            get
            {
                TimeSpan diferenca = FechaCheckout - FechaCheckin;
                int dias = diferenca.Days;
                return dias <= 0 ? 1 : dias;
            }
        }
        public double CalcularValorTotal()
        {
            double valorDiaria = 0;

            if (SuiteSelecionada.Contains("Master"))
                valorDiaria = 250.00;
            else if (SuiteSelecionada.Contains("Executiva"))
                valorDiaria = 150.00;
            else
                valorDiaria = 90.00;

            return TotalDias * QuantidadeHospedes * valorDiaria;
        }
    }
}