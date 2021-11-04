
namespace Line_of_Best_Fit_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xValue = new System.Windows.Forms.NumericUpDown();
            this.yValue = new System.Windows.Forms.NumericUpDown();
            this.Add = new System.Windows.Forms.Button();
            this.LinearRegression = new System.Windows.Forms.Button();
            this.canvasPictureBox = new System.Windows.Forms.PictureBox();
            this.RandomAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input a point:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "y:";
            // 
            // xValue
            // 
            this.xValue.Location = new System.Drawing.Point(652, 66);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(120, 20);
            this.xValue.TabIndex = 3;
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(652, 92);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(120, 20);
            this.yValue.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(634, 118);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(154, 57);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // LinearRegression
            // 
            this.LinearRegression.Location = new System.Drawing.Point(652, 274);
            this.LinearRegression.Name = "LinearRegression";
            this.LinearRegression.Size = new System.Drawing.Size(120, 105);
            this.LinearRegression.TabIndex = 6;
            this.LinearRegression.Text = "Regress";
            this.LinearRegression.UseVisualStyleBackColor = true;
            this.LinearRegression.Click += new System.EventHandler(this.LinearRegression_Click);
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.Location = new System.Drawing.Point(46, 44);
            this.canvasPictureBox.Name = "canvasPictureBox";
            this.canvasPictureBox.Size = new System.Drawing.Size(449, 382);
            this.canvasPictureBox.TabIndex = 7;
            this.canvasPictureBox.TabStop = false;
            // 
            // RandomAdd
            // 
            this.RandomAdd.Location = new System.Drawing.Point(634, 191);
            this.RandomAdd.Name = "RandomAdd";
            this.RandomAdd.Size = new System.Drawing.Size(154, 62);
            this.RandomAdd.TabIndex = 8;
            this.RandomAdd.Text = "Add a Random Point";
            this.RandomAdd.UseVisualStyleBackColor = true;
            this.RandomAdd.Click += new System.EventHandler(this.RandomAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RandomAdd);
            this.Controls.Add(this.canvasPictureBox);
            this.Controls.Add(this.LinearRegression);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown xValue;
        private System.Windows.Forms.NumericUpDown yValue;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button LinearRegression;
        private System.Windows.Forms.PictureBox canvasPictureBox;
        private System.Windows.Forms.Button RandomAdd;
    }
}

