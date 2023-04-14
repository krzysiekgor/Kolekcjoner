using System.ComponentModel.DataAnnotations;

namespace KolekcjonerModel.Models;

public class CollectionPosition
{
    [Key]
    public int Id_CollectionPosition { get; set; }
    public int Id_Collection { get; set; }
    public int Id_PositionProperty { get; set; }
    public int SortNumber { get; set; }

}