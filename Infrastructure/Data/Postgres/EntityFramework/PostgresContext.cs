﻿using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data.Postgres.EntityFramework;

public class PostgresContext : DbContext
{
    private readonly IConfiguration _configuration;

    public PostgresContext(DbContextOptions<PostgresContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserTokenConfiguration());
        modelBuilder.ApplyConfiguration(new MotorConfiguration());
		modelBuilder.ApplyConfiguration(new EkipmanConfiguration());
		modelBuilder.ApplyConfiguration(new ContactConfiguration());
	}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        if (_configuration["EnvironmentAlias"] == "DEV")
        {
            optionsBuilder.LogTo(Console.Write);
        }
    }

	public DbSet<UserToken> UserTokens => Set<UserToken>();
	public DbSet<User> User => Set<User>();
    public DbSet<Motor> Motor => Set<Motor>();
    public DbSet<Ekipman> Ekipman => Set<Ekipman>();
    public DbSet<Contact> Contacts => Set<Contact>();

}