﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitecture.DomainLayer.Entities;

namespace OnionArchitecture.DomainLayer.EntityMapper
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("pk_customerid");

            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("id")
                   .HasColumnType("INT");

            builder.Property(x => x.AmountPaid)
                .HasColumnName("purchased_product")
                   .HasColumnType("DECIMAL(18,2)")
                   .IsRequired();

            builder.Property(x => x.CreatedDate)
              .HasColumnName("created_date")
                 .HasColumnType("datetime");

            builder.Property(x => x.ModifiedDate)
              .HasColumnName("modified_date")
                 .HasColumnType("datetime");

            builder.Property(x => x.IsActive)
              .HasColumnName("is_active")
                 .HasColumnType("bit");
        }
    }
}
