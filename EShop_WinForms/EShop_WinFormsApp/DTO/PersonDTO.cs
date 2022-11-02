
namespace MAS_WinFormsApp.DTO
{
    public class PersonDTO
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;
                return (BirthDate.Date > today.AddYears(-age)) ? --age : age;
            }
        }
        public string PhoneNumber { get; set; }
    }
}
