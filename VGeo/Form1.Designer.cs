namespace VGeo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbBR = new ListBox();
            lbUF = new ListBox();
            ofd1 = new OpenFileDialog();
            label2 = new Label();
            label3 = new Label();
            brnPOrocesss = new Button();
            tbLog = new TextBox();
            lbLog = new Label();
            tbKmEnd = new TextBox();
            tbKmBegin = new TextBox();
            btFile = new Button();
            lbkmBegin = new Label();
            lbKMEnd = new Label();
            progressBar = new ProgressBar();
            tbStatus = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            cbTipo = new ComboBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lbBR
            // 
            lbBR.FormattingEnabled = true;
            lbBR.ItemHeight = 15;
            lbBR.Location = new Point(105, 24);
            lbBR.Margin = new Padding(3, 2, 3, 2);
            lbBR.Name = "lbBR";
            lbBR.Size = new Size(82, 289);
            lbBR.TabIndex = 12;
            lbBR.SelectedIndexChanged += lbBR_SelectedIndexChanged;
            // 
            // lbUF
            // 
            lbUF.FormattingEnabled = true;
            lbUF.ItemHeight = 15;
            lbUF.Location = new Point(13, 26);
            lbUF.Margin = new Padding(3, 2, 3, 2);
            lbUF.Name = "lbUF";
            lbUF.Size = new Size(84, 289);
            lbUF.TabIndex = 13;
            lbUF.SelectedIndexChanged += lbUF_SelectedIndexChanged;
            // 
            // ofd1
            // 
            ofd1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(13, 9);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 18;
            label2.Text = "UF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(106, 9);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 19;
            label3.Text = "BR";
            // 
            // brnPOrocesss
            // 
            brnPOrocesss.BackColor = Color.DarkBlue;
            brnPOrocesss.Cursor = Cursors.Hand;
            brnPOrocesss.ForeColor = SystemColors.ButtonHighlight;
            brnPOrocesss.Location = new Point(757, 467);
            brnPOrocesss.Margin = new Padding(3, 2, 3, 2);
            brnPOrocesss.Name = "brnPOrocesss";
            brnPOrocesss.Size = new Size(130, 35);
            brnPOrocesss.TabIndex = 0;
            brnPOrocesss.Text = "Processar";
            brnPOrocesss.UseVisualStyleBackColor = false;
            brnPOrocesss.Click += brnPOrocesss_Click;
            // 
            // tbLog
            // 
            tbLog.Location = new Point(13, 70);
            tbLog.Margin = new Padding(3, 2, 3, 2);
            tbLog.Multiline = true;
            tbLog.Name = "tbLog";
            tbLog.ScrollBars = ScrollBars.Both;
            tbLog.Size = new Size(634, 202);
            tbLog.TabIndex = 1;
            // 
            // lbLog
            // 
            lbLog.AutoSize = true;
            lbLog.ForeColor = SystemColors.ControlDarkDark;
            lbLog.Location = new Point(13, 53);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(36, 15);
            lbLog.TabIndex = 2;
            lbLog.Text = "Log...";
            // 
            // tbKmEnd
            // 
            tbKmEnd.Location = new Point(205, 25);
            tbKmEnd.Margin = new Padding(3, 2, 3, 2);
            tbKmEnd.Name = "tbKmEnd";
            tbKmEnd.Size = new Size(54, 23);
            tbKmEnd.TabIndex = 4;
            tbKmEnd.Text = "490";
            // 
            // tbKmBegin
            // 
            tbKmBegin.Location = new Point(134, 26);
            tbKmBegin.Margin = new Padding(3, 2, 3, 2);
            tbKmBegin.Name = "tbKmBegin";
            tbKmBegin.Size = new Size(61, 23);
            tbKmBegin.TabIndex = 5;
            tbKmBegin.Text = "490";
            // 
            // btFile
            // 
            btFile.BackColor = Color.Black;
            btFile.Cursor = Cursors.Hand;
            btFile.ForeColor = SystemColors.Control;
            btFile.Location = new Point(660, 467);
            btFile.Margin = new Padding(3, 2, 3, 2);
            btFile.Name = "btFile";
            btFile.Size = new Size(82, 35);
            btFile.TabIndex = 14;
            btFile.Text = "Diretorio";
            btFile.UseVisualStyleBackColor = false;
            btFile.Visible = false;
            btFile.Click += btFile_Click;
            // 
            // lbkmBegin
            // 
            lbkmBegin.AutoSize = true;
            lbkmBegin.ForeColor = SystemColors.ControlDarkDark;
            lbkmBegin.Location = new Point(134, 7);
            lbkmBegin.Name = "lbkmBegin";
            lbkmBegin.Size = new Size(57, 15);
            lbkmBegin.TabIndex = 15;
            lbkmBegin.Text = "Km Inicio";
            // 
            // lbKMEnd
            // 
            lbKMEnd.AutoSize = true;
            lbKMEnd.ForeColor = SystemColors.ControlDarkDark;
            lbKMEnd.Location = new Point(204, 6);
            lbKMEnd.Name = "lbKMEnd";
            lbKMEnd.Size = new Size(51, 15);
            lbKMEnd.TabIndex = 16;
            lbKMEnd.Text = "Km Fiim";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(721, 88);
            progressBar.Margin = new Padding(3, 2, 3, 2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(144, 22);
            progressBar.TabIndex = 20;
            // 
            // tbStatus
            // 
            tbStatus.Font = new Font("Segoe UI", 7F);
            tbStatus.Location = new Point(13, 277);
            tbStatus.Margin = new Padding(3, 2, 3, 2);
            tbStatus.Multiline = true;
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(634, 35);
            tbStatus.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 8);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(98, 32);
            label4.Name = "label4";
            label4.Size = new Size(176, 30);
            label4.TabIndex = 24;
            label4.Text = "Service GetVGeo";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(100, 68);
            label5.Name = "label5";
            label5.Size = new Size(213, 15);
            label5.TabIndex = 25;
            label5.Text = "Percorre dados API VGeo e Exporta xlsx";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(22, 3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 112);
            panel1.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(845, 7);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(13, 24);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(98, 23);
            cbTipo.TabIndex = 27;
            cbTipo.SelectedIndexChanged += cbTipo_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(lbBR);
            panel2.Controls.Add(lbUF);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(22, 119);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 326);
            panel2.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AntiqueWhite;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cbTipo);
            panel3.Controls.Add(tbLog);
            panel3.Controls.Add(tbStatus);
            panel3.Controls.Add(lbLog);
            panel3.Controls.Add(tbKmEnd);
            panel3.Controls.Add(lbKMEnd);
            panel3.Controls.Add(tbKmBegin);
            panel3.Controls.Add(lbkmBegin);
            panel3.Location = new Point(224, 119);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(663, 326);
            panel3.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 28;
            label1.Text = "Tipo de Trecho";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(911, 513);
            Controls.Add(panel3);
            Controls.Add(brnPOrocesss);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btFile);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service - VGeo ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox lbBR;
        private ListBox lbUF;
        private OpenFileDialog ofd1;
        private Label label2;
        private Label label3;
        private Button brnPOrocesss;
        private TextBox tbLog;
        private Label lbLog;
        private TextBox tbKmEnd;
        private TextBox tbKmBegin;
        private Button btFile;
        private Label lbkmBegin;
        private Label lbKMEnd;
        private ProgressBar progressBar;
        private TextBox tbStatus;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private ComboBox cbTipo;
        private Label label1;
    }
}
