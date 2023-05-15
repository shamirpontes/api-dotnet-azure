namespace Manager.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Confifure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable()
        }
    }
}