using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.IRC;
using System.Net.IRC.Client;

namespace TIRCClient
{
    public partial class MainWindow : Form
    {
        //delegate void SetTextCallback(string text);
        delegate void setChannelCallback(Server server,Channel channel,string message);
        delegate void setServerCallback(Server server, string message);

        private Thread serverThread;
        public Server ircClient;
        public TreeNode selectedChannel = new TreeNode();

        public MainWindow()
        {
            InitializeComponent();
            serverThread = new Thread(new ThreadStart(ClientConnection));
            serverThread.Start();           
        }

        private void ClientConnection()
        {
            this.ircClient = new Server();
            this.ircClient.ServerCommandsSent += new ServerMessage(SentServerCommands);
            this.ircClient.ChannelReceivedMessages += new ChannelMessage(ReceivedChannelMessages);
            this.ircClient.ChannelSentMessages += new ChannelMessage(SentChannelMessages);
            this.ircClient.ChannelSentCommands += new ChannelMessage(SentChannelCommands);
            this.ircClient.ChannelReceivedCommands += new ChannelMessage(ReceivedChannelCommands);

            /*this.ircClient.UserJoinEvent += new ChannelMessage(ChannelEvent);
            this.ircClient.ServerEvent += new ServerMessage(ServerEvent);
            this.ircClient.SendEvent += new CommandSent(ServerEvent);
            this.ircClient.ChannelEvent += new ChannelMessage(ChannelEvent);*/
            this.ircClient.Connect("irc.freenode.net", 6667,"taftse taftse","Taftse|Test");
        }

        private void SentServerCommands(Server server, string message)
        {
            if (this.InvokeRequired)
            {
                setServerCallback s = new setServerCallback(SentServerCommands);
                this.Invoke(s, new object[] { server, message });
            }
            else
            {
                switch (message)
                {
                    case "CONNECT": this.JoindServer(server); break;
                    //default: this.PrintToChatWindow(server, message); break;
                }
            }
        }

        private void ReceivedChannelMessages(Server server, Channel channel, string message)
        {
            if (this.InvokeRequired)
            {
                setChannelCallback s = new setChannelCallback(ReceivedChannelMessages);
                this.Invoke(s, new object[] { server, channel, message });
            }
            else
            {
                this.PrintToChatWindow(server, message);
            }
        }

        private void SentChannelMessages(Server server, Channel channel, string message)
        {
            if (this.InvokeRequired)
            {
                setChannelCallback s = new setChannelCallback(SentChannelMessages);
                this.Invoke(s,new object[] {server,channel,message});
            }
            else
            {
                this.PrintToChatWindow(server, message);
            }
        }

        private void SentChannelCommands(Server server, Channel channel, string message)
        {
            if (this.InvokeRequired)
            {
                setChannelCallback s = new setChannelCallback(SentChannelCommands);
                this.Invoke(s, new object[] { server, channel, message });
            }
            else
            {
                switch (message)
                {
                    case "JOIN": this.JoinedChannel(server, channel); break;
                    case "PART": this.LeftChannel(server, channel); break;
                    //default: this.ChatWindow.AppendText(message + " \n"); break;
                }
            }
        }

        private void ReceivedChannelCommands(Server server, Channel channel, string message)
        {
            if (this.InvokeRequired)
            {
                setChannelCallback s = new setChannelCallback(ReceivedChannelCommands);
                this.Invoke(s, new object[] { server, channel, message });
            }
            else
            {
                switch (message)
                {
                    case "NAMES": this.UserBox.DataSource = channel.NickNames; break;
                    case "JOIN": this.UserBox.DataSource = channel.NickNames; break;
                    case "TOPIC": this.ChannelTitle.Text = channel.Title; break;
                }
            }
        }

        private void PrintToChatWindow(Server server, string message)
        {
            this.ChatWindow.AppendText("[" + DateTime.Now + "] " + message + "\r\n");
        }

        private void JoindServer(Server server)
        {
            
                TreeNode newServer = new TreeNode();
                newServer.Name = "serverNode_" + server.Name;
                newServer.Text = " " + server.Name;
                this.ChannelList.Nodes.Add(newServer);
                this.SelectChannelListNode(newServer);
        }

        private void JoinedChannel(Server server,Channel channel)
        {
                TreeNode newChannel = new TreeNode();
                newChannel.Name = "channelNode_"+ channel.Name;
                newChannel.Text = channel.Name;
                TreeNode[] serverNode = this.ChannelList.Nodes.Find("serverNode_" + server.Name, false);
                serverNode[0].Nodes.Add(newChannel);
                this.SelectChannelListNode(newChannel);
        }

        private void LeftChannel(Server server, Channel channel)
        {
            TreeNode[] serverNode = this.ChannelList.Nodes.Find("serverNode_" + server.Name, false);
            TreeNode[] channelNode = serverNode[0].Nodes.Find("channelNode_" + channel.Name, false);
            serverNode[0].Nodes.Remove(channelNode[0]);
        }

        private void Op_Click(object sender, EventArgs e)
        {
            
        }

        private void DeOp_Click(object sender, EventArgs e)
        {

        }

        private void Ban_Click(object sender, EventArgs e)
        {

        }

        private void Kick_Click(object sender, EventArgs e)
        {
            // sendChannelMessage("/KICK "+channelName+" "+NickName); 
        }

        private void SendFile_Click(object sender, EventArgs e)
        {

        }

        private void Dialog_Click(object sender, EventArgs e)
        {

        }

        private void NickNameButton_Click(object sender, EventArgs e)
        {
           NickNameDialog nickDialog = new NickNameDialog(this);
           nickDialog.Show();
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            serverThread.Abort();
            Application.Exit();
        }

        private void MesageWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == (char)Keys.Enter)
            {
                this.send_message();
            }
        }

        private void send_message()
        {

           /* string[] channelNameParts = new string[this.selectedChannel.Name.Split('_').Length];
                channelNameParts =this.selectedChannel.Name.Split('_');*/
            string channelName = this.ircClient.SelectedChannel;
            string value = MesageWindow.Text.ToString();
            //if (value.Split(' ').Length > 1)
           // {
                string[] valueParts = new string[value.Split(' ').Length];
                valueParts = value.Split(' ');
                switch (valueParts[0])
                {
                    case "/action":
                        value = value.Replace("/action", "ACTION");
                        this.ircClient.SendCommand("PRIVMSG", ":\u0001" + value + "\u0001", channelName); 
                        break;
                    case "/join": this.ircClient.JoinChannel(valueParts[1]); break;
                    case "/leave":
                        if (valueParts.Length > 1)
                        {
                            this.ircClient.LeaveChannel(valueParts[1]);
                        }
                        else
                        {
                            this.ircClient.LeaveChannel(channelName);
                        }
                        break;
                    case "/quit": this.ircClient.SendCommand("QUIT",null); break;
                    case "/msg": this.ircClient.SendCommand("PRIVMSG", ":" + valueParts[2], valueParts[1]); break;

                    default: this.ircClient.SendCommand("PRIVMSG", ":" + value, channelName); break;
                }
           /* }
            else
            {
                this.ircClient.SendCommand("PRIVMSG",":"+ value, channelName);
            }*/
            MesageWindow.Text = null;
        }

        private void SelectChannelListNode(TreeNode channel)
        {
            //this.selectedChannel = channel;
            string[] channelNameParts = new string[channel.Name.Split('_').Length];
            channelNameParts = channel.Name.Split('_');

           if (channelNameParts[0] == "serverNode")
            {
                if (this.ircClient.SelectedChannel != channelNameParts[1])
                {
                    this.ChannelList.SelectedNode = channel;
                    this.ircClient.SelectedChannel = channelNameParts[1];
                    Channel selectedServer = this.ircClient.getChannel(channelNameParts[1]);
                    this.ChatWindow.Text = selectedServer.Messages;
                    this.NickNameButton.Text = this.ircClient.NickName;
                    this.ChannelTitle.Text = "";
                    this.UserBox.DataSource = new List<string>();
                }
            }
            else if (channelNameParts[0] == "channelNode")
            {
                if (this.ircClient.SelectedChannel != channelNameParts[1])
                {
                    this.ChannelList.SelectedNode = channel;
                    this.ircClient.SelectedChannel = channelNameParts[1];
                    Channel selectedChannel = this.ircClient.getChannel(channelNameParts[1]);
                    this.ChatWindow.Text = selectedChannel.Messages;
                    this.ChannelTitle.Text = selectedChannel.Title;
                    this.UserBox.DataSource = selectedChannel.NickNames;
                }
            }
        }

        private void ChannelList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.SelectChannelListNode(e.Node);
        }
    }
}
