using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projet_GSB
{
    public static class ModeleConnexion
    {
        public static NerdsUnitedEntities laConnexion;
       
        public static void init()
        {
            laConnexion = new NerdsUnitedEntities();
        }
        //les variables avec leur getter:
        private static Visiteur utilisateurConnecte;
        private static bool connexionValide;

        public static Visiteur UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }

        //et les méthodes :

        public static bool CorrectPassword(string mdp, bool Connexion)
        {
            bool vretour = false;
            if (Connexion == connexionValide)
            {
                string mdpHash = string.Concat("0x", GetMd5Hash(mdp));
                if (string.Equals(mdpHash, utilisateurConnecte.password, StringComparison.CurrentCultureIgnoreCase))
                {
                    vretour = true;
                }
            }
            return vretour;
        }




        public static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public static string validConnexion(string id, string mp)
        {
            string message = "";
            // Ecrire le code qui renvoie le message à afficher et mets à jour les variables utilisateurConnecte et connexionValide, la comparaison des mots de passes se fera via utilisateurConnecte.passwd.Substring(2).Equals(GetMd5Hash(mp))
            List<Visiteur> ListeVisiteur = laConnexion.Visiteur.Where(x => x.identifiant == id).ToList();
            if(ListeVisiteur.Count == 0)
            {
                message = "erreur : utlisateur innexistant ou mot de passe incorrect";
                connexionValide = false;
            }
            else
            {
                if(ListeVisiteur.Count > 1)
                {
                    message = "erreur base de donnée, contactez votre admin";
                    connexionValide = false;
                }
                else
                {
                    utilisateurConnecte = ListeVisiteur[0];
                    if(CorrectPassword(mp, false))
                    {
                        message = "connexion reussi";
                        connexionValide = true;
                    }
                    else
                    {
                        message = "erreur : utlisateur innexistant ou mot de passe incorrect";
                        connexionValide = false;
                    }
                }
                
            }

            return message;
        }

    }

}

