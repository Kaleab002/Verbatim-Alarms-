using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    public class TaskModel
    {
        public int Id { get; set; }
        public String TaskName { get; set; }
        public String TaskDescription { get; set; }
        public String TaskToDO {

            get
            {
                return $"{TaskName} : {TaskDescription}";
            }
        }
    }
}