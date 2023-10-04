#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess;

public abstract class Record
{
    [Key]
    [Column(Order = 0)]
    public virtual int Id { get; set; }

    [Key]
    [Column(Order = 1)]
    public virtual string GuId { get; set; }

}
