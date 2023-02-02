using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

//public Guid TransactionLineID { get; set; } //pk
//public int PetFoodQty { get; set; }
//public Guid PetFoodID { get; set; } //foreignkey
//public Guid SpecialOfferID { get; set; } //fk
//public decimal PetFoodPrice { get; set; }
//public decimal PetFoodCost { get; set; }
//public decimal PriceDiscount { get; set; }
//public decimal LineTotal { get; set; }


namespace Orm.Configurations
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLine");
            builder.HasKey(transactionLine => transactionLine.TransactionLineID);
            builder.Property(transactionLine => transactionLine.PetFoodQty).IsRequired();
            builder.Property(transactionLine => transactionLine.SpecialOfferID);
            builder.Property(transactionLine => transactionLine.PetFoodPrice);
            builder.Property(transactionLine => transactionLine.PetFoodCost);
            builder.Property(transactionLine => transactionLine.PriceDiscount);
            builder.Property(transactionLine => transactionLine.LineTotal);
         //   builder.Property(transactionLine => transactionLine.PetFoodID);
           

            //Relation OneToMany

            //list
            builder.HasOne(transactionLine => transactionLine.Transaction).WithMany(transaction => transaction.TransactionLines)
                .HasForeignKey(transactionLine => transactionLine.TransactionID);
           



        }
    }
}
