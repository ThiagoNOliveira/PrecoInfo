using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.InfraStructure.Logging
{
    /// <summary>
    /// Estrategia de log para o ambiente de testes
    /// </summary>
    public class LogEmTestes : EstrategiaDeLogParaDiferentesAmbientes
    {
        /// <summary>
        /// Registra log com informações de debug porém com menos informações que o Trace - Não é aconselhável utilizar em ambiente de produção
        /// </summary>
        /// <param name="mensagem">mensagem de depuração</param>
        public override void InformarErro(string mensagem)
        {
            Logger.Debug(mensagem);
        }
    }
}
