using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Item
{
    private double shippingWeight;
    private string description;
    public Item() 
    {
        this.shippingWeight = 0.0;
        this.description = null;
    } 
    public Item(double shippingWeight, string description)
    {
        this.shippingWeight = shippingWeight;
        this.description = description;
    }
    public double ShippingWeight
    {
        get { return shippingWeight; }
        set { shippingWeight = value; }
    }

    public string  Description
    {
        get { return description; }
        set { description = value; }
    }
    public double GetPriceForQuantity()
    {
        return 0.0;
    }

    public double GetTax()
    {
        return 0.0;
    }

    public bool InStock()
    {
        return true;
    }
    public string tostring()
    {
        return $"shippingWeight  {shippingWeight} " + $"description {description}";
    }
}

public class OrderDetail
{
    private int quantity;
    private string taxStatus;
    public OrderDetail() 
    {
        this.quantity = 0;
        this.taxStatus = null;
    } 
    public OrderDetail(int quantity, string taxStatus)
    {
        this.quantity = quantity;
        this.taxStatus = taxStatus;
    }
    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public string TaxStatus
    {
        get { return taxStatus; }
        set { taxStatus = value; }
    }
    public double CalcSubTotal()
    {
        return 0.0;
    }

    public double CalcWeight()
    {
        return 0.0;
    }

    public double CalcTax()
    {
        return 0.0;
    }
    public string tostring()
    {
        return $"quantity  {quantity} " + $"taxStatus {taxStatus}";
    }
}

public class Order
{
    private DateTime date;
    private string status;
    private OrderDetail orderD;
    private OrderDetail order = new OrderDetail() ;// (aggregation)
    public Order() 
    {
        this.date = null;
        this.status = null;
        this.orderD = null;



    } 
    public Order(DateTime date, string status, OrderDetail oorderD, List<orderD> orderDetails)
    {
        this.date = date;
        this.status = status;
        this.orderD = oorderD;
        this.orderD = orderDetails;
    }
    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public string Status
    {
        get { return status; }
        set { status = value; }
    }



    public double CalcSubTotal()
    {
        return 0.0;
    }

    public double CalcTax()
    {
        return 0.0;
    }

    public double CalcTotal()
    {
        return 0.0;
    }

    public double CalcTotalWeight()
    {
        return 0.0;
    }
    public string tostring()
    {
        return $"date  {date} " + $"status {status}" + $"orderD {orderD}" + $"orderDetails {orderDetails}";
    }
}

public class Customer
{
    private string name;
    private string address;
    public Customer() 
    {
        this.name = null;
        this.address = null;
    } 
    public Customer(string name, string address)
    {
        this.name = name;
        this.address = address;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string tostring()
    {
        return $"name  {name} " + $"address {address}";
    }
}

public class Payment
{
    private float amount;
    public Payment() //parent (superclass)
    {
        this.amount = 0.0;
    } 
    public Payment(float amount)
    {
        this.amount = amount;
    }
    public float Amount
    {
        get { return amount; }
        set { amount = value; }
    }

    public string tostring()
    {
        return $"amount  {amount} ";
    }
}

public class Cash : Payment //cash( child ,subclass)(inhert)
{
    private float cashTendered;
    public Cash() 
    {
        this.cashTendered = 0.0;
    }
    public Cash(float amount, float cashTendered) : base(amount)
    {
        this.cashTendered = cashTendered;
    }
    public string tostring()
    {
        return $"cashTendered  {cashTendered} ";
    }
}

public class Check : Payment // check ( child,subclass)(inhert)
{
    private string name;
    private string bankID;
    public Check() 
    {
        this.name = null;
        this.bankID = null;
    }
    public Check(float amount, string name, string bankID) : base(amount)
    {
        this.name = name;
        this.bankID = bankID;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string BankID
    {
        get { return bankID; }
        set { bankID = value; }
    }

    public string tostring()
    {
        return $"name{name}" + $"bankID  {bankID}";
    }
    public bool Authorized()
    {
        return true;
    }
}

public class Credit : Payment //Credit (child,subclass)(inhert)
{
    private string name;
    private string type;
    private DateTime expDate;
    public Credit() 
    {
        this.name = null;
        this.type = null;

        this.expDate = null;
    }
    public Credit(float amount, string name, string type, DateTime expDate) : base(amount)
    {
        this.name = name;
        this.type = type;
        this.expDate = expDate;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Type
    {
        get { return type; }
        set { type = value; }
    }
    public DateTime ExpDate
    {
        get { return expDate; }
        set { expDate = value; }
    }
    public string tostring()
    {
        return $"name{name}" + $"type  {type}" + $"expDate{expDate}";
    }
    public bool Authorized()
    {
        return true;
    }
}


public class System
{
    public static void Main(string[] args)
    {
        Item item = new Item();// object constructer defualt to class Item
        OrderDetail orderD = new OrderDetail(); // object constructer defualt to class OrderDetail
        Order order = new Order(); // object constructer defualt to class Order
        Payment payment = new Payment();// object constructer defualt to class Payment(parent)
        Cash cash = new Cash();// object constructer defualt to class cash (child)
        Credit credit = new Credit(); // object constructer defualt to class Credit (child)
        Check check = new Check();// object constructer defualt to class Check (child)
    }
}

