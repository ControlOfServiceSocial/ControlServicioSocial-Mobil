using MAUIControlServicioSocial.App_Code.Controladoras;
using SWLNControlServicioSocial;

namespace ControlServicioSocialMAUI.Views.ProjectViews;

public partial class PDetallesProyectosAsignados : ContentPage
{
    ECProyectoEstudiante eCProyectoEstudiante = new ECProyectoEstudiante();
    CCProyectoEstudiante cCProyectoEstudiante = new CCProyectoEstudiante();
    int idEstudiante = 3;
    int idProyecto;
    private CancellationTokenSource _cancelTokenSource;
    private bool _isCheckingLocation;
    public PDetallesProyectosAsignados(SWLNControlServicioSocial.ECProyecto eCProyecto)
	{
		InitializeComponent();
		BindingContext=eCProyecto;
        idProyecto = eCProyecto.IdProyecto;
	}

    private async void btnIniciar_Clicked(object sender, EventArgs e)
    {
        try
        {
            bool answer =await DisplayAlert("Inicio de Proyecto?", "¿Deseas iniciar el proyecto?", "Si", "No");

            if (answer != false)
            {
                var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

                if (status != PermissionStatus.Granted)
                {
                    await DisplayAlert("Inicio de Proyecto?", "¿Deseas iniciar el proyecto?", "Si", "No");
                    return;
                }
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                Location location = await Geolocation.GetLocationAsync(request);

                string latitud = location.Latitude.ToString();
                string longitud = location.Longitude.ToString();

                cCProyectoEstudiante.Actualizar_CProyectoEstudiante_A_Inicio(idEstudiante, idProyecto, DateTime.Now, latitud, longitud);
                DisplayAlert(Title, "Proyecto iniciado", "OK");
            }
            else
            {
                DisplayAlert(Title, "Proyecto no iniciado", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "No se pudo obtener la ubicación: " + ex.Message, "OK");
        }
    }

    private async void btnFinalizar_Clicked(object sender, EventArgs e)
    {
        try
        {
            bool answer = await DisplayAlert("Finalizar Proyecto?", "¿Deseas finalizar el proyecto?", "Si", "No");
            if (answer != false)
            {
                var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

                if (status != PermissionStatus.Granted)
                {
                    // El permiso no fue concedido
                    await DisplayAlert("Permisos de ubicación", "El permiso de ubicación no fue concedido", "OK");
                    return;
                }
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                Location location = await Geolocation.GetLocationAsync(request);

                string latitud = location.Latitude.ToString();
                string longitud = location.Longitude.ToString();

                cCProyectoEstudiante.Actualizar_CProyectoEstudiante_A_HoraAcumulada(idEstudiante, idProyecto, DateTime.Now, latitud, longitud);
                DisplayAlert(Title, "Proyecto finalizado", "OK");
            }
            else
            {
                DisplayAlert(Title, "Proyecto no finalizado", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "No se pudo obtener la ubicación: " + ex.Message, "OK");
        }
    }
    public void CancelRequest()
    {
        if (_isCheckingLocation && _cancelTokenSource != null && _cancelTokenSource.IsCancellationRequested == false)
            _cancelTokenSource.Cancel();
    }
}