using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelerikMvcApp1.Models
{
    public class TestEntityViewModelC
    {
        public int TestEntityId { get; set; }

        [StringLength(100)]
        public string TitleContains { get; set; }

        [StringLength(200)]
        public string ContentContains { get; set; }
    }
}