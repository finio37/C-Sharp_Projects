using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjektKsiegarniBCity.Models
{
    public class Article
    {
        [Key]
        [Required]
        public int ArticleId { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string ISBN { get; set; }

        public string ArticleTitle { get; set; }

        public string AuthorName { get; set; }

        public string Jezyk { get; set; }

        public DateTime DateAdded { get; set; }

        public string CoverFileName { get; set; }

        public string Description { get; set; }

        public decimal Cena { get; set; }

        public bool IsBestseller { get; set; }

        public bool IsHidden { get; set; }

        public bool IsPromotion { get; set; }

        public bool IsNew { get; set; }


        public virtual Category Product { get; set; }




    }
}