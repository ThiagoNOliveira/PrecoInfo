﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace PrecoInfo.InfraStructure.Persistence.SessionManagement
{
    /// <summary>
    /// Fábrica de construção de Fábrica de configuração de sessão
    /// </summary>
    public interface ISessionFactoryBuilder
    {
        /// <summary>
        /// Obter Fábrica de sessão
        /// </summary>
        /// <returns><see cref="ISessionFactory"/>Fábrica de Sessão</returns>
        ISessionFactory GetFactory();
    }
}
