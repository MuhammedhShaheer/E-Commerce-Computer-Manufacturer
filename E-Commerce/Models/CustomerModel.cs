using Microsoft.AspNetCore.Identity;

namespace E_Commerce.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }     

        public string Email { get; set; }    

        public int Password{ get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; } 

    }
}
