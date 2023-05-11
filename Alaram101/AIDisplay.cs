using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Alaram101
{
    public partial class AIDisplay : Form
    {
        List<TaskModel> Task1 = new List<TaskModel>();
        public static AIDisplay instance;
        public ListBox textTransfer;
        public AIDisplay()
        {
            InitializeComponent();
            instance = this;
            textTransfer = DisplayListBox;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            
            
            pictureBox1.Visible = true;
            await Task.Delay(5000);//waiting 5 seconds before switching to task 
            DisplayListBox.Visible = true;//Task display label
            TaskLabel1.Visible = true;  //Enabling the Title label 
            DoneButton.Visible = true;  //Enabling the Done Button
            pictureBox1.Visible = false;//disabling AI picture 
            AIDisplay form = new AIDisplay();
            form.Size = new Size(1000, 1200);//Form size 
            LoadTaskList();//Loading the Data and the connection

        }

        private void ConnectUpTaskList()
        {
            DisplayListBox.DataSource = null;
            DisplayListBox.DataSource = Task1;//Defined Data Source instance of TaskModel
            DisplayListBox.DisplayMember = "TaskToDO";//Display fromat from the TaskModel.Cs
           
        }
        private void LoadTaskList()
        {
            
            Task1 = SqliteDataAccess.LoadTask();//Loading Data from the database 

            ConnectUpTaskList();//Connecting it to the DisplayTextBox 

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            TaskModel T = new TaskModel();
            AIDisplay.ActiveForm.Close();//closes from AIDisplay
            SqliteDataAccess.DeleteTask(T);
        }
    }
}
