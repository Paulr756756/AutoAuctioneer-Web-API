﻿namespace DataAccessLibrary_BidStamp.Models;

public class User {
    public List<Bid>? Bids = new();

    public List<Listing>? Listings = new();
    public List<Stamp>? Stamps = new();
    public Guid UserId { get; set; }
    public string? UserName { get; set; }

    public string PasswordHash { get; set; }

    /* public byte[] PasswordSalt { get; set; } = new byte[32];*/
    public string? VerificationToken { get; set; }
    public DateTime VerifiedAt { get; set; }
    public string? PasswordResetToken { get; set; }
    public DateTime? ResetTokenExpires { get; set; }
    public string Email { get; set; } = string.Empty;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public DateTime RegistrationDate { get; set; }
}

public class Stamp {
    public Guid StampId { get; set; }
    public string StampTitle { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string? Year { get; set; }
    public string? Country { get; set; }
    public string? Condition { get; set; }

    public string? CatalogNumber { get; set; }

    /* public int? StartingBid { get; set; }
     public int? EndingBid { get; set; }*/
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    /*public Guid? ListingId { get; set; }*/
    public Listing? Listing { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}

public class Bid {
    public Guid BidId { get; set; }
    public Guid ListingId { get; set; }
    public Listing Listing { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public int BidAmount { get; set; }
    public DateTime BidTime { get; set; }
}

public class Listing {
    public List<Bid>? Bids = new();
    public Guid ListingId { get; set; }
    public Guid UserId { get; set; }
    public Guid StampId { get; set; }
    public User User { get; set; }
    public Stamp Stamp { get; set; }
    public Guid? BidId { get; set; }
}