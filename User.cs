using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace System.Net.IRC.Client
{
    public class User
    {
        private string nickName = "";
        private string connection = "";
        private Color nickColor;
        private string[] modes;

        public string NickName
        {
            get { return this.nickName; }
            set { this.nickName = value; }
        }

        public Color Color
        {
            get { return this.nickColor; }
        }

        public string[] Modes
        {
            get { return this.modes; }
        }

        public User(string nickName)
        {
            //split on !~
            this.nickName = nickName;
            Random random = new Random();
            this.nickColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }

        public override string ToString()
        {
            return nickName;
        }
    }
}
