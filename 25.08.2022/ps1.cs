using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _25_Prob1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter The Filename");
                string s = Console.ReadLine();
                Console.WriteLine("Menu \n Press 1 To Create The File \n Press 2 To Edit The File \n" +
                    " Press 3 To Read The File \n Press 4 To Append The File \n Press 5 To Truncate The File ");
                Console.WriteLine("Enter the Number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num < 6)
                {
                    switch (num)
                    {

                        case 1:
                            File.Create(s);
                            Console.WriteLine("File Created Successfully");
                            break;
                        case 2:
                            FileStream fw = new FileStream(s, FileMode.Open, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fw);
                            sw.Write("This Content is edited from the Program");
                            Console.WriteLine("File Edited Successfully");
                            fw.Flush();
                            sw.Flush();
                            sw.Close();
                            sw.Dispose();
                            fw.Close();
                            fw.Dispose();
                            break;
                        case 3:
                            FileStream fs = new FileStream(s, FileMode.Open, FileAccess.Read);
                            StreamReader sr = new StreamReader(fs);
                            string contents = sr.ReadToEnd();
                            Console.WriteLine(contents);

                            sr.Close();
                            sr.Dispose();
                            fs.Close();
                            fs.Dispose();
                            break;
                        case 4:
                            FileStream fa = new FileStream(s, FileMode.Append, FileAccess.Write);
                            Console.WriteLine("Appended Successfully");
                            fa.Close();
                            fa.Dispose();
                            break;
                        case 5:
                            FileStream ft = new FileStream(s, FileMode.Truncate, FileAccess.Write);
                            Console.WriteLine("Truncated Successfully");
                            ft.Close();
                            ft.Dispose();

                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Enter The valid Number");
                }

            } while (true);
            Console.ReadLine();
           
            }
            
        }
    }
