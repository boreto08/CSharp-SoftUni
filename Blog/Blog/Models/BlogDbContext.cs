namespace Blog.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class BlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual IDbSet<Article> Articles { get; set; }

        public BlogDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static BlogDbContext Create()
        {
            return new BlogDbContext();
        }
    }
}