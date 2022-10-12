using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLibrary;

namespace class29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.Bookstable.Add(new Book { Bookno = 1, BookName = "The Great King", Author = "Loki" });
            context.Bookstable.Add(new Book { Bookno = 2, BookName = "The New Beginning", Author = "Thor" });
            context.SaveChanges();
            MyContext context2 = new MyContext();   
            context2.Memberstable.Add(new Member { MemberID =1, MemberName = "Selva", AccOpenDate = DateTime.Now});
            context2.Memberstable.Add(new Member { MemberID = 2, MemberName = "Bharathi", AccOpenDate = DateTime.Now });
            context2.SaveChanges();
            Console.WriteLine("Done");
            Console.ReadLine();
            
        }
    }
}
-----------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLibrary
{
    public class Book
    {
        [Key]
        [Required]
        public int Bookno { get; set; }

        [MaxLength(40, ErrorMessage = "Not allowed above 20 chars")]
        [MinLength(5, ErrorMessage = "Not allowed below 2 chars")]
        public string BookName { get; set; }

        public string Author { get; set; }


    }

    public class Member
    {
        [Key, Required]
        public int MemberID { get; set; }

        [MaxLength(20, ErrorMessage = "Not allowed above 20 chars")]
        [MinLength(5, ErrorMessage = "Not allowed below 2 chars")]
        public string MemberName { get; set; }

        public DateTime AccOpenDate { get; set; }


        public virtual ICollection<Book> Books { get; set; }
    }


    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
            //createdatabase if not exists
            //drop create always
            //drop create if model changes

            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }
        public virtual DbSet<Book> Bookstable { get; set; }
        public virtual DbSet<Member> Memberstable { get; set; }
    }

    
}
