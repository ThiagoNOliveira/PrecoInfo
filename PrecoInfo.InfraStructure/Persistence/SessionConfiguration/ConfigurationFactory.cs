using System.Configuration;
using System.Reflection;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace PrecoInfo.InfraStructure.Persistence.SessionConfiguration
{
    /// <summary>
    /// Fábrica de Contrução de configuração de conexões entre o Hibernate e o banco de dados
    /// </summary>
    public class ConfigurationFactory : PrecoInfo.InfraStructure.Persistence.SessionConfiguration.IConfigurationFactory
    {
        /// <summary>
        /// Ambiente de configuração
        /// </summary>
        private string ambienteDeConfiguracao;

        /// <summary>
        /// Ambiente de configuração
        /// </summary>
        public string AmbienteDeConfiguracao
        {
            get
            {
                if (string.IsNullOrEmpty(ambienteDeConfiguracao))
                    ambienteDeConfiguracao = ConfigurationManager.AppSettings["AmbienteDeConfiguracao"];
             
                return ambienteDeConfiguracao;
            }
            set { ambienteDeConfiguracao = value; }
        }
 
        /// <summary>
        /// Constrói a configuração do hibernate para iniciar sessões
        /// </summary>
        /// <returns>Configuração</returns>
        public FluentConfiguration Build()
        {
            var caminhoDoAssemblyDeMapeamento = ObterCaminhoDoAssemblyDeMapeamento();

            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c
                                                                                                        .FromAppSetting(
                                                                                                            "Conexao")))
                           .Mappings(
                               m => m.FluentMappings.AddFromAssembly(Assembly.LoadFrom(caminhoDoAssemblyDeMapeamento)))
                           .Mappings(m => m.MergeMappings())
                           .ExposeConfiguration(c => c.SetProperty("current_session_context_class", "web"));
        }

        /// <summary>
        /// Obtem o caminho do assembly de mapeamento do hibernate
        /// </summary>
        /// <returns>caminho da dll</returns>
        private string ObterCaminhoDoAssemblyDeMapeamento()
        {
            string caminhoDoAssemblyDeMapeamento;

            if (AmbienteDeConfiguracao == "Testes")
                caminhoDoAssemblyDeMapeamento = string.Concat(System.Environment.CurrentDirectory,
                                                              ConfigurationManager.AppSettings["CaminhoDllDeMapeamento"]);
            else
                caminhoDoAssemblyDeMapeamento =
                    HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["CaminhoDllDeMapeamento"]);
            return caminhoDoAssemblyDeMapeamento;
        }
    }
}
