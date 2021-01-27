using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MicrosoftAuth
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAuthCode_Click(object sender, EventArgs e)
        {
            try
            {
                string url = string.Format("https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id={0}" +
    "&response_type=code" +
    "&redirect_uri=https://login.microsoftonline.com/common/oauth2/nativeclient" +
    "&response_mode=query" +
    "&scope={1}", txtClientId.Text, txtScopes.Text);

                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClientId.Text == "")
                {
                    txtClientId.Focus();
                    return;
                }

                if (txtScopes.Text == "")
                {
                    txtScopes.Focus();
                    return;
                }

                if (txtAuthCode.Text == "")
                {
                    txtAuthCode.Focus();
                    return;
                }

                string post = string.Format("client_id={0}&scope={1}&code={2}&redirect_uri=https://login.microsoftonline.com/common/oauth2/nativeclient&grant_type=authorization_code",
    txtClientId.Text, txtScopes.Text, txtAuthCode.Text);
                byte[] data = Encoding.UTF8.GetBytes(post);

                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://login.microsoftonline.com/common/oauth2/v2.0/token");
                httpRequest.Method = "POST";
                httpRequest.ContentLength = data.Length;
                httpRequest.ContentType = "application/x-www-form-urlencoded";

                Stream requestStream = httpRequest.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                requestStream.Close();

                HttpWebResponse response = (HttpWebResponse)httpRequest.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(responseStream);
                string html = sr.ReadToEnd();
                sr.Close();
                responseStream.Close();

                AuthResponse resp = AuthResponse.GetResponse(html);

                txtOutput.AppendText("Access_token:" + resp.access_token + "\r\n");
                txtOutput.AppendText("Refresh_token:" + resp.refresh_token + "\r\n");
                if (DateTime.Now < resp.created.AddHours(1))
                {
                    txtOutput.AppendText("Expire:" + resp.created.AddHours(1).Subtract(DateTime.Now).Minutes.ToString() + "m\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClientId.Text == "")
                {
                    txtClientId.Focus();
                    return;
                }

                if (txtScopes.Text == "")
                {
                    txtScopes.Focus();
                    return;
                }

                if (txtRefreshToken.Text == "")
                {
                    txtRefreshToken.Focus();
                    return;
                }

                string post = string.Format("client_id={0}&scope={1}&refresh_token={2}&redirect_uri=https://login.microsoftonline.com/common/oauth2/nativeclient&grant_type=refresh_token",
    txtClientId.Text, txtScopes.Text, txtRefreshToken.Text);
                byte[] data = Encoding.UTF8.GetBytes(post);

                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://login.microsoftonline.com/common/oauth2/v2.0/token");
                httpRequest.Method = "POST";
                httpRequest.ContentLength = data.Length;
                httpRequest.ContentType = "application/x-www-form-urlencoded";

                Stream requestStream = httpRequest.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                requestStream.Close();

                HttpWebResponse response = (HttpWebResponse)httpRequest.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(responseStream);
                string html = sr.ReadToEnd();
                sr.Close();
                responseStream.Close();

                AuthResponse resp = AuthResponse.GetResponse(html);

                txtOutput.AppendText("Access_token:" + resp.access_token + "\r\n");
                txtOutput.AppendText("Refresh_token:" + resp.refresh_token + "\r\n");
                if (DateTime.Now < resp.created.AddHours(1))
                {
                    txtOutput.AppendText("Expire:" + resp.created.AddHours(1).Subtract(DateTime.Now).Minutes.ToString() + "m\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}