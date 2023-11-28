﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GSB
{
    public static class ModeleM2
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

        public static List<MEDECIN> listeMedecin()
        {
            return laConnexion.MEDECIN.ToList();
        }

        public static List<RAPPORT> listeRapport()
        {
            return laConnexion.RAPPORT.ToList();
        }
        
        public static List<OFFRIR> listeOFFRIR()
        {
            return laConnexion .OFFRIR.ToList();
        }
        public static void chargeVisiteurConnect(string lid)
        {
            leVisiteurConnect = laConnexion.Visiteur.Where(x => x.idVisiteur == lid).ToList()[0];
        }

    }


}


