namespace proyecto_progra
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            TitleBar = new Panel();
            btnRest = new PictureBox();
            btnMin = new PictureBox();
            btnMax = new PictureBox();
            btnClose = new PictureBox();
            VerticalMenu = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            ContentPanel = new Panel();
            button2 = new Button();
            button3 = new Button();
            TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            VerticalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TitleBar
            // 
            TitleBar.BackColor = Color.FromArgb(255, 128, 0);
            TitleBar.Controls.Add(btnRest);
            TitleBar.Controls.Add(btnMin);
            TitleBar.Controls.Add(btnMax);
            TitleBar.Controls.Add(btnClose);
            TitleBar.Dock = DockStyle.Top;
            TitleBar.Location = new Point(0, 0);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(1300, 35);
            TitleBar.TabIndex = 0;
            // 
            // btnRest
            // 
            btnRest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRest.Cursor = Cursors.Hand;
            btnRest.Image = (Image)resources.GetObject("btnRest.Image");
            btnRest.Location = new Point(1214, 2);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(35, 31);
            btnRest.SizeMode = PictureBoxSizeMode.Zoom;
            btnRest.TabIndex = 0;
            btnRest.TabStop = false;
            btnRest.Visible = false;
            btnRest.Click += btnRest_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.Cursor = Cursors.Hand;
            btnMin.Image = Properties.Resources.icons8_minimize_50;
            btnMin.Location = new Point(1173, 2);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(35, 31);
            btnMin.SizeMode = PictureBoxSizeMode.Zoom;
            btnMin.TabIndex = 2;
            btnMin.TabStop = false;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(1214, 2);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(35, 31);
            btnMax.SizeMode = PictureBoxSizeMode.Zoom;
            btnMax.TabIndex = 1;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1255, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 31);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // VerticalMenu
            // 
            VerticalMenu.BackColor = Color.FromArgb(64, 64, 64);
            VerticalMenu.Controls.Add(button3);
            VerticalMenu.Controls.Add(button2);
            VerticalMenu.Controls.Add(label1);
            VerticalMenu.Controls.Add(pictureBox2);
            VerticalMenu.Controls.Add(button1);
            VerticalMenu.Controls.Add(btnRegister);
            VerticalMenu.Controls.Add(pictureBox1);
            VerticalMenu.Dock = DockStyle.Left;
            VerticalMenu.Location = new Point(0, 35);
            VerticalMenu.Name = "VerticalMenu";
            VerticalMenu.Size = new Size(220, 615);
            VerticalMenu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 158);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(12, 304);
            button1.Name = "button1";
            button1.Size = new Size(172, 36);
            button1.TabIndex = 2;
            button1.Text = "Progreso";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Location = new Point(12, 239);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(172, 37);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Nueva Marca";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ContentPanel
            // 
            ContentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ContentPanel.BackColor = Color.FromArgb(255, 224, 192);
            ContentPanel.Location = new Point(220, 35);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1080, 615);
            ContentPanel.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(12, 368);
            button2.Name = "button2";
            button2.Size = new Size(172, 36);
            button2.TabIndex = 4;
            button2.Text = "Progreso";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.Location = new Point(12, 432);
            button3.Name = "button3";
            button3.Size = new Size(172, 36);
            button3.TabIndex = 5;
            button3.Text = "Progreso";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(ContentPanel);
            Controls.Add(VerticalMenu);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRest).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            VerticalMenu.ResumeLayout(false);
            VerticalMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TitleBar;
        private Panel VerticalMenu;
        private Panel ContentPanel;
        private PictureBox btnClose;
        private PictureBox btnMax;
        private PictureBox btnMin;
        private PictureBox btnRest;
        private PictureBox pictureBox1;
        private Button btnRegister;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button2;
    }
}
