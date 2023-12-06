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
            return laConnexion.fichefrais.Where(x => x.idVisiteur==leVisiteurConnect.idVisiteur).ToList();
        }

      
    }

    




}

