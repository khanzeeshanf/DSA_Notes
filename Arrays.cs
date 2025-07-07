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


//--------------------------------------------//
//[3]Print array after it is right rotated K times 
//Using Reversal Algorithm - O(n) Time and O(1) Space
static void RightRotate(int[] arr, int k)
    {
        int n = arr.Length;
        k %= n; // In case k > n
        Reverse(arr, 0, n - 1);
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, n - 1);
    }

// input
int[] arr = { 1, 2, 3, 4, 5 };
        int k = 2;

        RightRotate(arr, k);

//-----------------------------------------//


//SEARCHING
//Linear Search
using System;

class Program
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i; // Found at index i
        }
        return -1; // Not found
    }

    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int target = 30;

        int index = LinearSearch(arr, target);
        Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not found");
    }
}


//---------------------------------//
// if an array is a palindrome
using System;

class Program
{
    static bool IsPalindrome(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            if (arr[left] != arr[right])
                return false;
            left++;
            right--;
        }

        return true;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 1 };

        Console.WriteLine(IsPalindrome(arr) ? "Palindrome" : "Not Palindrome");
    }
}

//---------------------------------------------------------------------//
//Find the Largest element in an array//
 public static void Main(string[] args)
    {
        Console.WriteLine ("Q: Find the Largest element in an array");
        int[] arr = {2,5,1,7,0};//for this input output should be 7
        
        int largest = arr[0];
        
        for(int i=1 ; i<arr.Length-1 ; i++)
        {
            if(arr[i]>largest)
                largest=arr[i];
        }

        Console.WriteLine ($"Largest element in an array :{largest}");
        
        
    }


//---------------------------------------------------------------------//
//Check if an Array is Sorted
public static void Main(string[] args)
    {
        Console.WriteLine ("Q: Check if an Array is Sorted");
        int[] arr = {1,2,3,4,6,7,8,8};//return fasle
        string result= IsArraySorted(arr)? "Sorted": "Unsorted";
    
        Console.WriteLine ($"Array is {result}");
        
        
    }
    
    public static bool IsArraySorted(int[] arr)
    {
    
        for(int i=0 ; i<arr.Length-1 ; i++)
        {
            if(arr[i]>arr[i+1])
                return false;
        }

    return true;
    }

