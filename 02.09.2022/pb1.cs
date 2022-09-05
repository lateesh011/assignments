using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using catprodlibrary;

namespace _2_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category c = new Category();
            c.AddCategory(1, "Beverage", "Soft Drink");
            

            Products p1 = new Products();
            p1.AddProduct(10, "Coke", "2 Litres", 40, "Litres", "100 Litres", 100);
            
            Products p2 = new Products();
            p2.AddProduct(11, "Pepsi", "5 Litres", 40, "Litres", "100 Litres", 200);
           
            List<Products> prodlist = new List<Products>();
            prodlist.Add(p1);
            prodlist.Add(p2);
            c.ListofCat = prodlist;


            c.DisplayDetails();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catprodlibrary
{
	public class Category
	{
		private int _catid;

		public int CategoryId
		{
			get { return _catid; }
			set { _catid = value; }
		}

		private string _catname;

		public string CategoryName
		{
			get { return _catname; }
			set { _catname = value; }
		}

		private string _catdescription;

		public string Catdescription
		{
			get { return _catdescription; }
			set { _catdescription = value; }
		}


		private List<Products> _productlist;

		public List<Products> ListofCat
		{
			get { return _productlist; }
			set { _productlist = value; }
		}

		static int prodcount = 0;
		public void Addcount()
		{
			prodcount += 1;
			Console.WriteLine("You added {0} Product ", prodcount);
			Console.WriteLine("--------------------------------");
		}

		public void AddCategory(int cid, string cname, string cdescription)
		{
			_catid = cid;
			_catname = cname;
			_catdescription = cdescription;
		}

		public void DisplayDetails()
		{
			Console.WriteLine("----------Category Details------------");
			Console.WriteLine("Category Id  :" + CategoryId);
			Console.WriteLine("Category Name  :" + CategoryName);
			Console.WriteLine("Category Description  :" + Catdescription);
			Console.WriteLine("-----------Product Details------------");


			foreach (var item in ListofCat)
			{
				Console.WriteLine("Product Id :" + item.Prodid);
				Console.WriteLine("Product Name :" + item.Prodname);
				Console.WriteLine("Sold :" + item.Qtysold);
				Console.WriteLine("Price :" + item.Unitprice);
				Console.WriteLine("Product Measurement :" + item.Unitofmeasurment);
				Console.WriteLine("Product In Hand :" + item.Qtyinhand);
				Console.WriteLine("Reorder Level :" + item.Reorderlevel);
				Console.WriteLine("--------------------------");
				Addcount();

			}


		}

	}
	public class Products
	{
		private int _prodid;

		public int Prodid
		{
			get { return _prodid; }
			set { _prodid = value; }
		}

		private string _prodname;

		public string Prodname
		{
			get { return _prodname; }
			set { _prodname = value; }
		}

		private string _qtysold;

		public string Qtysold
		{
			get { return _qtysold; }
			set { _qtysold = value; }
		}

		private int _unitprice;

		public int Unitprice
		{
			get { return _unitprice; }
			set { _unitprice = value; }
		}
		private string _unitofmeasurment;

		public string Unitofmeasurment
		{
			get { return _unitofmeasurment; }
			set { _unitofmeasurment = value; }
		}

		private string _qtyinhand;

		public string Qtyinhand
		{
			get { return _qtyinhand; }
			set { _qtyinhand = value; }
		}

		private int _reorderlevel;

		public int Reorderlevel
		{
			get { return _reorderlevel; }
			set { _reorderlevel = value; }
		}

		public void AddProduct(int pid, string pname, string qsold, int uprice, string umeasurement, string qhand, int rlevel)
		{
			 _prodid = pid;
            _prodname = pname;
            _qtysold = qsold;
            _unitprice = uprice;
            _unitofmeasurment = umeasurement;
            _qtyinhand = qhand;
            _reorderlevel = rlevel;

		}
	}
}
