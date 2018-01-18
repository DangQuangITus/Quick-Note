using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickNote
{
    public partial class fViewNotes : Form
    {
        List<Tag> tagsList = new List<Tag>();
        List<ContentNotes> NotesList = new List<ContentNotes>();

        public fViewNotes(List<Tag> tags, List<ContentNotes> NotesCont)
        {
            this.tagsList = tags;
            this.NotesList = NotesCont;
            InitializeComponent();
        }


        private void fViewNotes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tagsList.Count; i++)
            {
                lbx_tags.Items.Add(String.Format("{0} ({1})", tagsList[i].Tags, tagsList[i].Count));
            }
        }

        public void LoadTags(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string[] line = File.ReadAllLines(path);
                    foreach (var item in line)
                    {
                        lbx_tags.Items.Add(item);
                    }
                }
            }
            catch
            {

            }
        }

        private void lbx_tags_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbx_NoteTitle.Items.Clear();
            string tag = lbx_tags.GetItemText(lbx_tags.SelectedItem);
            int i = tag.LastIndexOf('(');
            string t = tag.Substring(0, i).Trim();
            for (int k = 0; k < NotesList.Count; k++)
            {
                if (NotesList[k].Tag.Contains(t) == true)
                {
                    lbx_NoteTitle.Items.Add(NotesList[k]);
                    lbx_NoteTitle.DisplayMember = "brief";
                }
            }

        }

        private void lbx_NoteTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = lbx_NoteTitle.SelectedItem;
            ContentNotes l = (ContentNotes)t;
            txb_NoteContent.Text = l.Content;
        }
    }
}
