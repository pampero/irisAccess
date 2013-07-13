using System.Data.Entity.ModelConfiguration;

namespace Model.Mappings
{
    public class BaseClassMap : EntityTypeConfiguration<AbstractUpdatableClass>
    {
        public BaseClassMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            this.Property(t => t.Created)
                .IsRequired();

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BaseClass");
            this.Property(t => t.ID).HasColumnName("ID");

            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.LastUpdated).HasColumnName("Updated");
            this.Property(t => t.LastUpdatedBy).HasColumnName("UpdatedBy");
        }
    }
}
