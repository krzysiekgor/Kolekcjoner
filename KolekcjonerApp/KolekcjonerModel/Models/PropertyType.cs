using System.Collections;

namespace KolekcjonerModel.Models;

public class PropertyType
{
    public int Id_PropertyType { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<Property> Properties { get; set; }
}