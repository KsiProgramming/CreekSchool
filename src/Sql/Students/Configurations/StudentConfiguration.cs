namespace CreekSchool.Students.Sql
{
    public class StudentConfiguration : IEntityTypeConfiguration<StudentModel>
    {
        public void Configure(EntityTypeBuilder<StudentModel> builder)
        {
            builder.ToTable("Student");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("INT")
                .IsRequired()
                .UseIdentityColumn();

            builder.Property(e => e.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();

            builder.Property(e => e.LastName)
                .HasColumnName("LastName")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();

            builder.Property(e => e.SexId)
                .HasColumnName("SexId")
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(e => e.SexId)
                .HasColumnName("SexId")
                .HasColumnType("INT")
                .IsRequired();

            builder.HasOne(e => e.Sex)
                .WithMany()
                .HasForeignKey(e => e.SexId);
        }
    }
}






