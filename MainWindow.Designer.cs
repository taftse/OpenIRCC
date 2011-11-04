using System.Windows.Forms;
namespace TIRCClient
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UserBox = new System.Windows.Forms.ListBox();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.tIRCClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewServerTab = new System.Windows.Forms.ToolStripMenuItem();
            this.NewChannelTab = new System.Windows.Forms.ToolStripMenuItem();
            this.NewServerWinow = new System.Windows.Forms.ToolStripMenuItem();
            this.NewChannelWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Detach = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.topicBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefrencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChannelList = new System.Windows.Forms.TreeView();
            this.NickNameButton = new System.Windows.Forms.Button();
            this.MesageWindow = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ChannelCount = new System.Windows.Forms.Panel();
            this.OpsNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalUsers = new System.Windows.Forms.Label();
            this.OpsText = new System.Windows.Forms.Label();
            this.ChannelTitle = new System.Windows.Forms.TextBox();
            this.ModeButtons = new System.Windows.Forms.Panel();
            this.Mode_L_TextBox = new System.Windows.Forms.TextBox();
            this.ModeButton_L = new System.Windows.Forms.CheckBox();
            this.Mode_K_TextBox = new System.Windows.Forms.TextBox();
            this.ModeButton_K = new System.Windows.Forms.CheckBox();
            this.ModeButton_B = new System.Windows.Forms.CheckBox();
            this.ModeButton_M = new System.Windows.Forms.CheckBox();
            this.ModeButton_P = new System.Windows.Forms.CheckBox();
            this.ModeButton_I = new System.Windows.Forms.CheckBox();
            this.ModeButton_S = new System.Windows.Forms.CheckBox();
            this.ModeButton_N = new System.Windows.Forms.CheckBox();
            this.ModeButton_T = new System.Windows.Forms.CheckBox();
            this.UserListButtons = new System.Windows.Forms.Panel();
            this.SendFile = new System.Windows.Forms.Button();
            this.Dialog = new System.Windows.Forms.Button();
            this.Ban = new System.Windows.Forms.Button();
            this.Kick = new System.Windows.Forms.Button();
            this.Op = new System.Windows.Forms.Button();
            this.DeOp = new System.Windows.Forms.Button();
            this.ChatWindow = new System.Windows.Forms.RichTextBox();
            this.MenuBar.SuspendLayout();
            this.ChannelCount.SuspendLayout();
            this.ModeButtons.SuspendLayout();
            this.UserListButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserBox
            // 
            this.UserBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UserBox.FormattingEnabled = true;
            this.UserBox.Location = new System.Drawing.Point(762, 54);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(134, 446);
            this.UserBox.TabIndex = 0;
            // 
            // MenuBar
            // 
            this.MenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuBar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tIRCClientToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.serverToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(-3, -2);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuBar.Size = new System.Drawing.Size(346, 24);
            this.MenuBar.TabIndex = 1;
            this.MenuBar.Text = "menuStrip1";
            // 
            // tIRCClientToolStripMenuItem
            // 
            this.tIRCClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkList,
            this.toolStripSeparator1,
            this.newToolStripMenuItem,
            this.toolStripSeparator2,
            this.Detach,
            this.Close,
            this.toolStripSeparator3,
            this.exitApplication});
            this.tIRCClientToolStripMenuItem.Name = "tIRCClientToolStripMenuItem";
            this.tIRCClientToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.tIRCClientToolStripMenuItem.Text = "TIRCClient";
            // 
            // networkList
            // 
            this.networkList.Name = "networkList";
            this.networkList.Size = new System.Drawing.Size(152, 22);
            this.networkList.Text = "Network List";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewServerTab,
            this.NewChannelTab,
            this.NewServerWinow,
            this.NewChannelWindow});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // NewServerTab
            // 
            this.NewServerTab.Name = "NewServerTab";
            this.NewServerTab.Size = new System.Drawing.Size(165, 22);
            this.NewServerTab.Text = "Server Tab";
            // 
            // NewChannelTab
            // 
            this.NewChannelTab.Name = "NewChannelTab";
            this.NewChannelTab.Size = new System.Drawing.Size(165, 22);
            this.NewChannelTab.Text = "Channel Tab";
            // 
            // NewServerWinow
            // 
            this.NewServerWinow.Name = "NewServerWinow";
            this.NewServerWinow.Size = new System.Drawing.Size(165, 22);
            this.NewServerWinow.Text = "Server Window";
            // 
            // NewChannelWindow
            // 
            this.NewChannelWindow.Name = "NewChannelWindow";
            this.NewChannelWindow.Size = new System.Drawing.Size(165, 22);
            this.NewChannelWindow.Text = "Channel Window";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // Detach
            // 
            this.Detach.Name = "Detach";
            this.Detach.Size = new System.Drawing.Size(152, 22);
            this.Detach.Text = "Detach";
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(152, 22);
            this.Close.Text = "Close";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // exitApplication
            // 
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Size = new System.Drawing.Size(152, 22);
            this.exitApplication.Text = "Exit";
            this.exitApplication.Click += new System.EventHandler(this.exitApplication_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.topicBarToolStripMenuItem,
            this.userListToolStripMenuItem,
            this.userListButtonsToolStripMenuItem,
            this.modeButtonsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem1.Text = "MenuBar";
            // 
            // topicBarToolStripMenuItem
            // 
            this.topicBarToolStripMenuItem.Checked = true;
            this.topicBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topicBarToolStripMenuItem.Name = "topicBarToolStripMenuItem";
            this.topicBarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.topicBarToolStripMenuItem.Text = "TopicBar";
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.Checked = true;
            this.userListToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.userListToolStripMenuItem.Text = "UserList";
            // 
            // userListButtonsToolStripMenuItem
            // 
            this.userListButtonsToolStripMenuItem.Checked = true;
            this.userListButtonsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.userListButtonsToolStripMenuItem.Name = "userListButtonsToolStripMenuItem";
            this.userListButtonsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.userListButtonsToolStripMenuItem.Text = "UserList Buttons";
            // 
            // modeButtonsToolStripMenuItem
            // 
            this.modeButtonsToolStripMenuItem.Checked = true;
            this.modeButtonsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modeButtonsToolStripMenuItem.Name = "modeButtonsToolStripMenuItem";
            this.modeButtonsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.modeButtonsToolStripMenuItem.Text = "Mode Buttons";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prefrencesToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // prefrencesToolStripMenuItem
            // 
            this.prefrencesToolStripMenuItem.Name = "prefrencesToolStripMenuItem";
            this.prefrencesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.prefrencesToolStripMenuItem.Text = "Prefrences";
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.advancedToolStripMenuItem.Text = "Advanced";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banListToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // banListToolStripMenuItem
            // 
            this.banListToolStripMenuItem.Name = "banListToolStripMenuItem";
            this.banListToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.banListToolStripMenuItem.Text = "Ban List";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.contentToolStripMenuItem.Text = "Content";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ChannelList
            // 
            this.ChannelList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ChannelList.HideSelection = false;
            this.ChannelList.Location = new System.Drawing.Point(0, 25);
            this.ChannelList.Name = "ChannelList";
            this.ChannelList.Size = new System.Drawing.Size(141, 563);
            this.ChannelList.TabIndex = 3;
            this.ChannelList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ChannelList_AfterSelect);
            // 
            // NickNameButton
            // 
            this.NickNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NickNameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NickNameButton.FlatAppearance.BorderSize = 0;
            this.NickNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NickNameButton.Location = new System.Drawing.Point(147, 563);
            this.NickNameButton.Name = "NickNameButton";
            this.NickNameButton.Size = new System.Drawing.Size(63, 23);
            this.NickNameButton.TabIndex = 5;
            this.NickNameButton.Text = "username";
            this.NickNameButton.UseVisualStyleBackColor = true;
            this.NickNameButton.Click += new System.EventHandler(this.NickNameButton_Click);
            // 
            // MesageWindow
            // 
            this.MesageWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MesageWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesageWindow.Location = new System.Drawing.Point(207, 564);
            this.MesageWindow.Name = "MesageWindow";
            this.MesageWindow.Size = new System.Drawing.Size(551, 23);
            this.MesageWindow.TabIndex = 6;
            this.MesageWindow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MesageWindow_KeyPress);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(762, 501);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 10);
            this.progressBar1.TabIndex = 7;
            // 
            // ChannelCount
            // 
            this.ChannelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChannelCount.Controls.Add(this.OpsNum);
            this.ChannelCount.Controls.Add(this.label1);
            this.ChannelCount.Controls.Add(this.TotalUsers);
            this.ChannelCount.Controls.Add(this.OpsText);
            this.ChannelCount.Location = new System.Drawing.Point(763, 25);
            this.ChannelCount.Name = "ChannelCount";
            this.ChannelCount.Size = new System.Drawing.Size(133, 23);
            this.ChannelCount.TabIndex = 8;
            // 
            // OpsNum
            // 
            this.OpsNum.AutoSize = true;
            this.OpsNum.Location = new System.Drawing.Point(1, 6);
            this.OpsNum.Name = "OpsNum";
            this.OpsNum.Size = new System.Drawing.Size(37, 13);
            this.OpsNum.TabIndex = 3;
            this.OpsNum.Text = "00000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "000000";
            // 
            // TotalUsers
            // 
            this.TotalUsers.AutoSize = true;
            this.TotalUsers.Location = new System.Drawing.Point(101, 5);
            this.TotalUsers.Name = "TotalUsers";
            this.TotalUsers.Size = new System.Drawing.Size(27, 13);
            this.TotalUsers.TabIndex = 1;
            this.TotalUsers.Text = "total";
            // 
            // OpsText
            // 
            this.OpsText.AutoSize = true;
            this.OpsText.Location = new System.Drawing.Point(37, 5);
            this.OpsText.Name = "OpsText";
            this.OpsText.Size = new System.Drawing.Size(27, 13);
            this.OpsText.TabIndex = 0;
            this.OpsText.Text = "ops,";
            // 
            // ChannelTitle
            // 
            this.ChannelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ChannelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelTitle.Location = new System.Drawing.Point(147, 25);
            this.ChannelTitle.Name = "ChannelTitle";
            this.ChannelTitle.Size = new System.Drawing.Size(382, 23);
            this.ChannelTitle.TabIndex = 9;
            // 
            // ModeButtons
            // 
            this.ModeButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeButtons.Controls.Add(this.Mode_L_TextBox);
            this.ModeButtons.Controls.Add(this.ModeButton_L);
            this.ModeButtons.Controls.Add(this.Mode_K_TextBox);
            this.ModeButtons.Controls.Add(this.ModeButton_K);
            this.ModeButtons.Controls.Add(this.ModeButton_B);
            this.ModeButtons.Controls.Add(this.ModeButton_M);
            this.ModeButtons.Controls.Add(this.ModeButton_P);
            this.ModeButtons.Controls.Add(this.ModeButton_I);
            this.ModeButtons.Controls.Add(this.ModeButton_S);
            this.ModeButtons.Controls.Add(this.ModeButton_N);
            this.ModeButtons.Controls.Add(this.ModeButton_T);
            this.ModeButtons.Location = new System.Drawing.Point(531, 25);
            this.ModeButtons.Name = "ModeButtons";
            this.ModeButtons.Size = new System.Drawing.Size(230, 23);
            this.ModeButtons.TabIndex = 10;
            // 
            // Mode_L_TextBox
            // 
            this.Mode_L_TextBox.Location = new System.Drawing.Point(200, 2);
            this.Mode_L_TextBox.Name = "Mode_L_TextBox";
            this.Mode_L_TextBox.Size = new System.Drawing.Size(27, 20);
            this.Mode_L_TextBox.TabIndex = 13;
            // 
            // ModeButton_L
            // 
            this.ModeButton_L.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeButton_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton_L.Location = new System.Drawing.Point(180, 0);
            this.ModeButton_L.Name = "ModeButton_L";
            this.ModeButton_L.Size = new System.Drawing.Size(20, 23);
            this.ModeButton_L.TabIndex = 11;
            this.ModeButton_L.Text = "L";
            this.ModeButton_L.UseVisualStyleBackColor = true;
            // 
            // Mode_K_TextBox
            // 
            this.Mode_K_TextBox.Location = new System.Drawing.Point(152, 2);
            this.Mode_K_TextBox.Name = "Mode_K_TextBox";
            this.Mode_K_TextBox.Size = new System.Drawing.Size(27, 20);
            this.Mode_K_TextBox.TabIndex = 12;
            // 
            // ModeButton_K
            // 
            this.ModeButton_K.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeButton_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton_K.Location = new System.Drawing.Point(131, 0);
            this.ModeButton_K.Name = "ModeButton_K";
            this.ModeButton_K.Size = new System.Drawing.Size(20, 23);
            this.ModeButton_K.TabIndex = 11;
            this.ModeButton_K.Text = "K";
            this.ModeButton_K.UseVisualStyleBackColor = true;
            // 
            // ModeButton_B
            // 
            this.ModeButton_B.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeButton_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton_B.Location = new System.Drawing.Point(112, 0);
            this.ModeButton_B.Name = "ModeButton_B";
            this.ModeButton_B.Size = new System.Drawing.Size(20, 23);
            this.ModeButton_B.TabIndex = 11;
            this.ModeButton_B.Text = "B";
            this.ModeButton_B.UseVisualStyleBackColor = true;
            // 
            // ModeButton_M
            // 
            this.ModeButton_M.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeButton_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton_M.Location = new System.Drawing.Point(93, 0);
            this.ModeButton_M.Name = "ModeButton_M";
            this.ModeButton_M.Size = new System.Drawing.Size(20, 23);
            this.ModeButton_M.TabIndex = 11;
            this.ModeButton_M.Text = "M";
            this.ModeButton_M.UseVisualStyleBackColor = true;
            // 
            // ModeButton_P
            // 
            this.ModeButton_P.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeButton_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton_P.Location = new System.Drawing.Point(74, 0);
            this.ModeButton_P.Name = "ModeButton_P";
            this.ModeButton_P.Size = new System.Drawing.Size(20, 23);
            this.ModeButton_P.TabIndex = 11;
            this.ModeButton_P.Text = "P";
            this.ModeButton_P.UseVisualStyleBackColor = true;
            // 
            // ModeButton_I
            // 
            this.ModeButton_I.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeButton_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton_I.Location = new System.Drawing.Point(58, 0);
            this.ModeButton_I.Name = "ModeButton_I";
            this.ModeButton_I.Size = new System.Drawing.Size(17, 23);
            this.ModeButton_I.TabIndex = 11;
            this.ModeButton_I.Text = "I";
            this.ModeButton_I.UseVisualStyleBackColor = true;
            // 
            // ModeButton_S
            // 
            this.ModeButton_S.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeButton_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton_S.Location = new System.Drawing.Point(39, 0);
            this.ModeButton_S.Name = "ModeButton_S";
            this.ModeButton_S.Size = new System.Drawing.Size(20, 23);
            this.ModeButton_S.TabIndex = 11;
            this.ModeButton_S.Text = "S";
            this.ModeButton_S.UseVisualStyleBackColor = true;
            // 
            // ModeButton_N
            // 
            this.ModeButton_N.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeButton_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton_N.Location = new System.Drawing.Point(20, 0);
            this.ModeButton_N.Name = "ModeButton_N";
            this.ModeButton_N.Size = new System.Drawing.Size(20, 23);
            this.ModeButton_N.TabIndex = 1;
            this.ModeButton_N.Text = "N";
            this.ModeButton_N.UseVisualStyleBackColor = true;
            // 
            // ModeButton_T
            // 
            this.ModeButton_T.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeButton_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton_T.Location = new System.Drawing.Point(1, 0);
            this.ModeButton_T.Name = "ModeButton_T";
            this.ModeButton_T.Size = new System.Drawing.Size(20, 23);
            this.ModeButton_T.TabIndex = 0;
            this.ModeButton_T.Text = "T";
            this.ModeButton_T.UseVisualStyleBackColor = true;
            // 
            // UserListButtons
            // 
            this.UserListButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UserListButtons.Controls.Add(this.SendFile);
            this.UserListButtons.Controls.Add(this.Dialog);
            this.UserListButtons.Controls.Add(this.Ban);
            this.UserListButtons.Controls.Add(this.Kick);
            this.UserListButtons.Controls.Add(this.Op);
            this.UserListButtons.Controls.Add(this.DeOp);
            this.UserListButtons.Location = new System.Drawing.Point(763, 513);
            this.UserListButtons.Name = "UserListButtons";
            this.UserListButtons.Size = new System.Drawing.Size(133, 75);
            this.UserListButtons.TabIndex = 11;
            // 
            // SendFile
            // 
            this.SendFile.Location = new System.Drawing.Point(3, 49);
            this.SendFile.Name = "SendFile";
            this.SendFile.Size = new System.Drawing.Size(65, 23);
            this.SendFile.TabIndex = 16;
            this.SendFile.Text = "SendFile";
            this.SendFile.UseVisualStyleBackColor = true;
            this.SendFile.Click += new System.EventHandler(this.SendFile_Click);
            // 
            // Dialog
            // 
            this.Dialog.Location = new System.Drawing.Point(67, 49);
            this.Dialog.Name = "Dialog";
            this.Dialog.Size = new System.Drawing.Size(65, 23);
            this.Dialog.TabIndex = 15;
            this.Dialog.Text = "Dialog";
            this.Dialog.UseVisualStyleBackColor = true;
            this.Dialog.Click += new System.EventHandler(this.Dialog_Click);
            // 
            // Ban
            // 
            this.Ban.Location = new System.Drawing.Point(3, 26);
            this.Ban.Name = "Ban";
            this.Ban.Size = new System.Drawing.Size(65, 23);
            this.Ban.TabIndex = 14;
            this.Ban.Text = "Ban";
            this.Ban.UseVisualStyleBackColor = true;
            this.Ban.Click += new System.EventHandler(this.Ban_Click);
            // 
            // Kick
            // 
            this.Kick.Location = new System.Drawing.Point(67, 26);
            this.Kick.Name = "Kick";
            this.Kick.Size = new System.Drawing.Size(65, 23);
            this.Kick.TabIndex = 13;
            this.Kick.Text = "Kick";
            this.Kick.UseVisualStyleBackColor = true;
            this.Kick.Click += new System.EventHandler(this.Kick_Click);
            // 
            // Op
            // 
            this.Op.Location = new System.Drawing.Point(3, 3);
            this.Op.Name = "Op";
            this.Op.Size = new System.Drawing.Size(65, 23);
            this.Op.TabIndex = 12;
            this.Op.Text = "OP";
            this.Op.UseVisualStyleBackColor = true;
            this.Op.Click += new System.EventHandler(this.Op_Click);
            // 
            // DeOp
            // 
            this.DeOp.Location = new System.Drawing.Point(67, 3);
            this.DeOp.Name = "DeOp";
            this.DeOp.Size = new System.Drawing.Size(65, 23);
            this.DeOp.TabIndex = 0;
            this.DeOp.Text = "DeOP";
            this.DeOp.UseVisualStyleBackColor = true;
            this.DeOp.Click += new System.EventHandler(this.DeOp_Click);
            // 
            // ChatWindow
            // 
            this.ChatWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatWindow.Location = new System.Drawing.Point(147, 54);
            this.ChatWindow.Name = "ChatWindow";
            this.ChatWindow.ReadOnly = true;
            this.ChatWindow.Size = new System.Drawing.Size(613, 508);
            this.ChatWindow.TabIndex = 12;
            this.ChatWindow.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 590);
            this.Controls.Add(this.ChatWindow);
            this.Controls.Add(this.UserListButtons);
            this.Controls.Add(this.ChannelTitle);
            this.Controls.Add(this.ChannelCount);
            this.Controls.Add(this.MesageWindow);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ModeButtons);
            this.Controls.Add(this.NickNameButton);
            this.Controls.Add(this.ChannelList);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ChannelCount.ResumeLayout(false);
            this.ChannelCount.PerformLayout();
            this.ModeButtons.ResumeLayout(false);
            this.ModeButtons.PerformLayout();
            this.UserListButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserBox;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem tIRCClientToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TreeView ChannelList;
        private System.Windows.Forms.Button NickNameButton;
        private System.Windows.Forms.TextBox MesageWindow;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel ChannelCount;
        private System.Windows.Forms.ToolStripMenuItem networkList;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewServerTab;
        private System.Windows.Forms.ToolStripMenuItem NewChannelTab;
        private System.Windows.Forms.ToolStripMenuItem NewServerWinow;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem NewChannelWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Detach;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitApplication;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem topicBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeButtonsToolStripMenuItem;
        private System.Windows.Forms.TextBox ChannelTitle;
        private System.Windows.Forms.Panel ModeButtons;
        private System.Windows.Forms.CheckBox ModeButton_T;
        private System.Windows.Forms.TextBox Mode_K_TextBox;
        private System.Windows.Forms.CheckBox ModeButton_K;
        private System.Windows.Forms.CheckBox ModeButton_B;
        private System.Windows.Forms.CheckBox ModeButton_M;
        private System.Windows.Forms.CheckBox ModeButton_P;
        private System.Windows.Forms.CheckBox ModeButton_I;
        private System.Windows.Forms.CheckBox ModeButton_S;
        private System.Windows.Forms.CheckBox ModeButton_N;
        private System.Windows.Forms.TextBox Mode_L_TextBox;
        private System.Windows.Forms.CheckBox ModeButton_L;
        private System.Windows.Forms.Label OpsNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalUsers;
        private System.Windows.Forms.Label OpsText;
        private System.Windows.Forms.Panel UserListButtons;
        private System.Windows.Forms.Button SendFile;
        private System.Windows.Forms.Button Dialog;
        private System.Windows.Forms.Button Ban;
        private System.Windows.Forms.Button Kick;
        private System.Windows.Forms.Button Op;
        private System.Windows.Forms.Button DeOp;
        private System.Windows.Forms.ToolStripMenuItem prefrencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.RichTextBox ChatWindow;
    }
}

