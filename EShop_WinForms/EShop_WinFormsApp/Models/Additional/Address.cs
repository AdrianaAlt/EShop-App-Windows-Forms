using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.Models.Additional
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Street Number can not be empty"), MaxLength(10)]
        public string StreetNumber { get; private set; }
        [Required(ErrorMessage = "Street name can not be empty"), MaxLength(20)]
        public string Street { get; private set; }
        [Required(ErrorMessage = "City name can not be empty"), MaxLength(25)]
        public string City { get; private set; }
        [Required(ErrorMessage = "Country name can not be empty"), MaxLength(30)]
        public string Country { get; private set; }
        [Required(ErrorMessage = "Postcode can not be empty"), MaxLength(15)]
        public string Postcode { get; private set; }

        protected Address() { }
        public Address(string country, string city, string street, string streetNumber, string postcode)
        {
            StreetNumber = streetNumber;
            Street = street;
            City = city;
            Country = country;
            Postcode = postcode;
        }

        public override string ToString()
        {
            return $"Adress: {Country} {City} {Street} {StreetNumber} {Postcode}";
        }
    }
}
