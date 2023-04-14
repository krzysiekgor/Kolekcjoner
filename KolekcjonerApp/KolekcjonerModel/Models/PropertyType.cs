using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace KolekcjonerModel.Models;

public class PropertyType
{
    [Key]
    public int Id_PropertyType { get; set; }
    public string Name { get; set; }
    
}