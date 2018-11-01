using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace Get_Link_Fshare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IDataObject dt = Clipboard.GetDataObject();
            if(dt.GetDataPresent(DataFormats.Text))
            {
                string text = (string)dt.GetData(DataFormats.Text);
                string[] array = text.Split('?');
                if (array.Length > 1)
                {
                    text = text.Replace("?", "").Replace(array[1], "");
                }
                string pattern = "^https:\\/\\/www\\.fshare\\.vn\\/file\\/[A-Za-z0-9_.]+$";
                if (Regex.Match(text, pattern, RegexOptions.IgnoreCase).Success)
                {
                    textBoxLink.Text = text;
                }
            }
            

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxLink, "");
            if (textBoxLink.Text != "")
            {
                if (textBoxLink.Text != "File Link...")
                {
                    string text = textBoxLink.Text;
                    string[] array = text.Split('?');
                    if (array.Length > 1)
                    {
                        text = text.Replace("?", "").Replace(array[1], "");
                    }
                    string pattern = "^https:\\/\\/www\\.fshare\\.vn\\/file\\/[A-Za-z0-9_.]+$";
                    if (Regex.Match(text, pattern, RegexOptions.IgnoreCase).Success)
                    {
                       
                        string address = "https://nghia.org/public/api/v1/fshare/events/get.cs";
                        string data = "link=" + text + "&password=vynghiak17@1308";
                        try
                        {
                            materialRaisedButton1.Text = "Getting...";
                            materialRaisedButton1.Enabled = false;
                            using (WebClient webClient = new WebClient())
                            {
                                webClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                                string[] array2 = webClient.UploadString(address, data).Split(new string[1]
                                {
                                "|"
                                }, StringSplitOptions.None);
                                if(array2[1]=="")
                                {
                                    MessageBox.Show("The wrong URL or server failed , Can't get link", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                                textBoxResult.Text = array2[1];
                                
                                
                               
                            }
                        }
                        catch
                        {
                        }
                        finally
                        {
                            materialRaisedButton1.Text = "Get Link";
                            materialRaisedButton1.Enabled = true;
                            if(CheckBoxDownLoad.Checked&&textBoxResult.Text!="")
                            {
                                Process.Start(textBoxResult.Text);
                            }
                        }
                    }
                    else
                    {
                        
                        errorProvider1.SetError(textBoxLink, "Not an Fshare Link");
                    }
                }
                else
                {
                    errorProvider1.SetError(textBoxLink, "Remove default value");
                }
            }
            else
            {
                
                errorProvider1.SetError(textBoxLink, "Link is Empty");
            }
        }

        private void ButtonDownLoad_Click(object sender, EventArgs e)
        {
            if(textBoxResult.Text!="")
            {
                //  Process.Start(textBoxResult.Text);
                Process.Start(@"C:\Program Files (x86)\Internet Download Manager\IDMan.exe", " /a /d " 
                              + textBoxResult.Text + @" /p C:\Users\Hien Lech\Downloads");
                Process.Start(@"C:\Program Files (x86)\Internet Download Manager\IDMan.exe", " /s /h");
            }
            
        }

        private void textBoxLink_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/hienlech7999");
        }
    }
}
