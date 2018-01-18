using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickNote
{
    public class Tag
    {
        string tags;
        int count = 0;

        public string Tags { get => tags; set => tags = value; }
        public int Count { get => count; set => count = value; }

        public Tag(string tag,int count)
        {
            this.tags = tag;
            this.count = count;
        }
        

    }
}
