using ApiWithAjax.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace ApiWithAjax.Data.Mapping
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> tb)
        {
            tb.HasKey(o => o.Id); 
            tb.Property(o => o.FullName).HasMaxLength(250);
            tb.Property(o => o.UserName).HasMaxLength(250);
            tb.Property(o => o.Password).HasMaxLength(250); 
 
        }
    }
}
