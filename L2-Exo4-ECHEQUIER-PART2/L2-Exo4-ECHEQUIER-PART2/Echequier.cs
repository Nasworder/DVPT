using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Exo4_ECHEQUIER_PART2
{
    internal class Echequier
    {
        // enum chess white and black pieces in french
        public enum Pieces
        {
            Vide,
            PionBlanc,
            CavalierBlanc,
            FouBlanc,
            TourBlanche,
            DameBlanche,
            RoiBlanc,
            PionNoir,
            CavalierNoir,
            FouNoir,
            TourNoire,
            DameNoire,
            RoiNoir
        }


        public Pieces[,] echequier { private set; get; } = new Pieces[8, 8];


        public Echequier()
        {
            InitEchequier();
        }


        // Fill echequier with pieces
        private void InitEchequier()
        {
            // Fill echequier with pieces
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    echequier[i, j] = Pieces.Vide;
                }
            }

            // Fill echequier with white pieces
            for (int i = 0; i < 8; i++)
            {
                echequier[1, i] = Pieces.PionBlanc;
            }
            echequier[0, 0] = Pieces.TourBlanche;
            echequier[0, 1] = Pieces.CavalierBlanc;
            echequier[0, 2] = Pieces.FouBlanc;
            echequier[0, 3] = Pieces.DameBlanche;
            echequier[0, 4] = Pieces.RoiBlanc;
            echequier[0, 5] = Pieces.FouBlanc;
            echequier[0, 6] = Pieces.CavalierBlanc;
            echequier[0, 7] = Pieces.TourBlanche;

            // Fill echequier with black pieces
            for (int i = 0; i < 8; i++)
            {
                echequier[6, i] = Pieces.PionNoir;
            }
            echequier[7, 0] = Pieces.TourNoire;
            echequier[7, 1] = Pieces.CavalierNoir;
            echequier[7, 2] = Pieces.FouNoir;
            echequier[7, 3] = Pieces.DameNoire;
            echequier[7, 4] = Pieces.RoiNoir;
            echequier[7, 5] = Pieces.FouNoir;
            echequier[7, 6] = Pieces.CavalierNoir;
            echequier[7, 7] = Pieces.TourNoire;



        }
    }
}
