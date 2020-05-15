﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Data.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImge>
    {
        public void Configure(EntityTypeBuilder<ProductImge> builder)
        {
            builder.ToTable("ProductImages");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ImagePath).HasMaxLength(200).IsRequired();

            builder.Property(x => x.Caption).HasMaxLength(200);

            builder.HasOne(x => x.Product).WithMany(x => x.ProductImges).HasForeignKey(x => x.ProductId);

        }
    }
}