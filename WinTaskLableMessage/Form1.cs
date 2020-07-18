using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace WinTaskLableMessage
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_ajax_Click(object sender, EventArgs e)
        {
            this.lab_message.Visible = true;
            this.lab_message.Text = "複製中";

            var _source = new CancellationTokenSource();
            var _token = _source.Token;

            try
            {
                this.btn_ajax.Enabled = false;
                await Task.Run(() => {
                    Thread.Sleep(5000);
                });
                this.btn_ajax.Enabled = true; ;

            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                this.lab_message.Visible = false;
                this.lab_message.Text = string.Empty;
            }
        }
    }
}
