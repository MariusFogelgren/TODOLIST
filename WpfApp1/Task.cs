using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Task
    {
        public string Title { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
    }

    enum Status
        {
            NotDone,
            Done,
        }
}
