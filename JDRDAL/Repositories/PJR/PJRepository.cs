using JDRDAL.Models;
using JDRDAL.Mappers;
using JDRDAL.Models.Intermediaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;
using ToolBox.Pattern.Repository;

namespace JDRDAL.Repositories.PJR
{
    public class PJRepository : IRepository<int, PJ>
    {
        public IEnumerable<PJ> Get()
        {
            Command cmd = new Command("SELECT * FROM PJ");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, pj => pj.ToPJ());
        }

        public PJ Get(int id)
        {
            Command cmd = new Command("SELECT * FROM PJ WHERE Id =" + id);
            return ServiceLocator.Instance.Connection.ExecuteReader(cmd,pj => pj.ToPJ()).FirstOrDefault();
        }        

        public PJ Insert(PJ entity)
        {
            Command cmd = new Command("AjouterPJ", true);

            cmd.AddParameter("Nom", entity.Nom);
            cmd.AddParameter("Sexe", entity.Sexe);
            cmd.AddParameter("Id_Race", entity.Id_Race);
            cmd.AddParameter("Id_Classe", entity.Id_Classe);
            cmd.AddParameter("Id_Signe", entity.Id_Signe);
            cmd.AddParameter("ValeurD4", entity.ValeurD4);

            entity.Id = (int)ServiceLocator.Instance.Connection.ExecuteScalar(cmd);
            return entity;
        }

        public bool Update(int id, PJ entity, PJ_Stat  entityStat)
        {
            Command cmd = new Command("ModifierPJ", true);

            cmd.AddParameter("Nom", entity.Nom);
            cmd.AddParameter("Sexe", entity.Sexe);
            cmd.AddParameter("Blesse", entity.Blesse);
            cmd.AddParameter("Esquive", entity.Esquive);
            cmd.AddParameter("CoupPuissant", entity.CoupPuissant);
            cmd.AddParameter("Id_Race", entity.Id_Race);
            cmd.AddParameter("Id_Classe", entity.Id_Classe);
            cmd.AddParameter("Id_Signe", entity.Id_Signe);
            cmd.AddParameter("Sante", entityStat.Valeur);
            cmd.AddParameter("Vigueur", entityStat.Valeur);
            cmd.AddParameter("Magie", entityStat.Valeur);
            cmd.AddParameter("RegenSante", entityStat.Valeur);
            cmd.AddParameter("RegenVigeur", entityStat.Valeur);
            cmd.AddParameter("RegenMagie", entityStat.Valeur);
            cmd.AddParameter("Force", entityStat.Valeur);
            cmd.AddParameter("Intelligence", entityStat.Valeur);
            cmd.AddParameter("Volonte", entityStat.Valeur);
            cmd.AddParameter("Agilite", entityStat.Valeur);
            cmd.AddParameter("Rapidite", entityStat.Valeur);
            cmd.AddParameter("Endurance", entityStat.Valeur);
            cmd.AddParameter("Personnalite", entityStat.Valeur);
            cmd.AddParameter("Niveau", entityStat.Valeur);
            cmd.AddParameter("ValeurD4", entity.ValeurD4);
            cmd.AddParameter("Forgeage", entityStat.Valeur);
            cmd.AddParameter("ArmureLourde", entityStat.Valeur);
            cmd.AddParameter("Blocage", entityStat.Valeur);
            cmd.AddParameter("DeuxMains", entityStat.Valeur);
            cmd.AddParameter("UneMain", entityStat.Valeur);
            cmd.AddParameter("Distance", entityStat.Valeur);
            cmd.AddParameter("ArmureLégère", entityStat.Valeur);
            cmd.AddParameter("Furtivité", entityStat.Valeur);
            cmd.AddParameter("Crochetage", entityStat.Valeur);
            cmd.AddParameter("Vol", entityStat.Valeur);
            cmd.AddParameter("Eloquence", entityStat.Valeur);
            cmd.AddParameter("Alchimie", entityStat.Valeur);
            cmd.AddParameter("Illusion", entityStat.Valeur);
            cmd.AddParameter("Conjuration", entityStat.Valeur);
            cmd.AddParameter("Destruction", entityStat.Valeur);
            cmd.AddParameter("Guérison", entityStat.Valeur);
            cmd.AddParameter("Altération", entityStat.Valeur);
            cmd.AddParameter("Enchantement", entityStat.Valeur);
            cmd.AddParameter("Septime", entityStat.Valeur);
            cmd.AddParameter("Encombrement", entityStat.Valeur);
            cmd.AddParameter("Vivres", entityStat.Valeur);
            cmd.AddParameter("Id", entityStat.Valeur);

            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd)==1;
        }

        public bool Delete(int id)
        {
            Command cmd = new Command("SupprimerPJ", true);

            cmd.AddParameter("Id", id);

            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) ==1;

        }

        public bool Update(int id, PJ entity)
        {
            Command cmd = new Command("update PJ set Nom = @Nom, Sexe = @Sexe, Blesse = @Blesse, Esquive = @Esquive, CoupPuissant = @CoupPuissant, Id_Race = @Id_Race, Id_Classe = @Id_Classe, Id_Signe = Id_Signe where id =" + id);
            cmd.AddParameter("Nom", entity.Nom);
            cmd.AddParameter("Sexe", entity.Sexe);
            cmd.AddParameter("Blesse", entity.Blesse);
            cmd.AddParameter("Esquive", entity.Esquive);
            cmd.AddParameter("CoupPuissant", entity.CoupPuissant);
            cmd.AddParameter("Id_Race", entity.Id_Race);
            cmd.AddParameter("Id_Classe", entity.Id_Classe);
            cmd.AddParameter("Id_Signe", entity.Id_Signe);
            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) == 1;
        }
    }
}
