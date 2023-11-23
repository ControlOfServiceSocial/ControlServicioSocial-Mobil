using MAUIControlServicioSocial.App_Code.Comunicacion;
using SWLNControlServicioSocial;

namespace MAUIControlServicioSocial.App_Code.Controladoras
{
    public class CCProyecto
    {
        LNServicio lNSServicio = new LNServicio();

        public CCProyecto()
        {
        }
        public List<ECProyecto> Obtener_CProyecto_O()
        {
            List<ECProyecto> lstECProyectos = new List<ECProyecto>();
            try
            {
                lstECProyectos = lNSServicio.Obtener_CProyecto_O();
            }
            catch (Exception)
            {
                throw;
            }
            return lstECProyectos;
        }
        public List<ECProyecto> Obtener_CProyectoEstudiante_O_CProyecto(int idEstudiante)
        {
            List<ECProyecto> lstECProyectos = new List<ECProyecto>();
            try
            {
                lstECProyectos = lNSServicio.Obtener_CProyectoEstudiante_O_CProyecto(idEstudiante);
            }
            catch (Exception)
            {
                throw;
            }
            return lstECProyectos;
        }
    }
}
