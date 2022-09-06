using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _5seplibrary
{
    public class Book
    {
		private int _bookid;

		public int BookId
		{
			get { return _bookid; }
			set { _bookid = value; }
		}

		private string _bookname;

		public string BookName
        {
			get { return _bookname; }
			set { _bookname = value; }
		}

		private float _bookprice;

		public float BookPrice
        {
			get { return _bookprice; }
			set { _bookprice = value; }
		}

		private string _bookauthor;

		public string BookAuthor
        {
			get { return _bookauthor; }
			set { _bookauthor = value; }
		}

		private int _numberofpages;

		public int NumberofPages
        {
			get { return _numberofpages; }
			set { _numberofpages = value; }
		}

		public Book()
		{

		}

		public Book(int bookid, string bookname, float bookprice, string bookauthor)
		{
			this.BookId = bookid;
		    this.BookName = bookname;
			this.BookPrice = bookprice;
            this.BookAuthor = bookauthor;
		}
		public void InsertBook(int bookid, string bookname, float bookprice)
		{
            this.BookId = bookid;
            this.BookName = bookname;
            this.BookPrice = bookprice;

        }

        public void InsertBook(int bookid, string bookname, float bookprice, string bookauthor)
        {
            this.BookId = bookid;
            this.BookName = bookname;
            this.BookPrice = bookprice;
			this.BookAuthor = bookauthor;

        }

        public void InsertBook(int bookid, string bookname)
        {
            this.BookId = bookid;
            this.BookName = bookname;
           
        }

		
    }

	public class BookCategory
	{
		private int _bcatid;

		public int BCatId
		{
			get { return _bcatid; }
			set { _bcatid = value; }
		}

		private string _bcatname;

		public string BcatName
        {
			get { return _bcatname; }
			set { _bcatname = value; }
		}
		private string _bcatdescription;

		public string BcatDescription
        {
			get { return _bcatdescription; }
			set { _bcatdescription = value; }
		}
		public BookCategory()
		{

		}

		public BookCategory(int bcatid,string bcatname, string bcatdescription)
		{
			this.BCatId= bcatid;	
			this.BcatName= bcatname;
			this.BcatDescription= bcatdescription;	

		}
	}
	public class Novels : Book
	{
		public  void InsertBook(int bookid, string  bookname, float bookprice, int numberofpages)
		{
			this.BookId= bookid;
			this.BookName = bookname;
			this.BookPrice= bookprice;	
			this.NumberofPages = numberofpages;

		} 
	}

	public class Cart:Book
	{
		private int _customerid;

		public int CustomerId
        {
			get { return _customerid; }
			set { _customerid = value; }
		}

		private string _bookingid;

		public string BookingId
        {
			get { return _bookingid; }
			set { _bookingid = value; }
		}
        private List<Cart> _booklist;

        public List<Cart> ListofCart
        {
            get { return _booklist; }
            set { _booklist = value; }
        }



        public  void Addbook(int customerid, string bookingid,string bookname, float bookprice )
		{
			this.CustomerId = customerid;
			this.BookingId = bookingid;
			this.BookName = bookname;	
			this.BookPrice = bookprice;	

		}
        static int bookcount = 0;
        public void Addcount()
        {
            bookcount += 1;
            Console.WriteLine("---------You added {0} Book----------- ", bookcount);
		}

        public  void DisplayDetails()
        {
            Console.WriteLine("-----------Books in the Cart------------");
            Console.WriteLine("Book Details : ");
			Console.WriteLine("------------");
            foreach (var item in ListofCart)
            {
				Console.WriteLine("CustomerId :" + item.CustomerId);
				Console.WriteLine("Booking Id :" + item.BookingId);
				Console.WriteLine("Book Name :" + item.BookName);
				Console.WriteLine("Book Price :"+ item.BookPrice);
				Addcount();
				Console.WriteLine("-------------------------------------");
            }

        }
    }
}


using _5seplibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5sep_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCategory c1 = new BookCategory();
            c1.BCatId = 1;
            c1.BcatName = "Programming";
            c1.BcatDescription = "Books to read,write and to obtain knowledge of Programming";
            Book b1 = new Book();
            b1.InsertBook(10, "C#", 500.00f, "John");
            Book b2 = new Book();
            b2.InsertBook(11, "Python", 600.00f, "Max");
            BookCategory c2 = new BookCategory();
            c2.BCatId = 2;
            c2.BcatName = "Novels";
            c2.BcatDescription = "Stories";
            Novels n1 = new Novels();
            n1.InsertBook(15, "Art of Life", 650.56f, 1230);
            Novels n2 = new Novels();
            n2.InsertBook(18, "Lion", 821.02f, 689);
            Cart cart1 = new Cart();
            cart1.Addbook(20, "Jason", "Lion", 821.02f);
            Cart cart2 = new Cart();
            cart2.Addbook(21, "Smith", "C#", 500.00f);

            List<Cart> Booklist = new List<Cart>();
            Booklist.Add(cart1);
            Booklist.Add(cart2);
            cart1.ListofCart= Booklist; 
            cart1.DisplayDetails();
            Console.ReadLine();
            
        }
    }
}
