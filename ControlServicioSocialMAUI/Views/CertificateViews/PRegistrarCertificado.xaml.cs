using System;
using System.Threading.Tasks;
using ControlServicioSocialMAUI.App_Code.Services;
using Firebase.Storage;
using MAUIControlServicioSocial.App_Code.Controladoras;
using Microsoft.VisualBasic;
using SWLNControlServicioSocial;


namespace ControlServicioSocialMAUI.Views.CertificateViews;

public partial class PRegistrarCertificado : ContentPage
{
    ECCertificado eCCertificado = new ECCertificado();
    CCCertificado cCCertificado = new CCCertificado();

    public int idEstudiante=3;
    private string filePath;
    private FileResult selectedFileResult;

    public PRegistrarCertificado()
	{
		InitializeComponent();
    }

    private async void btnSeleccionarArchivo_Clicked(object sender, EventArgs e)
    {
        try
        {
            var customFileType = new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>
        {
            { DevicePlatform.iOS, new[] { "com.adobe.pdf" } },
            { DevicePlatform.Android, new[] { "application/pdf" } },
            { DevicePlatform.WinUI, new[] { ".pdf" } },
        });

            var options = new PickOptions
            {
                PickerTitle = "Por favor, selecciona un documento de certificado",
                FileTypes = customFileType,
            };

            selectedFileResult = await FilePicker.PickAsync(options);

            if (selectedFileResult != null)
            {
                filePath = Path.Combine(Microsoft.Maui.Storage.FileSystem.CacheDirectory, selectedFileResult.FileName);
                lblRutaArchivo.Text = selectedFileResult.FileName;
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
     
    private async void btnEnviarCertificado_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTitulo.Text))
        {
            DisplayAlert("Error", "Por favor, ingresa un título para el certificado.", "OK");
            return; // Detener el proceso si la validación falla
        }

        if (string.IsNullOrWhiteSpace(txtCargaHoraria.Text))
        {
            DisplayAlert("Error", "Por favor, ingresa la carga horaria.", "OK");
            return;
        }
        if (selectedFileResult != null)
        {
            var fileName = Path.GetFileName(selectedFileResult.FileName);
            using (var stream = await selectedFileResult.OpenReadAsync())
            {
                var archivoUrl = await FirebaseStorageService.UploadFile(stream, fileName);

                cCCertificado.Insertar_CCertificado_I(fileName, idEstudiante, txtTitulo.Text, int.Parse(txtCargaHoraria.Text));
                //await DisplayAlert("Éxito", $"Archivo subido con éxito. Nombre: {fileName}, URL: {archivoUrl}", "OK");
                await DisplayAlert("Éxito", $"Archivo subido con éxito.", "OK");
            }
        }
        else
        {
            // Manejar el caso en el que no se haya seleccionado ningún archivo
            await DisplayAlert("Error", "Por favor, selecciona un archivo antes de enviar.", "OK");
            return;
        }
    }
  
}