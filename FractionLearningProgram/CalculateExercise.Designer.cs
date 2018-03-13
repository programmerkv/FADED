namespace FractionLearningProgram
{
    partial class CalculateExercise
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDen3 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDen2 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDen1 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDiv = new System.Windows.Forms.RadioButton();
            this.radMult = new System.Windows.Forms.RadioButton();
            this.radSub = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(360, 198);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(182, 198);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 35);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New fraction";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "=";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(265, 135);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(18, 20);
            this.lblOperator.TabIndex = 13;
            this.lblOperator.Text = "+";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDen3);
            this.groupBox4.Controls.Add(this.txtNum3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(398, 97);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(75, 92);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // txtDen3
            // 
            this.txtDen3.Location = new System.Drawing.Point(9, 55);
            this.txtDen3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDen3.Name = "txtDen3";
            this.txtDen3.Size = new System.Drawing.Size(58, 26);
            this.txtDen3.TabIndex = 2;
            this.txtDen3.TextChanged += new System.EventHandler(this.txtDen3_TextChanged);
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(8, 14);
            this.txtNum3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(58, 26);
            this.txtNum3.TabIndex = 1;
            this.txtNum3.TextChanged += new System.EventHandler(this.txtNum3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "______";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDen2);
            this.groupBox3.Controls.Add(this.txtNum2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(291, 97);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(75, 92);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // txtDen2
            // 
            this.txtDen2.Location = new System.Drawing.Point(9, 55);
            this.txtDen2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDen2.Name = "txtDen2";
            this.txtDen2.Size = new System.Drawing.Size(58, 26);
            this.txtDen2.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(8, 14);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(58, 26);
            this.txtNum2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "______";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDen1);
            this.groupBox2.Controls.Add(this.txtNum1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(182, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(75, 92);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // txtDen1
            // 
            this.txtDen1.Location = new System.Drawing.Point(9, 55);
            this.txtDen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDen1.Name = "txtDen1";
            this.txtDen1.Size = new System.Drawing.Size(58, 26);
            this.txtDen1.TabIndex = 2;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(8, 14);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(58, 26);
            this.txtNum1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "______";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDiv);
            this.groupBox1.Controls.Add(this.radMult);
            this.groupBox1.Controls.Add(this.radSub);
            this.groupBox1.Controls.Add(this.radAdd);
            this.groupBox1.Location = new System.Drawing.Point(21, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(150, 185);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operators";
            // 
            // radDiv
            // 
            this.radDiv.AutoSize = true;
            this.radDiv.Location = new System.Drawing.Point(10, 137);
            this.radDiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radDiv.Name = "radDiv";
            this.radDiv.Size = new System.Drawing.Size(88, 24);
            this.radDiv.TabIndex = 3;
            this.radDiv.Text = "Division";
            this.radDiv.UseVisualStyleBackColor = true;
            this.radDiv.CheckedChanged += new System.EventHandler(this.radDiv_CheckedChanged);
            // 
            // radMult
            // 
            this.radMult.AutoSize = true;
            this.radMult.Location = new System.Drawing.Point(10, 102);
            this.radMult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMult.Name = "radMult";
            this.radMult.Size = new System.Drawing.Size(125, 24);
            this.radMult.TabIndex = 2;
            this.radMult.Text = "Multiplication";
            this.radMult.UseVisualStyleBackColor = true;
            this.radMult.CheckedChanged += new System.EventHandler(this.radMult_CheckedChanged);
            // 
            // radSub
            // 
            this.radSub.AutoSize = true;
            this.radSub.Location = new System.Drawing.Point(10, 66);
            this.radSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radSub.Name = "radSub";
            this.radSub.Size = new System.Drawing.Size(95, 24);
            this.radSub.TabIndex = 1;
            this.radSub.Text = "Subtract";
            this.radSub.UseVisualStyleBackColor = true;
            this.radSub.CheckedChanged += new System.EventHandler(this.radSub_CheckedChanged);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(10, 31);
            this.radAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(92, 24);
            this.radAdd.TabIndex = 0;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Addition";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radAdd_CheckedChanged);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(182, 245);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(112, 35);
            this.btnTest.TabIndex = 17;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // CalculateExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 403);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalculateExercise";
            this.Text = "CalculateExercise";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDen3;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDen2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDen1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDiv;
        private System.Windows.Forms.RadioButton radMult;
        private System.Windows.Forms.RadioButton radSub;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.Button btnTest;
    }
}