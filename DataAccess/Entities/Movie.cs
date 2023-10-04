#nullable disable
namespace DataAccess;


public class Movie : Record
{
    public override int Id { get; set; }

    public override string GuId { get; set; }
    
    public string Name { get; set; }

    public short Year { get; set; }

    public double Revenue { get; set; }

    public int DirectorId { get; set; }

    public Director Director { get; set; }

}
