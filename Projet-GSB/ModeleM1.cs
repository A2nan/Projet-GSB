using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GSB
{
    public static class ModeleM1
    {
        private static NerdsUnitedEntities laConnexion;

        private static Visiteur leVisiteurConnect;
        public static void init()
        {
            laConnexion = new NerdsUnitedEntities();
        }

        public static List<Visiteur> listeVisiteur()
        {
            return laConnexion.Visiteur.ToList();
        }
        
        public static List<Region> listeRegion()
        {
            return laConnexion.Region.ToList();
        }

        public static List<Secteur> ListeSecteur()
        {
            return laConnexion.Secteur.ToList();
        }

        public static bool modifInfo(string nom, string prenom, string ville, string rue, string cp, string dateEmbauche)
        {
            bool vretour = true;
            try
            {
                ModeleConnexion.UtilisateurConnecte.nom = nom;
                ModeleConnexion.UtilisateurConnecte.prenom = prenom;
                ModeleConnexion.UtilisateurConnecte.ville = ville;
                ModeleConnexion.UtilisateurConnecte.rue = rue;
                ModeleConnexion.UtilisateurConnecte.cp = cp;
                ModeleConnexion.UtilisateurConnecte.dateEmbauche = dateEmbauche;
                ModeleConnexion.laConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;

        }

        public static string modifMdp(string mdp, string Newmdp, string Newmdp2)
        {
            string message = "";

            if (ModeleConnexion.CorrectPassword(mdp, true))
            {

                if (string.Equals(Newmdp, Newmdp2))
                {
                    try
                    {
                        string mdpHash = string.Concat("0x", ModeleConnexion.GetMd5Hash(Newmdp));
                        ModeleConnexion.UtilisateurConnecte.password = mdpHash;
                        ModeleConnexion.laConnexion.SaveChanges();
                        message = "mot de passe modifié";
                        
                    }
                    catch(Exception ex)
                    {
                        message = "Une erreur est survenu, votre mdp n'a pas été modifier";
                    }
                }
            }
            else
            {
                message = "informations incorrect";
            }

            return message;

        }

    }

}   

