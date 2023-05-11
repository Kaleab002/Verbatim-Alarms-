using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Alaram101
{
    public partial class AlarmDisplay : Form
    {
        public static AlarmDisplay instance;
        
        List<TaskModel> Task1 = new List<TaskModel>();//initianlizing Task1 from TaskModel
        
        System.Timers.Timer timer;
        public AlarmDisplay()
        {
            InitializeComponent();
            LoadTaskList();
            instance = this;
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();//initializing timer
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

        }
        delegate void UpdateLabel(Label lbl, string value);
        void UpdateDataLabel(Label lbl, string value)
        {
            lbl.Text = value;
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            DateTime currentTime = DateTime.Now;
            DateTime userTime = DateTimePicker.Value;


            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                

                timer.Stop();
                try
                {
                    UpdateLabel upd = UpdateDataLabel;//label updated 
                    if (StatusLabel.InvokeRequired)
                        Invoke(upd, StatusLabel, "STOP");
                    SoundPlayer player = new SoundPlayer();//playing start up music from the background
                    player.SoundLocation = @"C:\Users\abera\Downloads\Project Jarvis\Alarm\alarm02.wav";
                    player.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                StopButton.Enabled = true;
            }
            


        }

        private void StartButton_Click(object sender, EventArgs e)//Start Button Sequence to disable buttons and initiate timer
        {
            timer.Start();//initiate timer
            StatusLabel.Text = "Running...";
            TaskTitleTextBox.Enabled = false;
            TaskDescriptionTextBox.Enabled=false;
            StopButton.Enabled = true;
            AddTask.Enabled = false;
            RefreshButtton.Enabled = false;
        }
      
        private async void StopButton_Click(object sender, EventArgs e)
        {
          

            timer.Stop();//Stopping the timer
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\abera\source\repos\Alaram101\Alaram101\Resources\Jarvis1.wav";//Start Up music from Soundplayer, Start Sequence should be from resources folder for absolute path
            player.Play();

            
           
            await Task.Delay(2000);//waiting for the intro to be played

            string target = "https://www.youtube.com/watch?v=6CwIB6pQoPo";//Auto Starting an album
            string target1 = "https://www.cnn.com";//AutoStarting a news website 
            System.Diagnostics.Process.Start(target);
            System.Diagnostics.Process.Start(target1);
            StatusLabel.Text = "Stopped";
            this.Hide();
            AIDisplay f2 = new AIDisplay();
            f2.ShowDialog();
            this.Close();










        }
        private void LoadTaskList() 
        {
            
            Task1 = SqliteDataAccess.LoadTask();//loading data from database

            ConnectUpTaskList();
            
        }

        private void ConnectUpTaskList() 
        {
            TaskListBox.DataSource = null;
            TaskListBox.DataSource = Task1;
            TaskListBox.DisplayMember = "TaskToDO";//format for display from TaskModel
            
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            TaskModel T = new TaskModel();

            T.TaskName=TaskTitleTextBox.Text;
            T.TaskDescription = TaskDescriptionTextBox.Text;


            SqliteDataAccess.SaveTask(T);//calling SaveTask Method from SqiteDataAccess Class to Commit the data to database
            if (TaskDescriptionTextBox.Text.Length ==0 && TaskTitleTextBox.Text.Length==0) {
                MessageBox.Show("Please Add Task First");//validating the Text box not to be empty
            }
            

        }

        private void RefreshButtton_Click(object sender, EventArgs e)
        {
            LoadTaskList();//Reloading the data from database

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
              
                if (DateTime.Today >  DateTimePicker.Value)
                {
                    MessageBox.Show("Invalid Time Please Enter Future time");
                   // DateTimePicker.Value = DateTime.Today;
                }

            
          

        }
    }
 
}
