using PROG8051_Week_10_Sec_1_Lec_1.Car;
using PROG8051_Week_10_Sec_1_Lec_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{




    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\namiq\Desktop\test\sec3";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                // Delete the directory.
              
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }


            string newpath = @"C:\Users\namiq\Desktop\test\sec3\MyTest.txt";

            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(newpath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

               
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



            // Bulldog dog = new Bulldog();

            // object of a child class
            Lexus lexus = new Lexus();
            Console.WriteLine(lexus.model);
            lexus.Honk();

            Tesla modely = new Tesla();
            modely.Honk();
        }
    }
}