using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ZendeskAPIDemo2
{
    public class APIWrapper
    {
        HttpClient ApiClient = new HttpClient();
        public int ticket { get; set; }
        public string url;
        public DateTime date { get; set; }
        public double agent { get; set; }
        public string macro { get; set; }

        public APIWrapper()
        {

        }

        public APIWrapper(int ticket)
        {
            this.ticket = ticket;
        }

        public async Task GetTicketInfo()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                url = $"https://nvoicepay.zendesk.com/api/v2/tickets/{ticket}/audits.json";

                string response = await ApiClient.GetStringAsync(url);

                ZendeskResponse ZendeskObject = JsonConvert.DeserializeObject<ZendeskResponse>(response);
                
                agent = ZendeskObject.audits.FirstOrDefault().author_id;

                date = ZendeskObject.audits.FirstOrDefault().created_at;

                macro = ZendeskObject.events.FirstOrDefault().macro_title;
            }

            catch
            {
                //report.Text = "LOAD DATA";
            }
        }
    }
}
