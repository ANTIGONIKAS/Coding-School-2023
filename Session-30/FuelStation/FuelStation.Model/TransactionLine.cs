using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class TransactionLine
    {
        public TransactionLine(int quantity,decimal itemPrice,decimal netValue,decimal discountPercent,decimal discountValue,decimal totalValue) 
        {
           
            
            Quantity= quantity;
            ItemPrice= itemPrice;
            NetValue= netValue;
            DiscountPercent= discountPercent;
            DiscountValue= discountValue;
            TotalValue= totalValue;
         
                
        }

        public TransactionLine(int id, int quantity, decimal itemPrice, decimal netValue, decimal discountPercent, decimal discountValue, decimal totalValue, int transactionId, Transaction transaction, int itemId, Item item)
        {
            Id = id;
            Quantity = quantity;
            ItemPrice = itemPrice;
            NetValue = netValue;
            DiscountPercent = discountPercent;
            DiscountValue = discountValue;
            TotalValue = totalValue;
            TransactionId = transactionId;
            Transaction = transaction;
            ItemId = itemId;
            Item = item;
        }
        public TransactionLine(int quantity,decimal itemPrice,decimal discountPercent)
        {

            Quantity = quantity;
            ItemPrice = itemPrice;
            NetValue = quantity * itemPrice;
            DiscountPercent = discountPercent;
            DiscountPercent = discountPercent;
            DiscountValue = discountPercent / 100 * NetValue;
            DiscountPercent = discountPercent;
            TotalValue = NetValue - DiscountValue;
            NetValue = quantity * itemPrice;

        }   

        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal  DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        //relations
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; } = null!;

        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

    }
}
