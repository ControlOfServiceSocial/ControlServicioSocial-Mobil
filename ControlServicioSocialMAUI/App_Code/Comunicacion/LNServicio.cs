using SWLNControlServicioSocial;

namespace MAUIControlServicioSocial.App_Code.Comunicacion
{
    public class LNServicio
    {
        private SWLNControlServicioSocialClient sWLNContorolServicioSocialClient;
        #region Constructor
        public LNServicio()
        {
            sWLNContorolServicioSocialClient = new SWLNControlServicioSocialClient();
        }
        #endregion
        #region Metodos Publicos
        public List<ECProyecto> Obtener_CProyecto_O()
        {
            List<ECProyecto> lstECProyectos = new List<ECProyecto>();
            try
            {
                lstECProyectos = sWLNContorolServicioSocialClient.Obtener_CProyecto_O().ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lstECProyectos;
        }
        public List<ECCertificado> Obtener_CCertificado_O()
        {
            List<ECCertificado> lstECCertificados = new List<ECCertificado>();
            try
            {
                lstECCertificados = sWLNContorolServicioSocialClient.Obtener_CCertificado_O().ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lstECCertificados;
        }

        public List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O_IdEstudiante(int idEstudiante)
        {
            List<ECProyectoEstudiante> lstECProyectoEstudiante = new List<ECProyectoEstudiante>();
            try
            {
                lstECProyectoEstudiante = sWLNContorolServicioSocialClient.Obtener_CProyectoEstudiante_O_IdEstudiante(idEstudiante).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lstECProyectoEstudiante;
        }

        public ECProyectoEstudiante Obtener_CProyectoEstudiante_O()
        {
            ECProyectoEstudiante eCProyectoEstudiante = new ECProyectoEstudiante();
            try
            {
                eCProyectoEstudiante = sWLNContorolServicioSocialClient.Obtener_CProyectoEstudiante_O();
            }
            catch (Exception)
            {

                throw;
            }
            return eCProyectoEstudiante;
        }
        public List<ECProyecto> Obtener_CProyectoEstudiante_O_CProyecto(int idEstudiante)
        {
            List<ECProyecto> lstECProyecto = new List<ECProyecto>();
            try
            {
                lstECProyecto = sWLNContorolServicioSocialClient.Obtener_CProyecto_O_CProyecto(idEstudiante).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            return lstECProyecto;
        }

        public List<ECCertificado> Obtener_CCertificado_O_IdEstudiante(int idEstudiante)
        {
            List<ECCertificado> lstECCertificado = new List<ECCertificado>();
            try
            {
                lstECCertificado = sWLNContorolServicioSocialClient.Obtener_CCertificado_O_IdEstudiante(idEstudiante).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lstECCertificado;
        }

        public void Insertar_CCertificado_I(string documentoCertificado, int idEstudiante, string tituloCertificado, int cargaHoraria)
        {
            try
            {
                sWLNContorolServicioSocialClient.Insertar_CCertificado_I(documentoCertificado, idEstudiante, tituloCertificado, cargaHoraria);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Actualizar_CProyectoEstudiante_A_Inicio(int idEstudiante,int idProyecto, DateTime horaInicio, string latitudInicial, string longitudInicial)
        {
            try
            {
                sWLNContorolServicioSocialClient.Actualizar_CProyectoEstudiante_A_Inicio(idEstudiante, idProyecto, horaInicio, latitudInicial, longitudInicial);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Actualizar_CProyectoEstudiante_A_HoraAcumulada(int idEstudiante, int idProyecto, DateTime horaFinal, string latitudFinal, string longitudFinal)
        {
            try
            {
                sWLNContorolServicioSocialClient.Actualizar_CProyectoEstudiante_A_HoraAcumulada(idEstudiante, idProyecto, horaFinal, latitudFinal, longitudFinal);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
