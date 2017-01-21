using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notebook
{
    class note
    {
        string title;
        string msg;
        //constructors
        public note()
        {
            title = "New note\n";
            msg = "none\n";
        }
        public note(string ntitle, string nmsg)
        {
            title = ntitle;
            msg = nmsg;
        }
        //getters
        public string getTitle()
        {
            return title;
        }
        public string getMsg()
        {
            return msg;
        }
        //setters
        public void setTitle(string newTitle)
        {
            title = newTitle;
        }
        public void setMsg(string newMsg)
        {
            msg = newMsg;
        }
    }
}
