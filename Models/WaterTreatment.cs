using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace brew_logger_backend.Models;

[Table("WaterTreatments")]
public class WaterTreatment
{
	[Key]
	public int Id { get; set; }

	[ForeignKey("Beer")]
	public int BeerId { get; set; }
	public Beer Beer { get; set; }
	public string WaterHeatingStart { get; set; }
	public string WaterHeatingEnd { get; set; }
	public string WaterHeatingLiters { get; set; }
	public string WaterHeatingTemperature { get; set;}
	public string MashStart { get; set; }
	public string MashEnd { get; set; }
	public string MashLiters { get; set; }
	public string MashTemperature { get; set; }
	public string SpargeStart { get; set; }
	public string SpargeEnd { get; set; }
	public string SpargeTemperature { get; set; }
	public string SpargeLiters { get; set; }
	public string BoilStart { get; set; }
	public string BoilEnd { get; set; }
	public string BoilTemperature { get; set; }
	public string BoilLiters { get; set; }
	public string CoolingStart { get; set; }
	public string CoolingEnd { get; set; }
	public string CoolingTemperature { get; set; }
	public string CoolingLiters { get; set; }
	//for the total time spent on each procedure, calculations are to be made on the controller

}
