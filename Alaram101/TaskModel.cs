using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaram101
{
    public class TaskModel
    {
       
            public int Id { get; set; }//setters and getters for ID 
            public String TaskName { get; set; }//setters and getters for TaskName
            public String TaskDescription { get; set; }//setters and getters for TaskDescription
            public String TaskToDO
            {

                get
                {
                    return $"{TaskName} : {TaskDescription}";//Task Display format
                }
            }
        
    }
}
