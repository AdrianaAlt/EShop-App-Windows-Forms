using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.DTO
{
    public class WarehouseItemDTO
    {
        public int Id { get; set; }
        public ItemDTO Item { get; set; }
        public WarehouseDTO Warehouse { get; set; }
        public int Quantity { get; set; }
    }
}
