using System;

namespace Kata{
    public static int SquareDigits(int n){
        int Squared = 0;
        string toSquare = ToString(n);
        for(int i = 0; i < toSquare.Length; ++i){
            Squared += ToInt32(POW(toSquare[i], 2));
        }
        return Squared;
    }
}