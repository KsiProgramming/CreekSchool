namespace CreekSchool.Sql.Configurations
{
    internal static class DataModelConfigurationModule
    {
        public static void ApplyDataModulesConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SexConfiguration());
            modelBuilder.ApplyConfiguration(new ClassRoomConfiguration());
        }
    }
}
