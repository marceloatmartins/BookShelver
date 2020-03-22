using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShelver.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearEdition { get; set; }
        public decimal Value { get; set; }
        public string Author { get; set; }


        public Genero Genero { get; set; }
        public int GeneroId { get; set; }   
    
    }
}