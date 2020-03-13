using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IRProject.Models
{
    public class ViewModelAllItems
    {

        [Key]
        public int ID { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public IEnumerable<Keyboard> Keyboards { get; set; }
    }
}