
namespace Calculator_113
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
            this.b7 = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bdevide = new System.Windows.Forms.Button();
            this.bmulti = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.bminus = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.bplus = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bCe = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bEq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.b7.Location = new System.Drawing.Point(57, 141);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(84, 49);
            this.b7.TabIndex = 0;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.NumEvent);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(54, 53);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 17);
            this.lbResult.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(57, 73);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(444, 51);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "0";
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.b8.Location = new System.Drawing.Point(147, 141);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(84, 49);
            this.b8.TabIndex = 3;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.NumEvent);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.b9.Location = new System.Drawing.Point(237, 141);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(84, 49);
            this.b9.TabIndex = 4;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.NumEvent);
            // 
            // bdevide
            // 
            this.bdevide.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bdevide.Location = new System.Drawing.Point(327, 141);
            this.bdevide.Name = "bdevide";
            this.bdevide.Size = new System.Drawing.Size(84, 49);
            this.bdevide.TabIndex = 5;
            this.bdevide.Text = "/";
            this.bdevide.UseVisualStyleBackColor = false;
            this.bdevide.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bmulti
            // 
            this.bmulti.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bmulti.Location = new System.Drawing.Point(327, 196);
            this.bmulti.Name = "bmulti";
            this.bmulti.Size = new System.Drawing.Size(84, 49);
            this.bmulti.TabIndex = 9;
            this.bmulti.Text = "*";
            this.bmulti.UseVisualStyleBackColor = false;
            this.bmulti.Click += new System.EventHandler(this.OperandEvent);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.b6.Location = new System.Drawing.Point(237, 196);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(84, 49);
            this.b6.TabIndex = 8;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.NumEvent);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.b5.Location = new System.Drawing.Point(147, 196);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(84, 49);
            this.b5.TabIndex = 7;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.NumEvent);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.b4.Location = new System.Drawing.Point(57, 196);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(84, 49);
            this.b4.TabIndex = 6;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.NumEvent);
            // 
            // bminus
            // 
            this.bminus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bminus.Location = new System.Drawing.Point(327, 251);
            this.bminus.Name = "bminus";
            this.bminus.Size = new System.Drawing.Size(84, 49);
            this.bminus.TabIndex = 13;
            this.bminus.Text = "-";
            this.bminus.UseVisualStyleBackColor = false;
            this.bminus.Click += new System.EventHandler(this.OperandEvent);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.b3.Location = new System.Drawing.Point(237, 251);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(84, 49);
            this.b3.TabIndex = 12;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.NumEvent);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.b2.Location = new System.Drawing.Point(147, 251);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(84, 49);
            this.b2.TabIndex = 11;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.NumEvent);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.b1.Location = new System.Drawing.Point(57, 251);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(84, 49);
            this.b1.TabIndex = 10;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.NumEvent);
            // 
            // bplus
            // 
            this.bplus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bplus.Location = new System.Drawing.Point(327, 306);
            this.bplus.Name = "bplus";
            this.bplus.Size = new System.Drawing.Size(84, 49);
            this.bplus.TabIndex = 17;
            this.bplus.Text = "+";
            this.bplus.UseVisualStyleBackColor = false;
            this.bplus.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bdot
            // 
            this.bdot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bdot.Location = new System.Drawing.Point(237, 306);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(84, 49);
            this.bdot.TabIndex = 16;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = false;
            this.bdot.Click += new System.EventHandler(this.bdot_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.b0.Location = new System.Drawing.Point(57, 306);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(174, 49);
            this.b0.TabIndex = 15;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.NumEvent);
            // 
            // bCe
            // 
            this.bCe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bCe.Location = new System.Drawing.Point(417, 141);
            this.bCe.Name = "bCe";
            this.bCe.Size = new System.Drawing.Size(84, 49);
            this.bCe.TabIndex = 18;
            this.bCe.Text = "CE";
            this.bCe.UseVisualStyleBackColor = false;
            this.bCe.Click += new System.EventHandler(this.bCe_Click);
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bC.Location = new System.Drawing.Point(417, 196);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(84, 49);
            this.bC.TabIndex = 19;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bEq
            // 
            this.bEq.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bEq.Location = new System.Drawing.Point(417, 251);
            this.bEq.Name = "bEq";
            this.bEq.Size = new System.Drawing.Size(84, 104);
            this.bEq.TabIndex = 20;
            this.bEq.Text = "=";
            this.bEq.UseVisualStyleBackColor = false;
            this.bEq.Click += new System.EventHandler(this.bEq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 421);
            this.Controls.Add(this.bEq);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bCe);
            this.Controls.Add(this.bplus);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bminus);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bmulti);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bdevide);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.b7);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bdevide;
        private System.Windows.Forms.Button bmulti;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button bminus;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button bplus;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bCe;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bEq;
    }
}

