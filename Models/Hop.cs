using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace brew_logger_backend.Models;

[Table("Hops")]
public class Hop
{
	[Key]
	public int Id { get; set; }
	[ForeignKey("Beer")]
	public int BeerId { get; set; }
	public Beer Beer { get; set; }
	public string Name { get; set; }
	public string GramsPerLiter { get; set; }
	public string Grams { get; set; }
	public string Alfa { get; set; }
	public string Time { get; set; }
	public string Quantity { get; set; }

	public int Price { get; set; }


}