using Microsoft.EntityFrameworkCore;

namespace FAQApplication.Models
{
    public class FAQContext : DbContext
    {
        public FAQContext(DbContextOptions<FAQContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<FAQ> FAQs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<FAQ>()
            //    .Property(b => b.FaqId)
            //    .ValueGeneratedOnAdd();
            
                


            

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "general", CategoryName = "General" },
                new Category { CategoryID = "history", CategoryName = "History" }
            );

            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicID = "bootstrap", TopicName = "Bootstrap" },
                new Topic { TopicID = "c#", TopicName = "C#" },
                new Topic { TopicID = "javascript", TopicName = "JavaScript" }
            );

            modelBuilder.Entity<FAQ>()
                .HasData(



                new  { FaqID="1", Question = "What is Bootstrap?", Answer = "A CSS framework for creating responsive web apps for multiple screen sizes.", CategoryID="general", TopicID = "bootstrap" },
                new  { FaqID="2", Question = "What is C#?", Answer = "A general purpose object oriented language", CategoryID="general", TopicID = "c#" },
                new  { FaqID="3", Question = "What is JavaScript?", Answer = "A general purpose scripting language that executes in a web broser.", CategoryID = "general", TopicID = "javascript" },
                new  { FaqID="4", Question = "When was Bootstrap first released?", Answer = "In 2011", CategoryID = "history", TopicID = "bootstrap" },
                new  { FaqID="5", Question = "When was c# first released?", Answer = "In 2002", CategoryID = "history", TopicID = "c#" },
                new  { FaqID="6", Question = "When was JavaScript first released?", Answer = "In 1995.", CategoryID = "history", TopicID = "javascript" }
                );
        }
    }
}
