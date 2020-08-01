using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZendeskAPIDemo2
{
    public class ZendeskResponse
    {
        public List<Audit> audits { get; set; }
        public List<Event> events { get; set; }
        public object next_page { get; set; }
        public object previous_page { get; set; }
        public int count { get; set; }
    }
}