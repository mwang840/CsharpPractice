using System;

namespace Kata{
    public static int SquareDigits(int n){
        int Squared = 0;
        int digitPlace = 0;
        while(n > 0){
            int grab = n % 10;
            int sq = grab * grab;
            
            Squared+= (int)Math.Pow(10, digitPlace) * sq;
            digitPlace += sq > 10 ? 2:1;

            n/= 10;
        }
        return Squared;
    }
}