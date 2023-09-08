namespace Trilinguo
{
    partial class FrmConfig
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
            gpbL = new GroupBox();
            rdbJ = new RadioButton();
            rdbI = new RadioButton();
            gpbD = new GroupBox();
            rdbD = new RadioButton();
            rdbM = new RadioButton();
            rdbF = new RadioButton();
            gpbL.SuspendLayout();
            gpbD.SuspendLayout();
            SuspendLayout();
            // 
            // gpbL
            // 
            gpbL.Controls.Add(rdbJ);
            gpbL.Controls.Add(rdbI);
            gpbL.Location = new Point(27, 37);
            gpbL.Name = "gpbL";
            gpbL.Size = new Size(200, 100);
            gpbL.TabIndex = 0;
            gpbL.TabStop = false;
            gpbL.Text = "Selecione a linguagem";
            // 
            // rdbJ
            // 
            rdbJ.AutoSize = true;
            rdbJ.Location = new Point(108, 47);
            rdbJ.Name = "rdbJ";
            rdbJ.Size = new Size(64, 19);
            rdbJ.TabIndex = 1;
            rdbJ.Text = "Italiano";
            rdbJ.UseVisualStyleBackColor = true;
            rdbJ.CheckedChanged += rdbJ_CheckedChanged;
            // 
            // rdbI
            // 
            rdbI.AutoSize = true;
            rdbI.Location = new Point(28, 47);
            rdbI.Name = "rdbI";
            rdbI.Size = new Size(56, 19);
            rdbI.TabIndex = 0;
            rdbI.Text = "Inglês";
            rdbI.UseVisualStyleBackColor = true;
            rdbI.CheckedChanged += rdbI_CheckedChanged;
            // 
            // gpbD
            // 
            gpbD.Controls.Add(rdbD);
            gpbD.Controls.Add(rdbM);
            gpbD.Controls.Add(rdbF);
            gpbD.Location = new Point(27, 170);
            gpbD.Name = "gpbD";
            gpbD.Size = new Size(200, 100);
            gpbD.TabIndex = 1;
            gpbD.TabStop = false;
            gpbD.Text = "Selecione a dificuldade";
            // 
            // rdbD
            // 
            rdbD.AutoSize = true;
            rdbD.Location = new Point(135, 50);
            rdbD.Name = "rdbD";
            rdbD.Size = new Size(55, 19);
            rdbD.TabIndex = 2;
            rdbD.Text = "Díficil";
            rdbD.UseVisualStyleBackColor = true;
            rdbD.CheckedChanged += rdbD_CheckedChanged;
            // 
            // rdbM
            // 
            rdbM.AutoSize = true;
            rdbM.Location = new Point(70, 50);
            rdbM.Name = "rdbM";
            rdbM.Size = new Size(59, 19);
            rdbM.TabIndex = 1;
            rdbM.Text = "Médio";
            rdbM.UseVisualStyleBackColor = true;
            rdbM.CheckedChanged += rdbM_CheckedChanged;
            // 
            // rdbF
            // 
            rdbF.AutoSize = true;
            rdbF.Location = new Point(15, 50);
            rdbF.Name = "rdbF";
            rdbF.Size = new Size(49, 19);
            rdbF.TabIndex = 0;
            rdbF.Text = "Fácil";
            rdbF.UseVisualStyleBackColor = true;
            rdbF.CheckedChanged += rdbF_CheckedChanged;
            // 
            // FrmConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 303);
            Controls.Add(gpbD);
            Controls.Add(gpbL);
            Name = "FrmConfig";
            Text = "Form1";
            gpbL.ResumeLayout(false);
            gpbL.PerformLayout();
            gpbD.ResumeLayout(false);
            gpbD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbL;
        private RadioButton rdbJ;
        private RadioButton rdbI;
        private GroupBox gpbD;
        private RadioButton rdbD;
        private RadioButton rdbM;
        private RadioButton rdbF;
    }
}