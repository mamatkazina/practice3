
namespace практика3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.солнцеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sun = new System.Windows.Forms.ToolStripMenuItem();
            this.Mars = new System.Windows.Forms.ToolStripMenuItem();
            this.Saturn = new System.Windows.Forms.ToolStripMenuItem();
            this.Comet = new System.Windows.Forms.ToolStripMenuItem();
            this.Moon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.солнцеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // солнцеToolStripMenuItem
            // 
            this.солнцеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sun,
            this.Mars,
            this.Saturn,
            this.Comet,
            this.Moon});
            this.солнцеToolStripMenuItem.Name = "солнцеToolStripMenuItem";
            this.солнцеToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.солнцеToolStripMenuItem.Text = "Что сейчас на небосклоне?";
            // 
            // Sun
            // 
            this.Sun.Name = "Sun";
            this.Sun.Size = new System.Drawing.Size(180, 22);
            this.Sun.Text = "Солнце";
            this.Sun.Click += new System.EventHandler(this.Sun_Click);
            // 
            // Mars
            // 
            this.Mars.Name = "Mars";
            this.Mars.Size = new System.Drawing.Size(180, 22);
            this.Mars.Text = "Марс";
            this.Mars.Click += new System.EventHandler(this.Mars_Click);
            // 
            // Saturn
            // 
            this.Saturn.Name = "Saturn";
            this.Saturn.Size = new System.Drawing.Size(180, 22);
            this.Saturn.Text = "Сатурн";
            this.Saturn.Click += new System.EventHandler(this.Saturn_Click);
            // 
            // Comet
            // 
            this.Comet.Name = "Comet";
            this.Comet.Size = new System.Drawing.Size(180, 22);
            this.Comet.Text = "Комета";
            this.Comet.Click += new System.EventHandler(this.Comet_Click);
            // 
            // Moon
            // 
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(180, 22);
            this.Moon.Text = "Луна";
            this.Moon.Click += new System.EventHandler(this.Moon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(658, 411);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem солнцеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sun;
        private System.Windows.Forms.ToolStripMenuItem Mars;
        private System.Windows.Forms.ToolStripMenuItem Saturn;
        private System.Windows.Forms.ToolStripMenuItem Comet;
        private System.Windows.Forms.ToolStripMenuItem Moon;
    }
}

