using JDRDAL.Models;
using JDRDAL.Models.Intermediaire;
using JDRDAL.Models.ObjetM;
using JDRDAL.Models.UtilisateurM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRDAL.Mappers
{
    internal static class MapperDAL
    {
        internal static Role_Utilisateur ToRole_Utilisateur(this IDataRecord dr)
        {
            return MapperDR<Role_Utilisateur>.MapDR(dr);
        }

        internal static Roles ToRoles(this IDataRecord dr)
        {
            return MapperDR<Roles>.MapDR(dr);
        }

        internal static PJ_User ToPJ_User(this IDataRecord dr)
        {
            return MapperDR<PJ_User>.MapDR(dr);
        }


        internal static PJ_Equipement ToPJ_Equipement(this IDataRecord dr)
        {
            return MapperDR<PJ_Equipement>.MapDR(dr);
        }

        internal static PJDetails ToPjDetails(this IDataRecord dr)
        {
            return new PJDetails()
            {
                 Id= (int)dr["Id"],
                 Nom = (string)dr["Nom"],
                 Valeur=(int)dr["Valeur"]
            };
        }

        internal static Utilisateur ToUser(this IDataRecord dr)
        {
            return new Utilisateur()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Prenom = (string)dr["Prenom"],
                Login = (string)dr["Login"],
                Password = (string)dr["Password"],
                Email = (string)dr["Email"],                
            };
        }

        internal static PJ ToPJ(this IDataRecord dr)
        {
            return new PJ()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Sexe = (bool)dr["Sexe"],
                Blesse = (bool)dr["Blesse"],
                Esquive = (bool)dr["Esquive"],
                CoupPuissant = (bool)dr["CoupPuissant"],
                Id_Race = (int)dr["Id_Race"],
                Id_Classe = (int)dr["Id_Classe"],
                Id_Signe = (int)dr["Id_Signe"],
            };
        }

        internal static Equipement ToEquipement(this IDataRecord dr)
        {
            return new Equipement()
            {
                Id =  (int)dr["Id"],
                Id_Arme = (dr["Id_Arme"] is DBNull) ? null : (int?)dr["Id_Arme"],
                Id_Armure = (dr["Id_Armure"] is DBNull) ? null : (int?)dr["Id_Armure"],
                Id_Matiere = (int)dr["Id_Matiere"],
                Id_Style = (int)dr["Id_Style"],
                Id_Enchantement = (dr["Id_Enchantement"] is DBNull)? null :(int?)dr["Id_Enchantement"],
            };
        }

        internal static Matiere ToMatiere(this IDataRecord dr)
        {
            return new Matiere()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Arme = (bool)dr["Arme"],
                ArmureLourd = (bool)dr["ArmureLourd"],
                ArmureLegere = (bool)dr["ArmureLegere"],
            };
        }

        internal static Utilisateur ToUtilisateur(this IDataRecord dr)
        {
            return new Utilisateur()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Prenom = (string)dr["Prenom"],
                Login = (string)dr["Login"],
                Password = (string)dr["Password"],
                Email = (string)dr["Email"],
                Active = (bool)dr["Active"],
            };
        }
        internal static Race ToRace(this IDataRecord dr)
        {
            return new Race()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Id_Province = (int)dr["Id_Province"],
                Id_Resistence = (dr["Id_Resistence"] is DBNull) ? null : (int?)dr["Id_Resistence"],
                Id_Capacite1 = (int)dr["Id_Capacite1"],
                Id_Capacite2 = (int)dr["Id_Capacite2"],
            };
        }

        internal static Stat ToStat(this IDataRecord dr)
        {
            return new Stat()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Id_ClasseStat = (int)dr["Id_ClasseStat"],
            };
        }

        internal static Rang ToRang(this IDataRecord dr)
        {
            return new Rang()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
            };
        }

        internal static ClasseStat ToClasseStat(this IDataRecord dr)
        {
            return new ClasseStat()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
            };
        }

        internal static ClassePNJ ToClassePNJ(this IDataRecord dr)
        {
            return new ClassePNJ()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
            };
        }

        internal static PNJ ToPNJ(this IDataRecord dr)
        {
            return new PNJ()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Sexe = (bool)dr["Sexe"],
                Id_Race = (int)dr["Id_Race"],
                Id_Ame = (int)dr["Id_Ame"],
                Id_Rang = (int)dr["Id_Rang"],
                Id_ClassePNJ = (int)dr["Id_ClassePNJ"],
            };
        }

        internal static Classe ToClasse(this IDataRecord dr)
        {
            return new Classe()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
            };
        }

        internal static ConditionTalent ToConditionTalent(this IDataRecord dr)
        {
            return new ConditionTalent()
            {
                Id = (int)dr["Id"],
                Condition = (string)dr["Condition"],
                Id_Talent = (int)dr["Id_Talent"],
            };
        }

        internal static Signe ToSigne(this IDataRecord dr)
        {
            return new Signe()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Effet = (string)dr["Effet"],
            };
        }

        internal static Talent ToTalent(this IDataRecord dr)
        {
            return new Talent()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Limite = (int)dr["Limite"],
                Effet = (string)dr["Effet"],
                Id_Stat = (int)dr["Id_Stat"],
            };
        }

        internal static TypeArme ToTypeArme(this IDataRecord dr)
        {
            return new TypeArme()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
            };
        }

        internal static Style ToStyle(this IDataRecord dr)
        {
            return new Style()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Prix = (int)dr["Prix"],
            };
        }

        internal static Armure ToArmure(this IDataRecord dr)
        {
            return new Armure()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
            };
        }

        internal static Objet ToObjet(this IDataRecord dr)
        {
            return new Objet()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Encombrement = (int)dr["Encombrement"],
                Prix = (int)dr["Prix"],
                Effet = (string)dr["Effet"],
            };
        }

        internal static Arme ToArme(this IDataRecord dr)
        {
            return new Arme()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Id_TypeArme = (int)dr["Id_TypeArme"],
                Malus = (int)dr["Malus"],
                TailleArme = (bool)dr["DeuxMains"],
            };
        }

        internal static Enchantement ToEnchantement(this IDataRecord dr)
        {
            return new Enchantement()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Effet = (string)dr["Effet"],
            };
        }

        internal static Resistence ToResistence(this IDataRecord dr)
        {
            return new Resistence()
            {
                Id = (int)dr["Id"],
                Description = (string)dr["Description"],
            };
        }

        internal static Monstre ToMonstre(this IDataRecord dr)
        {
            return new Monstre()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Id_Ame = (dr["Id_Ame"] is DBNull) ? null : (int?)dr["Id_Ame"],
                Id_Rang = (int)dr["Id_Rang"],
                Id_Resistence = (dr["Id_Resistence"] is DBNull) ? null : (int?)dr["Id_Resistence"],
                Id_Capacite = (dr["Id_Capacite"] is DBNull) ? null : (int?)dr["IId_Capacited_Ame"],
            };
        }

        internal static Capacite ToCapacite(this IDataRecord dr)
        {
            return new Capacite()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Description = (string)dr["Description"],
            };
        }

        internal static Ame ToAme(this IDataRecord dr)
        {
            return new Ame()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
            };
        }

        internal static EcoleMagie ToEcoleMagie(this IDataRecord dr)
        {
            return new EcoleMagie()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
            };
        }

        internal static RangMagie ToRangMagie(this IDataRecord dr)
        {
            return new RangMagie()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
            };
        }

        internal static Magie ToMagie(this IDataRecord dr)
        {
            return new Magie()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
                Effet = (string)dr["Effet"],
                Id_EcoleMagie = (int)dr["Id_EcoleMagie"],
                Id_RangMagie = (int)dr["Id_RangMagie"],

            };
        }

        internal static Province ToProvince(this IDataRecord dr)
        {
            return new Province()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
            };
        }

        internal static Lieu ToLieu(this IDataRecord dr)
        {
            return new Lieu()
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"],
            };
        }

        internal static PJ_Stat ToPJ_Stat(this IDataRecord dr)
        {
            return new PJ_Stat()
            {
                Id = (int)dr["Id"],
                Id_PJ = (int)dr["Id_PJ"],
                Id_Stat = (int)dr["Id_Stat"],
                Valeur = (int)dr["Valeur"],
            };
        }
    }
}
