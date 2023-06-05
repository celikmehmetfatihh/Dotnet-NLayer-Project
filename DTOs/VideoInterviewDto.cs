﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class VideoInterviewDto:BaseDto
    {
        public DateTime? date { get; set; }
        public int size { get; set; }
        public String? format { get; set; }

        public int UserId { get; set; } //foreign key 

        public String? path { get; set; }
    }
}
