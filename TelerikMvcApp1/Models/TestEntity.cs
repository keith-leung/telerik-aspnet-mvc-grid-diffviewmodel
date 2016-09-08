using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelerikMvcApp1.Models
{
    public class TestEntity
    {
        public int TestEntityId { get; set; }
        
        public EntityType Type { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public string Content { get; set; }
    }

    public enum EntityType
    {
        A,
        B,
        C,
        D,
    }
}