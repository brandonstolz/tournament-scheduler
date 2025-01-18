namespace TournamentBuilder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListBoxTeams = new System.Windows.Forms.ListBox();
            this.TxtBoxTeam = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.CMSDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSOptionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMSDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxTeams
            // 
            this.ListBoxTeams.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxTeams.FormattingEnabled = true;
            this.ListBoxTeams.ItemHeight = 38;
            this.ListBoxTeams.Location = new System.Drawing.Point(202, 156);
            this.ListBoxTeams.Name = "ListBoxTeams";
            this.ListBoxTeams.Size = new System.Drawing.Size(556, 270);
            this.ListBoxTeams.TabIndex = 0;
            // 
            // TxtBoxTeam
            // 
            this.TxtBoxTeam.Location = new System.Drawing.Point(202, 452);
            this.TxtBoxTeam.Name = "TxtBoxTeam";
            this.TxtBoxTeam.Size = new System.Drawing.Size(443, 27);
            this.TxtBoxTeam.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(664, 450);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 29);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(397, 526);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(161, 61);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start Tournament";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // CMSDelete
            // 
            this.CMSDelete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMSOptionDelete});
            this.CMSDelete.Name = "CMSDelete";
            this.CMSDelete.Size = new System.Drawing.Size(163, 28);
            // 
            // CMSOptionDelete
            // 
            this.CMSOptionDelete.Name = "CMSOptionDelete";
            this.CMSOptionDelete.Size = new System.Drawing.Size(162, 24);
            this.CMSOptionDelete.Text = "Delete Team";
            this.CMSOptionDelete.Click += new System.EventHandler(this.CMSOptionDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(969, 621);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtBoxTeam);
            this.Controls.Add(this.ListBoxTeams);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.CMSDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ListBoxTeams;
        private TextBox TxtBoxTeam;
        private Button BtnAdd;
        private Button BtnStart;
        private ContextMenuStrip CMSDelete;
        private ToolStripMenuItem CMSOptionDelete;
        private PictureBox pictureBox1;
    }
}