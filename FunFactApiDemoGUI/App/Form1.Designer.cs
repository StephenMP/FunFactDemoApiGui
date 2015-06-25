using System.Drawing;
namespace FunFactApiDemoGUI.App
{
    partial class MainForm
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
            this.btnTrivia = new System.Windows.Forms.Button();
            this.btnMath = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrivia
            // 
            this.btnTrivia.Location = new System.Drawing.Point(12, 128);
            this.btnTrivia.Name = "btnTrivia";
            this.btnTrivia.Size = new System.Drawing.Size(88, 23);
            this.btnTrivia.TabIndex = 0;
            this.btnTrivia.Text = "Number Trivia";
            this.btnTrivia.UseVisualStyleBackColor = true;
            this.btnTrivia.Click += new System.EventHandler(this.btnTrivia_Click);
            // 
            // btnMath
            // 
            this.btnMath.Location = new System.Drawing.Point(106, 128);
            this.btnMath.Name = "btnMath";
            this.btnMath.Size = new System.Drawing.Size(107, 23);
            this.btnMath.TabIndex = 1;
            this.btnMath.Text = "Mathematical Fact";
            this.btnMath.UseVisualStyleBackColor = true;
            this.btnMath.Click += new System.EventHandler(this.btnMath_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(219, 128);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(130, 23);
            this.btnDate.TabIndex = 2;
            this.btnDate.Text = "Historical Fact By Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(355, 128);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(127, 23);
            this.btnYear.TabIndex = 3;
            this.btnYear.Text = "Historical Fact By Year";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(13, 13);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(284, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Select a button below to get a random fact about numbers!";
            this.lblOutput.MaximumSize = new Size(MainForm.ActiveForm.Width, 0);
            this.lblOutput.AutoSize = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 163);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnMath);
            this.Controls.Add(this.btnTrivia);
            this.Name = "MainForm";
            this.Text = "Fun Fact API Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrivia;
        private System.Windows.Forms.Button btnMath;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Label lblOutput;
    }
}

