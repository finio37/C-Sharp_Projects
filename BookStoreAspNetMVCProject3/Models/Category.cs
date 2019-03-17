using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjektKsiegarniBCity.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string Name { get; set; } //książki, podreczniki,repetytoria, czasopisma, obcojezyczne, stacjonarna

        public string Description { get; set; }

        public string IconFileName { get; set; }

        public string ClassName { get; set; }

        public virtual ICollection<Article> Articles { get; set; }


    }
}