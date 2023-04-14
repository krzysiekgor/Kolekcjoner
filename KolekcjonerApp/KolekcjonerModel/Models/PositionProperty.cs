using System.ComponentModel.DataAnnotations;

namespace KolekcjonerModel.Models;

public class PositionProperty
{
    [Key]
    public int Id_PositionProperty { get; set; }
    public int Id_Property { get; set; }
    public string Value { get; set; }
    

}