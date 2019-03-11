using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Pattern.IOC;

namespace ToolBox.Pattern.Locator
{
    public abstract class LocatorBase
    {
        private ISimpleIOC _Container;

        protected ISimpleIOC Container
        {
            get
            {
                return _Container;
            }

            private set
            {
                _Container = value;
            }
        }

        protected LocatorBase() : this(new SimpleIOC())
        {

        }

        protected LocatorBase(ISimpleIOC container)
        {
            Container = container;
        }
    }
}
