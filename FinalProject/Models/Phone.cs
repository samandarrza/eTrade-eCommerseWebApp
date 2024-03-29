﻿using FinalProject.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Phone
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        public bool StockStatus { get; set; }
        public bool IsNew { get; set; }
        public bool MostPopular { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal SalePrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountPercent { get; set; }
        public int BatteryId { get; set; }
        public int ColorId { get; set; }
        public int DisplayId { get; set; }
        public int MemoryId { get; set; }
        public int PhoneModelId { get; set; }
        public int ProcessorNameId { get; set; }
        public int RAMId { get; set; }
        public int PhoneSystemId { get; set; }
        public int? PhoneTagId { get; set; }
        public byte AvgRate { get; set; }
        public Battery? Battery { get; set; }
        public Color? Color { get; set; }
        public Display? Display { get; set; }
        public Memory? Memory { get; set; }
        public PhoneModel? PhoneModel { get; set; }
        public PhoneTag? PhoneTag { get; set; }
        public ProcessorName? ProcessorName { get; set; }
        public RAM? RAM { get; set; }
        public PhoneSystem? PhoneSystem { get; set; }
        public List<Review>? Reviews { get; set; }

        public List<PhoneImage>? PhoneImages { get; set; }
        [NotMapped]
        public List<int>? PhoneImageIds { get; set; } = new List<int>();

        [NotMapped]
        [MaxFileSize(2048)]
        [AllowedFileTypes("image/jpeg", "image/png")]
        public IFormFile? PosterFile { get; set; }

        [NotMapped]
        [MaxFileSize(2048)]
        [AllowedFileTypes("image/jpeg", "image/png")]
        public IFormFile? HoverPosterFile { get; set; }

        [NotMapped]
        [MaxFileSize(2048)]
        [AllowedFileTypes("image/jpeg", "image/png")]
        public List<IFormFile>? ImageFiles { get; set; }
    }
}
