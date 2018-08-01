namespace MSMQ1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.MessagetxtBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.UserIdTxt = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserIdsList = new System.Windows.Forms.ListView();
            this.RefereshListBtn = new System.Windows.Forms.Button();
            this.UserIds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessagetxtBox
            // 
            this.MessagetxtBox.Location = new System.Drawing.Point(12, 64);
            this.MessagetxtBox.Name = "MessagetxtBox";
            this.MessagetxtBox.Size = new System.Drawing.Size(391, 96);
            this.MessagetxtBox.TabIndex = 1;
            this.MessagetxtBox.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Receive";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(195, 12);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 3;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // UserIdTxt
            // 
            this.UserIdTxt.Location = new System.Drawing.Point(72, 15);
            this.UserIdTxt.Name = "UserIdTxt";
            this.UserIdTxt.Size = new System.Drawing.Size(100, 20);
            this.UserIdTxt.TabIndex = 4;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(12, 18);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(44, 13);
            this.userNameLbl.TabIndex = 5;
            this.userNameLbl.Text = "Your Id:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userNameLbl);
            this.panel1.Controls.Add(this.RegisterBtn);
            this.panel1.Controls.Add(this.UserIdTxt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 39);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UserIdsList);
            this.panel2.Location = new System.Drawing.Point(488, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 209);
            this.panel2.TabIndex = 7;
            // 
            // UserIdsList
            // 
            this.UserIdsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserIds});
            this.UserIdsList.Location = new System.Drawing.Point(3, 3);
            this.UserIdsList.Name = "UserIdsList";
            this.UserIdsList.Size = new System.Drawing.Size(194, 192);
            this.UserIdsList.TabIndex = 0;
            this.UserIdsList.UseCompatibleStateImageBehavior = false;
            this.UserIdsList.ItemActivate += new System.EventHandler(this.UserIdsList_ItemActivate);
            // 
            // RefereshListBtn
            // 
            this.RefereshListBtn.Location = new System.Drawing.Point(491, 226);
            this.RefereshListBtn.Name = "RefereshListBtn";
            this.RefereshListBtn.Size = new System.Drawing.Size(75, 23);
            this.RefereshListBtn.TabIndex = 8;
            this.RefereshListBtn.Text = "Referesh List";
            this.RefereshListBtn.UseVisualStyleBackColor = true;
            this.RefereshListBtn.Click += new System.EventHandler(this.RefereshListBtn_Click);
            // 
            // UserIds
            // 
            this.UserIds.Text = "User Ids";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 261);
            this.Controls.Add(this.RefereshListBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MessagetxtBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox MessagetxtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox UserIdTxt;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView UserIdsList;
        private System.Windows.Forms.Button RefereshListBtn;
        private System.Windows.Forms.ColumnHeader UserIds;
    }
}

