/*
 A GREEDY ALGORITHM is a way of solving a problem by making the best possible choice at each step.
 always choosing the next step that offers the most obvious and immediate benefit.

 Let's imagine you have a bunch of coins with different values: 10 rupees, 5 rupees, 2 rupees, and 1 rupee coins. 
 You want to buy a toy from a store of 16 Rupees, but you want to use as few coins as possible.
 
 So as per this algo 
 first u choose 10 rs coin => 16-10 = 6 
 now remaining 6 rs is less then 10 so we go for next big coin which is 5 whc is less then 6 so 16 - (10+5)=1
 now remaining 1 rs is less then 5 so we go for next big coin which is 2 but 2 is greater than 1 
 so we go for next coin which is 1  10+5+1 -16=0 so 
 we can use 3 coin(10,5,1) which is answer to this problem

*/

//When to use greedy
//when problem requeried minimum or maximum solution (optimization problem)from list of solutions with some constraint/limitation/restriction..
//

//Examples
//Q 1.Split n into maximum composite numbers Given n,
//print the maximum number of composite numbers that sum up to n. 
//First few composite numbers are 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20
//Input: 10  | Output: 2  | Explanation: 4 + 6 = 10

// Approch : main observation is to make n such that is composes of maximum no of 4’s
// and the remaining can be made up by 6 and 9.
// We won’t need composite numbers more than that, as the composite numbers above 9 can be made up of 4, 6, and 9.

using System;
 
class MaxCompNumber {
     
    // function to calculate the maximum number
    // of composite numbers adding upto n
    static int count(int n)
    {
         
        // 4 is the smallest composite number
        if (n < 4)
            return -1;
      
        // stores the remainder when n is divided
        // by 4
        int rem = n % 4;
      
        // if remainder is 0, then it is perfectly
        // divisible by 4.
        if (rem == 0)
            return n / 4;
      
        // if the remainder is 1
        if (rem == 1) {
      
            // If the number is less than 9, that
            // is 5, then it cannot be expressed as
            // 4 is the only composite number less
            // than 5
            if (n < 9)
                return -1;
      
            // If the number is greater than 8, and
            // has a remainder of 1, then express n
            // as n-9 a and it is perfectly divisible
            // by 4 and for 9, count 1.
            return (n - 9) / 4 + 1;
        }
      
          
        // When remainder is 2, just subtract 6 from n,
        // so that n is perfectly divisible by 4 and
        // count 1 for 6 which is subtracted.
        if (rem == 2)
            return (n - 6) / 4 + 1;
      
      
        // if the number is 7, 11 which cannot be
        // expressed as sum of any composite numbers
        if (rem == 3)
        {
            if (n < 15)
                return -1;
      
            // when the remainder is 3, then subtract
            // 15 from it and n becomes perfectly
            // divisible by 4 and we add 2 for 9 and 6,
            // which is getting subtracted to make n
            // perfectly divisible by 4.
            return (n - 15) / 4 + 2;
        }
         
        return 0;
    }
//---------------------------------------------------------------------
  
//Q2.Find minimum number of currency notes and values that sum to given amount
//supply of notes of values {500, 200, 100, 50, 20, 10, 5, 1}

public class CurrencyProblm{
 
    public static void countCurrency(int amount)
    {
        int[] notes = new int[]{500, 200, 100, 50, 20, 10, 5, 1 };
        int[] noteCounter = new int[8];
     
        // loop notes to get number of notes for each note start with big
        // as we need minimum notes
        for (int i = 0; i < 9; i++) {
            if (amount >= notes[i]) {
                noteCounter[i] = amount / notes[i];
                amount = amount % notes[i];
            }
        }
     
        // Print notes
        Console.WriteLine("Currency Count ->");
        for (int i = 0; i < 9; i++) {
            if (noteCounter[i] != 0) {
                Console.WriteLine(notes[i] + " : "
                    + noteCounter[i]);
            }
        }
    }
}
//Time Complexity: O(1)
//Auxiliary Space: O(1)
//--------------------------------------------------
//Q3 . Given an array of non-negative integers, the task is to find the minimum number of elements such that their 
// sum should be greater than the sum of the rest of the elements of the array.
// Input:  arr[] = [ 2 , 1 , 2 ]
// Output: 2
// Explanation: Smallest subset is {2 , 1}. 
// Sum of this subset is greater than the sum of all other elements left after removing subset {2 , 1} from the array

  
