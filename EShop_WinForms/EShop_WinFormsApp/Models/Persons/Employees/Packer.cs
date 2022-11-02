using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.Models.Persons.Employees
{
    [Table("Packers")]
    public class Packer : IPacker
    {
        [Key, ForeignKey("Employee")]
        public int Id { get; private set; }
        public int EmployeeId { get; private set; }
        public int QualificationLevel { get; set; }
        [Required]
        public virtual Employee Employee
        {
            get { return employee; }
            set
            {
                if (value == null) throw new NullReferenceException("Employee can not be null");
                employee = value;
                value.BecomePacker(this);
            }
        }

        private Employee employee;


        protected Packer() { }
        public Packer(Employee employee, int qualificationLevel)
        {
            Employee = employee;
            QualificationLevel = qualificationLevel;
        }

        public Employee GetEmployee()
        {
            return Employee;
        }
        public override string ToString()
        {
            return $"{Employee.Person.FullName} is a packer with qualification lvl.{QualificationLevel} ";
        }
    }
}
