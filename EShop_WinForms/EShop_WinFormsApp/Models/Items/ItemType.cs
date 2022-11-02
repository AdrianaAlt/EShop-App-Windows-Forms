
using System.ComponentModel;

namespace MAS_WinFormsApp.Models.Items
{
    [Flags]
    public enum ItemType
    {
        [Description("Desktop")]
        Desktop=1,
        [Description("Monitor")]
        Monitor=2,
        [Description("Keyboard")] 
        Keyboard=4
    }
}
