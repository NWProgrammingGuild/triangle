using System;
using System.IO;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
            
            for(int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            for(int i = 5; i > 0; i--)
            {
                Console.WriteLine(new string('*', i));
            }
            
            int n = int.Parse(args[0]);
            for(int i = n; i > 0; i--)
            {
                Console.WriteLine(new string('*', i));
            }

            foreach(string arg in args)
            {
                Console.WriteLine($"The triangle size is {arg}");
                int triangleSize = int.Parse(arg);
                for(int i = triangleSize; i > 0; i--)
                {
                    Console.WriteLine(new string('*', i));
                }
        
            }


            StreamWriter file = File.CreateText("Triangles.txt");

            foreach(string arg in args)
            {
                file.WriteLine($"The triangle size is {arg}");
                int triangleSize = int.Parse(arg);
                for(int i = triangleSize; i > 0; i--)
                {
                    file.WriteLine(new string('*', i));
                }
        
            }

            file.Close();

            using(StreamWriter usingFile = File.CreateText("TrianglesUsing.txt"))
            {
                foreach(string arg in args)
                {
                    usingFile.WriteLine($"The triangle size is {arg}");
                    int triangleSize = int.Parse(arg);
                    for(int i = triangleSize; i > 0; i--)
                    {
                        usingFile.WriteLine(new string('*', i));
                    }
                }
            }
        }
    }
}
