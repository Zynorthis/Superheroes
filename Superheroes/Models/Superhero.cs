using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superheroes.Models
{
    public class Superhero
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name="Alter Ego")]
        public string alterEgo { get; set; }
        [Display(Name = "Primary Ability")]
        public string primaryAbility { get; set; }
        [Display(Name = "Secondary Ability")]
        public string secondaryAbility { get; set; }
        [Display(Name = "Catchphrase")]
        public string catchphrase { get; set; }
    }
}