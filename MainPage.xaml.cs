namespace AppHotel;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnConfirmarClicked(object sender, EventArgs e)
    {
        // Pega os dados selecionados
        string suite = pck_suite.SelectedItem?.ToString() ?? "Não selecionada";
        string checkin = $"{dtp_checkin.Date:dd/MM/yyyy}";
        string checkout = $"{dtp_checkout.Date:dd/MM/yyyy}";
        double hospedes = stp_adultos.Value;

        // Abre a página de resumo passando os dados
        await Navigation.PushAsync(new Sobre(suite, checkin, checkout, hospedes));
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        // Navega pr a página Sobre sem parâmetros (pra informações do desenvolvedor)
        await Navigation.PushAsync(new Sobre("N/A", "N/A", "N/A", 0));
    }
}