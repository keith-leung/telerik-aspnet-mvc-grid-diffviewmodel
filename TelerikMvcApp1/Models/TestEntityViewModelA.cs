using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelerikMvcApp1.Models
{
    public class TestEntityViewModelA
    {
        public int TestEntityId { get; set; } 

        [StringLength(100)]
        public string TitleStartWith { get; set; }

        [StringLength(200)]
        public string ContentStartWith { get; set; }
    }
}