using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    abstract class Product
    {
        private int id;
        private string name;
        private double price;
        private string producer;

        public Product(int id, string name, double price, string producer)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }

        }
        public double Id
        {
            get { return this.id; }
        }
     
        public abstract double ComputeTax();

    }
}
