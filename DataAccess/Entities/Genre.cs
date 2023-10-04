#nullable disable
namespace DataAccess;

public class Genre : Record
{
    public override int Id {get; set;}

    public override string GuId { get; set; }
    public string Name { get; set; }

    public List<Movie> Movies { get; set; }

}
