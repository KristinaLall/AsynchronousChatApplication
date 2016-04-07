namespace AsynchronousChatUI
{
    partial class Form_NetworkGame
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
            this.menuStrip_GameMenu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGame = new System.Windows.Forms.Panel();
            this.labelGameGoesHere = new System.Windows.Forms.Label();
            this.groupBoxTypeMessages = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxTypeMessages = new System.Windows.Forms.TextBox();
            this.groupBoxConversation = new System.Windows.Forms.GroupBox();
            this.textBoxConversation = new System.Windows.Forms.TextBox();
            this.menuStrip_GameMenu.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.groupBoxTypeMessages.SuspendLayout();
            this.groupBoxConversation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_GameMenu
            // 
            this.menuStrip_GameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.networkToolStripMenuItem});
            this.menuStrip_GameMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_GameMenu.Name = "menuStrip_GameMenu";
            this.menuStrip_GameMenu.Size = new System.Drawing.Size(530, 24);
            this.menuStrip_GameMenu.TabIndex = 0;
            this.menuStrip_GameMenu.Text = "menuStrip_Menu";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelGame.Controls.Add(this.labelGameGoesHere);
            this.panelGame.Location = new System.Drawing.Point(0, 27);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(530, 204);
            this.panelGame.TabIndex = 1;
            // 
            // labelGameGoesHere
            // 
            this.labelGameGoesHere.AutoSize = true;
            this.labelGameGoesHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameGoesHere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGameGoesHere.Location = new System.Drawing.Point(150, 74);
            this.labelGameGoesHere.Name = "labelGameGoesHere";
            this.labelGameGoesHere.Size = new System.Drawing.Size(225, 31);
            this.labelGameGoesHere.TabIndex = 0;
            this.labelGameGoesHere.Text = "Game Goes Here";
            // 
            // groupBoxTypeMessages
            // 
            this.groupBoxTypeMessages.Controls.Add(this.buttonSend);
            this.groupBoxTypeMessages.Controls.Add(this.textBoxTypeMessages);
            this.groupBoxTypeMessages.Location = new System.Drawing.Point(10, 242);
            this.groupBoxTypeMessages.Name = "groupBoxTypeMessages";
            this.groupBoxTypeMessages.Size = new System.Drawing.Size(508, 56);
            this.groupBoxTypeMessages.TabIndex = 2;
            this.groupBoxTypeMessages.TabStop = false;
            this.groupBoxTypeMessages.Text = "Type your messages here.";
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(424, 20);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxTypeMessages
            // 
            this.textBoxTypeMessages.Location = new System.Drawing.Point(9, 22);
            this.textBoxTypeMessages.Name = "textBoxTypeMessages";
            this.textBoxTypeMessages.Size = new System.Drawing.Size(409, 20);
            this.textBoxTypeMessages.TabIndex = 0;
            // 
            // groupBoxConversation
            // 
            this.groupBoxConversation.Controls.Add(this.textBoxConversation);
            this.groupBoxConversation.Location = new System.Drawing.Point(10, 309);
            this.groupBoxConversation.Name = "groupBoxConversation";
            this.groupBoxConversation.Size = new System.Drawing.Size(508, 197);
            this.groupBoxConversation.TabIndex = 3;
            this.groupBoxConversation.TabStop = false;
            this.groupBoxConversation.Text = "Conversation";
            // 
            // textBoxConversation
            // 
            this.textBoxConversation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxConversation.Location = new System.Drawing.Point(11, 20);
            this.textBoxConversation.Multiline = true;
            this.textBoxConversation.Name = "textBoxConversation";
            this.textBoxConversation.ReadOnly = true;
            this.textBoxConversation.Size = new System.Drawing.Size(488, 162);
            this.textBoxConversation.TabIndex = 0;
            // 
            // Form_NetworkGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 518);
            this.Controls.Add(this.groupBoxConversation);
            this.Controls.Add(this.groupBoxTypeMessages);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.menuStrip_GameMenu);
            this.MainMenuStrip = this.menuStrip_GameMenu;
            this.Name = "Form_NetworkGame";
            this.Text = "Network Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_NetworkGame_FormClosing);
            this.Load += new System.EventHandler(this.Form_NetworkGame_Load);
            this.menuStrip_GameMenu.ResumeLayout(false);
            this.menuStrip_GameMenu.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.groupBoxTypeMessages.ResumeLayout(false);
            this.groupBoxTypeMessages.PerformLayout();
            this.groupBoxConversation.ResumeLayout(false);
            this.groupBoxConversation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_GameMenu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label labelGameGoesHere;
        private System.Windows.Forms.GroupBox groupBoxTypeMessages;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxTypeMessages;
        private System.Windows.Forms.GroupBox groupBoxConversation;
        private System.Windows.Forms.TextBox textBoxConversation;
    }
}

