using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace brew_logger_backend.Models;

[Table("BitteringCalculations")]
public class BitteringCalculation
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Beer")]
    public int BeerId { get; set; }
    public Beer Beer { get; set; }
    public int IBU { get; set; }
    public float AlfaSyre { get; set; }
    public int Yield { get; set; } 
    public int FinishedBrewLiters { get; set; } 
    // Default value should be boiled for XX minutes
    public string? MinutesNotes { get; set; }
}