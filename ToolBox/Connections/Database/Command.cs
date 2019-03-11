using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Connections.Database
{
    public class Command
    {
        internal string Query { get; private set; }
        internal bool IsStoredProcedure { get; private set; }
        internal IDictionary<string, Parameter> Parameters { get; private set; }

        public Command(string query, bool isStoredProcedure = false)
        {
            Parameters = new Dictionary<string, Parameter>();
            Query = query;
            IsStoredProcedure = isStoredProcedure;
        }

        public void AddParameter(string parameterName, object value)
        {
            Parameters.Add(parameterName, new Parameter(parameterName, value, null));            
        }

        public void AddParameter(string parameterName, object value, DbType type)
        {
            Parameters.Add(parameterName, new Parameter(parameterName, value, type));
        }
    }
}
