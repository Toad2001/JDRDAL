using System;
using System.Runtime.Serialization;

namespace ToolBox.Pattern.IOC
{
    [Serializable]
    public class InvalidGenericArgument : Exception
    {
        public InvalidGenericArgument(string message) : base(message)
        {
        }
    }
}