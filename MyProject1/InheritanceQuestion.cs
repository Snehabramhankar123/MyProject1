using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Order
    {
        int ordered;   
        string orderdate;
        Customer cust;
        Item item;
        public Order()
        {

        }
        public Order(int ordered, string orderdate)

        {
            this.ordered = ordered;
            this.orderdate = orderdate;
        }

        public Order(int ordered, string orderdate, Customer cust, Item item)
        {
            this.ordered = ordered;
            this.orderdate = orderdate;
            this.Cust = cust;
            this.Item = item;
        }

        public  int Ordered
        {
            set { ordered = value; }
            get { return ordered; }
        }
        public string Orderdate
        {
            set { orderdate = value; }
            get { return orderdate; }
        }

        internal Customer Cust { get => cust; set => cust = value; }
        internal Item Item { get => item; set => item = value; }
    }
    class Customer
    {
        int  custid;
        string custname;
        Address addr;

        public Customer()
        {

        }
        public Customer(int custid ,string custname)
        {
            this.custid = custid;
            this.custname = custname;
        }

        public Customer(int custid, string custname, Address addr)
        {
            this.custid = custid;
            this.custname = custname;
            this.addr = addr;
        }

        public int Custid
        {
            set { custid = value; }
            get { return custid; }
        }
        public string Custname
        {  set { custname = value; }
            get { return custname;  }

        }
            
        public Address Addr
        {
            set { addr = value; }
            get { return addr; }
        }

    }
    class Address
    {
        string add1;
        string city;
        int pincode;
        public Address()
        {

        }
        
        public Address (string add1,string city, int pincode )
        {
            this.add1 = add1;
            this.city = city;
            this.pincode = pincode;
        }
        public  string Add1
        {
            set { add1 = value; }
            get { return add1; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public  int Pincode
        {
            set { pincode = value; }
            get { return pincode; }
        }
    }
    class Item
    {
        int itemid;
        string itemname;
        int price;
        public Item (int itemid ,string itemname, int price )
        {
            this.itemid = itemid;
            this.itemname = itemname;
            this.price = price;
        }
        public int Itemid
        {
            set { itemid = value; }
            get { return itemid; }
        }
        public string Itemname
        {
            set { itemname = value; }
            get { return itemname; }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        static void Main(string[] args)
        { 
            Order o1 = new Order();
            o1.Ordered = 101;
            o1.Orderdate = " 1/9/2022";
            o1. Cust.Custname = "Sneha";
            o1.Cust.Custid = 103;
            o1.Cust.Addr.City = "Pune";
            o1.Item.itemname = "Pen";

            Customer c1 = new Customer(1, "Sneha", new Address("B-203 ", "Pune", 4110187));
            Item i1 = new Item(1, "Pizza", 3000);
            Order o2 = new Order(102, "8/9/2022", c1,i1 );
         
         // Console.WriteLine("Order Id :"+o.Ordered+"\nOrder Date: "+o.Orderdate+ "\nCustmerId: "+o.Custid+"\nCustmer Name :"+ Custname);



        }
    }
         

}
