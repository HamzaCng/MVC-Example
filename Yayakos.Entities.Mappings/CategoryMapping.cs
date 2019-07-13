using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yayakos.Entities.Mappings
{
    public class CategoryMapping:EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            HasMany(c => c.Products).WithRequired(p => p.Category).HasForeignKey(p => p.CategoryID).WillCascadeOnDelete(false);
        }
    }
}
