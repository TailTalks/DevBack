using System;

using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;


namespace TailTalks.Models

{

    [Table("leads")]

    public class Leads

    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Bike's name cannot be empty.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bike's model cannot be empty.")]
        public string Email { get; set; }
        [Column("Date_Created")]
        public DateTime DateCreated { get; set; }
    }

}