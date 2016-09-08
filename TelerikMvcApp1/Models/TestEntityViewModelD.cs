using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelerikMvcApp1.Models
{
    public class TestEntityViewModelD
    {
        public int TestEntityId { get; set; }

        [StringLength(100)]
        public string TitleNotContains { get; set; }

        [StringLength(200)]
        public string ContentNotContains { get; set; }
    }
}