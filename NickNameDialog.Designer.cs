using System.Windows.Forms;
namespace TIRCClient
{
    partial class NickNameDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.nickNameTextBox = new System.Windows.Forms.TextBox();
            this.nickOKbutton = new System.Windows.Forms.Button();
            this.nickCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter new Nickname: ";
            // 
            // nickNameTextBox
            // 
            this.nickNameTextBox.Location = new System.Drawing.Point(147, 12);
            this.nickNameTextBox.Name = "nickNameTextBox";
            this.nickNameTextBox.Size = new System.Drawing.Size(125, 20);
            this.nickNameTextBox.TabIndex = 1;
            this.nickNameTextBox.KeyPress += new KeyPressEventHandler(this.nick_KeyDown);
            // 
            // nickOKbutton
            // 
            this.nickOKbutton.Location = new System.Drawing.Point(197, 38);
            this.nickOKbutton.Name = "nickOKbutton";
            this.nickOKbutton.Size = new System.Drawing.Size(75, 23);
            this.nickOKbutton.TabIndex = 2;
            this.nickOKbutton.Text = "OK";
            this.nickOKbutton.UseVisualStyleBackColor = true;
            this.nickOKbutton.Click += new System.EventHandler(this.nickOKbutton_Click);
            // 
            // nickCancelButton
            // 
            this.nickCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nickCancelButton.Location = new System.Drawing.Point(116, 38);
            this.nickCancelButton.Name = "nickCancelButton";
            this.nickCancelButton.Size = new System.Drawing.Size(75, 23);
            this.nickCancelButton.TabIndex = 3;
            this.nickCancelButton.Text = "Cancel";
            this.nickCancelButton.UseVisualStyleBackColor = true;
            // 
            // NickNameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.nickCancelButton;
            this.ClientSize = new System.Drawing.Size(284, 69);
            this.Controls.Add(this.nickCancelButton);
            this.Controls.Add(this.nickOKbutton);
            this.Controls.Add(this.nickNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NickNameDialog";
            this.Text = "Enter new nickname";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.nickNameTextBox.KeyPress += new KeyPressEventHandler(this.nick_KeyDown);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nickNameTextBox;
        private System.Windows.Forms.Button nickOKbutton;
        private System.Windows.Forms.Button nickCancelButton;
    }
}