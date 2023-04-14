using System.ComponentModel.DataAnnotations;

namespace KolekcjonerModel.Models;

public class Property
{
    [Key]
    public int Id_Property { get; set; }
    public int Id_PropertyType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
}