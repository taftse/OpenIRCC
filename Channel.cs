using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace System.Net.IRC.Client
{
    public delegate void ChannelMessage(Server server, Channel channel, string message);

    public class Channel
    {

        public event ChannelMessage ChannelEvent;

        private string name;
        private string title ="";
       // private string titleCreater;
        private Server server;
        //private List<string> nickNames;
        private List<User> nickNames;
       

        //private List<string> messages = new List<string>();
        private string messages = "";


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Title
        {
            get { return this.title; }
        }

        public Server Server
        {
            get { return this.server; }
        }

        public string Messages
        {
            get { return this.messages; }
        }

        public List<User> NickNames
        {
            get { return this.nickNames; }
        }

        public Channel(Server server, string name)
        {
            this.nickNames = new List<User>();
            this.server = server;
            this.name = name;
        }


        public void Join(string username)
        {
            User user = new User(username);
            this.nickNames.Add(user);
            //this.nickNames.Sort();
            this.server.ReceivedChannelCommands(this, "JOIN");
        }

        public void Leave(string username)
        {
           // this.nickNames.Remove(username);
           
            this.server.ReceivedChannelCommands(this, "PART");
        }

        public void recevedCommands(string[] commandParts)
        {
            string commandAction = commandParts[1];
            switch (commandAction)
            {
                case "332":
                case "333": this.setTitle(commandParts); break;
                case "353": this.setNickNames(commandParts); break;
                case "366": break;
                case "328": break;
                case "JOIN": this.Join(commandParts[0]); break;
                case "PART": break;
                case "MODE": break;
                case "NICK": break;
                case "KICK": break;
                case "QUIT": break;
                case "PRIVMSG": this.ReceveMessage(commandParts); break;
                default: this.ReceveMessage(commandParts); break;
            }
        }

        public void setTitle(string[] commandParts)
        {
            if (commandParts[1] == "332")
            {
                string title = "";
                if (commandParts[4].Substring(0, 1) == ":")
                {
                    commandParts[4] = commandParts[4].Remove(0, 1);
                }

                for (int intI = 4; intI < commandParts.Length; intI++)
                {
                    title += " " + commandParts[intI];
                }
                this.messages += title + " \n";
                this.title += title;
                this.server.ReceivedChannelMessages(this, title);
                this.server.ReceivedChannelCommands(this, "TOPIC");
            }
            else if (commandParts[1] == "333")
            {
                string message = "Topic for " + this.name + " set by " + commandParts[4] + " on " + " \n";
                this.messages += message;
                this.server.ReceivedChannelMessages(this, message);
            }
        }

        public void setNickNames(string[] commandParts)
        {
            for (int intI = 6; intI < commandParts.Length; intI++)
            {
                User newUser = new User(commandParts[intI]);
                this.nickNames.Add(newUser);
            }
            //this.nickNames.Sort();
            this.server.ReceivedChannelCommands(this, "NAMES");
        }

        public void ReceveMessage(string[] commandParts)
        {
            string channelMessage = "";
            for (int intI = 2; intI < commandParts.Length; intI++)
            {
                channelMessage += " " + commandParts[intI];
            }
            messages += commandParts[0] + " " + channelMessage + " \n";
            this.server.ReceivedChannelMessages(this, commandParts[0] + " " + channelMessage);
        }

        public void ReceveMessage(string user, string channelMessage)
        {
            messages +=user + " " + channelMessage+" \n";
            this.server.ReceivedChannelMessages(this, channelMessage);
        }

        public void SendMessage(string message)
        {
            this.messages += message + "\r\n";
            this.server.SentChannelMessages(this, message);
        }



        public void sendCommand(string command, string value, bool print)
        {

            if (command == "PRIVMSG")
            {
                this.SendMessage(value);
            }
            else
            {
                if (print == true)
                {
                    messages += command + " " + value + " \n";
                }
            }

            //this.server.ChannelSentMessages(this, command + " " + value + " \n");
            /*if (print == true)
                {
                    if (this.SendEvent != null)
                    {
                        this.SendEvent(this, command + " " + value);
                    }
                   messages +=(command + " " + channelMessage+" \n");
                }
                this.server.Writer.WriteLine(command + " " + value);
            }
            this.server.Writer.Flush();*/
        }
    }
}
