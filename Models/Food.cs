using System;
using System.ComponentModel.DataAnnotations;

namespace WebNutrition.Models;

public class Food
{   
    public string? nombre{get; set;}
    public string? CantidadxPorcion{get; set;}
    public string? CaloriasxPorcion{get; set;}

}
