using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}
        [Required]
        public string ChefFirstName {get; set;}
        [Required]
        public string ChefLastName {get; set;}
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB {get; set;}
        public List<Dish> CreatedDishes {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

    }
}