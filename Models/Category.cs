﻿using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QRMenuAPI.Models
{
	public class Category
	{
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; } = "";

        [StringLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        public string? Description { get; set; } = "";

        public int RestaurantId { get; set; }
        [ForeignKey("RestaurantId")]
        public Restaurant? Restaurant { get; set; }

        public byte StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public State? State { get; set; }
    }
}

