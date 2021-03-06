﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using BookStoreWebApi.DAL;
using AuthorstoreWebApi.Repository;
using BookStoreWebApi.Repository;

namespace BookStoreWebApi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<StoreDataContext>(opts => opts.UseSqlServer("Data Source=TECHBROTHERDC;Initial Catalog=Bookstore;Integrated Security=True"));

            services.AddMvc();
            services.AddScoped<IAuthors, AuthorsRepository>();
            services.AddScoped<IBooks, BooksRepository>();
            services.AddScoped<IBooksReviews, BookReviewsRepository>();
            services.AddScoped<ICategory, CategoryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, StoreDataContext db)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            db.Database.Migrate();
            app.UseMvc();
        }
    }
}
