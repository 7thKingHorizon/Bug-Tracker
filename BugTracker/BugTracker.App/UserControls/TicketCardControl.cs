using BugTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.App.UserControls
{
    public partial class TicketCardControl : UserControl
    {
        private readonly TicketModel ticketModel;

        public TicketCardControl(TicketModel ticketModel)

        {
            InitializeComponent();
            this.ticketModel = ticketModel;
            Init();
        }
        private void Init()
        {
            LnkTitle.Text = ticketModel.Title;
            LblLastUpdate.Text = ticketModel.LastModified.ToString();

        }
    }
}
