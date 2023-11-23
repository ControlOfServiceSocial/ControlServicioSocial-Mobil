using MAUIControlServicioSocial.App_Code.Comunicacion;
using SWLNControlServicioSocial;

namespace MAUIControlServicioSocial.App_Code.Controladoras
{
    public class CCProyectoEstudiante
    {
        LNServicio lNSServicio = new LNServicio();

        public CCProyectoEstudiante()
        {
        }
        public List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O_IdEstudiante(int idEstudiante)
        {
            List<ECProyectoEstudiante> lstECProyectoEstudiante = new List<ECProyectoEstudiante>();
            try
            {
                lstECProyectoEstudiante = lNSServicio.Obtener_CProyectoEstudiante_O_IdEstudiante(idEstudiante).ToList();
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
                eCProyectoEstudiante = lNSServicio.Obtener_CProyectoEstudiante_O();
            }
            catch (Exception)
            {
                throw;
            }
            return eCProyectoEstudiante;
        }
        public void Actualizar_CProyectoEstudiante_A_Inicio(int IdEstudiante,int idProyecto, DateTime HoraInicio, string LatitudInicial, string LongitudInicial)
        {
            try
            {
                lNSServicio.Actualizar_CProyectoEstudiante_A_Inicio(IdEstudiante,idProyecto, HoraInicio, LatitudInicial, LongitudInicial);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Actualizar_CProyectoEstudiante_A_HoraAcumulada(int IdEstudiante, int idProyecto, DateTime HoraFinal, string LatitudFinal, string LongitudFinal)
        {
            try
            {
                lNSServicio.Actualizar_CProyectoEstudiante_A_HoraAcumulada(IdEstudiante,idProyecto, HoraFinal, LatitudFinal, LongitudFinal);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
