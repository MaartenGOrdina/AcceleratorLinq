namespace AcceleratorLinq.Data.Entities;

public class Business
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Website { get; set; }

    public List<Shareholder> Shareholders { get; } = new();
}