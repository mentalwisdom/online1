//4.Create Business Data model
using System.ComponentModel.DataAnnotations;

namespace online1.Models{
    public class Product{
        [Key]
        public int id {get;set;}
        public string name{get;set;}
        public double price{get;set;}
        public int qty {get;set;}
    }
}