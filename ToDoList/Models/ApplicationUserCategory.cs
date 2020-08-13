namespace ToDoList.Models
{
  public class ApplicationUserCategory
    {       
        public int ApplicationUserCategoryId { get; set; }
        // public int ApplicationUserId { get; set; }
        public int CategoryId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Category Category { get; set; }
    }
}