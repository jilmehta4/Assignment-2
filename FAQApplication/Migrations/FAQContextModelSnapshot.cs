﻿// <auto-generated />
using FAQApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FAQApplication.Migrations
{
    [DbContext(typeof(FAQContext))]
    partial class FAQContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FAQApplication.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "general",
                            CategoryName = "General"
                        },
                        new
                        {
                            CategoryID = "history",
                            CategoryName = "History"
                        });
                });

            modelBuilder.Entity("FAQApplication.Models.FAQ", b =>
                {
                    b.Property<string>("FaqID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FaqID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("TopicID");

                    b.ToTable("FAQs");

                    b.HasData(
                        new
                        {
                            FaqID = "1",
                            Answer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                            CategoryID = "general",
                            Question = "What is Bootstrap?",
                            TopicID = "bootstrap"
                        },
                        new
                        {
                            FaqID = "2",
                            Answer = "A general purpose object oriented language",
                            CategoryID = "general",
                            Question = "What is C#?",
                            TopicID = "c#"
                        },
                        new
                        {
                            FaqID = "3",
                            Answer = "A general purpose scripting language that executes in a web broser.",
                            CategoryID = "general",
                            Question = "What is JavaScript?",
                            TopicID = "javascript"
                        },
                        new
                        {
                            FaqID = "4",
                            Answer = "In 2011",
                            CategoryID = "history",
                            Question = "When was Bootstrap first released?",
                            TopicID = "bootstrap"
                        },
                        new
                        {
                            FaqID = "5",
                            Answer = "In 2002",
                            CategoryID = "history",
                            Question = "When was c# first released?",
                            TopicID = "c#"
                        },
                        new
                        {
                            FaqID = "6",
                            Answer = "In 1995.",
                            CategoryID = "history",
                            Question = "When was JavaScript first released?",
                            TopicID = "javascript"
                        });
                });

            modelBuilder.Entity("FAQApplication.Models.Topic", b =>
                {
                    b.Property<string>("TopicID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicID");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicID = "bootstrap",
                            TopicName = "Bootstrap"
                        },
                        new
                        {
                            TopicID = "c#",
                            TopicName = "C#"
                        },
                        new
                        {
                            TopicID = "javascript",
                            TopicName = "JavaScript"
                        });
                });

            modelBuilder.Entity("FAQApplication.Models.FAQ", b =>
                {
                    b.HasOne("FAQApplication.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FAQApplication.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicID");

                    b.Navigation("Category");

                    b.Navigation("Topic");
                });
#pragma warning restore 612, 618
        }
    }
}
