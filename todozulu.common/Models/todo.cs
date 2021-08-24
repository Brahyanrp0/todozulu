using System;
using System.Collections.Generic;
using System.Text;

namespace todozulu.common.Models
{
    public class todo
    {

        public DateTime CreatedTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }
    }
}
