#nullable disable
namespace DataAccess;

public class Director : Record
{
    public override int Id { get; set; }

    public override string GuId { get; set; }

    public string Name {get; set;}

    public string Surname { get; set; }

    public DateTime BirthDate { get; set; }

    public bool IsRetired { get; set; }

    public List<Movie> Movies { get; set; }
}
