namespace Hangman
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.labelGuess = new System.Windows.Forms.Label();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.labelLetter0 = new System.Windows.Forms.Label();
            this.labelLetter1 = new System.Windows.Forms.Label();
            this.labelLetter2 = new System.Windows.Forms.Label();
            this.labelLetter3 = new System.Windows.Forms.Label();
            this.labelLetter4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHangman = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelLetter5 = new System.Windows.Forms.Label();
            this.labelLetter6 = new System.Windows.Forms.Label();
            this.labelLetter7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1175, 27);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.aboutMenu,
            this.exitMenu});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(50, 19);
            this.menu.Text = "Menu";
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenu.Size = new System.Drawing.Size(149, 22);
            this.newMenu.Text = "New";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutMenu.Size = new System.Drawing.Size(149, 22);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenu.Size = new System.Drawing.Size(149, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // labelGuess
            // 
            this.labelGuess.AutoSize = true;
            this.labelGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuess.Location = new System.Drawing.Point(28, 496);
            this.labelGuess.Name = "labelGuess";
            this.labelGuess.Size = new System.Drawing.Size(166, 22);
            this.labelGuess.TabIndex = 2;
            this.labelGuess.Text = "GUESS A LETTER";
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLetter.Location = new System.Drawing.Point(252, 488);
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(67, 30);
            this.textBoxLetter.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(392, 484);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 34);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.Location = new System.Drawing.Point(120, 621);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(271, 33);
            this.buttonNewGame.TabIndex = 5;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // labelLetter0
            // 
            this.labelLetter0.AutoSize = true;
            this.labelLetter0.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter0.Location = new System.Drawing.Point(40, 261);
            this.labelLetter0.Name = "labelLetter0";
            this.labelLetter0.Size = new System.Drawing.Size(147, 54);
            this.labelLetter0.TabIndex = 6;
            this.labelLetter0.Text = "label0";
            // 
            // labelLetter1
            // 
            this.labelLetter1.AutoSize = true;
            this.labelLetter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter1.Location = new System.Drawing.Point(110, 261);
            this.labelLetter1.Name = "labelLetter1";
            this.labelLetter1.Size = new System.Drawing.Size(147, 54);
            this.labelLetter1.TabIndex = 7;
            this.labelLetter1.Text = "label1";
            // 
            // labelLetter2
            // 
            this.labelLetter2.AutoSize = true;
            this.labelLetter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter2.Location = new System.Drawing.Point(180, 261);
            this.labelLetter2.Name = "labelLetter2";
            this.labelLetter2.Size = new System.Drawing.Size(147, 54);
            this.labelLetter2.TabIndex = 8;
            this.labelLetter2.Text = "label2";
            // 
            // labelLetter3
            // 
            this.labelLetter3.AutoSize = true;
            this.labelLetter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter3.Location = new System.Drawing.Point(250, 261);
            this.labelLetter3.Name = "labelLetter3";
            this.labelLetter3.Size = new System.Drawing.Size(147, 54);
            this.labelLetter3.TabIndex = 9;
            this.labelLetter3.Text = "label3";
            // 
            // labelLetter4
            // 
            this.labelLetter4.AutoSize = true;
            this.labelLetter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter4.Location = new System.Drawing.Point(320, 261);
            this.labelLetter4.Name = "labelLetter4";
            this.labelLetter4.Size = new System.Drawing.Size(147, 54);
            this.labelLetter4.TabIndex = 10;
            this.labelLetter4.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hangman.Properties.Resources.Hangman;
            this.pictureBox1.Location = new System.Drawing.Point(352, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 79);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panelHangman
            // 
            this.panelHangman.Location = new System.Drawing.Point(696, 141);
            this.panelHangman.Name = "panelHangman";
            this.panelHangman.Size = new System.Drawing.Size(449, 488);
            this.panelHangman.TabIndex = 12;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMessage.Location = new System.Drawing.Point(343, 384);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(124, 31);
            this.labelMessage.TabIndex = 13;
            this.labelMessage.Text = "Message";
            // 
            // labelLetter5
            // 
            this.labelLetter5.AutoSize = true;
            this.labelLetter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter5.Location = new System.Drawing.Point(390, 261);
            this.labelLetter5.Name = "labelLetter5";
            this.labelLetter5.Size = new System.Drawing.Size(147, 54);
            this.labelLetter5.TabIndex = 14;
            this.labelLetter5.Text = "label5";
            // 
            // labelLetter6
            // 
            this.labelLetter6.AutoSize = true;
            this.labelLetter6.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter6.Location = new System.Drawing.Point(460, 261);
            this.labelLetter6.Name = "labelLetter6";
            this.labelLetter6.Size = new System.Drawing.Size(147, 54);
            this.labelLetter6.TabIndex = 15;
            this.labelLetter6.Text = "label6";
            // 
            // labelLetter7
            // 
            this.labelLetter7.AutoSize = true;
            this.labelLetter7.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter7.Location = new System.Drawing.Point(530, 261);
            this.labelLetter7.Name = "labelLetter7";
            this.labelLetter7.Size = new System.Drawing.Size(147, 54);
            this.labelLetter7.TabIndex = 16;
            this.labelLetter7.Text = "label7";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1175, 676);
            this.Controls.Add(this.labelLetter7);
            this.Controls.Add(this.labelLetter6);
            this.Controls.Add(this.labelLetter5);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.panelHangman);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLetter4);
            this.Controls.Add(this.labelLetter3);
            this.Controls.Add(this.labelLetter2);
            this.Controls.Add(this.labelLetter1);
            this.Controls.Add(this.labelLetter0);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxLetter);
            this.Controls.Add(this.labelGuess);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GUI";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE HANGMAN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.TextBox textBoxLetter;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label labelLetter0;
        private System.Windows.Forms.Label labelLetter1;
        private System.Windows.Forms.Label labelLetter2;
        private System.Windows.Forms.Label labelLetter3;
        private System.Windows.Forms.Label labelLetter4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHangman;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelLetter5;
        private System.Windows.Forms.Label labelLetter6;
        private System.Windows.Forms.Label labelLetter7;
    }
}

