﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWLNControlServicioSocial
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ECProyecto", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class ECProyecto : object
    {
        
        private string DescripcionProyectoField;
        
        private byte EstadoProyectoField;
        
        private System.DateTime FechaCreacionProyectoField;
        
        private System.DateTime FechaFinProyectoField;
        
        private System.DateTime FechaInicioProyectoField;
        
        private byte HorasEstimadasField;
        
        private int IdProyectoField;
        
        private int IdSedeField;
        
        private string ImagenProyectoField;
        
        private string NombreProyectoField;
        
        private string UbicacionProyectoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescripcionProyecto
        {
            get
            {
                return this.DescripcionProyectoField;
            }
            set
            {
                this.DescripcionProyectoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte EstadoProyecto
        {
            get
            {
                return this.EstadoProyectoField;
            }
            set
            {
                this.EstadoProyectoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaCreacionProyecto
        {
            get
            {
                return this.FechaCreacionProyectoField;
            }
            set
            {
                this.FechaCreacionProyectoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaFinProyecto
        {
            get
            {
                return this.FechaFinProyectoField;
            }
            set
            {
                this.FechaFinProyectoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaInicioProyecto
        {
            get
            {
                return this.FechaInicioProyectoField;
            }
            set
            {
                this.FechaInicioProyectoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte HorasEstimadas
        {
            get
            {
                return this.HorasEstimadasField;
            }
            set
            {
                this.HorasEstimadasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdProyecto
        {
            get
            {
                return this.IdProyectoField;
            }
            set
            {
                this.IdProyectoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdSede
        {
            get
            {
                return this.IdSedeField;
            }
            set
            {
                this.IdSedeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImagenProyecto
        {
            get
            {
                return this.ImagenProyectoField;
            }
            set
            {
                this.ImagenProyectoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreProyecto
        {
            get
            {
                return this.NombreProyectoField;
            }
            set
            {
                this.NombreProyectoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UbicacionProyecto
        {
            get
            {
                return this.UbicacionProyectoField;
            }
            set
            {
                this.UbicacionProyectoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ECCertificado", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class ECCertificado : object
    {
        
        private int CargaHorariaField;
        
        private string DocumentoCertificadoField;
        
        private int IdCertificadoField;
        
        private int IdEstudianteField;
        
        private string TituloCertificadoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CargaHoraria
        {
            get
            {
                return this.CargaHorariaField;
            }
            set
            {
                this.CargaHorariaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocumentoCertificado
        {
            get
            {
                return this.DocumentoCertificadoField;
            }
            set
            {
                this.DocumentoCertificadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCertificado
        {
            get
            {
                return this.IdCertificadoField;
            }
            set
            {
                this.IdCertificadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdEstudiante
        {
            get
            {
                return this.IdEstudianteField;
            }
            set
            {
                this.IdEstudianteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TituloCertificado
        {
            get
            {
                return this.TituloCertificadoField;
            }
            set
            {
                this.TituloCertificadoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ECProyectoEstudiante", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class ECProyectoEstudiante : object
    {
        
        private int HoraAcumuladaField;
        
        private System.DateTime HoraFinalField;
        
        private System.DateTime HoraInicioField;
        
        private int IdEstudianteField;
        
        private int IdProyectoField;
        
        private int IdProyectoEstudianteField;
        
        private string LatitudFinalField;
        
        private string LatitudInicialField;
        
        private string LongitudFinalField;
        
        private string LongitudInicialField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HoraAcumulada
        {
            get
            {
                return this.HoraAcumuladaField;
            }
            set
            {
                this.HoraAcumuladaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime HoraFinal
        {
            get
            {
                return this.HoraFinalField;
            }
            set
            {
                this.HoraFinalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime HoraInicio
        {
            get
            {
                return this.HoraInicioField;
            }
            set
            {
                this.HoraInicioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdEstudiante
        {
            get
            {
                return this.IdEstudianteField;
            }
            set
            {
                this.IdEstudianteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdProyecto
        {
            get
            {
                return this.IdProyectoField;
            }
            set
            {
                this.IdProyectoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdProyectoEstudiante
        {
            get
            {
                return this.IdProyectoEstudianteField;
            }
            set
            {
                this.IdProyectoEstudianteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LatitudFinal
        {
            get
            {
                return this.LatitudFinalField;
            }
            set
            {
                this.LatitudFinalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LatitudInicial
        {
            get
            {
                return this.LatitudInicialField;
            }
            set
            {
                this.LatitudInicialField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LongitudFinal
        {
            get
            {
                return this.LongitudFinalField;
            }
            set
            {
                this.LongitudFinalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LongitudInicial
        {
            get
            {
                return this.LongitudInicialField;
            }
            set
            {
                this.LongitudInicialField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SWLNControlServicioSocial.ISWLNControlServicioSocial")]
    public interface ISWLNControlServicioSocial
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_O", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_OResponse")]
        SWLNControlServicioSocial.ECProyecto[] Obtener_CProyecto_O();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_O", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_OResponse")]
        System.Threading.Tasks.Task<SWLNControlServicioSocial.ECProyecto[]> Obtener_CProyecto_OAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CCertificado_O", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CCertificado_OResponse")]
        SWLNControlServicioSocial.ECCertificado[] Obtener_CCertificado_O();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CCertificado_O", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CCertificado_OResponse")]
        System.Threading.Tasks.Task<SWLNControlServicioSocial.ECCertificado[]> Obtener_CCertificado_OAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyectoEstudiante_O_IdEst" +
            "udiante", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyectoEstudiante_O_IdEst" +
            "udianteResponse")]
        SWLNControlServicioSocial.ECProyectoEstudiante[] Obtener_CProyectoEstudiante_O_IdEstudiante(int idEstudiante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyectoEstudiante_O_IdEst" +
            "udiante", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyectoEstudiante_O_IdEst" +
            "udianteResponse")]
        System.Threading.Tasks.Task<SWLNControlServicioSocial.ECProyectoEstudiante[]> Obtener_CProyectoEstudiante_O_IdEstudianteAsync(int idEstudiante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyectoEstudiante_O", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyectoEstudiante_ORespon" +
            "se")]
        SWLNControlServicioSocial.ECProyectoEstudiante Obtener_CProyectoEstudiante_O();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyectoEstudiante_O", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyectoEstudiante_ORespon" +
            "se")]
        System.Threading.Tasks.Task<SWLNControlServicioSocial.ECProyectoEstudiante> Obtener_CProyectoEstudiante_OAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_O_IdProyecto", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_O_IdProyectoRespo" +
            "nse")]
        SWLNControlServicioSocial.ECProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_O_IdProyecto", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_O_IdProyectoRespo" +
            "nse")]
        System.Threading.Tasks.Task<SWLNControlServicioSocial.ECProyecto> Obtener_CProyecto_O_IdProyectoAsync(int IdProyecto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_O_CProyecto", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_O_CProyectoRespon" +
            "se")]
        SWLNControlServicioSocial.ECProyecto[] Obtener_CProyecto_O_CProyecto(int idEstudiante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_O_CProyecto", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CProyecto_O_CProyectoRespon" +
            "se")]
        System.Threading.Tasks.Task<SWLNControlServicioSocial.ECProyecto[]> Obtener_CProyecto_O_CProyectoAsync(int idEstudiante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CCertificado_O_IdEstudiante" +
            "", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CCertificado_O_IdEstudiante" +
            "Response")]
        SWLNControlServicioSocial.ECCertificado[] Obtener_CCertificado_O_IdEstudiante(int idEstudiante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CCertificado_O_IdEstudiante" +
            "", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Obtener_CCertificado_O_IdEstudiante" +
            "Response")]
        System.Threading.Tasks.Task<SWLNControlServicioSocial.ECCertificado[]> Obtener_CCertificado_O_IdEstudianteAsync(int idEstudiante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Insertar_CCertificado_I", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Insertar_CCertificado_IResponse")]
        void Insertar_CCertificado_I(string DocumentoCertificado, int IdEstudiante, string TituloCertificado, int CargaHoraria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Insertar_CCertificado_I", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Insertar_CCertificado_IResponse")]
        System.Threading.Tasks.Task Insertar_CCertificado_IAsync(string DocumentoCertificado, int IdEstudiante, string TituloCertificado, int CargaHoraria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Actualizar_CProyectoEstudiante_A_In" +
            "icio", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Actualizar_CProyectoEstudiante_A_In" +
            "icioResponse")]
        void Actualizar_CProyectoEstudiante_A_Inicio(int IdEstudiante, int IdProyecto, System.DateTime HoraInicio, string LatitudInicial, string LongitudInicial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Actualizar_CProyectoEstudiante_A_In" +
            "icio", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Actualizar_CProyectoEstudiante_A_In" +
            "icioResponse")]
        System.Threading.Tasks.Task Actualizar_CProyectoEstudiante_A_InicioAsync(int IdEstudiante, int IdProyecto, System.DateTime HoraInicio, string LatitudInicial, string LongitudInicial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Actualizar_CProyectoEstudiante_A_Ho" +
            "raAcumulada", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Actualizar_CProyectoEstudiante_A_Ho" +
            "raAcumuladaResponse")]
        void Actualizar_CProyectoEstudiante_A_HoraAcumulada(int IdEstudiante, int IdProyecto, System.DateTime HoraFinal, string LatitudFinal, string LongitudFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWLNControlServicioSocial/Actualizar_CProyectoEstudiante_A_Ho" +
            "raAcumulada", ReplyAction="http://tempuri.org/ISWLNControlServicioSocial/Actualizar_CProyectoEstudiante_A_Ho" +
            "raAcumuladaResponse")]
        System.Threading.Tasks.Task Actualizar_CProyectoEstudiante_A_HoraAcumuladaAsync(int IdEstudiante, int IdProyecto, System.DateTime HoraFinal, string LatitudFinal, string LongitudFinal);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface ISWLNControlServicioSocialChannel : SWLNControlServicioSocial.ISWLNControlServicioSocial, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class SWLNControlServicioSocialClient : System.ServiceModel.ClientBase<SWLNControlServicioSocial.ISWLNControlServicioSocial>, SWLNControlServicioSocial.ISWLNControlServicioSocial
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SWLNControlServicioSocialClient() : 
                base(SWLNControlServicioSocialClient.GetDefaultBinding(), SWLNControlServicioSocialClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISWLNControlServicioSocial.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SWLNControlServicioSocialClient(EndpointConfiguration endpointConfiguration) : 
                base(SWLNControlServicioSocialClient.GetBindingForEndpoint(endpointConfiguration), SWLNControlServicioSocialClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SWLNControlServicioSocialClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SWLNControlServicioSocialClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SWLNControlServicioSocialClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SWLNControlServicioSocialClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SWLNControlServicioSocialClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public SWLNControlServicioSocial.ECProyecto[] Obtener_CProyecto_O()
        {
            return base.Channel.Obtener_CProyecto_O();
        }
        
        public System.Threading.Tasks.Task<SWLNControlServicioSocial.ECProyecto[]> Obtener_CProyecto_OAsync()
        {
            return base.Channel.Obtener_CProyecto_OAsync();
        }
        
        public SWLNControlServicioSocial.ECCertificado[] Obtener_CCertificado_O()
        {
            return base.Channel.Obtener_CCertificado_O();
        }
        
        public System.Threading.Tasks.Task<SWLNControlServicioSocial.ECCertificado[]> Obtener_CCertificado_OAsync()
        {
            return base.Channel.Obtener_CCertificado_OAsync();
        }
        
        public SWLNControlServicioSocial.ECProyectoEstudiante[] Obtener_CProyectoEstudiante_O_IdEstudiante(int idEstudiante)
        {
            return base.Channel.Obtener_CProyectoEstudiante_O_IdEstudiante(idEstudiante);
        }
        
        public System.Threading.Tasks.Task<SWLNControlServicioSocial.ECProyectoEstudiante[]> Obtener_CProyectoEstudiante_O_IdEstudianteAsync(int idEstudiante)
        {
            return base.Channel.Obtener_CProyectoEstudiante_O_IdEstudianteAsync(idEstudiante);
        }
        
        public SWLNControlServicioSocial.ECProyectoEstudiante Obtener_CProyectoEstudiante_O()
        {
            return base.Channel.Obtener_CProyectoEstudiante_O();
        }
        
        public System.Threading.Tasks.Task<SWLNControlServicioSocial.ECProyectoEstudiante> Obtener_CProyectoEstudiante_OAsync()
        {
            return base.Channel.Obtener_CProyectoEstudiante_OAsync();
        }
        
        public SWLNControlServicioSocial.ECProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto)
        {
            return base.Channel.Obtener_CProyecto_O_IdProyecto(IdProyecto);
        }
        
        public System.Threading.Tasks.Task<SWLNControlServicioSocial.ECProyecto> Obtener_CProyecto_O_IdProyectoAsync(int IdProyecto)
        {
            return base.Channel.Obtener_CProyecto_O_IdProyectoAsync(IdProyecto);
        }
        
        public SWLNControlServicioSocial.ECProyecto[] Obtener_CProyecto_O_CProyecto(int idEstudiante)
        {
            return base.Channel.Obtener_CProyecto_O_CProyecto(idEstudiante);
        }
        
        public System.Threading.Tasks.Task<SWLNControlServicioSocial.ECProyecto[]> Obtener_CProyecto_O_CProyectoAsync(int idEstudiante)
        {
            return base.Channel.Obtener_CProyecto_O_CProyectoAsync(idEstudiante);
        }
        
        public SWLNControlServicioSocial.ECCertificado[] Obtener_CCertificado_O_IdEstudiante(int idEstudiante)
        {
            return base.Channel.Obtener_CCertificado_O_IdEstudiante(idEstudiante);
        }
        
        public System.Threading.Tasks.Task<SWLNControlServicioSocial.ECCertificado[]> Obtener_CCertificado_O_IdEstudianteAsync(int idEstudiante)
        {
            return base.Channel.Obtener_CCertificado_O_IdEstudianteAsync(idEstudiante);
        }
        
        public void Insertar_CCertificado_I(string DocumentoCertificado, int IdEstudiante, string TituloCertificado, int CargaHoraria)
        {
            base.Channel.Insertar_CCertificado_I(DocumentoCertificado, IdEstudiante, TituloCertificado, CargaHoraria);
        }
        
        public System.Threading.Tasks.Task Insertar_CCertificado_IAsync(string DocumentoCertificado, int IdEstudiante, string TituloCertificado, int CargaHoraria)
        {
            return base.Channel.Insertar_CCertificado_IAsync(DocumentoCertificado, IdEstudiante, TituloCertificado, CargaHoraria);
        }
        
        public void Actualizar_CProyectoEstudiante_A_Inicio(int IdEstudiante, int IdProyecto, System.DateTime HoraInicio, string LatitudInicial, string LongitudInicial)
        {
            base.Channel.Actualizar_CProyectoEstudiante_A_Inicio(IdEstudiante, IdProyecto, HoraInicio, LatitudInicial, LongitudInicial);
        }
        
        public System.Threading.Tasks.Task Actualizar_CProyectoEstudiante_A_InicioAsync(int IdEstudiante, int IdProyecto, System.DateTime HoraInicio, string LatitudInicial, string LongitudInicial)
        {
            return base.Channel.Actualizar_CProyectoEstudiante_A_InicioAsync(IdEstudiante, IdProyecto, HoraInicio, LatitudInicial, LongitudInicial);
        }
        
        public void Actualizar_CProyectoEstudiante_A_HoraAcumulada(int IdEstudiante, int IdProyecto, System.DateTime HoraFinal, string LatitudFinal, string LongitudFinal)
        {
            base.Channel.Actualizar_CProyectoEstudiante_A_HoraAcumulada(IdEstudiante, IdProyecto, HoraFinal, LatitudFinal, LongitudFinal);
        }
        
        public System.Threading.Tasks.Task Actualizar_CProyectoEstudiante_A_HoraAcumuladaAsync(int IdEstudiante, int IdProyecto, System.DateTime HoraFinal, string LatitudFinal, string LongitudFinal)
        {
            return base.Channel.Actualizar_CProyectoEstudiante_A_HoraAcumuladaAsync(IdEstudiante, IdProyecto, HoraFinal, LatitudFinal, LongitudFinal);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISWLNControlServicioSocial))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISWLNControlServicioSocial))
            {
                return new System.ServiceModel.EndpointAddress("http://swlncontrolserviciosocial.somee.com/SWLNControlServicioSocial.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SWLNControlServicioSocialClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISWLNControlServicioSocial);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SWLNControlServicioSocialClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISWLNControlServicioSocial);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ISWLNControlServicioSocial,
        }
    }
}
