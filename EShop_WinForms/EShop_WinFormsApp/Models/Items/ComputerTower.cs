using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.Models.Items
{
    [Table("ComputerTowers")]
    public partial class ComputerTower : Item
    {
        [Required]
        public string Processor { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int RamMemory { get; set; }
        public override ItemType Type => ItemType.Desktop;
        public override string SpecificInfo => $"processor: {Processor}, RAM memory: {RamMemory}";

        private ComputerTower() : base() { }
        public ComputerTower(string upcCode, string itemName, double unitPrice, string processor, int ramMemory, string? description = null)
            : base(upcCode, itemName, unitPrice, description)
        {
            Processor = processor;
            RamMemory = ramMemory;
        }



        public override string ToString()
        {
            return base.ToString() + ", processor = " + Processor + ", RAM = " + RamMemory;
        }
    }
}
