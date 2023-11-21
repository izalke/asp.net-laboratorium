using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium3.Models
{
    public class Contact 
    {
       public int Id { get; set; }
        //atrybuty nad dotyczą pola pod
       [Required(ErrorMessage ="Podaj swoje imię")]
       [StringLength(maximumLength: 50, ErrorMessage = "Imię za długie maksymalna ilość znaków 50 ")]
       public string Name { get; set; }
       [EmailAddress(ErrorMessage = "Zły adres email")]
       public string Email { get; set; }
       [Phone]
       public string Phone { get; set; }
       [DataType(DataType.Date)]
       public DateTime? Birth { get; set; }
    }
}
