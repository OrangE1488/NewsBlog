﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace NewsBlog.Models
{
    public class BlogItem
    {
        [Key]
        public int NewsId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public byte[] Image { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

        public BlogItem()
        {
            Tags = new List<Tag>();
        }

    }
}