using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fenyx_Project.WebService.Models
{
    [Table("Address")]
    public class Address
    {
        [ForeignKey("User")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        [Column("Street")]
        public string Street { get; set; }
        [Column("Zipcode")]
        public int Zipcode { get; set; }
        [Column("City")]
        public string City { get; set; }

        [ForeignKey("User")]
        public virtual User User { get; set; }
    }
}