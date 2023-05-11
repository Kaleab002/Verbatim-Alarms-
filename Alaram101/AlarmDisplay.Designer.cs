namespace Alaram101
{
    partial class AlarmDisplay
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.TaskTitleTextBox = new System.Windows.Forms.TextBox();
            this.TaskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TaskListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTask = new System.Windows.Forms.Button();
            this.RefreshButtton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePicker.Location = new System.Drawing.Point(457, 261);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(1);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(226, 20);
            this.DateTimePicker.TabIndex = 0;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(406, 366);
            this.StartButton.Margin = new System.Windows.Forms.Padding(1);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(129, 91);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(612, 366);
            this.StopButton.Margin = new System.Windows.Forms.Padding(1);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(122, 91);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(521, 313);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(72, 18);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task Title";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(20, 124);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(139, 15);
            this.lable2.TabIndex = 4;
            this.lable2.Text = "Task Description";
            // 
            // TaskTitleTextBox
            // 
            this.TaskTitleTextBox.Location = new System.Drawing.Point(176, 82);
            this.TaskTitleTextBox.Name = "TaskTitleTextBox";
            this.TaskTitleTextBox.Size = new System.Drawing.Size(297, 20);
            this.TaskTitleTextBox.TabIndex = 5;
            // 
            // TaskDescriptionTextBox
            // 
            this.TaskDescriptionTextBox.Location = new System.Drawing.Point(176, 121);
            this.TaskDescriptionTextBox.Name = "TaskDescriptionTextBox";
            this.TaskDescriptionTextBox.Size = new System.Drawing.Size(297, 20);
            this.TaskDescriptionTextBox.TabIndex = 5;
            // 
            // TaskListBox
            // 
            this.TaskListBox.FormattingEnabled = true;
            this.TaskListBox.Location = new System.Drawing.Point(27, 210);
            this.TaskListBox.Name = "TaskListBox";
            this.TaskListBox.Size = new System.Drawing.Size(294, 277);
            this.TaskListBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Task Lists ";
            // 
            // AddTask
            // 
            this.AddTask.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTask.Location = new System.Drawing.Point(537, 76);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(102, 30);
            this.AddTask.TabIndex = 8;
            this.AddTask.Text = "Add Task";
            this.AddTask.UseVisualStyleBackColor = true;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // RefreshButtton
            // 
            this.RefreshButtton.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButtton.Location = new System.Drawing.Point(537, 112);
            this.RefreshButtton.Name = "RefreshButtton";
            this.RefreshButtton.Size = new System.Drawing.Size(106, 30);
            this.RefreshButtton.TabIndex = 8;
            this.RefreshButtton.Text = "Refresh";
            this.RefreshButtton.UseVisualStyleBackColor = true;
            this.RefreshButtton.Click += new System.EventHandler(this.RefreshButtton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Verbatim Alarms";
            // 
            // AlarmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(804, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RefreshButtton);
            this.Controls.Add(this.AddTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskListBox);
            this.Controls.Add(this.TaskDescriptionTextBox);
            this.Controls.Add(this.TaskTitleTextBox);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "AlarmDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox TaskDescriptionTextBox;
        private System.Windows.Forms.TextBox TaskTitleTextBox;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RefreshButtton;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox TaskListBox;
        private System.Windows.Forms.Label label3;
    }
}

