namespace ControlServicioSocialMAUI.Views;

public partial class PCertificados : ContentPage
{
	public PCertificados()
	{
		InitializeComponent();
	}

    private void btnCargarCertificado_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new CertificateViews.PRegistrarCertificado(),animated:false);
    }
}