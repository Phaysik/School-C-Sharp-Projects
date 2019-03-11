using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt
{
    class receipt
    {
        private int receiptNum;
        private int customerNum;
        private string customerName;
        private string customerAddress;
        private int customerPhone;
        private string itemDesc;
        private int itemNum;
        private double unitPrice;
        private int quantPurchased;

        DateTime currentDay = DateTime.Now;

        //Constructors

        public receipt()
        {

        }

        public receipt(string address, double unPrice)
        {
            customerAddress = address;
            unitPrice = unPrice;
        }

        //Properties

        public int ReciptNum
        { get { return receiptNum; } set { receiptNum = value; } }

        public int CustomerNum
        {
            get { return customerNum; }
            set { customerNum = value; }
        }

        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public DateTime DateOfPurchase
        {
            get { return currentDay; }
        }

        public int CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }

        public string ItemDesc
        {
            get { return itemDesc; }
            set { itemDesc = value; }
        }

        public int ItemNum
        {
            get { return itemNum; }
            set { itemNum = value; }
        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public int QuantPurchased
        {
            get { return quantPurchased; }
            set { quantPurchased = value; }
        }

        public double Calc()
        {
            return (unitPrice * quantPurchased);
        }

        public override string ToString()
        {
            return $"{customerName}\nDate of Purchase: {DateOfPurchase}.\nRecipt Number: {receiptNum}.\nCustomer Number: {customerNum}.\nCustomer Address: {customerAddress}." + 
                      $"\nCustome Phone Number: {customerPhone.ToString().Substring(0,3) + "-" + customerPhone.ToString().Substring(3,3) + "-" + customerPhone.ToString().Substring(6)}." + 
                      $"\nItem Number: {itemNum}.\nItem Description: {itemDesc}.\nUnit Price: ${unitPrice}.\nQuantity Purchased: {quantPurchased}.\nThe total price of the purchase is: ${Calc()}.";
        }
    }
}
