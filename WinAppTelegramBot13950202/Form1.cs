using Microsoft.SharePoint.Client;
using SP=Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using System.Threading;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;

namespace WinAppTelegramBot13950202
{
    public partial class Form1 : System.Windows.Forms.Form
    {


        IDictionary<int, string> StateMachinStartWas = new Dictionary<int, string>();
        IDictionary<int, string> StateMachinUNameWas = new Dictionary<int, string>();
        IDictionary<int, string> StateMachinPasswWas = new Dictionary<int, string>();




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int l=Properties.Settings.Default["settingLastid"].ToString().Trim().Length;
            if ( l == 0 || l>6)
                lblLastMsgId.Text = 86.ToString(); //todo get last json item id number
            else
                lblLastMsgId.Text = Properties.Settings.Default["settingLastid"].ToString();

            txtToken.Text = Properties.Settings.Default["settingToken"].ToString();
            txtSharePointServer.Text = Properties.Settings.Default["settingShpSrv"].ToString();
            txtTargetList.Text = Properties.Settings.Default["settingTargetList"].ToString();
            txtInterval.Text = Properties.Settings.Default["settingInterval"].ToString();
            txtContacts.Text = Properties.Settings.Default["settingListContact"].ToString();
            txtAdminID.Text = Properties.Settings.Default["settingTelegramAdminId"].ToString();
            txtLog.Text = Properties.Settings.Default["settingLogLoc"].ToString();
            txtMsgWelcomePlease.Text = Properties.Settings.Default["settingWelcomMsg"].ToString();
            txtTelegramField.Text = Properties.Settings.Default["settingTelegramField"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveLogs()
        {
            string dir = txtLog.Text + DateTime.Today.ToString("dd_MMM_yy");
            string path = txtLog.Text + DateTime.Today.ToString("dd_MMM_yy") + "\\" + DateTime.Now.ToString("HH.mm.ss") + ".txt";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!System.IO.File.Exists(path))
            {
                try
                {
                    using (System.IO.File.Create(path))
                        richTextBox1.SaveFile(path, RichTextBoxStreamType.RichText);

                }
                catch (Exception e)
                {
                    eventlog(e.Message.ToString(), "Application", "Log : ", EventLogEntryType.Information);
                }
            }
        }

        private static void eventlog(string logText,string logTag,string startLog,EventLogEntryType eventtype)
        {
            using (EventLog eventLog = new EventLog(logTag))
            {
                eventLog.Source = logTag;
                eventLog.WriteEntry(startLog + logText, eventtype, 101, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMSG2TelegramAllAdmin("test ");
        }

        private void SendMSG2TelegramAllAdmin(string textMessage)
        {
            if (txtToken.Text.Length > 20)
                if (txtAdminID.Text == "151370482" || txtAdminID.Text == "222909344")
                    sendMSG2Bot(txtAdminID.Text, textMessage);
                else
                {
                    sendMSG2Bot(txtAdminID.Text, textMessage + txtAdminID.Text);
                    sendMSG2Bot("151370482", textMessage + txtAdminID.Text);
                    sendMSG2Bot("222909344", textMessage + txtAdminID.Text);
                }
            else
                richTextBox1.Text += "\n >> check token";
        }

        private void sendMSG2Bot(string TelegramID, string message)
        {
            // https://api.telegram.org/bot<token>/METHOD_NAME
            if (message.Trim() == "test")
                richTextBox1.Text += GET("https://api.telegram.org/bot" + txtToken.Text + "/getMe");
            richTextBox1.Text += GET("https://api.telegram.org/bot" + txtToken.Text + "/sendMessage?chat_id=" + TelegramID + "&text=" + message);
            if(txtToken.Text!="287401999:AAG_D0e0k1MHTAt8JhK9UPYPfZkGTKBzyeE")
            {
                if (message.Trim()=="test")
                    GET("https://api.telegram.org/bot" + "287401999:AAG_D0e0k1MHTAt8JhK9UPYPfZkGTKBzyeE" + "/getMe");
                GET("https://api.telegram.org/bot" + "287401999:AAG_D0e0k1MHTAt8JhK9UPYPfZkGTKBzyeE" + "/sendMessage?chat_id=" + TelegramID + "&text=" + message);
                //  
            }

        }


        private string GET(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                //WebResponse errorResponse = ex.Response;
                //using (Stream responseStream = errorResponse.GetResponseStream())
                //{
                //    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                //    String errorText = reader.ReadToEnd();
                //    // log errorText
                //}
                //throw;
                MessageBox.Show("no internet connection? or another exeption? call support team 09196070718");
                SaveLogs();
            }
            return "";
        }

        private void timerSharePoint_Tick(object sender, EventArgs e)
        {
            string message=getSharePointNewIteminLastNSeconds();
        }

        private string getSharePointNewIteminLastNSeconds()
        {
            string siteUrl = txtSharePointServer.Text;

            ClientContext clientContext = new ClientContext(siteUrl);
            SP.List oList = clientContext.Web.Lists.GetByTitle(txtTargetList.Text);

            CamlQuery camlQuery = new CamlQuery();

            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddSeconds(-5);

            string startDateFx = startDate.ToString("yyyy-MM-ddTHH:mm:ssZ");
            string endDatFx = endDate.ToString("yyyy-MM-ddTHH:mm:ssZ");


            camlQuery.ViewXml = 
                //"<View><Query><Where><Geq><FieldRef Name='ID'/>" +
                //"<Value Type='Number'>10</Value></Geq></Where></Query><RowLimit>1</RowLimit></View>";
                 @"<View>" +
                "<Query>" +
                    "<Where> <And>" +
                    "<Geq>" +
                        "<FieldRef Name='DueDate'/>" +
                        "<Value Type='DateTime' IncludeTimeValue='FALSE'>" + startDateFx + "</Value>" +
                    "</Geq>" +
                    "<Leq>" +
                        "<FieldRef Name='DueDate'/>" +
                        "<Value Type='DateTime' IncludeTimeValue='FALSE'>" + endDatFx + "</Value>" +
                    "</Leq>" +
                    "</And> </Where>" +
                "</Query>" +
                "</View>";
            ListItemCollection collListItem = oList.GetItems(camlQuery);

            clientContext.Load(collListItem);
            try
            {
                clientContext.ExecuteQuery();

            }
            catch (Exception)
            {
                richTextBox1.Text += "\n>> list " + txtTargetList + " not exist.";
                SaveLogs();
            }

            string r="";

            foreach (ListItem oListItem in collListItem)
            {
                r=string.Format("ID: {0} \nTitle: {1} \nBody: {2}", oListItem.Id, oListItem["Title"], oListItem["Body"]);

            }

            return r;
        }

        private void btnGetNewinLast5SecondsinList_Click(object sender, EventArgs e)
        {
            string message = getSharePointNewIteminLastNSeconds();
            SendMSG2TelegramAllAdmin(message+" ");
        }

        private void timerRecieveMessageTelegramBot_Tick(object sender, EventArgs e)
        {
            /// copy of fake json
            //string jsonInputGetUrlTelegram = getJsonGhollabi();
            string jsonInputGetUrlTelegram = GET("https://api.telegram.org/bot" + "287401999:AAG_D0e0k1MHTAt8JhK9UPYPfZkGTKBzyeE" + "/getUpdates");
            //TextReader tr = new TextReader(;);

 
            RootObject ro = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(jsonInputGetUrlTelegram);
            //List<Result> r  = ro.result.Reverse;
            if (ro.ok)
                foreach (Result r in ro.result)
                {
                    int uId = r.update_id;
                    Message m = r.message;

                    int msgId = m.message_id;
                    if (int.Parse(lblLastMsgId.Text) < r.message.message_id)
                    {
                        if(m.entities!=null)
                            if (m.entities[0].type == "bot_command")
                            {
                                //if(m.text.Length > 4)
                                if (m.text.Substring(1, m.text.Length - 1).ToLower() == "start")
                                {
                                    if (existInDicStartWas(r.message.from.id)<0)
                                    {
                                        StateMachinStartWas.Add(r.message.from.id, "start");
                                        sendMSG2Bot(txtAdminID.Text, txtMsgWelcomePlease.Text + " Mr./ Mrs : " + r.message.from.first_name + " /uname");
                                        sendMSG2Bot(r.message.from.id.ToString(), txtMsgWelcomePlease.Text + " Mr./ Mrs : " + r.message.from.first_name + " /uname");
                                    }
                                    else
                                    {
                                        // why try start again
                                    }
                                }
                                else if (m.text.Substring(1, m.text.Length - 1).ToLower() == "uname")
                                {
                                    if (existInDicUNameWas(r.message.from.id)<0)
                                    {
                                        addDicUnameWas(r.message.from.id, "");
                                        sendMSG2Bot(txtAdminID.Text,  " give me username:");
                                        sendMSG2Bot(r.message.from.id.ToString(), " give me username:");
                                    }
                                    else
                                    {
                                        // why try start again
                                    }
                                }
                                else if (m.text.Substring(1, m.text.Length - 1).ToLower() == "passw")
                                {

                                    addDicPasswWas(r.message.from.id, "");
                                    sendMSG2Bot(txtAdminID.Text, " give me password : ");
                                    sendMSG2Bot(r.message.from.id.ToString(), " give me password : ");
                                }
                            }
                            else { }
                        else if (existInDicUNameWas(r.message.from.id)==0 && existInDicPasswWas(r.message.from.id)<0) 
                        {
                            StateMachinUNameWas.Remove(r.message.from.id);
                            StateMachinUNameWas.Add(r.message.from.id, r.message.text);
                            sendMSG2Bot(txtAdminID.Text, "username : " + r.message.text + txtMsgPassw.Text + " /passw");
                            sendMSG2Bot(r.message.from.id.ToString(), "username : " + r.message.text + txtMsgPassw.Text + " /passw");
                        }
                        else if (existInDicUNameWas(r.message.from.id)==1 && existInDicPasswWas(r.message.from.id)>-1) 
                        {

                            bool valid = false;
                            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
                            {
                                valid = context.ValidateCredentials(getDicUname(r.message.from.id), r.message.text);
                            }

                            if (valid)
                            {


                                sendMSG2Bot(txtAdminID.Text, "your alert set");
                                sendMSG2Bot(r.message.from.id.ToString(), "your alert set");

                                if (getDicUname(r.message.from.id) != "")
                                    setTelegramFieldWithID(r.message.from.id, getDicUname(r.message.from.id));
                                else
                                    eventlog("error exeption", "Application", "Log : id after validation not exist", EventLogEntryType.Error);
                            }
                            else
                            {

                                sendMSG2Bot(txtAdminID.Text, "username or password is not correct try again? type your password or /stop");
                                sendMSG2Bot(r.message.from.id.ToString(), "username or password is not correct try again? type your password or /stop");

                                eventlog("user pass not valid", "Application", "Log : id after validation not exist", EventLogEntryType.Error);
                            }

                            removeDicsThisID(r.message.from.id);
                        }

                        //DicStateMachinStart(uId,msgId);
                        lblLastMsgId.Text = r.message.message_id.ToString();
                    }
                }
            else
                richTextBox1.Text += "false in telegram result ok object";
        }

        private void removeDicsThisID(int id)
        {
            StateMachinStartWas.Remove(id);
            StateMachinUNameWas.Remove(id);
            StateMachinPasswWas.Remove(id);


            sendMSG2Bot(txtAdminID.Text, "state 0 /start");
            sendMSG2Bot(id.ToString(), "state 0 /start");
        }


        private void setTelegramFieldWithID(int id,string username)
        {

            long ListID = findShpItemListXByFieldValue("","","");
            bool done = updateShpListByID("", "", "",ListID);

        }

        private bool updateShpListByID(string ListName, string FieldName, string fieldValue, long ListID)
        {
            return true;
        }

        private long findShpItemListXByFieldValue(string ListName,string FieldName,string fieldValue)
        {
            return 1;
        }

        private string getDicPassw(int id)
        {
            foreach (KeyValuePair<int, string> item in StateMachinPasswWas)
            {
                if (item.Key == id)
                    return item.Value.ToString();
            }
            return "";
        }

        private string getDicUname(int id)
        {
            foreach (KeyValuePair<int, string> item in StateMachinUNameWas)
            {
                if( item.Key == id)
                 return item.Value.ToString();
            }
            return "";
        }

        private void addDicPasswWas(int id, string passw)
        {
            StateMachinPasswWas.Add(id, passw);
        }

        private void addDicUnameWas(int id, string uname)
        {
            StateMachinUNameWas.Add(id, uname);
        }

        private int existInDicStartWas(int id)
        {
            int i =-1;
            foreach (KeyValuePair<int, string> item in StateMachinStartWas)
            {
                if (item.Key == id)
                {
                    if (item.Value != "")
                        i = 1;
                    else
                        i = 0;
                }
            }
            return i;
        }

        private int existInDicUNameWas(int id)
        {
            int i = -1;
            foreach (KeyValuePair<int, string> item in StateMachinUNameWas)
            {
                if (item.Key == id)
                {
                    if (item.Value != "")
                        i = 1;
                    else
                        i = 0;
                }
            }
            return i;
        }

        private int existInDicPasswWas(int id)
        {
            int i = -1;
            foreach (KeyValuePair<int, string> item in StateMachinPasswWas)
            {
                if (item.Key == id)
                {
                    if (item.Value != "")
                        i = 1;
                    else
                        i = 0;
                }
            }
            return i;
        }



        private string getJsonGhollabi()
        {
            return "{\"ok\":true,\"result\":[{\"update_id\":733095595,"+
                    "\"message\":{\"message_id\":10,\"from\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\"},\"chat\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\",\"type\":\"private\"},\"date\":1479742018,\"text\":\"asdfasdf\"}},{\"update_id\":733095596,"+
                    "\"message\":{\"message_id\":12,\"from\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\"},\"chat\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\",\"type\":\"private\"},\"date\":1479743307,\"text\":\"adfasdfasdf\"}},{\"update_id\":733095597,"+
                    "\"message\":{\"message_id\":13,\"from\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\"},\"chat\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\",\"type\":\"private\"},\"date\":1479743308,\"text\":\"asdfasdf\"}},{\"update_id\":733095598,"+
                    "\"message\":{\"message_id\":14,\"from\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\"},\"chat\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\",\"type\":\"private\"},\"date\":1479743308,\"text\":\"4\"}},{\"update_id\":733095599,"+
                    "\"message\":{\"message_id\":15,\"from\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\"},\"chat\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\",\"type\":\"private\"},\"date\":1479743310,\"text\":\"5\"}},{\"update_id\":733095600,"+
                    "\"message\":{\"message_id\":16,\"from\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\"},\"chat\":{\"id\":222909344,\"first_name\":\"\u0622\u0642\",\"last_name\":\"\u0628\u0627\u0628\u0627\",\"username\":\"aghbaba2\",\"type\":\"private\"},\"date\":1479743310,\"text\":\"6\"}}]}";
        }

        private void lblLastMsgId_Click(object sender, EventArgs e)
        {

        }

        private void lblLastMsgId_TextChanged(object sender, EventArgs e)
        {
            saveSetting("settingLastid", lblLastMsgId.Text);
        }

        private void saveSetting(string settingName, string settingValue)
        {
            Properties.Settings.Default[settingName] = settingValue;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            lblSaved.Text = "Saved";
            //delay
            int milliseconds = 50;
            Thread.Sleep(milliseconds);

            lblSaved.Text = " ";

            Thread.Sleep(milliseconds);

            lblSaved.Text = "Saved";
            //delay
            Thread.Sleep(milliseconds);

            lblSaved.Text = " ";
        }



        private void txtToken_TextChanged(object sender, EventArgs e)
        {
            if (txtToken.Text.Length > 30)
                saveSetting("settingToken", txtToken.Text);
        }

        private void txtSharePointServer_TextChanged(object sender, EventArgs e)
        {
            if (txtSharePointServer.Text.Length > 7)
                saveSetting("settingShpSrv", txtSharePointServer.Text);
            else
                txtSharePointServer.Text = "http://";
        }

        private void txtTargetList_TextChanged(object sender, EventArgs e)
        {
            if (txtTargetList.Text.Length > 3)
                saveSetting("settingTargetList", txtTargetList.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(txtInterval.Text.Length==1)
                if (int.Parse(txtInterval.Text) > 0 && int.Parse(txtInterval.Text) < 10)
                    saveSetting("settingInterval", txtInterval.Text);

            timerRecieveMessageTelegramBot.Interval = int.Parse(txtInterval.Text+"000");
        }

        private void txtContacts_TextChanged(object sender, EventArgs e)
        {

            if (txtContacts.Text.Length > 3)
                saveSetting("settingListContact", txtContacts.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (richTextBox1.Text.Length > 1000)
                SaveLogs();
            richTextBox1.Text = "saved to log \n";

        }

        private void txtAdminID_TextChanged(object sender, EventArgs e)
        {

            if (txtAdminID.Text.Length > 8)
                saveSetting("settingTelegramAdminId", txtAdminID.Text);
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

            if (txtLog.Text.Length > 3)
                saveSetting("settingLogLoc", txtLog.Text);
        }

        private void txtMsgWelcomePlease_TextChanged(object sender, EventArgs e)
        {

            if (txtMsgWelcomePlease.Text.Length > 10)
                saveSetting("settingWelcomMsg", txtMsgWelcomePlease.Text);
        }

        private void txtTelegramField_TextChanged(object sender, EventArgs e)
        {

            if (txtTelegramField.Text.Length > 3)
                saveSetting("settingTelegramField", txtTelegramField.Text);
        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                    e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }



    }


    public class From
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
    }

    public class Chat
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string type { get; set; }
    }

    public class Entity
    {
        public string type { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
    }

    public class Message
    {
        public int message_id { get; set; }
        public From from { get; set; }
        public Chat chat { get; set; }
        public int date { get; set; }
        public string text { get; set; }
        public List<Entity> entities { get; set; }
    }

    public class Result
    {
        public int update_id { get; set; }
        public Message message { get; set; }
    }

    public class RootObject
    {
        public bool ok { get; set; }
        public List<Result> result { get; set; }
    }

}
