using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZendeskAPIDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public async Task PrintTicketData()
        {
            int userTicket = Convert.ToInt32(ticket.Text);

            var apiWrapper = new APIWrapper(userTicket);

            await apiWrapper.GetTicketInfo();


            try
            {
                agent.Text = Convert.ToString(apiWrapper.agent);

                date.Text = Convert.ToString(apiWrapper.date);

                macro.Text = apiWrapper.macro;
            }

            catch
            {
                macro.Text = "LOAD DATA";
            }
        }

        private async void search_Click(object sender, EventArgs e)
        {
            try
            {
                await PrintTicketData();
            }

            catch
            {
                macro.Text = "LOAD DATA";
            }
        }
    }
}
