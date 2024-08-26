using Microsoft.EntityFrameworkCore;
using Ogani.Models.Entities;

namespace Ogani.Models.Contexts.Configurations
{
	public class DataContext:DbContext
	{
        internal object SubscribePosts;

        public DataContext (DbContextOptions options) 
			: base(options) 
		{ 


		}

		public DbSet<ContactPost>  ContactPosts { get; set; }

		public DbSet<SubscribePost> SubscribePost { get; set; }
 
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);	
		}

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }

	
		 
}
