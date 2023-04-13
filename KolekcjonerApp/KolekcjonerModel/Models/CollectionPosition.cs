namespace KolekcjonerModel.Models;

public class CollectionPosition
{
    public int Id_CollectionPosition { get; set; }
    public int Id_Collection { get; set; }
    public int Id_PositionProperty { get; set; }
    public int SortNumber { get; set; }

    public virtual Collection Collection { get; set; }
    public virtual ICollection<PositionProperty> PositionProperties { get; set; }
}