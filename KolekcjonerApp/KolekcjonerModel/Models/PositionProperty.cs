namespace KolekcjonerModel.Models;

public class PositionProperty
{
    public int Id_PositionProperty { get; set; }
    public int Id_Property { get; set; }
    public string Value { get; set; }
    
    public virtual CollectionPosition CollectionPosition { get; set; }

}