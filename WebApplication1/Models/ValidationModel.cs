namespace WebApplication1.Models;
using System.ComponentModel.DataAnnotations;

public class ValidationModel
{
    [Required(ErrorMessage = "First Name is required")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required")]
    public string? LastName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Age is required")]
    [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]
    public int Age { get; set; }
}