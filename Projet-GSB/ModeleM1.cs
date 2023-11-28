using System;
using System.Collections.Generic;
using System.Linq;
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

    }

}   

