using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.IOC;

namespace ToolBox.Pattern.Locator
{
    public class ServiceLocator : LocatorBase
    {
        private static ServiceLocator _Instance;
        public static ServiceLocator Instance { get { return _Instance ?? (_Instance = new ServiceLocator()); } }

        //Aller rechercher la connexion     
        public Connection Connection => Container.GetInstance<Connection>();


        public ServiceLocator()
        {
            //Enregistrer la "connectionstring" dans le container
            Container.Register<Connection>(Resource1.ConnectionString);
        }

        public ServiceLocator(SimpleIOC container) : base(container)
        {
        }
    }
}
