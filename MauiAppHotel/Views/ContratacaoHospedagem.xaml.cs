namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HospedagemContratada());
    }

    private void Button_Clicked2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Sobre());
    }
}