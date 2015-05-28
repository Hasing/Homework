using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace OnlineRadio
{
    public partial class Form1 : Form
    {
        private WebBrowser webBrowser = new WebBrowser();
        private Timer timer = new Timer();
        private readonly string redioUrl = "http://hichannel.hinet.net/radio/index.do";

        public Form1()
        {
            InitializeComponent();
            InitWebBrowser();
            TimerSetting();
            InitButtionClickEvent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region InitWebBrowser

        private void InitWebBrowser()
        {
            webBrowser.Navigate(redioUrl + "?id=248");
            webBrowser.NewWindow += (s, e) => e.Cancel = true;
            webBrowser.DocumentCompleted += WebBrowserCompletedEventHandler;
        }

        #endregion

        #region InitRadioListBox

        private void InitRadioListBox(Dictionary<string, string> radioDic)
        {
            radioListBox.DataSource = new BindingSource(radioDic, null);
            radioListBox.DisplayMember = "Value";
            radioListBox.DoubleClick += (sender, e) =>
            {
                var listBox = sender as ListBox;
                if (listBox != null)
                {
                    var item = (KeyValuePair<string, string>)listBox.SelectedItem;
                    webBrowser.Document.InvokeScript("changeRadio", new object[] { item.Key });
                    radioName.Text = radioDic[item.Key];
                }
            };
        }

        #endregion

        #region TimerSetting

        private void TimerSetting()
        {
            timer.Interval = 100;
            timer.Tick += (s, e) =>
            {
                if (radioName.Left < this.Width)
                {
                    radioName.Left += 10;
                    return;
                }

                radioName.Left = radioName.Width * -1;
            };
        }

        #endregion

        #region InitButtionClickEvent

        private void InitButtionClickEvent()
        {
            previous.Click += NextAndPreviousClickEventHandler;
            next.Click += NextAndPreviousClickEventHandler;
            play.Click += (s, e) =>
            {
                if (play.Tag == "Stop")
                {
                    timer.Stop();
                    play.BackgroundImage = Properties.Resources.play;
                    play.Tag = "Start";
                }
                else
                {
                    timer.Start();
                    play.BackgroundImage = Properties.Resources.stop;
                    play.Tag = "Stop";
                }

                webBrowser.Document.InvokeScript("play");
            };
        }

        #endregion

        #region WebBrowserCompletedEventHandler

        private void WebBrowserCompletedEventHandler(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            CreateJavaScriptFunction();
            var content = webBrowser.Document.GetElementById("contentDiv").GetElementsByTagName("ul");

            if (!content.IsNullOrEmpty())
            {
                if (webBrowser.ReadyState == WebBrowserReadyState.Complete)
                    webBrowser.Refresh();

                var itemList = content[0].GetElementsByTagName("li");

                if (!itemList.IsNullOrEmpty())
                {
                    var radioDic = new Dictionary<string, string>();

                    foreach (HtmlElement item in itemList)
                    {
                        var radioNameElements = item.GetElementsByTagName("p");
                        if (!radioNameElements.IsNullOrEmpty())
                        {
                            radioDic.Add(item.GetAttribute("rel"), radioNameElements[0].InnerText);
                        }
                    }

                    InitRadioListBox(radioDic);
                    radioName.Text = radioDic.First().Value;
                    timer.Start();               
                    webBrowser.DocumentCompleted -= WebBrowserCompletedEventHandler;
                    
                }
            }         
        }

        #endregion
                    
        #region NextAndPreviousClickEventHandler

        private void NextAndPreviousClickEventHandler(object sender, EventArgs e)
        {
            var button = sender as Button;
            int selectIndex = radioListBox.SelectedIndex + Convert.ToInt16(button.Tag);

            if (selectIndex < 0 || selectIndex > radioListBox.Items.Count - 1)
                return;

            radioListBox.SelectedIndex = selectIndex;
            var selectItem = (KeyValuePair<string, string>)radioListBox.SelectedValue;
            radioName.Text = selectItem.Value;
            webBrowser.Document.InvokeScript("changeRadio", new object[] { selectItem.Key });
        }

        #endregion

        #region CreateJavaScriptFunction

        private void CreateJavaScriptFunction()
        {
            var element = webBrowser.Document.CreateElement("script");
            element.SetAttribute("text", @"function play(){
                                                $('#play').click();
                                           }
                                           function changeRadio(id){
                                                indexUtil.play(id);
                                            }");
            webBrowser.Document.Body.AppendChild(element);
        }

        #endregion
    }
}
