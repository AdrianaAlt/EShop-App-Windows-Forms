
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MAS_WinFormsApp.Models.Items
{
    [Table("Monitor")]
    public partial class Monitor : Item
    {
        [Required]
        [Range(1.0, int.MaxValue)]
        public double ScreenDisplaySize { get; set; }
        public override ItemType Type => ItemType.Monitor;
        public override string SpecificInfo => $"screen display size: {ScreenDisplaySize}";


        protected Monitor() : base(){ }
        public Monitor(string upcCode, string itemName, double unitPrice, double screenDisplaySize, string? description = null) : base(upcCode, itemName, unitPrice, description)
        {
            ScreenDisplaySize = screenDisplaySize;
        }

        public override string ToString()
        {
            return base.ToString() + ", screen display size = " + ScreenDisplaySize;
        }
    }
}
