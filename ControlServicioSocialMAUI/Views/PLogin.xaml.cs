
namespace ControlServicioSocialMAUI.Views;

public partial class PLogin : ContentPage
{
	public PLogin()
	{
		InitializeComponent();
	}

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new PTabbedPage());
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Ejecuta la animación en el logo
        await Task.WhenAll(
            imgLogo.ScaleTo(1.2, 1000),
            imgLogo.FadeTo(1, 1000)
        );

        // Ejecuta animaciones en los campos de entrada
        await Task.WhenAll(
            txtUsuario.TranslateTo(0, 0, 500, Easing.SpringOut),
            txtContrasena.TranslateTo(0, 0, 500, Easing.SpringOut)
        );

        // Continuamente anima el botón para que parezca que pulsa
        await btnIniciarSesion.ScaleTo(1.05, 1000);
        await btnIniciarSesion.ScaleTo(1, 1000);
    }
}