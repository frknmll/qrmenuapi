using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QRMenuAPI.Models
{
	public class RestaurantUser
	{
        
        public int RestaurantId { get; set; }
        public string ApplicationUserId { get; set; } = "";

        [ForeignKey("RestaurantId")]
        public Restaurant? Restaurant { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser? applicationUser { get; set; }
    }
}

