//Arrays
//

//[1]
//Array Reverse Best approche 
//Using Two Pointers - O(n) Time and O(1) Space
using System;

class ArrayOpration {
  
    static void reverseArray(int[] arr) 
    {
        // Initialize left to the beginning and right to the end
        int left = 0, right = arr.Length - 1;

        // Iterate till left is less than right
        while (left < right) {
            // Swap the elements at left and right position
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++; // Increment left pointer
            right--; // Decrement the right pointer
        }
    }
}

//---------------------------------------------------------------//
//[2]
//Rotate an Array by d - Counterclockwise or Left
//Using Reversal Algorithm - O(n) Time and O(1) Space

void Reverse(int[] arr, int start, int end)
{
    while (start < end)
    {
        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        start++;
        end--;
    }
}

void LeftRotate(int[] arr, int d)
{
    int n = arr.Length;
    d = d % n; // in case d > n

    Reverse(arr, 0, d - 1);
    Reverse(arr, d, n - 1);
    Reverse(arr, 0, n - 1);
}
