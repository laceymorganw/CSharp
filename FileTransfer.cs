using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace csharp_console
{
    class Program

    {
        public static DateTime Seconds
        {
            get { return Seconds; }
           
            set
            {
                int seconds = 86400; 
                DateTime i = new DateTime(System.DateTime.Now.Second);
                DateTime timePast = new DateTime(DateTime.Now.Subtract.seconds);
                int result = DateTime.Compare(i, timePast);

                

        }
        }

        static void Main(string[] args)
        {
            string fileName = ".txt";
            string sourcePath = @"C:\Users\new\Desktop\folderA";
            string targetPath = @"C:\Users\new\Desktop\folderB";

            
            

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);


            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }




            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);
                

                foreach (string s in files)
                {
                    DateTime dt = File.GetLastWriteTime(sourceFile);
                    

                    if (dt < Seconds || dt == Seconds)
                    {
                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(targetPath, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }

                    

                    
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
        
    }
    
}
