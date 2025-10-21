namespace WebApplication1.Models;

public class JsonModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
}