using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZendeskAPIDemo2
{
    public class Audit
    {
        public object id { get; set; }
        public int ticket_id { get; set; }
        public DateTime created_at { get; set; }

        //public object author_id { get; set; }
        public double author_id { get; set; }
        
        //public Metadata metadata { get; set; }
        public List<Event> events { get; set; }
        
        //public Via2 via { get; set; }
    }
}
