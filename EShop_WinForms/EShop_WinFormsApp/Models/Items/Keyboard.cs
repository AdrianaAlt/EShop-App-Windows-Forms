using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MAS_WinFormsApp.Models.Items
{
    [Table("Keyboard")]
    public partial class Keyboard : Item
    {
        [Required(ErrorMessage="Connectivity technology is required"), MaxLength(30)]
        public string ConnectivityTechnology { get; set; }
        public override ItemType Type => ItemType.Keyboard;
        public override string SpecificInfo => $"connectivity technology: {ConnectivityTechnology}";


        public Keyboard() : base() { }

        public Keyboard(string upcCode, string itemName, double unitPrice, string connectivityTechnology, string? description = null) : base(upcCode, itemName, unitPrice, description)
        {
            ConnectivityTechnology = connectivityTechnology;
        }

        public override string ToString()
        {
            return base.ToString() + ", connectivity technology = " + ConnectivityTechnology;
        }

    }
}
