using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasLiemiePPE4
{
    public static class controleur
    {
        private static modele vModele;

        public static void init()
        {
            vModele = new modele();
        }

        public static modele getModele()
        {
            return vModele;
        }
    }
}
