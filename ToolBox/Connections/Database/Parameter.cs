using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Connections.Database
{
    internal class Parameter
    {
        internal string ParameterName { get; private set; }
        internal object Value { get; private set; }
        internal DbType? Type { get; private set; }

        public Parameter(string parameterName, object value, DbType? type)
        {
            ParameterName = parameterName;
            Value = value;
            Type = type;
        }        
    }
}
