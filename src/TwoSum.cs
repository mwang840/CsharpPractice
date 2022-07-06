using System;

public class Sums{

    public static int[] TwoSum(int []numbers, int target){
        int[] twoTargets = new int[2];
        for(int i = 0; i < numbers.Length; ++i){
            for(int j = i+1; j < numbers.Length; ++j){
                int consecutiveSum = numbers[i] + numbers[j];
                if(consecutiveSum == target){
                    return new int[2]{i,j};
                }
            }
        }
        return new int[0];
    }


    static void AMain(string[]args){
        Console.Write("Hello");
    }
}