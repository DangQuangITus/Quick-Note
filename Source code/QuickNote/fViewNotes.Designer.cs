namespace QuickNote
{
    partial class fViewNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fViewNotes));
            this.lbx_tags = new System.Windows.Forms.ListBox();
            this.lbx_NoteTitle = new System.Windows.Forms.ListBox();
            this.txb_NoteContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_tags
            // 
            this.lbx_tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbx_tags.FormattingEnabled = true;
            this.lbx_tags.ItemHeight = 22;
            this.lbx_tags.Location = new System.Drawing.Point(12, 44);
            this.lbx_tags.Name = "lbx_tags";
            this.lbx_tags.Size = new System.Drawing.Size(147, 532);
            this.lbx_tags.TabIndex = 0;
            this.lbx_tags.SelectedIndexChanged += new System.EventHandler(this.lbx_tags_SelectedIndexChanged);
            // 
            // lbx_NoteTitle
            // 
            this.lbx_NoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbx_NoteTitle.FormattingEnabled = true;
            this.lbx_NoteTitle.ItemHeight = 22;
            this.lbx_NoteTitle.Location = new System.Drawing.Point(165, 44);
            this.lbx_NoteTitle.Name = "lbx_NoteTitle";
            this.lbx_NoteTitle.Size = new System.Drawing.Size(352, 532);
            this.lbx_NoteTitle.TabIndex = 1;
            this.lbx_NoteTitle.SelectedIndexChanged += new System.EventHandler(this.lbx_NoteTitle_SelectedIndexChanged);
            // 
            // txb_NoteContent
            // 
            this.txb_NoteContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_NoteContent.Location = new System.Drawing.Point(523, 44);
            this.txb_NoteContent.Multiline = true;
            this.txb_NoteContent.Name = "txb_NoteContent";
            this.txb_NoteContent.Size = new System.Drawing.Size(640, 532);
            this.txb_NoteContent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Notes Brief";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(528, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note Content";
            // 
            // fViewNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1175, 589);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_NoteContent);
            this.Controls.Add(this.lbx_NoteTitle);
            this.Controls.Add(this.lbx_tags);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fViewNotes";
            this.Text = "View Notes";
            this.Load += new System.EventHandler(this.fViewNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_tags;
        protected System.Windows.Forms.ListBox lbx_NoteTitle;
        public System.Windows.Forms.TextBox txb_NoteContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}