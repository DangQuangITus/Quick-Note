using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickNote
{
    public class ContentNotes
    {
        string content;
        string brief;
        List<string> tag = new List<string>();

        public string Content { get => content; set => content = value; }
        public List<string> Tag { get => tag; set => tag = value; }
        public string Brief { get => brief; set => brief = value; }

        public ContentNotes(string notes, List<string> tags)
        {

            if (notes.Length > 41)
            {
                Brief = notes.Substring(0, 39);
            }
            else
            {
                Brief = notes;
            }
            this.content = notes;
            this.Tag = tags;
        }
    }
}
