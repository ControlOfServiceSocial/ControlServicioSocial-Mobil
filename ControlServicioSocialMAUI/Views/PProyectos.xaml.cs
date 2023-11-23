using ControlServicioSocialMAUI.App_Code.Services;
using ControlServicioSocialMAUI.Views.ProjectViews;
using MAUIControlServicioSocial.App_Code.Controladoras;
using SWLNControlServicioSocial;
using System.Diagnostics;

namespace ControlServicioSocialMAUI.Views;

public partial class PProyectos : ContentPage
{
	ECProyecto eCProyecto = new ECProyecto();
	List<ECProyecto> listaProyectos = new List<ECProyecto>();
	CCProyecto cCProyecto = new CCProyecto();


	public PProyectos()
	{
		InitializeComponent();
		CargarProyectos();
        
	}
	private async void CargarProyectos()
	{
		listaProyectos.Clear();
		listaProyectos = cCProyecto.Obtener_CProyecto_O();
		foreach (var item in listaProyectos)
		{
            var fileResult =await FirebaseStorageService.GetImage(item.ImagenProyecto);

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
		cvProyectos.ItemsSource = listaProyectos;
    }

    private async void cvProyectos_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
                    await Navigation.PushModalAsync(new PDetallesProyectos(selectedProject), animated: false);
                }
            }
        }
        catch (Exception ex)
        {
            // Manejo de excepciones aquí
            Debug.WriteLine($"Error de navegación: {ex.Message}");
        }
    }

    private void btnProyectos_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new PProyectosAsignados(), animated: false);
    }
}