using System;

namespace Number{
    public class Number{
        public int DigitalRoot(long n){
            if(n < 10){
                return (int)n;
            }
            else{
                return DigitalRoot((n % 10) + DigitalRoot((int)Math.Floor(n % 10)));
            }
        }
    }
}