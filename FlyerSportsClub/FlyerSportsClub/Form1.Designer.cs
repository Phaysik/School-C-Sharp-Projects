namespace FlyerSportsClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySelectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.checkEarmuffs = new System.Windows.Forms.CheckBox();
            this.checkGoggles = new System.Windows.Forms.CheckBox();
            this.checkBindings = new System.Windows.Forms.CheckBox();
            this.checkBoots = new System.Windows.Forms.CheckBox();
            this.checkSkis = new System.Windows.Forms.CheckBox();
            this.checkPoles = new System.Windows.Forms.CheckBox();
            this.checkGloves = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaySelectionsToolStripMenuItem,
            this.clearSelectionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // displaySelectionsToolStripMenuItem
            // 
            this.displaySelectionsToolStripMenuItem.Name = "displaySelectionsToolStripMenuItem";
            this.displaySelectionsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.displaySelectionsToolStripMenuItem.Text = "Display Selections";
            this.displaySelectionsToolStripMenuItem.Click += new System.EventHandler(this.displaySelectionsToolStripMenuItem_Click);
            // 
            // clearSelectionsToolStripMenuItem
            // 
            this.clearSelectionsToolStripMenuItem.Name = "clearSelectionsToolStripMenuItem";
            this.clearSelectionsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clearSelectionsToolStripMenuItem.Text = "Clear Selections";
            this.clearSelectionsToolStripMenuItem.Click += new System.EventHandler(this.clearSelectionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "What equipment do you need?";
            // 
            // checkEarmuffs
            // 
            this.checkEarmuffs.AutoSize = true;
            this.checkEarmuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEarmuffs.Location = new System.Drawing.Point(38, 72);
            this.checkEarmuffs.Name = "checkEarmuffs";
            this.checkEarmuffs.Size = new System.Drawing.Size(102, 28);
            this.checkEarmuffs.TabIndex = 2;
            this.checkEarmuffs.Text = "Earmuffs";
            this.checkEarmuffs.UseVisualStyleBackColor = true;
            // 
            // checkGoggles
            // 
            this.checkGoggles.AutoSize = true;
            this.checkGoggles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGoggles.Location = new System.Drawing.Point(38, 106);
            this.checkGoggles.Name = "checkGoggles";
            this.checkGoggles.Size = new System.Drawing.Size(100, 28);
            this.checkGoggles.TabIndex = 3;
            this.checkGoggles.Text = "Goggles";
            this.checkGoggles.UseVisualStyleBackColor = true;
            // 
            // checkBindings
            // 
            this.checkBindings.AutoSize = true;
            this.checkBindings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBindings.Location = new System.Drawing.Point(38, 140);
            this.checkBindings.Name = "checkBindings";
            this.checkBindings.Size = new System.Drawing.Size(132, 28);
            this.checkBindings.TabIndex = 4;
            this.checkBindings.Text = "Ski Bindings";
            this.checkBindings.UseVisualStyleBackColor = true;
            // 
            // checkBoots
            // 
            this.checkBoots.AutoSize = true;
            this.checkBoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoots.Location = new System.Drawing.Point(38, 174);
            this.checkBoots.Name = "checkBoots";
            this.checkBoots.Size = new System.Drawing.Size(106, 28);
            this.checkBoots.TabIndex = 5;
            this.checkBoots.Text = "Ski Boots";
            this.checkBoots.UseVisualStyleBackColor = true;
            // 
            // checkSkis
            // 
            this.checkSkis.AutoSize = true;
            this.checkSkis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSkis.Location = new System.Drawing.Point(38, 208);
            this.checkSkis.Name = "checkSkis";
            this.checkSkis.Size = new System.Drawing.Size(63, 28);
            this.checkSkis.TabIndex = 6;
            this.checkSkis.Text = "Skis";
            this.checkSkis.UseVisualStyleBackColor = true;
            // 
            // checkPoles
            // 
            this.checkPoles.AutoSize = true;
            this.checkPoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPoles.Location = new System.Drawing.Point(38, 242);
            this.checkPoles.Name = "checkPoles";
            this.checkPoles.Size = new System.Drawing.Size(106, 28);
            this.checkPoles.TabIndex = 7;
            this.checkPoles.Text = "Ski Poles";
            this.checkPoles.UseVisualStyleBackColor = true;
            // 
            // checkGloves
            // 
            this.checkGloves.AutoSize = true;
            this.checkGloves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGloves.Location = new System.Drawing.Point(38, 276);
            this.checkGloves.Name = "checkGloves";
            this.checkGloves.Size = new System.Drawing.Size(140, 28);
            this.checkGloves.TabIndex = 8;
            this.checkGloves.Text = "Snow Gloves";
            this.checkGloves.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkGloves);
            this.Controls.Add(this.checkPoles);
            this.Controls.Add(this.checkSkis);
            this.Controls.Add(this.checkBoots);
            this.Controls.Add(this.checkBindings);
            this.Controls.Add(this.checkGoggles);
            this.Controls.Add(this.checkEarmuffs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySelectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkEarmuffs;
        private System.Windows.Forms.CheckBox checkGoggles;
        private System.Windows.Forms.CheckBox checkBindings;
        private System.Windows.Forms.CheckBox checkBoots;
        private System.Windows.Forms.CheckBox checkSkis;
        private System.Windows.Forms.CheckBox checkPoles;
        private System.Windows.Forms.CheckBox checkGloves;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

