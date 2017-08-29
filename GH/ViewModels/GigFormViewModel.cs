using GH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GH.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        //This is going to be a dropd down list so we need a numeric value this is the Id from gig models
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}