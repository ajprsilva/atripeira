using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace atripeira
{
    public partial class Mensagem : PhoneApplicationPage
    {
        public Mensagem()
        {
            InitializeComponent();
        }

        private void SendMensagem_Click(object sender, EventArgs e)
        {
            SmsComposeTask smsComposeTask = new SmsComposeTask();

            string texto="";

            texto = "O Cliente " + nome.Text + " efectuou uma reserva com " + num.Text + " pessoas para as " + hora.Text + " horas";

            smsComposeTask.To = "+351919856385";
            smsComposeTask.Body = texto;

            smsComposeTask.Show();

            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }

        }
    }
}