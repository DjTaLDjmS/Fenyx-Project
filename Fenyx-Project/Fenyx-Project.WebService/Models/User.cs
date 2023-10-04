using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fenyx_Project.WebService.Models
{
    [Table("User")]
    public class User
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Birthdate")]
        public DateTime Birthdate { get; set; }
        [Column("PhotoUrl")]
        public string PhotoUrl { get; set; }

        public virtual Address Address { get; set; }
    }
}