using MAS_WinFormsApp.Models.Additional;
using MAS_WinFormsApp.Models.Persons.Employees;
using MAS_WinFormsApp.Models.Persons.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MAS_WinFormsApp.Models.Persons
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25), MinLength(1)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(25), MinLength(1)]
        public string LastName { get; set; }
        [MaxLength(25), MinLength(1)]
        public string? MiddleName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException("Phone number can not be null or empty");
                if (!Regex.IsMatch(value, "(?<!\\w)(\\(?(\\+|00)?48\\)?)?[ -]?\\d{3}[ -]?\\d{3}[ -]?\\d{3}(?!\\w)"))
                    throw new ArgumentException("Phone number is not valid");
                _phoneNumber = value;
            }
        }
        [NotMapped]
        public int Age
        {
            get
            {
                var age = DateTime.Today.Year - BirthDate.Year;
                return (BirthDate.Date > DateTime.Today.AddYears(-age)) ? --age : age;
            }
        }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public virtual Employee Employee { get; set; }
        public virtual IndividualCustomer IndividualCustomer { get; set; }


        private string _phoneNumber;

        protected Person() { }
        private Person(string firstName, string lastName, DateTime birthDate, string phoneNumber, string middleName = null)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }
        public Person(string firstName, string lastName, DateTime birthDate, string phoneNumber, string email, string password, Address deliveryAddress, long creditCardId, string middleName = null)
        : this(firstName, lastName, birthDate, phoneNumber, middleName)
        {
            BecomeIndividualCustomer(email, password, deliveryAddress, creditCardId);
        }
        public Person(string firstName, string lastName, DateTime birthDate, string phoneNumber, double payRate, double weekWorkHours, string middleName)
        : this(firstName, lastName, birthDate, phoneNumber, middleName)
        {
            BecomeEmployee(payRate, weekWorkHours);
        }
        public Person(string firstName, string lastName, DateTime birthDate, string phoneNumber, double payRate, double weekWorkHours, string email, string password, Address deliveryAddress, long creditCardId, string middleName)
        : this(firstName, lastName, birthDate, phoneNumber, middleName)
        {
            BecomeEmployee(payRate, weekWorkHours);
            BecomeIndividualCustomer(email, password, deliveryAddress, creditCardId);
        }


        // Employee
        public bool IsEmployee()
        {
            return Employee != null;
        }
        public Employee GetEmployeeAccount()
        {
            if (!IsEmployee()) throw new Exception("Person is not an employee");
            return Employee;
        }
        public void BecomeEmployee(double payRate, double weekWorkHours)
        {
            if (IsEmployee()) return;
            Employee = Employee.CreateEmployee(this, payRate, weekWorkHours);
        }
        public void BecomeEmployee(Employee employee)
        {
            if (IsEmployee()) return;
            Employee = employee;
            employee.Person = this;
        }
        public void StopBeingEmployee()
        {
            if (!IsEmployee()) return;
            Employee.RemoveEmployee(Employee);
            Employee = null;
        }

        
        public void BecomeWarehouseWorker()
        {
            if (!IsEmployee()) throw new ArgumentException("Person is not an employee");
            Employee.BecomeWarehouseWorker();
        }
        public void BecomePacker(int qualificationLevel)
        {
            if (!IsEmployee()) throw new ArgumentException("Person is not an employee");
            Employee.BecomePacker(qualificationLevel);
        }
        public void BecomeDeliveryman(string drivingLicenseCategory)
        {
            if (!IsEmployee()) throw new ArgumentException("Person is not an employee");
            Employee.BecomeDeliveryman(drivingLicenseCategory);
        }
        public void BecomePackerWarehouseWorker(int qualificationLevel)
        {
            if (!IsEmployee()) throw new ArgumentException("Person is not an employee");
            Employee.BecomePackerWarehouseWorker(qualificationLevel);
        }

        public bool IsIndividualCustomer()
        {
            return IndividualCustomer != null;
        }
        public IndividualCustomer GetIndividualCustomerAccount()
        {
            if (!IsIndividualCustomer()) throw new Exception("Person is not a customer!");
            return IndividualCustomer;
        }
        public void BecomeIndividualCustomer(string email, string password, Address deliveryAddress, long creditCardId)
        {
            if (IsIndividualCustomer()) return;
            IndividualCustomer = new IndividualCustomer(this, email, password, deliveryAddress, creditCardId);
        }
        public void StopBeingIndividualCustomer()
        {
            if (!IsIndividualCustomer()) return;
            IndividualCustomer tmp = IndividualCustomer;
            IndividualCustomer = null;
            IndividualCustomer.RemoveCustomer(tmp);
        }

        public bool IsCustomerAndEmployee()
        {
            return IsEmployee() && IsIndividualCustomer();
        }

    }
}
