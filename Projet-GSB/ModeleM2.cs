using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GSB
{
    public static class ModeleM2
    {
        private static NerdsUnitedEntities laConnexion;
        private static Visiteur leVisiteurConnect;
        private static int action;
        private static RAPPORT RapportChoisi;
       
        
       
        public static RAPPORT RapportChoisi1 { get => RapportChoisi; set => RapportChoisi = value; }
        public static int Action { get => action; set => action = value; }

        public static void init()
        {
            laConnexion = new NerdsUnitedEntities();

         
        }

        public static RAPPORT recupRapport(int ID)
        {
            RAPPORT vretour;
            vretour = laConnexion.RAPPORT.Where(x => x.idRapport == ID).ToList()[0];
            return vretour;
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
            return laConnexion.OFFRIR.ToList();
        }

        public static List<MOTIF> listeMotif()
        {
            return laConnexion.MOTIF.ToList();
        }

        public static List<MEDICAMENT> listeMedicaments()
        {
            return laConnexion.MEDICAMENT.ToList();
        }

        public static List<OFFRIR> listeOffrir()
        {
            return laConnexion.OFFRIR.ToList();
        }
        public static void chargeVisiteurConnect(string lid)
        {
            leVisiteurConnect = laConnexion.Visiteur.Where(x => x.idVisiteur == lid).ToList()[0];
        }

    }


}


