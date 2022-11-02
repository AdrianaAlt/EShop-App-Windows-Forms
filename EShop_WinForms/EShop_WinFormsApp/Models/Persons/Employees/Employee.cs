using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_WinFormsApp.Models.Persons.Employees
{
    [Table("Employees")]
    public class Employee
    {
        [Key, ForeignKey("Person")]
        public int Id { get; private set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? HireDate { get; private set; }
        [Required]
        [Range(MIN_PAY_RATE, double.MaxValue)]
        public double PayRate
        {
            get { return payRate; }
            private set
            {
                if (payRate <= minPayRate)
                    throw new Exception("Pay rate can not be less than PLN " + minPayRate);
                payRate = value;
            }
        }
        [Required]
        [Range(MIN_WEEK_WORK_HOURS, MAX_WEEK_WORK_HOURS)]
        public double WeekWorkHours { get; private set; }
        
        public virtual Job JobType { get; private set; }

        private const double MIN_PAY_RATE = 18.3;
        private const double MIN_WEEK_WORK_HOURS = 1;
        private const double MAX_WEEK_WORK_HOURS = 48;


        [Required]
        public virtual Person Person
        {
            get { return person; }
            set
            {
                if (value == null) throw new NullReferenceException("Person can not be null");
                if (person == value) return;
                if (person != null) throw new Exception("Person can not be changed");
                person = value;
                person.BecomeEmployee(this);
            }
        }

        public virtual Packer PackerData { get; private set; }
        public virtual Deliveryman DeliverymanData { get;  set; }
        public virtual WarehouseWorker WarehouseWorkerData { get; private set; }
        public virtual PackerWarehouseWorker PackerWarehouseWorkerData { get; private set; }

        public string QualificationLevel
        {
            get
            {
                if (JobType == Job.Packer) return PackerData.QualificationLevel + " lvl.";
                if (JobType == Job.PackerWarehouseWorker) return PackerWarehouseWorkerData.QualificationLevel + "lvl.";
                throw new Exception("Employee is not a packer / packer warehouse worker");
            }
        }
        public string GetDrivingLicenceCategory
        {
            get
            {
                if (JobType == Job.Deliveryman) return DeliverymanData.DrivingLicenceCategory;
                throw new Exception("Employee is not a deliveryman");
            }
        }


        private double payRate;
        private Person person;

        private const double minPayRate = 18.3;


        protected Employee() { }
        private Employee(Person person, double payRate, double weekWorkHours)
        {
            HireDate = DateTime.Now;
            Person = person;

            WeekWorkHours = weekWorkHours;
            BecomeWarehouseWorker();
        }
        private Employee(Person person, double payRate, double weekWorkHours, int qualificationLevel)
        : this(person, payRate, weekWorkHours)
        {
            BecomePacker(qualificationLevel);
        }
        private Employee(Person person, double payRate, double weekWorkHours, string drivingCategory)
        : this(person, payRate, weekWorkHours)
        {
            BecomeDeliveryman(drivingCategory);
        }


        public static Employee CreateEmployee(Person person, double payRate, double weekWorkHours)
        {
            if (person == null) throw new ArgumentException("The given person does not exist!");
            return new Employee(person, payRate, weekWorkHours);
        }
        public static Employee CreateEmployee(Person person, double payRate, double weekWorkHours, int qualificationLevel)
        {
            if (person == null) throw new Exception("The given person does not exist!");
            Employee employee = new Employee(person, payRate, weekWorkHours);
            employee.BecomePacker(qualificationLevel);
            return employee;
        }
        public static Employee CreateEmployee(Person person, double payRate, double weekWorkHours, string drivingCategory)
        {
            if (person == null) throw new ArgumentException("The given person does not exist!");
            Employee employee = new Employee(person, payRate, weekWorkHours, drivingCategory);
            employee.BecomeDeliveryman(drivingCategory);
            return employee;
        }
        public static Employee CreateEmployee(Person person, double payRate, double weekWorkHours, int qualificationLevel, string drivingCategory)
        {
            if (person == null) throw new Exception("The given person does not exist!");
            Employee employee = new Employee(person, payRate, weekWorkHours);
            employee.BecomePackerWarehouseWorker(qualificationLevel);
            return employee;
        }

        public static void RemoveEmployee(Employee employee)
        {
            employee.ClearJobs();
            employee.person.StopBeingEmployee();
            employee.person = null;
        }
        private void ClearJobs()
        {
            WarehouseWorkerData = null;
            PackerWarehouseWorkerData = null;
            DeliverymanData = null;
            PackerData = null;
        }
        public string GetJobInfo()
        {
            switch (JobType)
            {
                case Job.Packer: return PackerData.ToString();
                case Job.WarehouseWorker: return WarehouseWorkerData.ToString();
                case Job.PackerWarehouseWorker: return PackerWarehouseWorkerData.ToString();
                case Job.Deliveryman: return DeliverymanData.ToString();
                default: return null;
            }
        }

        public string GetJobString()
        {
            return JobType.ToString();
        }



        public void BecomeWarehouseWorker()
        {
            if (WarehouseWorkerData != null) return;
            ClearJobs();
            JobType = Job.WarehouseWorker;
            WarehouseWorkerData = new WarehouseWorker(this);
        }
        public void BecomeWarehouseWorker(WarehouseWorker warehouseWorker)
        {
            if (WarehouseWorkerData == null) throw new ArgumentException("Warehouse worker job can not be null");
            if (WarehouseWorkerData == warehouseWorker) return;
            ClearJobs();
            JobType = Job.WarehouseWorker;
            WarehouseWorkerData = warehouseWorker;
            warehouseWorker.Employee = this;
        }
        public void BecomePacker(int qualificationLevel)
        {
            if (PackerData != null) return;
            ClearJobs();
            JobType = Job.Packer;
            PackerData = new Packer(this, qualificationLevel);
        }
        public void BecomePacker(Packer packer)
        {
            if (packer == null) throw new NullReferenceException("Packer job can not be null");
            if (PackerData == packer) return;
            ClearJobs();
            JobType = Job.Packer;
            PackerData = packer;
            packer.Employee = this;
        }

        public void BecomeDeliveryman(string drivingLicenseCategory)
        {
            if (DeliverymanData != null) return;
            ClearJobs();
            JobType = Job.Deliveryman;
            DeliverymanData = new Deliveryman(this, drivingLicenseCategory);
        }
        public void BecomeDeliveryman(Deliveryman deliveryman)
        {
            if (deliveryman == null) throw new NullReferenceException("Deliveryman job can not be null");
            ClearJobs();
            JobType = Job.Deliveryman;
            DeliverymanData = deliveryman;
            deliveryman.Employee = this;
        }
        public void BecomePackerWarehouseWorker(int qualificationLevel)
        {
            if (PackerWarehouseWorkerData != null) return;
            ClearJobs();
            JobType = Job.PackerWarehouseWorker;
            PackerWarehouseWorkerData = new PackerWarehouseWorker(this, qualificationLevel);
        }
        public void becomePackerWarehouseWorker(PackerWarehouseWorker packerWarehouseWorker)
        {
            if (packerWarehouseWorker == null) throw new NullReferenceException("Packer job can not be null");
            if (PackerWarehouseWorkerData == packerWarehouseWorker) return;
            ClearJobs();
            JobType = Job.PackerWarehouseWorker;
            PackerWarehouseWorkerData = packerWarehouseWorker;
            packerWarehouseWorker.Employee = this;
        }
        public override string ToString()
        {
            return $"Employee: id={Id}, name={Person.FullName}, Job={JobType}, payRate={PayRate}";
        }
    }
}
