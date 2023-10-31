using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Products<T>
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

        

        public void AddProduct<T>()
        {

        }

        public void UpdateProduct<T>()
        {

        }

        public void RemoveProduct<T>()
        {

        }

    }
}
