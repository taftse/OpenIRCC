using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace System.Net.IRC.Client
{
    public delegate void ServerMessage(Server server,string message);
    public delegate void CommandSent(Server server,string command);

    public class Server
    {
        // messages the user sends to the server 
        public event ChannelMessage ChannelSentMessages;
        // messages the client receives from the server 
        public event ChannelMessage ChannelReceivedMessages;
        // commands the user sends to the server 
        public event ChannelMessage ChannelSentCommands;
        // commands the client receives from the server 
        public event ChannelMessage ChannelReceivedCommands;

        public event ServerMessage ServerCommandsSent;

        public event ServerMessage ServerCommandsReceived;

        /*public event ChannelMessage ChannelEvent;
       
        public event ServerMessage ServerEvent;
        public event CommandSent SendEvent;
        public event ChannelMessage UserJoinEvent;
        public event ChannelMessage UserLeaveEvent;
        public event ServerMessage ConnectionTrafic;*/

        private string name;
        private string host;
        private int port;
        private string username;
        private string password;
        private string nickname;
        private string realName = "Timothy's IRC Client";
        private bool isConnected = false;
        private bool isInvisble = false;
        private string selectedChannel;
        private SortedDictionary<string,Channel> connectedChannels = new SortedDictionary<string,Channel>();

        private string[] hostNameParts;

        private TcpClient connection;
        private StreamReader reader;
        private StreamWriter writer;

        private Channel serverChannel;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Host
        {
            get { return this.host; }
        }

        public int Port
        {
            get { return this.port; }
        }

        public string NickName
        {
            get { return this.nickname; }
            set { this.ChangeNickName(value); }
        }

        public bool ISConnected
        {
            get { return this.isConnected; }
        }

        public string SelectedChannel
        {
            get { return this.selectedChannel; }
            set { this.selectedChannel = value; }
        }

        public Channel Channel
        {
            get { return this.getChannel(this.selectedChannel); }
        }

        public Channel getChannel(string channelName)
        {
            if (channelName == hostNameParts[1])
            {
                return this.serverChannel;
            }
            else
            {
                return this.connectedChannels[channelName];
            }
        }

        

        public Server()
        {

        }

        public void Connect(string host, int port)
        {
            this.Connect(host, port, null, null, null,null);
        }

        public void Connect(string host, int port, string nickname)
        {
            this.Connect(host, port, null, null, null, nickname);
        }

        public void Connect(string host, int port, string password, string nickname)
        {
            this.Connect(host, port, null, null, password, nickname);
        }

        public void Connect(string host, int port, string username, string name, string password, string nickname)
        {
            hostNameParts = new string[host.Split('.').Length];
            hostNameParts = host.Split('.');
            this.serverChannel = new Channel(this, hostNameParts[1]);
            this.host = host;
            this.port = port;
            this.username = username;
            this.nickname = nickname;
            if (name == null) { this.name = hostNameParts[1]; } else { this.name = name; }
            this.password = password;
            this.connection = new TcpClient(this.host, this.port);

            if (this.ServerCommandsSent != null) { this.ServerCommandsSent(this, "CONNECT"); }

            this.reader = new StreamReader(this.connection.GetStream());
            this.writer = new StreamWriter(this.connection.GetStream());
            this.Authenticate();
            this.isConnected = true;
            this.Listen();
        }

        public void SentChannelMessages(Channel channel,string message)
        {
            if (this.selectedChannel == channel.Name)
            {
                if (this.ChannelSentMessages != null)
                {
                    this.ChannelSentMessages(this, channel, message.Trim());
                }
            }
        }

        public void ReceivedChannelMessages(Channel channel, string message)
        {
            if (this.selectedChannel == channel.Name)
            {
                if (this.ChannelReceivedMessages != null)
                {
                    this.ChannelReceivedMessages(this, channel, message.Trim());
                }
            }
        }

        public void SentChannelCommands(Channel channel, string message)
        {
            if (this.selectedChannel == channel.Name)
            {
                if (this.ChannelSentCommands != null)
                {
                    this.ChannelSentCommands(this, channel, message);
                }
            }
        }

        public void ReceivedChannelCommands(Channel channel, string message)
        {
            if (this.selectedChannel == channel.Name)
            {
                if (this.ChannelReceivedCommands != null)
                {
                    this.ChannelReceivedCommands(this, channel, message);
                }
            }
        }

        public void Disconnect()
        {
            this.writer.Close();
            this.reader.Close();
            this.connection.Close();
            this.isConnected = false;
        }

        private void Authenticate()
        {
            if (this.password != null)
            {
                this.SendCommand("PASS", this.password);
            }
            this.SendCommand("NICK", this.nickname);

            string isVisable = this.isInvisble ? "8" : "0";
            if (this.username != null)
            {
                this.SendCommand("USER", this.username + " " + isVisable + " " + this.realName);
            }
            else
            {
                this.SendCommand("USER", this.NickName + " " + isVisable + " " + this.realName);
            }
        }

        private void Listen()
        {
            while (true)
            {
                string command;
                while ((command = this.reader.ReadLine()) != null)
                {
                   /* if (ConnectionTrafic != null)
                    {
                        this.ConnectionTrafic(this, command);
                    }
                    */
                    if (ServerCommandsReceived != null)
                    {
                        this.ServerCommandsReceived(this, command);
                    }

                    string[] commandParts = new string[command.Split(' ').Length];
                    commandParts = command.Split(' ');

                    if (commandParts[0].Substring(0, 1) == ":")
                    {
                        commandParts[0] = commandParts[0].Remove(0, 1);
                    }

                    string[] commandhostParts = new string[commandParts[0].Split('.').Length];
                    commandhostParts = commandParts[0].Split('.');


                    if (commandParts.Length > 3 && (connectedChannels.ContainsKey(commandParts[2]) == true))
                    {
                        this.connectedChannels[commandParts[2]].recevedCommands(commandParts);
                    }
                    else if (commandParts.Length > 4 && (connectedChannels.ContainsKey(commandParts[3]) == true))
                    {
                        this.connectedChannels[commandParts[3]].recevedCommands(commandParts);
                    }

                    else if (commandParts.Length > 5 && (connectedChannels.ContainsKey(commandParts[4]) == true))
                    {
                        this.connectedChannels[commandParts[4]].recevedCommands(commandParts);
                    }
                    else
                    {
                        if ((commandParts[0] == this.host) || (commandhostParts.Length > 1 && commandhostParts[1] == this.hostNameParts[1] && commandhostParts[2] == this.hostNameParts[2]))
                        {
                            switch (commandParts[1])
                            {
                                // case "332": break;
                                //case "333":
                                //case "353": /*this.serverChannel.setNickNames(commandParts);//*/this.connectedChannels[commandParts[4]].setNickNames(commandParts);/* setNamesList(commandParts);*/
                                //   break;
                                /* case "431":*/
                                case "451": this.Authenticate(); break;
                                default: this.IncomingServerMessage(commandParts); break;
                            }
                        }
                        else if (commandParts[0] == "PING")
                        {
                            this.Ping(commandParts);
                        }
                        else
                        {
                            // this.serverChannel.recevedCommands(commandParts);
                            string commandAction = commandParts[1];

                            switch (commandAction)
                            {
                                //case "JOIN": this.JoinChannel(commandParts[2]); break;
                                case "PART": break;
                                case "MODE": break;
                                case "NICK": break;
                                case "KICK": break;
                                case "QUIT": break;
                                case "ERROR": this.Disconnect(); this.IncomingServerMessage(commandParts); break;
                                default: this.IncomingServerMessage(commandParts); break;
                            }
                        }

                    }
                }
                this.Disconnect();
                break;
            }
        }

        private void Ping(string[] command)
        {
            string PingHash = "";
            for (int intI = 1; intI < command.Length; intI++)
            {
                PingHash += command[intI] + " ";
            }
            this.SendCommand("PONG", PingHash,false);
            if (this.ServerCommandsSent != null)
            {
                this.ServerCommandsSent(this, "PONG " + PingHash);
            }
        }

        private void IncomingServerMessage(string[] command)
        {
            string serverMessage = "";
            for (int intI = 0; intI < command.Length; intI++)
            {
                serverMessage += command[intI] +" ";
                
            }
            //if (ServerEvent != null) { this.ServerEvent(this,serverMessage.Trim()); }

            this.serverChannel.recevedCommands(command);
        }

        private void ReceveMessage(string[] commandParts)
        {
            Channel channel = this.connectedChannels[commandParts[2]];
            string channelMessage = "";
            for (int intI = 2;intI <commandParts.Length;intI++)
            {
                channelMessage += " "+commandParts[intI];
            }
            channel.ReceveMessage(commandParts[0], channelMessage);
           // if (ChannelEvent != null) { this.ChannelEvent(this, channel, channelMessage); }
            
        }

        /**
         * for when the client joins a channel
         */
        public void JoinChannel(string channelName)
        {
           this.SendCommand("JOIN",channelName);
           Channel joinedChannel = new Channel(this,channelName);
           this.connectedChannels.Add(channelName,joinedChannel);
           //if (this.ChannelEvent != null) { this.ChannelEvent(this, joinedChannel, "JOIN"); } 
           if (this.ChannelSentCommands != null)
           {
               this.ChannelSentCommands(this, joinedChannel, "JOIN");
           }
        }

        /**
         * for when the client leaves a channel
         */
        public void LeaveChannel(string channelName)
        {
            if (this.connectedChannels.ContainsKey(channelName))
            {
                this.SendCommand("PART",channelName);
                this.connectedChannels.Remove(channelName);
                if (this.ChannelSentCommands != null) 
                { 
                   // this.ChannelSentCommands(this, this.connectedChannels[channelName], "PART"); 
                }
            }
            else
            {
                // return system message (You are not a memeber if the channel)
            }
        }

        public void SendCommand(string Command, string value)
        {
            this.SendCommand(Command, value, true);
        }

        public void SendCommand(string Command, string value, bool print)
        {
            this.SendCommand(Command, value, null, print);
        }

        public void SendCommand(string Command, string value, string channel)
        {
            this.SendCommand(Command, value, channel, true);
        }

        public void SendCommand(string command, string value, string channel, bool print)
        {
            if (channel != null)
            {
                if (print == true)
                {
                   /* if (this.SendEvent != null)
                    {
                        this.SendEvent(this, command + " " + channel + " " + value);
                    }*/
                    if(this.ServerCommandsSent != null)
                    {
                        this.ServerCommandsSent(this,command + " " + channel + " " + value);
                    }
                    this.connectedChannels[channel].sendCommand(command, value, print);   
                }
                this.writer.WriteLine(command + " " + channel + " " + value);
            }
            else
            {
                if (print == true)
                {
                   /* if (this.SendEvent != null)
                    {
                        this.SendEvent(this, command + " " + value);
                    }*/
                    if(this.ServerCommandsSent != null)
                    {
                        this.ServerCommandsSent(this,command + " " + value);
                    }
                    this.serverChannel.sendCommand(command, value, print);
                }
                this.writer.WriteLine(command + " " + value);
            }
            this.writer.Flush();
        }

        public void ChangeNickName(string newNickname)
        {
            if (newNickname != this.nickname)
            {
                this.SendCommand("NICK", newNickname);
                this.nickname = newNickname;
            }
        }
    }
} 