using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using NHibernate;
using PrecoInfo.InfraStructure.Persistence.SessionConfiguration;
using PrecoInfo.InfraStructure.ScopeInstance;

namespace PrecoInfo.InfraStructure.Persistence.SessionManagement
{
    public class SessionFactoryBuilder : ISessionFactoryBuilder
    {
        private const string SESSION_FACTORY = "sessionFactory";

        private readonly SingletonInstanceScoper<ISessionFactory> _sessionFactorySingleton =
            new SingletonInstanceScoper<ISessionFactory>();

        private IConfigurationFactory configurationFactory;

        public IConfigurationFactory ConfigurationFactory
        {
            get
            {
                if (configurationFactory == null)//Todo: Remover acoplamento
                    configurationFactory = new ConfigurationFactory();
                return configurationFactory;
            }
            set { configurationFactory = value; }
        }

        public ISessionFactory GetFactory()
        {
            return _sessionFactorySingleton.GetScopedInstance(SESSION_FACTORY, BuildFactory);
        }

        private ISessionFactory BuildFactory()
        {
            FluentConfiguration cfg = ConfigurationFactory.Build();
            ISessionFactory sessionFactory = cfg.BuildSessionFactory();
            return sessionFactory;
        }
    }
}
