using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3.Models
{
    public class Car
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole 'Model' jest wymagane.")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Pole 'Producent' jest wymagane.")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Pole 'Pojemność silnika' jest wymagane.")]
        public string EngineCapacity { get; set; }

        [Required(ErrorMessage = "Pole 'Moc' jest wymagane.")]
        public int Power { get; set; }

        [Required(ErrorMessage = "Pole 'Rodzaj silnika' jest wymagane.")]
        public string EngineType { get; set; }

        [Required(ErrorMessage = "Pole 'Nr rejestracyjny' jest wymagane.")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Pole 'Właściciel' jest wymagane.")]
        public string Owner { get; set; }
    }
}
