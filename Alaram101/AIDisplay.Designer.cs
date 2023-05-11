namespace Alaram101
{
    partial class AIDisplay
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.TaskLabel1 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alaram101.Properties.Resources.Jarvis2;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 3019);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DisplayListBox.Font = new System.Drawing.Font("Stencil", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.ItemHeight = 22;
            this.DisplayListBox.Location = new System.Drawing.Point(4, 31);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(392, 400);
            this.DisplayListBox.TabIndex = 1;
            this.DisplayListBox.Visible = false;
            // 
            // TaskLabel1
            // 
            this.TaskLabel1.AutoSize = true;
            this.TaskLabel1.BackColor = System.Drawing.Color.Cyan;
            this.TaskLabel1.Font = new System.Drawing.Font("Showcard Gothic", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskLabel1.Location = new System.Drawing.Point(1, 5);
            this.TaskLabel1.Name = "TaskLabel1";
            this.TaskLabel1.Size = new System.Drawing.Size(365, 29);
            this.TaskLabel1.TabIndex = 2;
            this.TaskLabel1.Text = "THIS ARE YOUR TASKS TODAY";
            this.TaskLabel1.Visible = false;
            // 
            // DoneButton
            // 
            this.DoneButton.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(109, 449);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(150, 42);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "DONE";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Visible = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // AIDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(391, 550);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.TaskLabel1);
            this.Controls.Add(this.DisplayListBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "AIDisplay";
            this.Text = "AI";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.Label TaskLabel1;
        private System.Windows.Forms.Button DoneButton;
    }
}