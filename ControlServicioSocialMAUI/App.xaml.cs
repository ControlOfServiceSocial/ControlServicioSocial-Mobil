using ControlServicioSocialMAUI.Views;

namespace ControlServicioSocialMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PLogin();
        }
    }
}