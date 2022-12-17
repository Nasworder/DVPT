namespace L2_Exo4_ECHEQUIER_PART1
{
    internal class Program
    {
        // enum chess white an black piece in french
        private enum Piece
        {
            Vide,
            PionBlanc,
            PionNoir,
            CavalierBlanc,
            CavalierNoir,
            FouBlanc,
            FouNoir,
            TourBlanche,
            TourNoire,
            DameBlanche,
            DameNoire,
            RoiBlanc,
            RoiNoir
        }



        private static void Main(string[] args)
        {
            // create a 2D array of chess piece
            Piece[,] echiquier = new Piece[8, 8];

            // fill the array with chess piece
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    echiquier[i, j] = Piece.Vide;
                }
            }

            // fill the array with chess piece
            for (int i = 0; i < 8; i++)
            {
                echiquier[1, i] = Piece.PionBlanc;
                echiquier[6, i] = Piece.PionNoir;
            }

            echiquier[0, 0] = Piece.TourBlanche;
            echiquier[0, 7] = Piece.TourBlanche;
            echiquier[7, 0] = Piece.TourNoire;
            echiquier[7, 7] = Piece.TourNoire;

            echiquier[0, 1] = Piece.CavalierBlanc;
            echiquier[0, 6] = Piece.CavalierBlanc;
            echiquier[7, 1] = Piece.CavalierNoir;
            echiquier[7, 6] = Piece.CavalierNoir;

            echiquier[0, 2] = Piece.FouBlanc;
            echiquier[0, 5] = Piece.FouBlanc;
            echiquier[7, 2] = Piece.FouNoir;
            echiquier[7, 5] = Piece.FouNoir;

            echiquier[0, 3] = Piece.DameBlanche;
            echiquier[7, 3] = Piece.DameNoire;

            echiquier[0, 4] = Piece.RoiBlanc;
            echiquier[7, 4] = Piece.RoiNoir;

            // display the array
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    // - 7 permet d'inverser l'affichage de l'echiquier -> permet de respecter l'image fournie
                    Console.Write(echiquier[7-i, j] + " ");
                }

                Console.WriteLine();



            }
        }


    }
}