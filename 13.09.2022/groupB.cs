using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _12_groupB
{
    class Program
    {
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Methods " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is StereoDiscAttribute)
                {
                    StereoDiscAttribute a = (StereoDiscAttribute)attr;
                    Console.WriteLine("Song Name :" + a.SongName);
                    Console.WriteLine("Lyrics :" + a.Lyrics);
                    Console.WriteLine("Language :" + a.Language);
                }
            }
            Console.WriteLine("---------------------------------");
            MemberInfo[] minfo = t.GetMembers();

            foreach (var item in minfo)
            {
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is StereoDiscAttribute)
                    {
                        StereoDiscAttribute a = (StereoDiscAttribute)attrItem;
                        System.Console.WriteLine(a.SongName);
                        Console.WriteLine(a.Lyrics);
                        Console.WriteLine(a.Language);
                    }
                }

            }


        }
        static void Main(string[] args)
        {

            Program.WritedataForEachCode(typeof(Song));
            Console.Read();
        }
    }
}
==========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_groupB
{
    [StereoDisc(Language ="Tamil",Lyrics ="Muthukumar",SongName ="Anandha Yaalai")]
    public class  Song
    {
        public string SongName { get; set; }
        public string Language { get; set; }
        public string Lyrics { get; set; }


        public void SongDetails(string songname, string language, string lyrics )
        {
            SongName = songname;
            Language = language;    
            Lyrics = lyrics;    
        }
    }
}
=============================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_groupB
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class StereoDiscAttribute : Attribute
    {
       
        public string SongName { get; set; }

        public string Language { get; set; }
        public string Lyrics { get; set; }
    }
}
