using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BookStoreWebApi.DAL;

namespace BookStoreWebApi.Migrations
{
    [DbContext(typeof(StoreDataContext))]
    partial class StoreDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStoreWebApi.Models.Authors", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("BookStoreWebApi.Models.BookReviews", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Rating");

                    b.Property<string>("Review_Text")
                        .IsRequired();

                    b.Property<string>("Reviewer_Name")
                        .IsRequired();

                    b.Property<DateTime>("publish_date");

                    b.HasKey("id");

                    b.ToTable("BookReview");
                });

            modelBuilder.Entity("BookStoreWebApi.Models.Books", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<string>("imageUrl")
                        .IsRequired();

                    b.Property<string>("publishdate")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("BookStoreWebApi.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Categorys");
                });
        }
    }
}
