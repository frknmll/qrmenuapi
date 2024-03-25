using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QRMenuAPI.Models
{
	public class Company
	{
        public int Id { get; set; }

        [StringLength(200, MinimumLength = 2)]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; } = "";

        [StringLength(5, MinimumLength = 5)]
        [Column(TypeName = "char(5)")]
        public string PostalCode { get; set; } = "";

        [StringLength(200, MinimumLength = 5)]
        [Column(TypeName = "nvarchar(5)")]
        public string Address { get; set; } = "";

        [Phone]
        [Column(TypeName = "varchar(30)")]
        public string Phone { get; set; } = "" ;

        [EmailAddress]
        [Column(TypeName = "varchar(30)")]
        public string EMail { get; set; } = "";

        [Column(TypeName = "smalldatetime")]
        public DateTime RegisterDate { get; set; }

        [StringLength(11, MinimumLength = 10)]
        [Column(TypeName = "varchar(11)")]
        public string TaxNumber { get; set; } = "";

        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string WebAdress { get; set; } = "";

        public byte StateId { get; set; }
        [ForeignKey("StateId")]
        public State? State { get; set; }
    }
}

