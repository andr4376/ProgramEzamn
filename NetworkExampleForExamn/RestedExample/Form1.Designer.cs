namespace RestedExample
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
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.OutPutTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(80, 22);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(324, 20);
            this.URLTextBox.TabIndex = 0;
            // 
            // OutPutTextBox
            // 
            this.OutPutTextBox.Location = new System.Drawing.Point(80, 60);
            this.OutPutTextBox.Multiline = true;
            this.OutPutTextBox.Name = "OutPutTextBox";
            this.OutPutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutPutTextBox.Size = new System.Drawing.Size(515, 318);
            this.OutPutTextBox.TabIndex = 1;
            this.OutPutTextBox.Text = "http://dry-cliffs-19849.herokuapp.com/users/2.json";
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(446, 22);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(87, 23);
            this.sendMessageButton.TabIndex = 2;
            this.sendMessageButton.Text = "Send Request";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.OutPutTextBox);
            this.Controls.Add(this.URLTextBox);
            this.Name = "Form1";
            this.Text = "Rested Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.TextBox OutPutTextBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

