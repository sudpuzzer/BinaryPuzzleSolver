using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzleSolver
{
    public class Pieces
    {
        //Create array which will identify the puzzle pieces
        //Side: 1 = left, 2 = top, 3 = right, 4 = bottom
        //For each side, described as follows:
        //1 = color1, half1
        //2 = color1, half2
        //3 = color2, half1
        //4 = color2, half2
        //5 = color3, half1
        //6 = color3, half2
        //7 = color4, half1
        //8 = color4, half2
        public Pieces(int size)
        {
            int numberOfPieces = size * size;
            int[,] pieces = new int[numberOfPieces, 4];
        }

    }
    public class Colors
    {
        //Defines the colors of the puzzle pieces
        //1 = White
        //2 = Black
        //3 = Grey
        //4 = Red
        //5 = Green
        //6 = Blue
        //7 = Yellow
        //8 = Orange
        //9 = Purple
        //10 = Indigo

        int color1;
        int color2;
        int color3;
        int color4;
    }
}
