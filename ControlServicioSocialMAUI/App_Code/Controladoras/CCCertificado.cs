using MAUIControlServicioSocial.App_Code.Comunicacion;
using SWLNControlServicioSocial;

namespace MAUIControlServicioSocial.App_Code.Controladoras
{
    public class CCCertificado
    {
        LNServicio lNSServicio = new LNServicio();
        public CCCertificado()
        {
        }
        public List<ECCertificado> Obtener_CCertificado_O()
        {
            List<ECCertificado> lstECCertificados = new List<ECCertificado>();
            try
            {
                lstECCertificados = lNSServicio.Obtener_CCertificado_O();
            }
            catch (Exception)
            {
                throw;
            }
            return lstECCertificados;
        }
        public List<ECCertificado> Obtener_CCertificado_O_IdEstudiante(int idEstudiante)
        {
            List<ECCertificado> lstECCertificados = new List<ECCertificado>();
            try
            {
                lstECCertificados = lNSServicio.Obtener_CCertificado_O_IdEstudiante(idEstudiante);
            }
            catch (Exception)
            {
                throw;
            }
            return lstECCertificados;
        }
        public void Insertar_CCertificado_I(string DocumentoCertificado, int IdEstudiante, string TituloCertificado, int CargaHoraria)
        {
            try
            {
                lNSServicio.Insertar_CCertificado_I(DocumentoCertificado, IdEstudiante, TituloCertificado, CargaHoraria);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
