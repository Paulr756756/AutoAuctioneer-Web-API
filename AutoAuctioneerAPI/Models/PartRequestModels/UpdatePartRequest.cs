﻿using Org.BouncyCastle.Asn1.Mozilla;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace API_AutoAuctioneer.Models.PartRequestModels;

public class UpdatePartRequest
{
    [Required]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public long? MarketPrice { get; set; }
    public int PartType { get; set; }
    public string? Category { get; set; }
    public string? Manufacturer { get; set; }

    [Required]
    public Guid UserId { get; set; }

    /*    //Engine
        public string? EngineType { get; set; }
        public double? Displacement { get; set; }
        public int? Horsepower { get; set; }
        public int? Torque { get; set; }

        //CustomizationPart



        //IndividualCarPart
        public string? CarMake { get; set; }
        public string? CarModel { get; set; }
        public string? Year { get; set; }*/
}