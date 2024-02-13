using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        string nom;
        int pointsDevie;
        int pointsDePuissance; // pour proteger nos attributs on fait clic droit ation rapide et refra.... puis encapsuler les champs et utiliser sa proprieté

        public string Nom { get => nom; set => nom = value; }
        public int PointsDevie
        {
            get => pointsDevie;

            set
            {
                if (value < 0)
                {
                    pointsDevie = 0;
                }
             
                else
                {
                    pointsDevie = value;
                }
            }
        }


        public int PointsDePuissance { get => pointsDePuissance; set => pointsDePuissance = value; }
            
                public bool EstEnVie
        {
            get
            {
                if (pointsDevie > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
