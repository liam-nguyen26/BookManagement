using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Entity
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Book name must not be empty")]
        [StringLength(1000, MinimumLength = 3, ErrorMessage = "Book name length must between 3 and 1000")]
        public String BookName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Category must not be empty")]
        [StringLength(1000, MinimumLength = 3, ErrorMessage = "Category length must between 3 and 1000")]
        public String Category { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }
    }
}
