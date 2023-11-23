using SWLNControlServicioSocial;

namespace ControlServicioSocialMAUI.Views.ProjectViews;

public partial class PDetallesProyectos : ContentPage
{
	public PDetallesProyectos()
	{
		InitializeComponent();
	}
	public PDetallesProyectos(ECProyecto eCProyecto)
	{
		InitializeComponent();
		BindingContext=eCProyecto;
    }
}