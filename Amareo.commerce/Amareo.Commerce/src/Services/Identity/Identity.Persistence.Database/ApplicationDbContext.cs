﻿using Identity.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Identity.Persistence.Database
{
    public class ApplicationDbContext : IdentityDbContext <ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("Identity");

            ModelConfig(builder);


        }

        private void ModelConfig(ModelBuilder ModelBuilder)
        {

        }
    }
}
