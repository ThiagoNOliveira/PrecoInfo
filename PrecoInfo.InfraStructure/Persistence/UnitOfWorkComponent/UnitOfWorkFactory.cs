using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrecoInfo.InfraStructure.Persistence.SessionManagement;

namespace PrecoInfo.InfraStructure.Persistence.UnitOfWorkComponent
{
    public class UnitOfWorkFactory
    {
        public static IUnitOfWork GetDefault()
        {
            return new UnitOfWork(new SessionBuilder());
        }
    }
}
