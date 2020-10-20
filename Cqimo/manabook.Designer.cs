  namespace Cqimo
{
    partial class manabook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manabook));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.studentTableAdapter1 = new Cqimo.CqimoDataSetTableAdapters.studentTableAdapter();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(2, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel2.Text = "图书管理系统";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.iconButton7);
            this.panel1.Controls.Add(this.iconButton6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 84);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("华文楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(104, 45);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(136, 36);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 10;
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("华文楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(104, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(198, 36);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "Welcome,Manager:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 84);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.Black;
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton7.ForeColor = System.Drawing.Color.Black;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton7.IconColor = System.Drawing.Color.Red;
            this.iconButton7.IconSize = 50;
            this.iconButton7.Location = new System.Drawing.Point(743, 0);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Rotation = 0D;
            this.iconButton7.Size = new System.Drawing.Size(62, 84);
            this.iconButton7.TabIndex = 7;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(13)))));
            this.iconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton6.IconColor = System.Drawing.SystemColors.Highlight;
            this.iconButton6.IconSize = 30;
            this.iconButton6.Location = new System.Drawing.Point(650, 12);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Rotation = 0D;
            this.iconButton6.Size = new System.Drawing.Size(88, 39);
            this.iconButton6.TabIndex = 6;
            this.iconButton6.Text = "主页";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            this.iconButton6.MouseLeave += new System.EventHandler(this.iconButton6_MouseLeave);
            this.iconButton6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.iconButton6_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("宋体", 30F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(318, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "图书馆管理系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 109);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.uiSymbolButton1);
            this.panel2.Controls.Add(this.iconButton5);
            this.panel2.Controls.Add(this.iconButton4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 433);
            this.panel2.TabIndex = 3;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(6, 125);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(123, 35);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.TabIndex = 6;
            this.uiSymbolButton1.Text = "uiSymbolButton1";
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.White;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButton5.ForeColor = System.Drawing.Color.Black;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconSize = 35;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(3, 352);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(128, 39);
            this.iconButton5.TabIndex = 4;
            this.iconButton5.Text = "图书管理";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.White;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButton4.ForeColor = System.Drawing.Color.Black;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconSize = 35;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(2, 262);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(129, 39);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "图书管理";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.White;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButton3.ForeColor = System.Drawing.Color.Black;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(3, 307);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(128, 39);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "图书管理";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 217);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(131, 39);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "图书管理";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(4, 166);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(127, 45);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "读者管理";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            this.iconButton1.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            this.iconButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.iconButton1_MouseMove);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(134, 119);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 433);
            this.panel3.TabIndex = 4;
            this.panel3.SizeChanged += new System.EventHandler(this.panel3_SizeChanged);
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // manabook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(809, 576);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "manabook";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(13)))));
            this.ShowDragStretch = true;
            this.ShowIcon = true;
            this.ShowRadius = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "管理员界面";
            this.TitleForeColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.manabook_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private CqimoDataSetTableAdapters.studentTableAdapter studentTableAdapter1;
    }
}