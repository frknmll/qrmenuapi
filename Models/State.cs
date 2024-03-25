using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QRMenuAPI.Models
{
	public class State
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte Id { get; set; }
        [StringLength(10)]
        [Column(TypeName = "nvarchar(10)")]
        public string Description { get; set; } = "";

        public List<ApplicationUser>? ApplicationUsers { get; set; }
    }
}

