using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace brew_logger_backend.Models;
[Table("Malts")]
public class Malt
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Beer")]
    public int BeerId { get; set; }
    public Beer Beer { get; set; }
    public string Name { get; set; }
    public string Kg { get; set; }
    public int Price { get; set; } 
    // This is what part of the total Malt this constitutes. E.G. if you have 10 kgs across two malts, one being 9kg
    // and the other 1 kg, their respective Part property should read 0.9 and 0.1.
    public float Part { get; set; }
}