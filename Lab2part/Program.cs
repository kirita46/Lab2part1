using System;
using Lab2part;

class Program
{
    static void Main(string[] args)
    {
        
        var set1 = new Set<int>(new[] { 1, 2, 3 });
        var set2 = new Set<int>(new[] { 3, 4, 5 });

        
        set1 += 6;  
        var unionSet = set1 + set2;  
        var intersectSet = set1 * set2; 

        Console.WriteLine("Set1: " + set1);
        Console.WriteLine("Set2: " + set2);
        Console.WriteLine("Union: " + unionSet);
        Console.WriteLine("Intersection: " + intersectSet);

       
        int count = (int)set1; 
        Console.WriteLine("Set1 size: " + count);
        Console.WriteLine(set1 ? "Set1 size is in range [3, 10]" : "Set1 size is out of range [3, 10]");

       
        string sentence = "Hello world this is test";
        Console.WriteLine(sentence.AddCommas());

        var setWithDuplicates = new Set<int>(new[] { 1, 1, 2, 2, 3, 3 });
        Console.WriteLine("Original Set with Duplicates: " + setWithDuplicates);
        var setWithoutDuplicates = setWithDuplicates.RemoveDuplicates();
        Console.WriteLine("Set Without Duplicates: " + setWithoutDuplicates);
    }
}