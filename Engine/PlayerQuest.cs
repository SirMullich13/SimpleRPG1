using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuest
    {
        /*this class contains a new data type, bool. Bool stores true or false.
         *in this class, the IsCompleted property will store a value of false
         * until the player finishes the quest. Then it will store true in it.*/
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }

        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
