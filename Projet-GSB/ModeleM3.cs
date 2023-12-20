using Projet_GSB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GSB
{
    public static class ModeleM3
    {
        private static NerdsUnitedEntities laConnexion;
        private static Visiteur leVisiteurConnect;
        //trigger si il y a plus de 40 km dans le mois dans c'est frais on réfus les frais 
        
        public static void init()
        {
            laConnexion = new NerdsUnitedEntities();
        }

        public static List<FraisForfait> listeFraisForfaits()
        {
            return laConnexion.FraisForfait.ToList();
        }

        public static List<Visiteur> listeVisiteurs() 
        {
            return laConnexion.Visiteur.ToList();
        }
        public static List<fichefrais> LesListeFraisDuVisiteurConnec()
        {
            return laConnexion.fichefrais.Where(x => x.idVisiteur==ModeleConnexion.UtilisateurConnecte.idVisiteur).ToList();
        }

        public static List<FraisForfait> LesFicheEngagesDuVisiteurConnec() 
        {
            return laConnexion.FraisForfait.Where(x => x.id == ModeleConnexion.UtilisateurConnecte.idVisiteur).ToList();
        }

        public static bool ModificationFiche(string mois, int nbJustificatifs, string montantValide, DateTime dateModif)
        {
            bool vretour = true;
            try
            {
               
                var ficheAModifier = ModeleM3.LesListeFraisDuVisiteurConnec()
                    .FirstOrDefault(fiche => fiche.idVisiteur == ModeleConnexion.UtilisateurConnecte.idVisiteur);

                if (ficheAModifier != null)
                {
                    
                    ficheAModifier.mois = mois;
                    ficheAModifier.nbJustificatifs = nbJustificatifs;
                    ficheAModifier.dateModif = dateModif;
                }
                else
                {
                    
                    vretour = false;
                }
            }
            catch (Exception ex)
            {
               
                vretour = false;
            }
            return vretour;
        }


        

    }






}


