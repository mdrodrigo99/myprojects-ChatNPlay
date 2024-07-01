namespace Windows_Forms_Chat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.MyPortTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serverPortTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerIPTextBox = new System.Windows.Forms.TextBox();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HostButton = new System.Windows.Forms.Button();
            this.JoinButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.myTile = new System.Windows.Forms.PictureBox();
            this.otherTile = new System.Windows.Forms.PictureBox();
            this.paper = new System.Windows.Forms.PictureBox();
            this.scissors = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // MyPortTextBox
            // 
            this.MyPortTextBox.BackColor = System.Drawing.Color.MediumPurple;
            this.MyPortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyPortTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MyPortTextBox.Location = new System.Drawing.Point(22, 43);
            this.MyPortTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyPortTextBox.Name = "MyPortTextBox";
            this.MyPortTextBox.Size = new System.Drawing.Size(93, 23);
            this.MyPortTextBox.TabIndex = 1;
            this.MyPortTextBox.Text = "6666";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // serverPortTextBox
            // 
            this.serverPortTextBox.BackColor = System.Drawing.Color.MediumPurple;
            this.serverPortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverPortTextBox.Location = new System.Drawing.Point(70, 18);
            this.serverPortTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverPortTextBox.Name = "serverPortTextBox";
            this.serverPortTextBox.Size = new System.Drawing.Size(129, 23);
            this.serverPortTextBox.TabIndex = 3;
            this.serverPortTextBox.Text = "6666";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP";
            // 
            // ServerIPTextBox
            // 
            this.ServerIPTextBox.BackColor = System.Drawing.Color.MediumPurple;
            this.ServerIPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerIPTextBox.Location = new System.Drawing.Point(70, 58);
            this.ServerIPTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.Size = new System.Drawing.Size(129, 23);
            this.ServerIPTextBox.TabIndex = 5;
            this.ServerIPTextBox.Text = "127.0.0.1";
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(20, 15);
            this.ChatTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatTextBox.Size = new System.Drawing.Size(633, 173);
            this.ChatTextBox.TabIndex = 6;
            this.ChatTextBox.Text = "\r\n";
            this.ChatTextBox.TextChanged += new System.EventHandler(this.ChatTextBox_TextChanged);
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(72, 204);
            this.TypeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(493, 23);
            this.TypeTextBox.TabIndex = 7;
            this.TypeTextBox.TextChanged += new System.EventHandler(this.TypeTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chat";
            // 
            // HostButton
            // 
            this.HostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HostButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HostButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HostButton.Location = new System.Drawing.Point(136, 18);
            this.HostButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HostButton.Name = "HostButton";
            this.HostButton.Size = new System.Drawing.Size(138, 63);
            this.HostButton.TabIndex = 9;
            this.HostButton.Text = "HOST";
            this.HostButton.UseVisualStyleBackColor = true;
            this.HostButton.Click += new System.EventHandler(this.HostButton_Click);
            // 
            // JoinButton
            // 
            this.JoinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JoinButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JoinButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.JoinButton.Location = new System.Drawing.Point(216, 18);
            this.JoinButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(138, 63);
            this.JoinButton.TabIndex = 10;
            this.JoinButton.Text = "JOIN";
            this.JoinButton.UseVisualStyleBackColor = true;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SendButton.Location = new System.Drawing.Point(571, 203);
            this.SendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(82, 24);
            this.SendButton.TabIndex = 11;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // myTile
            // 
            this.myTile.BackColor = System.Drawing.Color.Transparent;
            this.myTile.Location = new System.Drawing.Point(20, 73);
            this.myTile.Name = "myTile";
            this.myTile.Size = new System.Drawing.Size(250, 250);
            this.myTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myTile.TabIndex = 14;
            this.myTile.TabStop = false;
            this.myTile.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // otherTile
            // 
            this.otherTile.BackColor = System.Drawing.Color.Transparent;
            this.otherTile.Location = new System.Drawing.Point(290, 73);
            this.otherTile.Name = "otherTile";
            this.otherTile.Size = new System.Drawing.Size(250, 250);
            this.otherTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.otherTile.TabIndex = 15;
            this.otherTile.TabStop = false;
            // 
            // paper
            // 
            this.paper.BackColor = System.Drawing.Color.Transparent;
            this.paper.Location = new System.Drawing.Point(230, 380);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(100, 100);
            this.paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paper.TabIndex = 16;
            this.paper.TabStop = false;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // scissors
            // 
            this.scissors.BackColor = System.Drawing.Color.Transparent;
            this.scissors.Location = new System.Drawing.Point(350, 380);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(100, 100);
            this.scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissors.TabIndex = 17;
            this.scissors.TabStop = false;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // rock
            // 
            this.rock.BackColor = System.Drawing.Color.Transparent;
            this.rock.Location = new System.Drawing.Point(110, 380);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(100, 100);
            this.rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock.TabIndex = 18;
            this.rock.TabStop = false;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(119, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "ME";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(334, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 37);
            this.label7.TabIndex = 20;
            this.label7.Text = "STRANGER";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.otherTile);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.myTile);
            this.panel1.Controls.Add(this.rock);
            this.panel1.Controls.Add(this.paper);
            this.panel1.Controls.Add(this.scissors);
            this.panel1.Location = new System.Drawing.Point(726, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 558);
            this.panel1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(368, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "SCISSORS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(261, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "PAPER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(143, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "ROCK";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.MyPortTextBox);
            this.panel2.Controls.Add(this.HostButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(23, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 100);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ServerIPTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.serverPortTextBox);
            this.panel3.Controls.Add(this.JoinButton);
            this.panel3.Location = new System.Drawing.Point(322, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 100);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumPurple;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.TypeTextBox);
            this.panel4.Controls.Add(this.SendButton);
            this.panel4.Controls.Add(this.ChatTextBox);
            this.panel4.Location = new System.Drawing.Point(23, 338);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(672, 241);
            this.panel4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(146, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 79);
            this.label5.TabIndex = 25;
            this.label5.Text = "ChatNPlay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1309, 618);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChatNPlay";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MyPortTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverPortTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ServerIPTextBox;
        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button HostButton;
        private System.Windows.Forms.Button JoinButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.PictureBox myTile;
        private System.Windows.Forms.PictureBox otherTile;
        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.PictureBox scissors;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

