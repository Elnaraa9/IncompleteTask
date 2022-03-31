using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers2
{
    class Group
    {
        public int No { get; }
        public string GroupName;
        public Group[] Student;
        public Group(int no)
        {
            No = no;
            no++;
            Console.WriteLine("NO:"+no);
        }
    }
}
 