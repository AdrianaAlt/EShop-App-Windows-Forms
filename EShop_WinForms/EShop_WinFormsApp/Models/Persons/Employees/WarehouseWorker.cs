
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_WinFormsApp.Models.Persons.Employees
{
    [Table("WarehouseWorkers")]
    public class WarehouseWorker
    {
        [Key, ForeignKey("Employee")]
        public int Id { get; private set; }
        public int EmployeeId { get; private set; }

        [Required]
        public virtual Employee Employee
        {
            get { return employee; }
            set
            {
                if (value == null) throw new NullReferenceException("Employee can not be null");
                employee = value;
                value.BecomeWarehouseWorker(this);
            }
        }

        private Employee employee;


        protected WarehouseWorker() { }
        public WarehouseWorker(Employee employee)
        {
            Employee = employee;
        }

        public override string ToString()
        {
            return $"{Employee.Person.FullName} is a warehouse worker";
        }

    }
}
