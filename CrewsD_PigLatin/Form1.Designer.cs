
namespace CrewsD_PigLatin
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
            this.sentenceTextbox = new System.Windows.Forms.TextBox();
            this.sentenceLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.convertedLabel = new System.Windows.Forms.Label();
            this.convertedOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sentenceTextbox
            // 
            this.sentenceTextbox.Location = new System.Drawing.Point(75, 130);
            this.sentenceTextbox.Name = "sentenceTextbox";
            this.sentenceTextbox.Size = new System.Drawing.Size(1038, 31);
            this.sentenceTextbox.TabIndex = 0;
            // 
            // sentenceLabel
            // 
            this.sentenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentenceLabel.Location = new System.Drawing.Point(12, 52);
            this.sentenceLabel.Name = "sentenceLabel";
            this.sentenceLabel.Size = new System.Drawing.Size(1167, 58);
            this.sentenceLabel.TabIndex = 1;
            this.sentenceLabel.Text = "Type a sentence without punctuation that you would like converted to Pig Latin:";
            this.sentenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sentenceLabel.Click += new System.EventHandler(this.sentenceLabel_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(356, 471);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(207, 80);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(637, 471);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(207, 80);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // convertedLabel
            // 
            this.convertedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedLabel.Location = new System.Drawing.Point(176, 254);
            this.convertedLabel.Name = "convertedLabel";
            this.convertedLabel.Size = new System.Drawing.Size(857, 58);
            this.convertedLabel.TabIndex = 4;
            this.convertedLabel.Text = "Converted sentence:";
            this.convertedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertedOutput
            // 
            this.convertedOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedOutput.Location = new System.Drawing.Point(75, 325);
            this.convertedOutput.Name = "convertedOutput";
            this.convertedOutput.Size = new System.Drawing.Size(1038, 63);
            this.convertedOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 649);
            this.Controls.Add(this.convertedOutput);
            this.Controls.Add(this.convertedLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.sentenceLabel);
            this.Controls.Add(this.sentenceTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sentenceTextbox;
        private System.Windows.Forms.Label sentenceLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label convertedLabel;
        private System.Windows.Forms.Label convertedOutput;
    }
}

