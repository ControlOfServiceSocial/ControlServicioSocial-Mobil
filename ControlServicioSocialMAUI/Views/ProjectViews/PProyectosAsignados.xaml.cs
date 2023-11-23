using ControlServicioSocialMAUI.App_Code.Services;
using MAUIControlServicioSocial.App_Code.Controladoras;
using SWLNControlServicioSocial;
using System.Diagnostics;

namespace ControlServicioSocialMAUI.Views.ProjectViews;

public partial class PProyectosAsignados : ContentPage
{
    ECProyecto eCProyecto = new ECProyecto();
    ECProyectoEstudiante eCProyectoEstudiante = new ECProyectoEstudiante();
    List<ECProyectoEstudiante> lstECProyectoEstudiante = new List<ECProyectoEstudiante>();
    List<ECProyecto> lstECProyecto = new List<ECProyecto>();
    CCProyecto cProyecto = new CCProyecto();
    CCProyectoEstudiante cProyectoEstudiante = new CCProyectoEstudiante();
    int idEstudiante = 3;

    public PProyectosAsignados()
	{
		InitializeComponent();
        CargarProyectosAsignados();
	}
    private async void CargarProyectosAsignados()
    {
        lstECProyecto.Clear();
        lstECProyecto = cProyecto.Obtener_CProyectoEstudiante_O_CProyecto(idEstudiante);
        foreach (var item in lstECProyecto)
        {
            var fileResult = await FirebaseStorageService.GetImage(item.ImagenProyecto);

            if (fileResult != null)
            {
                item.ImagenProyecto = fileResult.FileUrl;
            }
            else
            {
                Console.WriteLine("Imagen no cargada");
            }
            eCProyecto.IdProyecto = item.IdProyecto;
            eCProyecto.ImagenProyecto = item.ImagenProyecto;
            eCProyecto.NombreProyecto = item.NombreProyecto;
            eCProyecto.DescripcionProyecto = item.DescripcionProyecto;
        }
        cvProyectosAsignados.ItemsSource = lstECProyecto;
    }

    private async void cvProyectosAsignados_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        try
        {
            if (e.CurrentSelection.Count > 0)
            {
                var selectedProject = e.CurrentSelection[0] as ECProyecto;
                if (selectedProject != null)
                {
                    ((CollectionView)sender).SelectedItem = null;
                    //await Navigation.PushAsync(new ProjectDetailPage(selectedProject));
                    await Navigation.PushModalAsync(new PDetallesProyectosAsignados(selectedProject), animated: false);
                }
            }
        }
        catch (Exception ex)
        {
            // Manejo de excepciones aquí
            Debug.WriteLine($"Error de navegación: {ex.Message}");
        }
    }
}