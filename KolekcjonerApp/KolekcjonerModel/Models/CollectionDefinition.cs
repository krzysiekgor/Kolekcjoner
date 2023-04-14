using System.ComponentModel.DataAnnotations;

namespace KolekcjonerModel.Models;

public class CollectionDefinition
{
    [Key]
    public int Id_CollectionDefinition { get; set; }
    public int Id_Property { get; set; }
    
}