﻿using System;
using System.Collections.Generic;

namespace Notes.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        
    }
}