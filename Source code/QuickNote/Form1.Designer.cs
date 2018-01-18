namespace QuickNote
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txb_InputTag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_InputNote = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.NFI_F1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CMS_F1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Save = new System.Windows.Forms.Button();
            this.ERP_InputTag = new System.Windows.Forms.ErrorProvider(this.components);
            this.CMS_F1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ERP_InputTag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Tag (Seperated by commas: \",\")";
            // 
            // txb_InputTag
            // 
            this.txb_InputTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_InputTag.Location = new System.Drawing.Point(44, 52);
            this.txb_InputTag.Name = "txb_InputTag";
            this.txb_InputTag.Size = new System.Drawing.Size(713, 27);
            this.txb_InputTag.TabIndex = 1;
            this.txb_InputTag.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(40, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 24);
            this.label2.TabIndex = 2;
            this.label2.Tag = "";
            this.label2.Text = "Note (Maximum 2000 characters)";
            // 
            // txb_InputNote
            // 
            this.txb_InputNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_InputNote.Location = new System.Drawing.Point(44, 146);
            this.txb_InputNote.Multiline = true;
            this.txb_InputNote.Name = "txb_InputNote";
            this.txb_InputNote.Size = new System.Drawing.Size(892, 545);
            this.txb_InputNote.TabIndex = 3;
            this.txb_InputNote.Tag = "";
            // 
            // NFI_F1
            // 
            this.NFI_F1.ContextMenuStrip = this.CMS_F1;
            this.NFI_F1.Icon = ((System.Drawing.Icon)(resources.GetObject("NFI_F1.Icon")));
            this.NFI_F1.Text = "notifyIcon1";
            this.NFI_F1.Visible = true;
            this.NFI_F1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NFI_F1_MouseDoubleClick);
            // 
            // CMS_F1
            // 
            this.CMS_F1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_F1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4});
            this.CMS_F1.Name = "CMS_F1";
            this.CMS_F1.Size = new System.Drawing.Size(171, 82);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 24);
            this.toolStripMenuItem2.Text = "View notes";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(170, 24);
            this.toolStripMenuItem3.Text = "View statistics";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(170, 24);
            this.toolStripMenuItem4.Text = "Exit";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.toolStripMenuItem1.Text = "Exit";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Save.Location = new System.Drawing.Point(763, 52);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(173, 71);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save Note";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ERP_InputTag
            // 
            this.ERP_InputTag.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(985, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txb_InputNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_InputTag);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Quick Note";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.CMS_F1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ERP_InputTag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_InputTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_InputNote;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        public System.Windows.Forms.NotifyIcon NFI_F1;
        protected System.Windows.Forms.ContextMenuStrip CMS_F1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ErrorProvider ERP_InputTag;
    }
}

