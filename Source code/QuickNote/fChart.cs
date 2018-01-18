using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickNote
{
    public partial class fChart : Form
    {
        List<Tag> TagList = new List<Tag>();

        public fChart(List<Tag> TagList)
        {
            this.TagList = TagList;
            InitializeComponent();

        }

        public List<Tag> TagList1 { get => TagList; set => TagList = value; }


        private void fChart_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < TagList.Count; i++)
            {
                chart1.Series["Tags"].Points.AddXY(TagList[i].Tags, TagList[i].Count);
            }


        }
    }
}
