using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.Models.Persons.Employees
{
    [Table("Deliverymen")]
    public class Deliveryman
    {
        [Key, ForeignKey("Employee")]
        public int Id { get; private set; }
        [Required]
        public virtual Employee Employee
        {
            get => _employee;
            set
            {
                _employee = value ?? throw new NullReferenceException("Employee can not be null");
                _employee.BecomeDeliveryman(this);
            }
        }
        [Required(ErrorMessage ="Driving Licence Category is required")]
        [MaxLength(3)]
        public string DrivingLicenceCategory
        {
            get { return _drivingLicenceCategory; }
            set
            {
                if (value == null || value.Length != 0) throw new ArgumentException("Driver licence category can not be null or empty");
                _drivingLicenceCategory = value;
            }
        }

        private Employee _employee;
        private string _drivingLicenceCategory;


        protected Deliveryman() { }
        public Deliveryman(Employee employee, string drivingLicenceCategory)
        {
            Employee = employee;
            DrivingLicenceCategory = drivingLicenceCategory;
        }

        public override string ToString()
        {
            return $"{Employee.Person.FullName} is a deliveryman with driving licence category {DrivingLicenceCategory} ";
        }

    }
}
