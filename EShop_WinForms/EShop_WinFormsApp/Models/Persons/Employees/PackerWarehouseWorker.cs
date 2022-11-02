using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_WinFormsApp.Models.Persons.Employees
{
    [Table("PackerWarehouseWorkers")]
    public class PackerWarehouseWorker : WarehouseWorker, IPacker
    {
        public int PackerId { get; private set; }

        [Required]
        [Range(1, 8)]
        public int QualificationLevel { get; set; }
        [Required]
        [ForeignKey("PackerId")]
        public virtual Packer Packer { get; private set; }

        protected PackerWarehouseWorker() { }
        public PackerWarehouseWorker(Employee employee, int qualificationLevel)
        : base(employee)
        {
            Packer = new Packer(employee, qualificationLevel);
            QualificationLevel = qualificationLevel;
        }

        public override string ToString()
        {
            return $"{Employee.Person.FullName} is a packer-warehouse worker";
        }
    }
}
