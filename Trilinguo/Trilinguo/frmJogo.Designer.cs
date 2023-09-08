namespace Trilinguo
{
    partial class frmJogo
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
            components = new System.ComponentModel.Container();
            btnJ = new Button();
            btnC = new Button();
            btnS = new Button();
            btnT = new Button();
            pictureBox2 = new PictureBox();
            lblQ = new Label();
            txtbR = new TextBox();
            lblF = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            pgb = new ProgressBar();
            ex = new Label();
            btnE = new Button();
            pictureBox3 = new PictureBox();
            btnR = new Button();
            btnM = new Button();
            timer3 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnJ
            // 
            btnJ.Location = new Point(540, 376);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(118, 36);
            btnJ.TabIndex = 0;
            btnJ.Text = "Jogar";
            btnJ.UseVisualStyleBackColor = true;
            btnJ.Click += button1_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(540, 418);
            btnC.Name = "btnC";
            btnC.Size = new Size(118, 36);
            btnC.TabIndex = 1;
            btnC.Text = "Configurações";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += button2_Click;
            // 
            // btnS
            // 
            btnS.Location = new Point(540, 502);
            btnS.Name = "btnS";
            btnS.Size = new Size(118, 36);
            btnS.TabIndex = 2;
            btnS.Text = "Sair";
            btnS.UseVisualStyleBackColor = true;
            btnS.Click += button3_Click;
            // 
            // btnT
            // 
            btnT.Location = new Point(540, 460);
            btnT.Name = "btnT";
            btnT.Size = new Size(118, 36);
            btnT.TabIndex = 3;
            btnT.Text = "Como jogar";
            btnT.UseVisualStyleBackColor = true;
            btnT.Click += btnT_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.trilingo;
            pictureBox2.Location = new Point(447, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(314, 271);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // lblQ
            // 
            lblQ.AutoSize = true;
            lblQ.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblQ.Location = new Point(463, 96);
            lblQ.Name = "lblQ";
            lblQ.Size = new Size(268, 40);
            lblQ.TabIndex = 5;
            lblQ.Text = "Traduza essa frase";
            lblQ.Visible = false;
            // 
            // txtbR
            // 
            txtbR.Location = new Point(420, 347);
            txtbR.Name = "txtbR";
            txtbR.Size = new Size(356, 23);
            txtbR.TabIndex = 6;
            txtbR.Visible = false;
            // 
            // lblF
            // 
            lblF.AutoSize = true;
            lblF.Location = new Point(582, 254);
            lblF.Name = "lblF";
            lblF.Size = new Size(34, 15);
            lblF.TabIndex = 7;
            lblF.Text = "Frase";
            lblF.Visible = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // pgb
            // 
            pgb.Dock = DockStyle.Bottom;
            pgb.Location = new Point(0, 668);
            pgb.Name = "pgb";
            pgb.Size = new Size(1264, 13);
            pgb.TabIndex = 8;
            pgb.Visible = false;
            // 
            // ex
            // 
            ex.AutoSize = true;
            ex.Location = new Point(1024, 78);
            ex.Name = "ex";
            ex.Size = new Size(38, 15);
            ex.TabIndex = 9;
            ex.Text = "label1";
            // 
            // btnE
            // 
            btnE.Location = new Point(540, 376);
            btnE.Name = "btnE";
            btnE.Size = new Size(118, 36);
            btnE.TabIndex = 10;
            btnE.Text = "Enviar";
            btnE.UseVisualStyleBackColor = true;
            btnE.Visible = false;
            btnE.Click += btnE_Click;
            btnE.KeyDown += btnE_KeyDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.duofeliz;
            pictureBox3.Location = new Point(497, 166);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 175);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // btnR
            // 
            btnR.Location = new Point(540, 418);
            btnR.Name = "btnR";
            btnR.Size = new Size(118, 36);
            btnR.TabIndex = 12;
            btnR.Text = "Tentar novamente";
            btnR.UseVisualStyleBackColor = true;
            btnR.Visible = false;
            btnR.Click += btnR_Click;
            // 
            // btnM
            // 
            btnM.Location = new Point(540, 460);
            btnM.Name = "btnM";
            btnM.Size = new Size(118, 36);
            btnM.TabIndex = 13;
            btnM.Text = "Menu";
            btnM.UseVisualStyleBackColor = true;
            btnM.Visible = false;
            btnM.Click += btnM_Click;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // frmJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox3);
            Controls.Add(ex);
            Controls.Add(pgb);
            Controls.Add(lblF);
            Controls.Add(txtbR);
            Controls.Add(lblQ);
            Controls.Add(pictureBox2);
            Controls.Add(btnT);
            Controls.Add(btnS);
            Controls.Add(btnC);
            Controls.Add(btnJ);
            Controls.Add(btnR);
            Controls.Add(btnE);
            Controls.Add(btnM);
            Name = "frmJogo";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJ;
        private Button btnC;
        private Button btnS;
        private Button btnT;
        private System.CodeDom.CodeTypeReference pictureBox1;
        private PictureBox pictureBox2;
        private Label lblQ;
        private TextBox txtbR;
        private Label lblF;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ProgressBar pgb;
        private Label ex;
        private Button btnE;
        private PictureBox pictureBox3;
        private Button btnR;
        private Button btnM;
        private System.Windows.Forms.Timer timer3;
    }
}