using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _23Sseplib1;
using _23seplib3;

namespace _23sep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelperLibrary helperLibrary = new HelperLibrary();

            List<Productclass> prd = new List<Productclass>();
            prd = helperLibrary.GetProducts();
            foreach (var item in prd)
            {
                Console.WriteLine(item.ProductId);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.Unitprice);
                Console.WriteLine("----------------------------");
            }
            Console.ReadLine();

        }
    }
}
-------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Sseplib1
{
    public class Productclass
    {
        private int _prodid;

        public int ProductId
        {
            get
            {
                return _prodid;
            }
            set
            {

                _prodid = value;
            }
        }

        private string _pname;

        public string ProductName
        {
            get { return _pname; }
            set
            {
                if ((value.Length > 40) || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid ProductName.... Please check");
                }
                else
                {
                    _pname = value;
                }

            }
        }


        private float _unitprice;

        public float Unitprice
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }

        
    }
}
------------------------------------------------------------------------------


using _23Sseplib1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _23seplib2
{
    public class Dac
    {
        public List<Productclass> ShowProductDetails()
        {
            string connectionString = @"Data Source=DESKTOP-DAUUJB2\SQLEXPRESS;Initial Catalog=Northwind;" +
                "Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);
           

            SqlCommand cmd = new SqlCommand("select * from Products", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
         
            List<Productclass> Productlist = new List<Productclass>();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    Productclass P = new Productclass();
                    P.ProductId =(int)dr[0];
                    P.ProductName = dr[1].ToString();
                    P.Unitprice = (float) dr[5];

                    Productlist.Add(P);
                }
            }
            else
            {
                Console.WriteLine("No records found");
            }
            cn.Close();
            return Productlist;

        }
    }
}
-------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _23Sseplib1;
using _23seplib2;



namespace _23seplib3
{
    public class HelperLibrary
    {

        public List<Productclass> GetProducts()
        {
            Dac products = new Dac();
            List<Productclass> prodlist = new List<Productclass>();
            prodlist = products.ShowProductDetails();
            return prodlist;
        }
    }
}
