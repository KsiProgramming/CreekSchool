﻿//-----------------------------------------------------------------------
// <copyright file="SexConfiguration.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Sql
{
    public class SexConfiguration : IEntityTypeConfiguration<SexModel>
    {
        public void Configure(EntityTypeBuilder<SexModel> builder)
        {
            builder.ToTable("Sex");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("INT")
                .IsRequired()
                .UseIdentityColumn();

            builder.Property(e => e.Label)
                .HasColumnName("Label")
                .HasColumnType("VARCHAR(50)")
                .IsRequired();
        }
    }
}
