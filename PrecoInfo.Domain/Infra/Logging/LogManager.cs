using System;
using System.Configuration;

namespace PrecoInfo.InfraStructure.Logging
{
    /// <summary>
    /// Enum de ambientes de log
    /// </summary>
    public enum AmbienteDeLog : short
    {
        /// <summary>
        /// Produção
        /// </summary>
        Producao = 1,

        /// <summary>
        /// Teste
        /// </summary>
        Teste = 2,

        /// <summary>
        /// Desenvolvimento
        /// </summary>
        Desenvolvimento = 3,

        /// <summary>
        /// Desconhecido
        /// </summary>
        Desconhecido = 4
    }

    /// <summary>
    /// Wrapper de log da PrecoInfo para o framework Nlog
    /// </summary>
    public class PrecoInfoLogManager : IPrecoInfoLogManager
    {
        private IPrecoInfoLogManager _log;
        private static PrecoInfoLogManager _instance;
        private static object syncLock = new object();
        private static short ambiente;

        public static AmbienteDeLog Ambiente
        {
            get
            {
                if (ambiente == default(int))
                    ambiente = short.Parse(ConfigurationManager.AppSettings["AmbienteDeLog"]);

                return (AmbienteDeLog)ambiente;
            }
            set
            {
                ambiente = (short)value;
            }
        }

        /// <summary>
        /// Contrutor de Log da ProcuraFacil
        /// </summary>
        private PrecoInfoLogManager()
        {
            switch (Ambiente)
            {
                case AmbienteDeLog.Producao:
                    _log = new LogEmProducao();
                    break;
                case AmbienteDeLog.Teste:
                    _log = new LogEmTestes();
                    break;
                case AmbienteDeLog.Desenvolvimento:
                    _log = new LogEmDesenvolvimento();
                    break;
                default:
                    throw new GerenciadorDeLogNaoConfigurado();
            }
        }

        /// <summary>
        /// Singleton do gerenciador de log
        /// </summary>
        /// <returns>instancia única do gerenciador de log</returns>
        public static PrecoInfoLogManager Inicializar()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                        _instance = new PrecoInfoLogManager();
                }
            }

            return _instance;
        }

        public static void LimparInstancia()
        {
            _instance = null;
        }

        /// <summary>
        /// Registra um log informativo, Normalmente recomendado para ambiente de produção
        /// </summary>
        /// <param name="mensagem">mensagem informativa</param>
        public void InformarErro(string mensagem)
        {
            _log.InformarErro(mensagem);
        }

        /// <summary>
        /// Registra um log de aviso, normalmente para questões que não são críticas, geralmente falhas temporárias
        /// </summary>
        /// <param name="mensagem">mensagem de aviso</param>
        public void Informar(string mensagem)
        {
            _log.Informar(mensagem);
        }

        /// <summary>
        /// Registra um log de um erro fatal ou muito grave
        /// </summary>
        /// <param name="mensagem">mensagem de erro grave</param>
        public void Avisar(string mensagem)
        {
            _log.Avisar(mensagem);
        }

        /// <summary>
        /// Registra um log de mensagem de erro
        /// </summary>
        /// <param name="mensagem">mensagem de erro</param>
        public void InformarErroFatal(string mensagem)
        {
            _log.InformarErroFatal(mensagem);
        }

        /// <summary>
        /// Classe de excecao de configuração do gerenciador de Log
        /// </summary>
        public class GerenciadorDeLogNaoConfigurado : Exception
        {
            /// <summary>
            /// Mensagem de erro
            /// </summary>
            public override string Message
            {
                get { return "Gerenciador de log não foi devidamente configurado"; }
            }
        }

    }
}
