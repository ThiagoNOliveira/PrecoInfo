namespace PrecoInfo.InfraStructure.Logging
{
    /// <summary>
    /// Estratégia de log para o ambiente de desenvolvimento
    /// </summary>
    public class LogEmDesenvolvimento : EstrategiaDeLogParaDiferentesAmbientes
    {
        /// <summary>
        /// Registra um log detalhado, inclui um grande volume de informação até ao ponto de demonstrar protocolos. Ótimo para ambiente de desenvolvimento
        /// </summary>
        /// <param name="mensagem">mensagem de rastreamento</param>
        public override void InformarErro(string mensagem)
        {
            Logger.Trace(mensagem);
        }
    }
}
