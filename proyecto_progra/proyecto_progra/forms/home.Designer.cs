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
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            BtnProgreso = new Button();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            ContentPanel = new Panel();
            BtnGrafico = new Button();
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
            TitleBar.Margin = new Padding(3, 4, 3, 4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(1486, 47);
            TitleBar.TabIndex = 0;
            // 
            // btnRest
            // 
            btnRest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRest.Cursor = Cursors.Hand;
            btnRest.Image = (Image)resources.GetObject("btnRest.Image");
            btnRest.Location = new Point(1387, 3);
            btnRest.Margin = new Padding(3, 4, 3, 4);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(40, 41);
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
            btnMin.Location = new Point(1341, 3);
            btnMin.Margin = new Padding(3, 4, 3, 4);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(40, 41);
            btnMin.SizeMode = PictureBoxSizeMode.Zoom;
            btnMin.TabIndex = 2;
            btnMin.TabStop = false;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(1387, 3);
            btnMax.Margin = new Padding(3, 4, 3, 4);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(40, 41);
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
            btnClose.Location = new Point(1434, 3);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 41);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // VerticalMenu
            // 
            VerticalMenu.BackColor = Color.FromArgb(64, 64, 64);
            VerticalMenu.Controls.Add(BtnGrafico);
            VerticalMenu.Controls.Add(button3);
            VerticalMenu.Controls.Add(button2);
            VerticalMenu.Controls.Add(label1);
            VerticalMenu.Controls.Add(pictureBox2);
            VerticalMenu.Controls.Add(BtnProgreso);
            VerticalMenu.Controls.Add(btnRegister);
            VerticalMenu.Controls.Add(pictureBox1);
            VerticalMenu.Dock = DockStyle.Left;
            VerticalMenu.Location = new Point(0, 47);
            VerticalMenu.Margin = new Padding(3, 4, 3, 4);
            VerticalMenu.Name = "VerticalMenu";
            VerticalMenu.Size = new Size(251, 820);
            VerticalMenu.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.Location = new Point(14, 576);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(197, 48);
            button3.TabIndex = 5;
            button3.Text = "Progreso";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(14, 491);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(197, 48);
            button2.TabIndex = 4;
            button2.Text = "Progreso";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 211);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 196);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // BtnProgreso
            // 
            BtnProgreso.BackColor = Color.DimGray;
            BtnProgreso.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            BtnProgreso.FlatAppearance.BorderSize = 0;
            BtnProgreso.Location = new Point(14, 341);
            BtnProgreso.Margin = new Padding(3, 4, 3, 4);
            BtnProgreso.Name = "BtnProgreso";
            BtnProgreso.Size = new Size(197, 48);
            BtnProgreso.TabIndex = 2;
            BtnProgreso.Text = "Progreso";
            BtnProgreso.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Location = new Point(14, 284);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(197, 49);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Nueva Marca";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ContentPanel
            // 
            ContentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ContentPanel.BackColor = Color.FromArgb(255, 224, 192);
            ContentPanel.Location = new Point(251, 47);
            ContentPanel.Margin = new Padding(3, 4, 3, 4);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1234, 820);
            ContentPanel.TabIndex = 2;
            // 
            // BtnGrafico
            // 
            BtnGrafico.BackColor = Color.Transparent;
            BtnGrafico.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            BtnGrafico.FlatAppearance.BorderSize = 0;
            BtnGrafico.Location = new Point(14, 397);
            BtnGrafico.Margin = new Padding(3, 4, 3, 4);
            BtnGrafico.Name = "BtnGrafico";
            BtnGrafico.Size = new Size(197, 49);
            BtnGrafico.TabIndex = 6;
            BtnGrafico.Text = "Grafico";
            BtnGrafico.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 867);
            Controls.Add(ContentPanel);
            Controls.Add(VerticalMenu);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "home";
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
        private Button BtnProgreso;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button2;
        private Button btnRegister;
        private Button BtnGrafico;
    }
}
