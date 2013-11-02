using System;

namespace PrecoInfo.InfraStructure.Persistence.SessionConfiguration
{
    public interface IConfigurationFactory
    {
        FluentNHibernate.Cfg.FluentConfiguration Build();
    }
}
