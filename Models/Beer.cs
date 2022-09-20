using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace brew_logger_backend.Models;

[Table("Beers")]
public class Beer
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public DateOnly CreationDate { get; set; }
    public int BatchNumber { get; set; }
    public string? Brewers { get; set; }
    public string Notes { get; set; }
    
    public string OriginalGravity { get; set; }
    public string FinalGravity { get; set; }
    public string AlcoholPercentage { get; set; }
    
    public int TotalIngredientsPrice { get; set; }
    public int FinalProductLiters { get; set; }
    public int PricerPerLiter { get; set; }
    
    public List<Malt> Malts { get; set; }
    public List<Hop> Hops { get; set; }
    public BitteringCalculation BitteringCalculation { get; set; }
    public MashingProcedure MashingProcedure { get; set; }
    public WaterTreatment WaterTreatment { get; set; }
    public YeastingDetails YeastingDetails { get; set; }
    
    
}
