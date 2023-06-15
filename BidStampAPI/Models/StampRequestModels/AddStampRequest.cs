﻿using System.ComponentModel.DataAnnotations;

namespace API_BidStamp.Models.StampRequestModels
{
    public class AddStampRequest
    {
       /* [Required]
        public Guid UserId;*/
        [Required]
        public string StampTitle { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Year { get; set; }
        public string? Country { get; set; }
        public string? Condition { get; set; }
        public string? CatalogNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
