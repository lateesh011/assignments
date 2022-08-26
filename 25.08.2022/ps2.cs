using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _25_Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C#\desktop\25\";
            Console.WriteLine("Enter file Name");
            string filename=Console.ReadLine();
            string fname = string.Concat(path, filename);

            //File.Create(fname);
            //Console.WriteLine("File Created Successfully");

            //File.Copy(fname, @"D:\C#\25\25 Problem 2\copyonsamefolder.txt");
            //Console.WriteLine("File Copied in the Same Folder Successfully");

            //File.Copy(fname, "copiedfile.txt");
            //Console.WriteLine("File Copied  In Diffrent Folder Successfully");

            //File.Move(fname, "Movedfile.txt");
            //Console.WriteLine("File Moved Successfully");

            //File.Delete(fname);
            //Console.WriteLine("File Deleted Successfully");

            FileInfo fileinfo = new FileInfo(fname);
            Console.WriteLine( "Extension" + fileinfo.Extension);
            Console.WriteLine("Creationtime of the file" + fileinfo.CreationTime);
            Console.WriteLine("Directory of the file" + fileinfo.Directory);




            Console.ReadLine(); 
        }
    }
}
