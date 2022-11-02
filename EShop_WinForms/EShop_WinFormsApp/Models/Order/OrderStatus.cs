using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.Models.Order
{
    [Flags]
    public enum OrderStatus
    {
        Placed = 1, InProcess=2, Cancelled=4, Shipped=8
    }
}
