using Finance.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Finance.Api.Data.Mappings
{
    public class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        private const string NVARCHAR_100 = "NVARCHAR(100)";
        private const string SMALLINT = "SMALLINT";
        private const string MONEY = "MONEY";
        private const string VARCHAR_160 = "VARCHAR(160)";

        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder
                .ToTable("Transaction")
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Title)
                .IsRequired()
                .HasColumnType(NVARCHAR_100);

            builder
                .Property(t => t.Type)
                .IsRequired()
                .HasColumnType(SMALLINT);

            builder
                .Property(t => t.Amount)
                .IsRequired()
                .HasColumnType(MONEY);

            builder
                .Property(t => t.CreatedAt)
                .IsRequired();

            builder
                .Property(t => t.PaidOrReceivedAt)
                .IsRequired(false);

            builder
                .Property(t => t.UserId)
                .IsRequired()
                .HasColumnType(VARCHAR_160);
        }
    }
}
