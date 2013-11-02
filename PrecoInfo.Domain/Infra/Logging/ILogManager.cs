using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.InfraStructure.Logging
{
    /// <summary>
    /// Interface de log da PrecoInfo Business
    /// </summary>
    public interface IPrecoInfoLogManager
    {
        /// <summary>
        /// Registra um log de mensagem de erro
        /// </summary>
        /// <param name="mensagem">mensagem de erro</param>
        void InformarErro(string mensagem);

        /// <summary>
        /// Registra um log informativo, Normalmente recomendado para ambiente de produção
        /// </summary>
        /// <param name="mensagem">mensagem informativa</param>
        void Informar(string mensagem);

        /// <summary>
        /// Registra um log de aviso, normalmente para questões que não são críticas, geralmente falhas temporárias
        /// </summary>
        /// <param name="mensagem">mensagem de aviso</param>
        void Avisar(string mensagem);

        /// <summary>
        /// Registra um log de um erro fatal ou muito grave
        /// </summary>
        /// <param name="mensagem">mensagem de erro grave</param>
        void InformarErroFatal(string mensagem);
    }
}
