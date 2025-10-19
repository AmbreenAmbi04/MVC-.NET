namespace WebApplication1.Models;
using System.ComponentModel.DataAnnotations;

public class ValidationModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public bool Age { get; set; }
}