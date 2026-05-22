using System;
using Microsoft.Maui.Controls;

namespace AppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnConfirmarClicked(object? sender, EventArgs e)
        {
            
            Hospedagem reserva = new Hospedagem
            {
                SuiteSelecionada = pck_suite.SelectedItem?.ToString() ?? "Standard Comfort",
                FechaCheckin = dtp_checkin.Date.Value,   // .Value limpa o warning de valor nulo
                FechaCheckout = dtp_checkout.Date.Value, // .Value limpa o warning de valor nulo
                QuantidadeHospedes = Convert.ToInt32(stp_adultos.Value)
            };

            // Realiza os cálculos usando a inteligência do objeto
            double valorTotal = reserva.CalcularValorTotal();
            int dias = reserva.TotalDias;

            // Transmite os parâmetros calculados para a tela de resumo (Sobre.xaml)
            await Navigation.PushAsync(new Sobre(
                reserva.SuiteSelecionada, 
                reserva.FechaCheckin.ToString("dd/MM/yyyy"), 
                reserva.FechaCheckout.ToString("dd/MM/yyyy"), 
                reserva.QuantidadeHospedes,
                dias,
                valorTotal
            ));
        }
    }
}