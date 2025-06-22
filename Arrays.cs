//Arrays
//

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
