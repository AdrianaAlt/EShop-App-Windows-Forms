using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.Models.Persons.Employees
{
    [Flags]
    public enum Job
    {
        WarehouseWorker = 1, Deliveryman = 2, Packer = 4, PackerWarehouseWorker = 8
    }
}
