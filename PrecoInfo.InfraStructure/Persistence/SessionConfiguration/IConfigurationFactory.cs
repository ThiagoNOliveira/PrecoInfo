using System;

namespace PrecoInfo.InfraStructure.Persistence.SessionConfiguration
{
    public interface IConfigurationFactory
    {
        string AmbienteDeConfiguracao { get; set; }
        FluentNHibernate.Cfg.FluentConfiguration Build();
    }
}
