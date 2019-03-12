using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsWithBlackHair = new List<string>() { "Nathan", "Austin", "Marty McFly" };

            // Dictionary
            var studentByHairColor = new Dictionary<string, List<string>> // Key Value pair (TKey, TValue).  Key can only be listed once
            {
                {"Black", studentsWithBlackHair }
            }; 

            studentByHairColor.Add("Bald", new List<string> { "Martin" });

            var theBlackHairedStudents = studentByHairColor["Black"];

            if (theBlackHairedStudents == studentsWithBlackHair)
            {
                Console.WriteLine("They are the same");
            }

            // Looping on a Dictionary returns a key value pair
            foreach (var (hairColor, students) in studentByHairColor) // Deconstruct the Key Value Pair
            {
                Console.WriteLine($"The following students have {hairColor} hair.");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
            Console.ReadLine();
        }
    }
}
