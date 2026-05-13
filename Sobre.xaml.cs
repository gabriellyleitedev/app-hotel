namespace AppHotel;

public partial class Sobre : ContentPage
{
    // Construtor que recebe os dados da reserva
    public Sobre(string suite, string inDate, string outDate, double qnt)
    {
        InitializeComponent();

        lbl_suite.Text = $"Acomodação: {suite}";
        lbl_periodo.Text = $"Período: {inDate} até {outDate}";
        lbl_hospedes.Text = $"Total de Hóspedes: {qnt}";
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Volta para a tela inicial
    }
}