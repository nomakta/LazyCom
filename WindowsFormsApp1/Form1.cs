using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public string username;
        public string password;

        public int amountOfMistakes;
        public int amountOfQuestions;

        public string Hoofdstuk;
        public string Paragraaf;
        public string Opdracht;

        public int amountOfSeconds;

        static IWebDriver driverGC;

        public void startBrowser()
        {
            var driverService = FirefoxDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            var options = new FirefoxOptions();
            options.AddArgument("--headless");

            driverGC = new FirefoxDriver(driverService, options);
            driverGC.Navigate().GoToUrl("https://www.nedercom.nl/appl/");
        }

        public void closeBrowser()
        {
            driverGC.Close();
        }

        static public bool verify(string classname)
        {
            try
            {
                bool isElementDisplayed = driverGC.FindElement(By.ClassName(classname)).Displayed;
                return true;
            }
            catch
            {
                return false;
            }
        } 

        private void loginNedercom(string username, string password)
        {
            try
            {
                    var school = driverGC.FindElement(By.Id("schoolid"));
                    school.SendKeys("ttt"); // probarly should do this in an propper way but too lazy

                    var usernameBox = driverGC.FindElement(By.Name("loginname"));
                    usernameBox.SendKeys(username);

                    var passwordBox = driverGC.FindElement(By.Name("password"));
                    passwordBox.SendKeys(password);

                    var loginBtn = driverGC.FindElement(By.Id("continueItem"));
                    loginBtn.Click();

                    if (verify("userinfo") == true)
                    {
                        usernameLbl.Enabled = false;
                        PasswordLbl.Enabled = false;
                        logoutBtn.Enabled = true;
                        usernameTb.ReadOnly = true;
                        passwordTb.ReadOnly = true;
                        submitBtn.Enabled = false;
                        tabPage1.Enabled = true;
                        settingsTab.Enabled = true;
                        accountGrp.Text = " Account  | Logged in: True";
                        this.Text = "Lazycom | Logged in";
                        this.WindowState = FormWindowState.Minimized;
                        this.Show();
                        this.WindowState = FormWindowState.Normal;
                        logRTB.AppendText("[SUCCESS] Logged in as " + username + "\n");
                        MessageBox.Show("Logged in", "Success");
                    }
                    else
                    {
                        closeBrowser();
                        logRTB.AppendText("[ERROR] Incorrect username or password for " + username + "\n");
                        MessageBox.Show("Incorrect login, try again", "Error");
                    }
            }catch(Exception) {
                closeBrowser();
                MessageBox.Show("Login failed, try again", "Error");
            }
        }
        
        public void gotoOpdracht(string hoofdstuk, string paragraaf, string opdracht)
        {
            try
            {
                driverGC.FindElement(By.XPath("//a[.='" + hoofdstuk + "']")).Click();
                driverGC.FindElement(By.XPath("//span[.='" + paragraaf + "']")).Click();
                driverGC.FindElement(By.XPath("//span[.='"+opdracht+"']")).Click();
                driverGC.FindElement(By.Id("continueItem")).Click();
            }catch (Exception) { }
        }


        public void makeTextbox(string hoofdstuk, string opdrachtNumber, string paragraaf, int amountOfErrors)
        {
            int errorsDone = 0;

            var amountOf = driverGC.FindElement(By.ClassName("amountOfQuestions")).Text.Split(' ');
            amountOfQuestions = Int32.Parse(amountOf[3]);

            IList<AnswerHelper> answers = new List<AnswerHelper>();
            for (int i = 0; i != amountOfQuestions; i++)
            {
                string question = driverGC.FindElement(By.CssSelector("div[class='question'] p")).Text;
                var answerBox = driverGC.FindElement(By.Id("answer"));
                answerBox.SendKeys(".");
                driverGC.FindElement(By.Id("continueItem")).Click();
                if (verify("subhead") == false) { driverGC.FindElement(By.Id("continueItem")).Click(); }
                string correctAnswer = driverGC.FindElement(By.CssSelector("strong[class='subhead']")).Text;
                driverGC.FindElement(By.Id("continueItem")).Click();
                string correctAnswer2 = correctAnswer.Split(':').Last();
                answers.Add(new AnswerHelper() { id = i.ToString(), question = question, answer = correctAnswer2 });
                int vraagNumber = i + 1;
                logRTB.AppendText("[ANSWER " + vraagNumber + "] >> Question:" + question + " Answer:" + correctAnswer + "\n");
            }

            driverGC.FindElement(By.Id("continueItem")).Click();
            driverGC.FindElement(By.Id("continueItem")).Click();
            driverGC.FindElement(By.XPath("//span[.='"+opdrachtNumber+"']")).Click();
            driverGC.FindElement(By.Id("continueItem")).Click();

            for (int i = 0; i < amountOfQuestions; i++)
            {
                string newQuestion = driverGC.FindElement(By.CssSelector("div[class='question'] p")).Text;
                var list = answers.ToList();
                foreach (var item in list)
                {
                    if (item.question == newQuestion)
                    {
                        Thread.Sleep(amountOfSeconds * 1000);

                        if (errorsDone != amountOfErrors)
                        {
                            var answerBox = driverGC.FindElement(By.Id("answer"));
                            answerBox.SendKeys(".");
                            driverGC.FindElement(By.Id("continueItem")).Click();
                            if (verify("subhead") == false) { driverGC.FindElement(By.Id("continueItem")).Click(); }

                            errorsDone++;
                        }
                        else
                        {
                            var answerBox = driverGC.FindElement(By.Id("answer"));
                            answerBox.SendKeys(item.answer);
                            driverGC.FindElement(By.Id("continueItem")).Click();
                            if (verify("subhead") == false) { driverGC.FindElement(By.Id("continueItem")).Click(); }

                        }
                    }
                }
            }
            driverGC.Navigate().GoToUrl("https://www.nedercomweb.nl/appl/coursemenu/course");
            MessageBox.Show(hoofdstuk + " " + paragraaf + "." + opdrachtNumber + " klaar");
        }

        public void makeMultipleChoice(string hoofdstuk, string opdrachtNumber, string paragraaf, int amountOfErrors)
        {
            int errorsDone = 0;
            var amountOf = driverGC.FindElement(By.ClassName("counter")).Text.Split(' ');
            amountOfQuestions = Int32.Parse(amountOf[3]);
            IList<AnswerHelper> answers = new List<AnswerHelper>();

            for (int i = 0; i < amountOfQuestions; i++)
            {
                Thread.Sleep(amountOfSeconds * 1000);

                string question = driverGC.FindElement(By.CssSelector("div[class='question_maxheight'] p")).Text; // Vraag text
                driverGC.FindElement(By.XPath("//input[@value='A'][@name='answer']")).Click();
                string correctAnswer = driverGC.FindElement(By.CssSelector("div[class='short_row correct'] div span")).Text; // Vraag text
                answers.Add(new AnswerHelper() { id = i.ToString(), question = question, answer = correctAnswer });
                driverGC.FindElement(By.Id("continueItem")).Click();
                int vraagNumber = i + 1;
                logRTB.AppendText("[ANSWER " + vraagNumber + "] >> Question:" + question + " Answer:" + correctAnswer + "\n");
            }

            driverGC.FindElement(By.Id("continueItem")).Click();
            driverGC.FindElement(By.Id("continueItem")).Click();
            driverGC.FindElement(By.XPath("//span[.='"+opdrachtNumber+"']")).Click();
            driverGC.FindElement(By.Id("continueItem")).Click();

            for (int i = 0; i != amountOfQuestions; i++)
            {
                string newQuestion = driverGC.FindElement(By.CssSelector("div.question_maxheight p")).Text;
                var list = answers.ToList();
                foreach (var item in list)
                {
                    if (item.question == newQuestion)
                    {
                        Thread.Sleep(amountOfSeconds * 1000);

                        if (errorsDone != amountOfErrors)
                        {
                            if (item.answer.ToUpper() == "A")
                            {
                                driverGC.FindElement(By.XPath("//input[@value='B'][@name='answer']")).Click();
                                driverGC.FindElement(By.Id("continueItem")).Click();
                            }
                            else
                            {
                                driverGC.FindElement(By.XPath("//input[@value='B'][@name='answer']")).Click();
                                driverGC.FindElement(By.Id("continueItem")).Click();
                            }
                            errorsDone++;
                        }
                        else
                        {
                            driverGC.FindElement(By.XPath("//input[@value='" + item.answer.ToUpper() + "'][@name='answer']")).Click();
                            driverGC.FindElement(By.Id("continueItem")).Click();
                        }
                    }
                }
            }
            driverGC.Navigate().GoToUrl("https://www.nedercomweb.nl/appl/coursemenu/course");
            MessageBox.Show(hoofdstuk + " " + paragraaf + "." + opdrachtNumber + " klaar");
        }

        public void makeDrag(string hoofdstuk, string opdrachtNumber, string paragraaf, int amountOfErrors)
        {
           // int errorsDone = 0; // haven't implemented errors yet cause lazy but don't want any warnings :$
            var amountOf = driverGC.FindElement(By.ClassName("amountOfQuestions")).Text.Split(' ');
            amountOfQuestions = Int32.Parse(amountOf[3]);

            IList<AnswerHelper> answers = new List<AnswerHelper>();

            int questionsDone = 0;
            for (int I = 0; I != amountOfQuestions; I++)
            { 
                Thread.Sleep(amountOfSeconds * 1000);
                var source = driverGC.FindElements(By.ClassName("dragButton"));
                var target = driverGC.FindElements(By.ClassName("dropzone"));
                string opdr = driverGC.FindElement(By.Id("head_1")).GetAttribute("innerHTML");

                int columnsdone = 0;
                for (int i = 0; i < source.Count; i++)
                {
                    Actions builder = new Actions(driverGC);
                    builder.DragAndDrop(source[columnsdone], target[1]).Release(source[columnsdone]).Build().Perform();
                    columnsdone++;
                }
                driverGC.FindElement(By.Id("continueItem")).Click();
                if (verify("result_inconclusive")) { driverGC.FindElement(By.Id("continueItem")).Click(); }
                var tablerow = driverGC.FindElements(By.TagName("tr"));
                for (int rows = 0; rows != tablerow.Count; rows++)
                {
                    var cell = tablerow[I].FindElements(By.TagName("td"));
                    for (int tds = 0; tds != cell.Count; tds++)
                    {
                        try
                        {
                            var answer = cell[tds].FindElement(By.ClassName("goodAnswer"));
                            logRTB.AppendText("[ANSWER " + questionsDone + ">" + I + "] Answer:" + answer.GetAttribute("innerHTML") + " >> " + tds + "\n");
                            answers.Add(new AnswerHelper() { id = opdr, question = answer.GetAttribute("innerHTML"), answer = tds.ToString() });
                        }
                        catch (NoSuchElementException)
                        {
                            try
                            {
                                var answer = cell[tds].FindElement(By.ClassName("answerButton"));
                                logRTB.AppendText("[ANSWER " + questionsDone + ">" + I + "] Answer:" + answer.GetAttribute("innerHTML") + " >> " + tds + "\n");
                                answers.Add(new AnswerHelper() { id = opdr, question = answer.GetAttribute("innerHTML"), answer = tds.ToString() });

                            }
                            catch (NoSuchElementException) { }
                        }
                    }
                }
               
                driverGC.FindElement(By.Id("continueItem")).Click();
            }

            driverGC.FindElement(By.Id("continueItem")).Click();
            driverGC.FindElement(By.Id("continueItem")).Click();
            driverGC.FindElement(By.XPath("//span[.='" + opdrachtNumber + "']")).Click();
            driverGC.FindElement(By.Id("continueItem")).Click();

            questionsDone = 0;
            for(int i = 0; i != amountOfQuestions; i++)
            { 
                Thread.Sleep(amountOfSeconds * 1000);
                var source = driverGC.FindElements(By.ClassName("dragButton"));
                var target = driverGC.FindElements(By.ClassName("dropzone"));
                string opdr2 = driverGC.FindElement(By.Id("head_1")).GetAttribute("innerHTML");

                for (int columnsdone = 0; columnsdone != amountOfQuestions; columnsdone++)
                {
                    var list = answers.ToList();
                    foreach (var item in list)
                    {
                        if(item.id == opdr2)
                        {
                            if (source[columnsdone].GetAttribute("innerHTML") == item.question)
                            {
                                Actions builder = new Actions(driverGC);
                                builder.DragAndDrop(source[columnsdone], target[Int32.Parse(item.answer)]).Release(source[columnsdone]).Build().Perform();
                            }
                        }
                    }

                }
                driverGC.FindElement(By.Id("continueItem")).Click();
                driverGC.FindElement(By.Id("continueItem")).Click();
            }
        }

        public Form1()
        {
            InitializeComponent();
            tabPage1.Enabled = false;
            settingsTab.Enabled = false;
            // maybe make this dynamic later :/
            hoofdstukCB.Items.Add("Basiscursus Spelling");
            hoofdstukCB.Items.Add("Basisgrammatica Nederlands");
            hoofdstukCB.Items.Add("Deinfach");
            hoofdstukCB.Items.Add("Dlogisch");
            hoofdstukCB.Items.Add("Formuleren 1");
            hoofdstukCB.Items.Add("Formuleren 2");
            hoofdstukCB.Items.Add("Grammatica Nederlands");
            hoofdstukCB.Items.Add("High Five");
            hoofdstukCB.Items.Add("Lees vaardig 1");
            hoofdstukCB.Items.Add("Lees vaardig 2");
            hoofdstukCB.Items.Add("Mind the Gap");
            hoofdstukCB.Items.Add("Spelling 1");
            hoofdstukCB.Items.Add("Spelling 2");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logRTB.AppendText("[INFO] Loaded\n");
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            startBrowser();
            loginNedercom(usernameTb.Text, passwordTb.Text);
    
        }

        private void enableMistakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if(enableMistakesCb.Checked)
            {
                randomMistakesCb.Enabled = true;
                randomMistakesLbl.Enabled = true;
                amountOfErrorsLbl.Enabled = true;
                amountOfMistakesCB.Enabled = true;
            }
            else
            {
                amountOfMistakes = 0;
                randomMistakesCb.Enabled = false;
                randomMistakesLbl.Enabled = false;
                amountOfErrorsLbl.Enabled = false;
                amountOfMistakesCB.Enabled = false;
            }
        }

        private void randomMistakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if(randomMistakesCb.Checked)
            {
                Random rnd = new Random();
                amountOfMistakes = rnd.Next(1, 4);
                amountOfErrorsLbl.Enabled = false;
                amountOfMistakesCB.Enabled = false;
            }
            else
            {
                amountOfMistakes =  (int)amountOfMistakesCB.Value;
                amountOfErrorsLbl.Enabled = true;
                amountOfMistakesCB.Enabled = true;
            }
        }
        

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            closeBrowser();
            usernameLbl.Enabled = true;
            PasswordLbl.Enabled = true;
            settingsTab.Enabled = false;
            logoutBtn.Enabled = false;
            usernameTb.ReadOnly = false;
            passwordTb.ReadOnly = false;
            tabPage1.Enabled = false;
            submitBtn.Enabled = true;
            accountGrp.Text = " Account  | Logged in: False";
            this.Text = "Lazycom | Not logged in";
        }

        private void amountOfMistakesCB_ValueChanged(object sender, EventArgs e)
        {
            amountOfMistakes = (int)amountOfMistakesCB.Value;
        }

        private void hoofdstukCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hoofdstuk = hoofdstukCB.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Paragraaf = ParagraafNumeric.Value.ToString();
        }

        private void OpdrachtNumeric_ValueChanged(object sender, EventArgs e)
        {
            Opdracht = OpdrachtNumeric.Value.ToString();
        }

        private void secondsNumeric_ValueChanged(object sender, EventArgs e)
        {
            amountOfSeconds = (int)secondsNumeric.Value;
        }

        private void startBotBtn_Click(object sender, EventArgs e)
        {
            if (Hoofdstuk == null || Opdracht == null || Paragraaf == null)
            {
                MessageBox.Show("Chapter, paragraph or assignment cannot be empty", "Error");
            }
            else
            {
                gotoOpdracht(Hoofdstuk, Paragraaf, Opdracht);
                if (verify("question"))
                {
                    logRTB.AppendText("[INFO] Making: " + Hoofdstuk + " " + Paragraaf + "." + Opdracht + ", With " + amountOfMistakes + " mistakes\n");
                    makeTextbox(Hoofdstuk, Opdracht, Paragraaf, amountOfMistakes);
                }
                else
                {
                    if (verify("question_maxheight"))
                    {
                        logRTB.AppendText("[INFO ]Making: " + Hoofdstuk + " " + Paragraaf + "." + Opdracht+ ", With "+amountOfMistakes+" mistakes\n");
                        makeMultipleChoice(Hoofdstuk, Opdracht, Paragraaf, amountOfMistakes);
                    }
                    else
                    {
                        logRTB.AppendText("[INFO ]Making: " + Hoofdstuk + " " + Paragraaf + "." + Opdracht + ", With " + amountOfMistakes + " mistakes\n");
                        makeDrag(Hoofdstuk, Opdracht, Paragraaf, amountOfMistakes);
                    }
                }
            } 
        }
    }
}
