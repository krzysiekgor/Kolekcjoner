using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KolekcjonerModel.Models;

public class Collection
{
    [Key]
    public int Id_Collection { get; set; }
    
    public string Name { get; set; }
    public string Description { get; set; }
    [ForeignKey(nameof(Id_PropertyDefinition))]
    public int Id_PropertyDefinition { get; set; }

}