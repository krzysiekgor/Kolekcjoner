namespace KolekcjonerModel.Models;

public class Collection
{
    public int Id_Collection { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id_PropertyDefinition { get; set; }

    public virtual CollectionDefinition CollectionDefinition { get; set; }
    public virtual ICollection<CollectionPosition> CollectionPositions { get; set; }
}