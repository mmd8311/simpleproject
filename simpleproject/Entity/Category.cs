using System.ComponentModel.DataAnnotations;

namespace simpleproject.Entity
{
    public class Category
    {

            public int Id { get; set; }
            [Required]
            [MaxLength(300)]
            public string CategoryName { get; set; }
            public string Body { get; set; }
       

    }
}
