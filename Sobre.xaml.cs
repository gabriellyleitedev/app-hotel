using System;
using Microsoft.Maui.Controls;

namespace AppHotel
{
    public partial class Sobre : ContentPage
    {
        // Construtor atualizado pro o resumo da Agenda 14
        public Sobre(string suite, string inDate, string outDate, int hospedes, int dias, double total)
        {
            InitializeComponent();

            lbl_suite.Text = suite;
            lbl_periodo.Text = $"Período: {inDate} até {outDate}";
            lbl_dias.Text = $"Duração: {dias} diária(s)";
            lbl_hospedes.Text = $"Hóspedes: {hospedes} pessoa(s)";
            lbl_valor.Text = total.ToString("C"); // Formata como Moeda Real (R$)
        }

        private async void Button_Clicked(object? sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Retorna para a tela de reservas
        }
    }
}