using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QRMenuAPI.Models
{
	public class Restaurant
	{
        public int Id { get; set; }

        [StringLength(200, MinimumLength = 2)]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; } = "";

        public int CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company? Company { get; set; }

        public byte StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public State? State { get; set; }

        [Phone]
        [Column(TypeName = "varchar(30)")]
        public string Phone { get; set; } = "";

        [EmailAddress]
        [Column(TypeName = "varchar(30)")]
        public string EMail { get; set; } = "";

        [StringLength(200, MinimumLength = 5)]
        [Column(TypeName = "nvarchar(5)")]
        public string AddressDetails { get; set; } = "";

        [Column(TypeName = "smalldatetime")]
        public DateTime RegisterDate { get; set; }
    }
}

