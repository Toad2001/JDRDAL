using JDRDAL.Models.ObjetM;
using JDRDAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;
using ToolBox.Pattern.Repository;

namespace JDRDAL.Repositories.ObjetR
{
    public class EquipementRepository : IRepository<int, Equipement>
    {
        public IEnumerable<Equipement> Get()
        {
            Command cmd = new Command("select * from Equipement");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, e => e.ToEquipement());
        }

        public Equipement Get(int id)
        {
            Command cmd = new Command("select * from Equipement where Id = " + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, e => e.ToEquipement()).FirstOrDefault();
        }

        public Equipement Insert(Equipement entity)
        {
            Command cmd = new Command("AjouterEquipement", true);
            cmd.AddParameter("Id_Arme", entity.Id_Arme);
            cmd.AddParameter("Id_Armure", entity.Id_Armure);
            cmd.AddParameter("Id_Matiere", entity.Id_Matiere);
            cmd.AddParameter("Id_Style", entity.Id_Style);
            cmd.AddParameter("Id_Enchantement", entity.Id_Enchantement);

            return (Equipement)ServiceLocator.Instance.Connection.ExecuteScalar(cmd);
        }

        public bool Update(int id, Equipement entity)
        {
            Command cmd = new Command("ModifierEquipement", true);
            cmd.AddParameter("Id_Arme", entity.Id_Arme);
            cmd.AddParameter("Id_Armure", entity.Id_Armure);
            cmd.AddParameter("Id_Matiere", entity.Id_Matiere);
            cmd.AddParameter("Id_Style", entity.Id_Style);
            cmd.AddParameter("Id_Enchantement", entity.Id_Enchantement);
            cmd.AddParameter("Id", entity.Id);

            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) ==1;
        }

        public bool Delete(int id)
        {
            Command cmd = new Command("SupprimerEquipement", true);
            cmd.AddParameter("Id", id);
            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) == 1;
        }
    }
}
