﻿using System.ComponentModel.DataAnnotations;

namespace API_AutoAuctioneer.Models.BidRequestModels;

public class UpdateBidRequest
{
    [Required] public Guid BidId { get; set; }

    [Required] public Guid UserId { get; set; }

    [Required] public long BidAmount { get; set; }
}