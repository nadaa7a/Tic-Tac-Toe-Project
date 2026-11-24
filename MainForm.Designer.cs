namespace Tic_Tac_Toe_Project
{
    partial class MainForm
    {
    
        private System.ComponentModel.IContainer components = null;

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

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.xscore = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTimeTitle = new System.Windows.Forms.Label();
            this.PlayerO = new System.Windows.Forms.Label();
            this.PlayerX = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.lblPlayerOScore = new System.Windows.Forms.Label();
            this.lblPlayerXScore = new System.Windows.Forms.Label();
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlayerO = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlGameBoard.SuspendLayout();
            this.SuspendLayout();
            
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(16, 94);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(68, 31);
            this.lblTurn.TabIndex = 1;
            this.lblTurn.Text = "Turn:";
          
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.lblStatus.Location = new System.Drawing.Point(38, 251);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(187, 38);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "In Progress...";
          
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(237)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(123, 528);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(189, 65);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "↻ Restart Round";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
           
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(32)))), ((int)(((byte)(240)))));
            this.lblCurrentPlayer.Location = new System.Drawing.Point(62, 119);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(133, 41);
            this.lblCurrentPlayer.TabIndex = 13;
            this.lblCurrentPlayer.Text = "Player X";
          
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.xscore);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.lblTimeTitle);
            this.panel1.Controls.Add(this.PlayerO);
            this.panel1.Controls.Add(this.PlayerX);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lblRoundNumber);
            this.panel1.Controls.Add(this.lblTurn);
            this.panel1.Controls.Add(this.lblCurrentPlayer);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblPlayerOScore);
            this.panel1.Controls.Add(this.lblPlayerXScore);
            this.panel1.Location = new System.Drawing.Point(67, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 302);
            this.panel1.TabIndex = 16;
        
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(306, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "0";
          
            this.xscore.AutoSize = true;
            this.xscore.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(38)))), ((int)(((byte)(255)))));
            this.xscore.Location = new System.Drawing.Point(108, 51);
            this.xscore.Name = "xscore";
            this.xscore.Size = new System.Drawing.Size(27, 31);
            this.xscore.TabIndex = 29;
            this.xscore.Text = "0";
           
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.flowLayoutPanel4.Location = new System.Drawing.Point(12, 245);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(361, 3);
            this.flowLayoutPanel4.TabIndex = 19;
         
            this.lblTimeTitle.AutoSize = true;
            this.lblTimeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTitle.ForeColor = System.Drawing.Color.White;
            this.lblTimeTitle.Location = new System.Drawing.Point(15, 204);
            this.lblTimeTitle.Name = "lblTimeTitle";
            this.lblTimeTitle.Size = new System.Drawing.Size(86, 38);
            this.lblTimeTitle.TabIndex = 24;
            this.lblTimeTitle.Text = "Time:";
          
            this.PlayerO.AutoSize = true;
            this.PlayerO.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerO.ForeColor = System.Drawing.Color.White;
            this.PlayerO.Location = new System.Drawing.Point(272, 20);
            this.PlayerO.Name = "PlayerO";
            this.PlayerO.Size = new System.Drawing.Size(101, 31);
            this.PlayerO.TabIndex = 28;
            this.PlayerO.Text = "Player O";
            
            this.PlayerX.AutoSize = true;
            this.PlayerX.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerX.ForeColor = System.Drawing.Color.White;
            this.PlayerX.Location = new System.Drawing.Point(75, 20);
            this.PlayerX.Name = "PlayerX";
            this.PlayerX.Size = new System.Drawing.Size(98, 31);
            this.PlayerX.TabIndex = 27;
            this.PlayerX.Text = "Player X";
           
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.lblTimer.Location = new System.Drawing.Point(107, 204);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(88, 38);
            this.lblTimer.TabIndex = 21;
            this.lblTimer.Text = "00:00";
            
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(17, 88);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(361, 3);
            this.flowLayoutPanel3.TabIndex = 19;
           
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Round:";
           
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 163);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(361, 3);
            this.flowLayoutPanel1.TabIndex = 17;
          
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.ForeColor = System.Drawing.Color.White;
            this.lblRoundNumber.Location = new System.Drawing.Point(107, 169);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(75, 41);
            this.lblRoundNumber.TabIndex = 20;
            this.lblRoundNumber.Text = "1 / 3";
           
            this.lblPlayerOScore.AutoSize = true;
            this.lblPlayerOScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOScore.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.lblPlayerOScore.Location = new System.Drawing.Point(210, 4);
            this.lblPlayerOScore.Name = "lblPlayerOScore";
            this.lblPlayerOScore.Size = new System.Drawing.Size(80, 81);
            this.lblPlayerOScore.TabIndex = 19;
            this.lblPlayerOScore.Text = "O";
            this.lblPlayerOScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             
            this.lblPlayerXScore.AutoSize = true;
            this.lblPlayerXScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerXScore.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerXScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(38)))), ((int)(((byte)(255)))));
            this.lblPlayerXScore.Location = new System.Drawing.Point(12, 4);
            this.lblPlayerXScore.Name = "lblPlayerXScore";
            this.lblPlayerXScore.Size = new System.Drawing.Size(72, 81);
            this.lblPlayerXScore.TabIndex = 18;
            this.lblPlayerXScore.Text = "X";
            this.lblPlayerXScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlGameBoard.Controls.Add(this.btn9);
            this.pnlGameBoard.Controls.Add(this.btn8);
            this.pnlGameBoard.Controls.Add(this.btn7);
            this.pnlGameBoard.Controls.Add(this.btn6);
            this.pnlGameBoard.Controls.Add(this.btn5);
            this.pnlGameBoard.Controls.Add(this.btn4);
            this.pnlGameBoard.Controls.Add(this.btn3);
            this.pnlGameBoard.Controls.Add(this.btn2);
            this.pnlGameBoard.Controls.Add(this.btn1);
            this.pnlGameBoard.Location = new System.Drawing.Point(693, 164);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(415, 415);
            this.pnlGameBoard.TabIndex = 17;
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(32)))));
            this.btn9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn9.BackgroundImage")));
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.btn9.FlatAppearance.BorderSize = 2;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(16)))), ((int)(((byte)(128)))));
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(16)))), ((int)(((byte)(74)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Purple;
            this.btn9.Location = new System.Drawing.Point(275, 275);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(115, 115);
            this.btn9.TabIndex = 21;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(32)))));
            this.btn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn8.BackgroundImage")));
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.btn8.FlatAppearance.BorderSize = 2;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(16)))), ((int)(((byte)(128)))));
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(16)))), ((int)(((byte)(74)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Purple;
            this.btn8.Location = new System.Drawing.Point(150, 275);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(115, 115);
            this.btn8.TabIndex = 20;
            this.btn8.UseVisualStyleBackColor = false;
           
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(32)))));
            this.btn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn7.BackgroundImage")));
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.btn7.FlatAppearance.BorderSize = 2;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(16)))), ((int)(((byte)(128)))));
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(16)))), ((int)(((byte)(74)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Purple;
            this.btn7.Location = new System.Drawing.Point(25, 275);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(115, 115);
            this.btn7.TabIndex = 19;
            this.btn7.UseVisualStyleBackColor = false;
        
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(32)))));
            this.btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn6.BackgroundImage")));
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.btn6.FlatAppearance.BorderSize = 2;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(16)))), ((int)(((byte)(128)))));
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(16)))), ((int)(((byte)(74)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Purple;
            this.btn6.Location = new System.Drawing.Point(150, 150);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(115, 115);
            this.btn6.TabIndex = 18;
            this.btn6.UseVisualStyleBackColor = false;
            
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(32)))));
            this.btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5.BackgroundImage")));
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.btn5.FlatAppearance.BorderSize = 2;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(16)))), ((int)(((byte)(128)))));
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(16)))), ((int)(((byte)(74)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Purple;
            this.btn5.Location = new System.Drawing.Point(275, 150);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(115, 115);
            this.btn5.TabIndex = 17;
            this.btn5.UseVisualStyleBackColor = false;
            
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(32)))));
            this.btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4.BackgroundImage")));
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.btn4.FlatAppearance.BorderSize = 2;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(16)))), ((int)(((byte)(128)))));
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(16)))), ((int)(((byte)(74)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Purple;
            this.btn4.Location = new System.Drawing.Point(25, 150);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(115, 115);
            this.btn4.TabIndex = 16;
            this.btn4.UseVisualStyleBackColor = false;
           
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(32)))));
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.btn3.FlatAppearance.BorderSize = 2;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(16)))), ((int)(((byte)(128)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(16)))), ((int)(((byte)(74)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Purple;
            this.btn3.Location = new System.Drawing.Point(275, 25);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(115, 115);
            this.btn3.TabIndex = 15;
            this.btn3.UseVisualStyleBackColor = false;
         
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(32)))));
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.btn2.FlatAppearance.BorderSize = 2;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(16)))), ((int)(((byte)(128)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(16)))), ((int)(((byte)(74)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Purple;
            this.btn2.Location = new System.Drawing.Point(150, 25);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(115, 115);
            this.btn2.TabIndex = 14;
            this.btn2.UseVisualStyleBackColor = false;
           
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(32)))));
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(32)))), ((int)(((byte)(255)))));
            this.btn1.FlatAppearance.BorderSize = 2;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(16)))), ((int)(((byte)(128)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(16)))), ((int)(((byte)(74)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Purple;
            this.btn1.Location = new System.Drawing.Point(25, 25);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(115, 115);
            this.btn1.TabIndex = 13;
            this.btn1.UseVisualStyleBackColor = false;
         
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitle.Location = new System.Drawing.Point(427, -8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 81);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tic Tac Toe";
            
            this.lblPlayerO.AutoSize = true;
            this.lblPlayerO.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerO.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(38)))), ((int)(((byte)(255)))));
            this.lblPlayerO.Location = new System.Drawing.Point(322, 119);
            this.lblPlayerO.Name = "lblPlayerO";
            this.lblPlayerO.Size = new System.Drawing.Size(0, 54);
            this.lblPlayerO.TabIndex = 23;
            
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(425, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 65);
            this.button1.TabIndex = 24;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = false;
           
            this.btnSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.btnSound.FlatAppearance.BorderSize = 2;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.btnSound.Location = new System.Drawing.Point(898, 27);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(190, 65);
            this.btnSound.TabIndex = 25;
            this.btnSound.Text = "🔊 Sound: ON";
            this.btnSound.UseVisualStyleBackColor = false;
           
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(224)))));
            this.lblSubtitle.Location = new System.Drawing.Point(465, 46);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(247, 28);
            this.lblSubtitle.TabIndex = 26;
            this.lblSubtitle.Text = "\tThe Ultimate Classic Game";
         
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(31)))));
            this.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.Neon_Cosmic_Tic_Tac_Toe_Arena;
            this.ClientSize = new System.Drawing.Size(1148, 653);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPlayerO);
            this.Controls.Add(this.pnlGameBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGameBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerOScore;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblPlayerXScore;
        private System.Windows.Forms.Label lblPlayerO;
        private System.Windows.Forms.Label PlayerO;
        private System.Windows.Forms.Label PlayerX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblTimeTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Label xscore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubtitle;
    }
}

