using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace brew_logger_backend.Models;

[Table("FermentingDetails")]
public class FermentingDetail
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Beer")]
    public int BeerId { get; set; }
    public Beer Beer { get; set; }
    public int Liter { get; set; }
    public DateOnly StartDate { get; set; }
    // This should probably refer to when the fermentation visibly started with the "plopping", need to clarify
    public DateTime FermentationStarted { get; set; }
    public DateTime FermentationStopped { get; set; }
    public string Notes { get; set; }
}