//-----------------------------------------------------------------------
// <copyright file="ClassRoomConfiguration.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Sql.Configurations
{
    internal class ClassRoomConfiguration : IEntityTypeConfiguration<ClassroomModel>
    {
        public void Configure(EntityTypeBuilder<ClassroomModel> builder)
        {
            builder
                .ToTable("Classroom");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR(50)")
                .IsRequired();
        }
    }
}
