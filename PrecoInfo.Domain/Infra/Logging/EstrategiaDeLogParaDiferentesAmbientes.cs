using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace PrecoInfo.InfraStructure.Logging
{
    /// <summary>
    /// Estratégia de log abstrata para diferentes ambientes
    /// </summary>
    public abstract class EstrategiaDeLogParaDiferentesAmbientes : IPrecoInfoLogManager
    {
        /// <summary>
        /// instancia do Nlog
        /// </summary>
        protected static Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Registra um log informativo, Normalmente recomendado para ambiente de produção
        /// </summary>
        /// <param name="mensagem">mensagem informativa</param>
        public virtual void Informar(string mensagem)
        {
            Logger.Info(mensagem);
        }

        /// <summary>
        /// Registra um log de aviso, normalmente para questões que não são críticas, geralmente falhas temporárias
        /// </summary>
        /// <param name="mensagem">mensagem de aviso</param>
        public virtual void Avisar(string mensagem)
        {
            Logger.Warn(mensagem);
        }

        /// <summary>
        /// Registra um log de um erro fatal ou muito grave
        /// </summary>
        /// <param name="mensagem">mensagem de erro grave</param>
        public virtual void InformarErroFatal(string mensagem)
        {
            Logger.Fatal(mensagem);
        }

        /// <summary>
        /// Registra um log de mensagem de erro
        /// </summary>
        /// <param name="mensagem">mensagem de erro</param>
        public abstract void InformarErro(string mensagem);
    }
}
