﻿using System;
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

    }

   /* public static list<FraisForfait> listeForfait() 
    {
        return laConnexion.FraisForfait.ToList();
    }*/

}

