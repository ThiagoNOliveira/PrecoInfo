using NUnit.Framework;
using PrecoInfo.InfraStructure.Persistence.SessionManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Mappings.Test
{
    [TestFixture]
    public class CreateDataBaseTest
    {
        [Test]
        public void criar_base_de_dados()
        {
            new FullSessionState().CreateDataBase();
        }
    }
}
