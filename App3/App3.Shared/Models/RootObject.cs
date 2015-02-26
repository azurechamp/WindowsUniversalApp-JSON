using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    public class LatestNew
    {
        public string News_thumb { get; set; }
        public string News_title { get; set; }
        public string News_link { get; set; }
    }

    public class RootObject
    {
        public List<LatestNew> LatestNews { get; set; }
    }
}
