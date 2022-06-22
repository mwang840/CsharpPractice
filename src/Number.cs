using System;

namespace Number{
    public class Number{
        
        public int DigitalRoot(long n){
           while(n >= 10){
            n = singleNum(n);
           }
           return (int)n;
        }
        public int singleNum(long n){
           if(n <= 9){
            return (int)n;
           }
           else{
            return singleNum(n/10) + (int)(n % 10);
           }
        }

        static void Main(string[] args){
            Number n = new Number();
            Console.WriteLine(n.DigitalRoot(493193));
        }
    }
}