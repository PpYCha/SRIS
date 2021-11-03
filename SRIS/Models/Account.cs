namespace SRIS.Models
{
    public class Account
    {


        public int User_id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AccessLevel { get; set; }
        public bool IsActive { get; set; }
        public string Position { get; set; }
    }
}