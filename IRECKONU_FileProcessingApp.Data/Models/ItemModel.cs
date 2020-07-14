using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IRECKONU_FileProcessingApp.Data.Models
{
    public class ItemModel
    {
        public int Id { get; set; }

        public string Key { get; set; }

        public string ArtikelCode { get; set; }
        public string ColorCode { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string DiscountPrice { get; set; }
        public string DeliveredIn { get; set; }
        public string Q1 { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
    }
}