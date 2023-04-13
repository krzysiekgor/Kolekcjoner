namespace KolekcjonerModel.Models;

public class Property
{
    public int Id_Property { get; set; }
    public int Id_PropertyType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public virtual PropertyType PropertyType { get; set; }
    public virtual ICollection<CollectionDefinition> CollectionDefinitions { get; set; }
}