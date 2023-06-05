using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class VideoInterview:Base
    {
        public DateTime? date { get; set; }
        public int? size { get; set; }
        public String? format { get; set; }

        public int UserId { get; set; } //foreign key 
        public User User { get; set; }
        public Score Score { get; set; }

        public String? path { get; set; }
    }
}
