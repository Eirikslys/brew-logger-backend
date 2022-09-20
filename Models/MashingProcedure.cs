using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace brew_logger_backend.Models;

[Table("MashingProcedures")]
public class MashingProcedures
{
	[Key]
	public int Id { get; set; }

	[ForeignKey("Beer")]
	public int BeerId { get; set; }
	public Beer Beer { get; set; }
	public TimeOnly WaterHeatingStart { get; set; }
	public TimeOnly WaterHeatingEnd { get; set; }
	public string WaterHeatingLiters { get; set; }
	public string WaterHeatingTemperature { get; set;}
	public TimeOnly MashStart { get; set; }
	public TimeOnly MashEnd { get; set; }
	public string MashLiters { get; set; }
	public string MashTemperature { get; set; }
	public TimeOnly SpargeStart { get; set; }
	public TimeOnly SpargeEnd { get; set; }
	public string SpargeTemperature { get; set; }
	public string SpargeLiters { get; set; }
	public TimeOnly BoilStart { get; set; }
	public TimeOnly BoilEnd { get; set; }
	public string BoilTemperature { get; set; }
	public string BoilLiters { get; set; }
	public TimeOnly CoolingStart { get; set; }
	public TimeOnly CoolingEnd { get; set; }
	public string CoolingTemperature { get; set; }
	public string CoolingLiters { get; set; }

	//for the total time spent on each procedure, calculations are to be made on the controller

}