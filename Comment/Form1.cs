using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.Extensions;
using ET.FakeText;
using System.CodeDom;

namespace Comment
{
    public partial class Form1 : Form
    {
        //global to be easy to access
        IWebDriver driver;
        IJavaScriptExecutor js;
        int done=0;
        int next_wait = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Close_button_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit(); 
        }
        private void Minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void Close_button_MouseHover(object sender, EventArgs e)
        {
            //change the button colors on hover
            Close_button.BackColor = Color.Red;
            Close_button.ForeColor = Color.White;
        }
        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            //change the layout back on mouse leave
            Close_button.BackColor = Color.White;
            Close_button.ForeColor = Color.DimGray;
        }
        private void Close_button_Click(object sender, EventArgs e)
        {
            // you may close before the driver starts . so to avoid errors
            try
            {
                //close driver to minimum the process of loading the last session on startup
                driver.Close();
                driver.Quit();
            }
            catch
            { }     
            Application.Exit();
        }
        
        private void Start_Browser()
        {
            var pathWithEnv = @"%USERPROFILE%\AppData\Local\Google\Chrome\User Data";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            ChromeOptions op = new ChromeOptions();
            op.AddArgument($"user-data-dir={filePath}");
            op.AddArgument($"--profile-directory=Default");
            //-------------------------------------- headless facing a problem in starting with the default profile 
            //op.AddArgument("--headless");
            //---------------------------------------
            op.AddArgument("--disable-extensions"); // for faster process
            op.AddArgument("--disable-gpu"); // for faster process
            //op.AddArgument("--remote-debugging-port=45447");
            // it's kind of important in headless mode but it's not working yet
            op.AddAdditionalCapability("useAutomationExtension", false); // avoid  the automation bar 

            // the next 3 lines is to hide the chrome driver CMD 
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverService ,op);

            // minimize the chrome process when start
            driver.Manage().Window.Minimize();
        }
        private bool Check_login()
        {
            driver.Navigate().GoToUrl("https://m.facebook.com");
            try
            {
                var na = driver.FindElement(By.Id("m_home_notice"));
                if (na != null)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                //-------------------- this section is for debuging the profile issue in headless mode -----------
                //MessageBox.Show(ex.Message);
                //Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                //ss.SaveAsFile("Image.png",
                //ScreenshotImageFormat.Png);
                //------------------------------------------------------------------------------------------------
                return false;
            }
           
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // the background worker is to avoid program freezing
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                Status.Text = "There is something wrong";
            }
        }
        private void status_changer(string text)
        {
            Status.Invoke((MethodInvoker)delegate
            {
                Status.Text = text;
            });
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            status_changer("Checking Chrome driver (1/4)");
            try
            {
                Start_Browser();
                status_changer("i'm running fine after 1");
            }
            catch (Exception)
            {
                status_changer("Updating chrome driver (2/4)");
                try
                {
                    new DriverManager().SetUpDriver(new ChromeConfig());
                }
                catch (Exception)
                {
                    status_changer("Connection error");
                }

                status_changer("Checking chrome again (3/4)");
                try
                {
                    Start_Browser();
                    status_changer("testing login (4/4)");
                    System.Threading.Thread.Sleep(1000);
                    try
                    {
                        bool login = Check_login();
                        if (login)
                        {
                            js = (IJavaScriptExecutor)driver;
                            home_deawer();
                        }
                        else
                            status_changer("You are not logedin");
                    }
                    catch (Exception)
                    {

                        status_changer("bad connection");
                    }
                    
                }
                catch (Exception)
                {
                    status_changer("Check google-Chrome version");
                }
            }
        }
        private void home_deawer()
        {
            // change the layout to the main app
            Status.Invoke((MethodInvoker)delegate
            {
                Status.Visible = false;
            });
            logo.Invoke((MethodInvoker)delegate
            {
                logo.Visible = true;
            });
            PostGroup.Invoke((MethodInvoker)delegate
            {
                PostGroup.Visible = true;
            });
            Controle.Invoke((MethodInvoker)delegate
            {
                Controle.Visible = true;
            });
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TestPost_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                Postchecker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("The process can't start.");
            }
        }
        private void Postchecker_DoWork(object sender, DoWorkEventArgs e)
        {
            // change any link to a mobile link
            string url = Post.Text;
            string reg = @"facebook.+";
            Regex re = new Regex(reg);
            var res = re.Match(url);
            url = "https://m." + res.Value;
            // store the new link in the textbox to use as public variable
            Post.Invoke((MethodInvoker)delegate
            {
                Post.Text = url;
            });
            driver.Navigate().GoToUrl(Post.Text);
            try
            {
                //comment place
                var na = driver.FindElement(By.TagName("input"));
                // enable the next options 
                if (na != null)
                { 
                    PostError.Invoke((MethodInvoker)delegate
                    {
                        PostError.Visible = false;
                    });
                    Post.Invoke((MethodInvoker)delegate
                    {
                        Post.Enabled = false;
                    });
                    TestPost.Invoke((MethodInvoker)delegate
                    {
                        TestPost.Enabled = false;
                    });
                    Comments.Invoke((MethodInvoker)delegate
                    {
                        Comments.Enabled = true;
                    });
                    RandomTime.Invoke((MethodInvoker)delegate
                    {
                        RandomTime.Enabled = true;
                    });
                    Generate.Invoke((MethodInvoker)delegate
                    {
                        Generate.Enabled = true;
                    });
                    NoComments.Invoke((MethodInvoker)delegate
                    {
                        NoComments.Enabled = true;
                    });
                }
                else
                    PostError.Invoke((MethodInvoker)delegate
                    {
                        PostError.Visible = true;
                    });

            }
            catch (Exception ex)
            {
                    PostError.Invoke((MethodInvoker)delegate
                    {
                        PostError.Visible = true;
                        PostError.Text = ex.Message;
                    });
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void share_CheckedChanged(object sender, EventArgs e)
        {
            NoShares.Enabled = !NoShares.Enabled;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (textgenerator.IsBusy != true)
            {
                textgenerator.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Unable to start generate process");
            }
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void textgenerator_DoWork(object sender, DoWorkEventArgs e)
        {
            string final_text = "";
            TextGenerator wc = new TextGenerator(WordTypes.Name);
            List<string> namesList = new List<string>(20);
            for (int i = 0; i < 300; i++)
            {
                namesList.Add(wc.GenerateWord(6));
            }
            final_text = string.Join(" ", namesList);
            Comments.Invoke((MethodInvoker)delegate
            {
                Comments.Text = final_text;
            });
        }
        
        private void send_comment(string text,bool rand)
        {
            
            string script= "var input = document.getElementsByName(\"comment_text\")[0];\n"+
                "var submit = document.querySelector('button[type=\"submit\"]');\n"+
                "submit.disabled = false;\n"+
                "input.value ='" + text + "';\n"+
                "submit.click();";
            js.ExecuteScript(script);
            if (rand)
            {
                System.Threading.Thread.Sleep(random.Next(1000, 7000));
                // random big wait every random time
                if (done % next_wait == 0)
                {
                    next_wait = random.Next(50, 100);
                    System.Threading.Thread.Sleep(random.Next(20000, 60000));
                }
            }
            try
            {
                var na = driver.FindElement(By.Name("comment_text"));
                if (na != null)
                { }
                else
                {
                    MessageBox.Show("Something wrong, Check it and start again");
                    stop.PerformClick();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something wrong, Check it and start again");
                stop.PerformClick();
            }
            
           
            driver.Navigate().Refresh();
            done += 1;
        }

        private void Comments_TextChanged(object sender, EventArgs e)
        {
            if (Comments.Text.Length>100)
                start.Enabled = true;
            else
                start.Enabled = false;
        }

        private void NoComments_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NoShares_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void start_Click(object sender, EventArgs e)
        {
            working.Text = "Starting ...";
            working.Visible = true;
            start.Enabled = false;
            stop.Visible = true;
            if (Commenter.IsBusy != true)
            {
                Commenter.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Unable to start comments process");
            }
            
        }
        
        private void Commenter_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] ssize = Comments.Text.Split(null);
            bool emo = emojis.Checked;
            bool Sti = stickers.Checked;
            bool ran = RandomTime.Checked;
            bool pri = share.Checked;
            int nComments;
            int nShare;
            
            if (NoComments.Text.Length>0)
                nComments = int.Parse(NoComments.Text);
            else
                nComments = 0;
            if (NoShares.Text.Length>0)
                nShare = int.Parse(NoShares.Text);
            else
                nShare = 0;
            if (nComments>0)
            {
                for (int i = 0; i < nComments; i++)
                    try
                    {
                        string final = "";
                        int rand_num = random.Next(1, 15); ;
                        for (int ii = 0; ii < rand_num; ii++)
                            if (ii == 0)
                                final += ssize[random.Next(0, ssize.Length)] + " ";
                            else
                                final += ssize[random.Next(0, ssize.Length)] + " ".ToLower();
                        send_comment(final, ran);
                        working.Invoke((MethodInvoker)delegate
                        {
                            working.ForeColor = Color.Green;
                            working.Text = "Done : ( " + done + " / " + nComments + " )";
                        });
                    }
                    catch (Exception)
                    {
                        working.Invoke((MethodInvoker)delegate
                        {
                            working.ForeColor = Color.Red;
                            working.Text = "Connection error , i will try again in 5 sec.";
                        });
                        System.Threading.Thread.Sleep(5000);
                    }
                    
            }
            else 
                while (true)
                    try
                    {
                        string final = ""; 
                        int rand_num = random.Next(1, 15);
                        for (int ii = 0; ii < rand_num; ii++)
                            if ( ii ==0 )
                                final += ssize[random.Next(0, ssize.Length)] + " ";
                            else
                                final += ssize[random.Next(0, ssize.Length)] + " ".ToLower();
                        send_comment(final, ran);
                        working.Invoke((MethodInvoker)delegate
                        {
                            working.ForeColor = Color.Green;
                            working.Text = "Done : "+done;
                        });
                    }
                    catch (Exception)
                    {

                        working.Invoke((MethodInvoker)delegate
                        {
                            working.ForeColor = Color.Red;
                            working.Text = "Connection error , i will try again in 5 sec.";
                        });
                        System.Threading.Thread.Sleep(5000);
                    }

            start.Invoke((MethodInvoker)delegate
            {
                start.Enabled = true;
            });
            stop.Invoke((MethodInvoker)delegate
            {
                stop.Visible = false;
            });
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Commenter.CancelAsync();
            stop.Enabled = false;
            start.Enabled = true;
            working.Text = "done : " + done;
        }
    }
}
