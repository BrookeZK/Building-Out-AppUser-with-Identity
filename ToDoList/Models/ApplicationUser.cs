using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<ApplicationUserCategory> Categories { get; set; }
        public virtual ICollection<Item> Items { get; set; }

        public ApplicationUser() : base()
        {
        this.Categories = new HashSet<ApplicationUserCategory>();
        this.Items = new HashSet<Item>();
        }
    }
}