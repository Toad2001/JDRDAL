using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Pattern.Repository
{
    public interface IRepository<TKey, TResult> where TResult : class where TKey : struct //Peut implémenter une interface que si TResult est une classe et TKey est un type structure
    {
        //IEnumerable nous permet de construire une séquence ce qui nous permet de facilement boucler sur notre séquence
        IEnumerable<TResult> Get();
        TResult Get(TKey id);
        //Meme TResult sauf qu'a la sortie il aura l'Id intercepté
        TResult Insert(TResult entity);
        bool Update(TKey id, TResult entity);
        bool Delete(TKey id);
    }
}
