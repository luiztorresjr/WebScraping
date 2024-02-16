﻿using MongoDB.Bson.Serialization.Attributes;

namespace WebScraping.Infra.Models
{
    public class ProductModel
    {
        public string Id { get; set; }
        public long Code { get; set; }

        public string Barcode { get; set; } = String.Empty;

        public string Status { get; set; } = String.Empty;

        public DateTime Imported { get; set; }

        public string Url { get; set; } = String.Empty;
        
        public string ProductName { get; set; } = String.Empty;
        
        public string Quantity { get; set; } = String.Empty;
        
        public string Categories { get; set; } = String.Empty;
        
        public string Packaging { get; set; } = String.Empty;

        public string Brands { get; set; } = String.Empty;
        
        public string ImageUrl { get; set; } = String.Empty;
    }
}