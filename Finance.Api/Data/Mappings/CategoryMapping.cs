using Finance.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finance.Api.Data.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        private const string NVARCHAR = "NVARCHAR";
        private const string VARCHAR = "VARCHAR";
        private const int TITLE_MAX_LENGTH = 80;
        private const int DESCRIPTION_MAX_LENGTH = 255;
        private const int USERID_MAX_LENGTH = 160;

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .ToTable("Category")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Title)
                .IsRequired()
                .HasColumnType(NVARCHAR)
                .HasMaxLength(TITLE_MAX_LENGTH);

            builder
                .Property(x => x.Description)
                .HasColumnType(NVARCHAR)
                .HasMaxLength(DESCRIPTION_MAX_LENGTH);

            builder
                .Property(x => x.UserId)
                .IsRequired()
                .HasColumnType(VARCHAR)
                .HasMaxLength(USERID_MAX_LENGTH);
        }
    }
}
