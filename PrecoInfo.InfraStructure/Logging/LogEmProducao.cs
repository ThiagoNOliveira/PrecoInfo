namespace PrecoInfo.InfraStructure.Logging
{
    /// <summary>
    /// Estratégia de log para o ambiente de produção
    /// </summary>
    public class LogEmProducao : EstrategiaDeLogParaDiferentesAmbientes
    {
        /// <summary>
        /// Registra um log de mensagem de erro
        /// </summary>
        /// <param name="mensagem">mensagem de erro</param>
        public override void InformarErro(string mensagem)
        {
            Logger.Error(mensagem);
        }
    }
}
