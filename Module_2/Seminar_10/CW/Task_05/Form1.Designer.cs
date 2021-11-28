
namespace Task_05
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
            this.initButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // initButton
            // 
            this.initButton.Location = new System.Drawing.Point(104, 60);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(156, 35);
            this.initButton.TabIndex = 0;
            this.initButton.Text = "Initial";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(104, 361);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(156, 35);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Modify";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(104, 101);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(156, 254);
            this.textBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.initButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox textBox;
    }
}

