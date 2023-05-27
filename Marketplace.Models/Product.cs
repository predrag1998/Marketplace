using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketplace.Models.CustomDataAnnotation;

namespace Marketplace.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        [DisplayName("Production Year")]
        [RangeCurrentYear(0,ErrorMessage ="Production year cannot be greater than current year")]
        public int ProductionYear { get; set; }

        public string Location { get; set; }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        [DisplayName("Last Modified")]
        public DateTime? LastModified { get; set; }

        [DisplayName("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

        [ValidateNever]
        [DisplayName("Image")]
        public string ImageUrl { get; set; }

    }
}
