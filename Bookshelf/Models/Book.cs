using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bookshelf.Models
{
    public class Book
    {
        [Key]
        //Key = ID
        public int ID { get; set; }
        //rest of data
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")]
        //ForeignKey = CategoryID
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}