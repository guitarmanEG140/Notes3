using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Models
{
    public class Note
    {
        public int ID { get; set; }        
        public string Title { get; set; }
        public string Notes { get; set; }
        public int CategoryID { get; set; }
        public Boolean IsDeleted { get; set; }
        public int userID { get; set; }
    }
}


