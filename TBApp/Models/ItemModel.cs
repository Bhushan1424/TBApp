using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TBApp.Models
{
    public class ItemModel
    {
        /// <summary>
        /// Item Name
        /// </summary>
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Item Price with precision 10,2
        /// </summary>
        [RegularExpression(@"[\d]{1,10}([.][\d]{1,2})?",
                            ErrorMessage = "Please enter a valid amount")]
        public double Price { get; set; }
    }
}