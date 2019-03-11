using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Patterns.Mediator
{
    public class Messenger<TMessage>
    {
        private static Messenger<TMessage> _Instance;

        public static Messenger<TMessage> Instance
        {
            get
            {
                return _Instance ?? (_Instance = new Messenger<TMessage>());
            }
        }

        private Action<TMessage> _Broadcast;

        protected Messenger()
        {

        }

        public void Register(Action<TMessage> action)
        {
            _Broadcast += action;
        }

        public void Send(TMessage message)
        {
            _Broadcast?.Invoke(message);
        }
    }
}
