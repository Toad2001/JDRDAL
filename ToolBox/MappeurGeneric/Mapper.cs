using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.MappeurGeneric
{
    public static class Mapper<Tfrom, Uto>
        where Tfrom : class
        where Uto : class
    {
        public static Uto Map(Tfrom entity)
        {
            //Creation de l'objet a retourner
            Uto retour = (Uto)Activator.CreateInstance(typeof(Uto));

            //pour chaque proprietés du type de départ
            foreach (PropertyInfo item in typeof(Tfrom).GetProperties())
            {
                //Si il y a une proprieté dans le type a retourner qui a le meme nom qu'une proprieté du type de départ
                if (typeof(Uto).GetProperties().Count(e => e.Name == item.Name) > 0)
                {
                    //on affecte a la propriete du type a retourner la valeur se trouvant dans la proprieté de l'objet de départ
                    typeof(Uto).GetProperty(item.Name).SetValue(retour, item.GetValue(entity));
                }
            }
            return retour;
        }
        
    }
}
