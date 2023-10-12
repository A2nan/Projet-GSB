using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GSB
{
    public static class ModeleConnexion
    {
        private static NerdsUnitedEntities laConnexion;
        public static void init()
        {
            laConnexion = new NerdsUnitedEntities();
        }

    }

}

