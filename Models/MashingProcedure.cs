using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace brew_logger_backend.Models;

[Table("MashingProcedures")]
public class MashingProcedure
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Beer")]
    public int BeerId { get; set; }
    public Beer Beer { get; set; }
    public int KiloGramsOfMalt { get; set; }
    // Normally 66-67 degrees, add a note to frontend
    public int WantedWaterTemperature { get; set; }
    // tempereature of the dry malt
    public int MaltTemperature { get; set; }
    public int LitersOfWater { get; set; }
    // we will use the other data points to calculate this to inform the user what temperature they should heat their
    // water to for the mashing procedure.
    public int TemperatureOfWater { get; set; }
    // see tab called Mal in excel document for future reference
    // formula on calculating above is as follows:
    // 0.58 * KiloGramsOfMalt * ( WantedWaterTemperature - MaltTemperature ) / LitersOfWater + WantedWaterTemperature
}