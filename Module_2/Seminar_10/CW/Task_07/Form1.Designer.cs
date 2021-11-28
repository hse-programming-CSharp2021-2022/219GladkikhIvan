
namespace Task_07
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
            this.buttonSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSize
            // 
            this.buttonSize.Location = new System.Drawing.Point(2, 12);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(200, 30);
            this.buttonSize.TabIndex = 0;
            this.buttonSize.Text = "Увеличить форму";
            this.buttonSize.UseVisualStyleBackColor = true;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 61);
            this.Controls.Add(this.buttonSize);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(220, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSize;
    }
}

