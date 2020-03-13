using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRProject.Models
{
    public class Keyboard
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string ShortDescription { get; set; }
        public string ImagePath { get; set; }
    }
}