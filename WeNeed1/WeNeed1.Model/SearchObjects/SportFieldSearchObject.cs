namespace WeNeed1.Model.SearchObjects;

public class SportFieldSearchObject:BaseSearchObject
{
    public int? SportsCenterId { get; set; }
    
    public string? SportType { get; set; }
    
    public string? Name { get; set; }
}