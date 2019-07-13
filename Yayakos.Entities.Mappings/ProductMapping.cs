using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yayakos.Entities.Mappings
{
    public class ProductMapping:EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
           // HasKey(p => p.ID);

            Property(p => p.ProductName).HasMaxLength(20).IsUnicode(false);

            HasRequired(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryID).WillCascadeOnDelete(false);
        }
    }
}
