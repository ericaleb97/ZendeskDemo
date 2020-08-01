using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZendeskAPIDemo2
{
    public class Event
    {
        public object id { get; set; }
        public string type { get; set; }

        //public object author_id { get; set; }
        
        public double author_id { get; set; }
        public object body { get; set; }
        public string html_body { get; set; }
        public string plain_body { get; set; }
        
        //public List<Attachment> attachments { get; set; }
        
        public object audit_id { get; set; }
        public object value { get; set; }
        public string field_name { get; set; }
        
        //public Via via { get; set; }
        
        public object previous_value { get; set; }
        public object previous_schedule_id { get; set; }
        public string new_schedule_id { get; set; }
        public List<object> recipients { get; set; }
        public string comment_id { get; set; }
        public string subject { get; set; }
        public string macro_title { get; set; }
        public string macro_id { get; set; }
        public bool? macro_deleted { get; set; }
    }
}
