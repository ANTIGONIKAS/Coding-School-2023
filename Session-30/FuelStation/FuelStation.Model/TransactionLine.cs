using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class TransactionLine
    {
        public TransactionLine(int quantity,decimal itemPrice,decimal netValue,decimal discountPercent,decimal discountValue,decimal totalValue,Guid transactionId,Guid itemId) 
        {
           
            Id=Guid.NewGuid();
            Quantity= quantity;
            ItemPrice= itemPrice;
            NetValue= netValue;
            DiscountPercent= discountPercent;
            DiscountValue= discountValue;
            TotalValue= totalValue;
            TransactionId= transactionId;
            ItemId = itemId;
                
        }
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal  DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        //relations
        public Guid TransactionId { get; set; }
        public Transaction Transaction { get; set; } = null!;

        public Guid ItemId { get; set; }
        public Item Item { get; set; } = null!;

    }
}
