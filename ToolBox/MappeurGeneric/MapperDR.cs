using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.MappeurGeneric
{
    public static class MapperDR<T>
    {
        public static T MapDR(IDataRecord dr)
        {
            T retour = Activator.CreateInstance<T>();

            for (int i = 0; i < dr.FieldCount; i++)
            {
                string PropName = dr.GetName(i);
                object PropValue = dr.GetValue(i);

                if (PropValue != DBNull.Value)
                {
                    typeof(T).GetProperty(PropName).SetValue(retour, PropValue);
                }
            }
            return retour;
        }
    }
}
