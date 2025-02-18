using System;
using Microsoft.EntityFrameworkCore;

namespace WebNutrition.Models;

public class WebNutritionDbContext : DbContext
{
    public WebNutritionDbContext(DbContextOptions<WebNutritionDbContext> options):base(options){}

    public DbSet<Food> Foods{get; set;} 

}
