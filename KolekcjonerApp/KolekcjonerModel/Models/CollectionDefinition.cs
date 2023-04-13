namespace KolekcjonerModel.Models;

public class CollectionDefinition
{
    public int Id_CollectionDefinition { get; set; }
    public int Id_Property { get; set; }
    
    public virtual Property Property { get; set; }
    public virtual  ICollection<Collection> Collections { get; set; }
}