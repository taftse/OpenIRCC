using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


namespace System.Net.IRC.Client
{
    /*public delegate void SystemMessage(string SystemMessage);
    public delegate void CommandReceived(string IrcCommand);
   // public delegate void CommandSent(string IrcCommand);
  //  public delegate void ServerMessage(string ServerMessage);
    

    public class IRCClient
    {
        public event SystemMessage eventSystemMessage;
        public event CommandReceived eventReceiving;
        public event CommandSent eventSent;
        public event ServerMessage eventServerMessage;
        public event SystemMessage serverConnect;
        public event SystemMessage joinChannel;

        

        private string host;
        private int port;
        private string nick;
        private string user;
        private string password;
        private string realname = "Taftse's Client";
        private bool isInvisible;
        private Hashtable joinedChannels;
        private string[] hostnameParts;
        private Server thisServer;

        private TcpClient connection;
        private StreamReader reader;
        private StreamWriter writer;

        public string Host
        {
            get { return this.host; }
        }

        public int Port
        {
            get { return this.port; }
        }

        public string UserName
        {
            get { return this.user; }
        }

        public string Password
        {
            get { return this.password; }
        }

        public string NickName
        {
            get { return this.nick; }
            set { this.ChangeNick(value); }
        }

        public bool IsInvisble
        {
            get { return this.isInvisible; }
            set { this.isInvisible = value; }
        }

        public IRCClient()
        {

        }

        public void Connect(string host, int port)
        {
            this.Connect(host, port, null, null, null);
        }

        public void Connect(string host, int port, string nickname)
        {
            this.Connect(host, port, null, null, nickname);
        }

        public void Connect(string host, int port, string username, string password, string nickname)
        {
            hostnameParts = new string[host.Split('.').Length];
            hostnameParts = host.Split('.');
            
            this.host = host;
            this.port = port;
            this.user = username;
            this.password = password;
            this.nick = nickname;
            this.thisServer = new Server();
            this.thisServer.Connect(this.host, this.port, this.nick, this.user, this.password);
            this.connection = new TcpClient(this.host, this.port);
            this.SystemMessage("Connected To: " + this.host);
            if (this.serverConnect != null) { this.serverConnect(hostnameParts[1]); }
            this.reader = new StreamReader(this.connection.GetStream());
            this.writer = new StreamWriter(this.connection.GetStream());
            
            this.authenticate("TaftseTest","taftse", "taftse taftse");
            this.SendCommand("JOIN", "#codeigniter");
            this.Listen();
           
        }

        public void authenticate(string nickName)
        {
            this.authenticate(nickName, this.user, this.password);
        }

        public void authenticate(string nickName ,string username)
        {
            this.authenticate(nickName,username,this.password);
        }

        public void authenticate(string nickName,string username,string password)
        {

            if (password != null)
            {
                this.SendCommand("PASS",password,false);
                this.password = password;
            }

            this.SendCommand("NICK", nickName);
            this.nick = nickName;

            string isVisable = this.IsInvisble? "8" :"0";
            if (username != null)
            {
               this.SendCommand("USER",username + " " + isVisable + " " + this.realname);
               this.user = username;
            }
        }

        private void Listen()
        {
            while (true)
            {
                string command;
                while ((command = this.reader.ReadLine()) != null)
                {
                    if (eventReceiving != null)
                    {
                        this.eventReceiving(command);
                    }
                    string[] commandParts = new string[command.Split(' ').Length];
                    commandParts = command.Split(' ');
                    
                    if (commandParts[0].Substring(0, 1) == ":")
                    {
                        commandParts[0] = commandParts[0].Remove(0, 1);
                    }

                    string[] commandhostParts = new string[commandParts[0].Split('.').Length];
                    commandhostParts = commandParts[0].Split('.');
                    if ((commandParts[0] == this.host) ||(commandhostParts.Length > 1 &&commandhostParts[1] == this.hostnameParts[1] && commandhostParts[2] == this.hostnameParts[2]))
                    {
                       switch (commandParts[1])
                        {
                            case "332": break;
                            case "353": this.setNamesList(commandParts); break;
                            case "451": authenticate(this.nick); break;
                            default: this.ServerMessage(commandParts); break;
                        }
                    }
                    else if (commandParts[0] == "PING")
                    {
                        this.Ping(commandParts);
                    }
                    else
                    {
                        string commandAction = commandParts[1];
                        switch (commandAction)
                        {
                            case "JOIN": break;
                            case "PART": break;
                            case "MODE": break;
                            case "NICK": break;
                            case "KICK": break;
                            case "QUIT": break;
                        }
                    }

                }
                this.writer.Close();
                this.reader.Close();
                this.connection.Close();
            }
        }

        private void Ping(string[] command)
        {
            string PingHash = "";
            for (int intI = 1; intI < command.Length; intI++)
            {
                PingHash += command[intI] + " ";
            }
            this.SendCommand("PONG",PingHash);
        }

        public void SendCommand(string Command, string value)
        {
            this.SendCommand(Command, value, true);
        }

        public void SendCommand(string Command, string value,bool print)
        {
            this.SendCommand(Command, value, null,print);
        }

        public void SendCommand(string Command, string value,string channel)
        {
            this.SendCommand(Command, value, channel, true);
        } 

        public void SendCommand(string Command,string value,string channel,bool print)
        {
            if (channel != null)
            {
                if (print == true)
                {
                    this.eventSent(Command + " " + channel + " " + value);
                }
                this.writer.WriteLine(Command + " " + channel + " " + value);
            }
            else
            {
                if (print == true)
                {
                    this.eventSent(Command + " " + value);
                }
                this.writer.WriteLine(Command + " " + value);
            }
            this.writer.Flush();
        }

        private void SystemMessage(string message)
        {
            this.eventSystemMessage(message);
        }

        private void ServerMessage(string[] command)
        {
            string ServerMessage = "";
            for (int intI = 1; intI < command.Length; intI++)
            {
                ServerMessage += command[intI] + " ";
            }
            if (eventServerMessage != null) { this.eventServerMessage(ServerMessage.Trim()); }
        }

        public void ChangeNick(string newNick)
        {
            if (this.nick != newNick)
            {
                SendCommand("NICK", newNick);
                this.nick = newNick;
            }
        }

        public void setNamesList(string[]commandParts)
        {

        }
        /*public void getAllChannels()
        {
          
        }

        public void JoinChannel(string channelName)
        {
            this.writer.WriteLine("JOIN "+channelName);
            this.writer.Flush();
            this.channels.
        }*/
    /*}*/
}
