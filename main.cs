using System;

class Program {
    static void Main(string[] args) {
        int[] tab1 = {10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        int[] tab2 = {10, 11, 12, 13, 14, 15, 16, 17, 18, 20};
        int missingNumber = 0;
        
        for(int i = 0; i < tab1.Length; i++) {
            missingNumber ^= tab1[i];
        }
        for(int i = 0; i < tab2.Length; i++) {
            missingNumber ^= tab2[i];
        }

            Console.WriteLine("The contents of table tab1:");
        foreach (var item in tab1)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nThe contents of table tab2:");
        foreach (var item in tab2)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nThe missing number is: " + missingNumber);
    }
}



