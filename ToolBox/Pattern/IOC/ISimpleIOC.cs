using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Pattern.IOC
{
    public interface ISimpleIOC
    {

        TResource GetInstance<TResource>();
        void Register<TResource>();
        void Register<TResource>(params object[] parameters);

        void Register<TInterface,TResource>()
            where TResource : TInterface;
        void Register<TInterface, TResource>(params object[] parameters)
            where TResource : TInterface;
    }
}
