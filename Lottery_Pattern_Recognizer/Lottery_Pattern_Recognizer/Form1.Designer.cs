namespace Lottery_Pattern_Recognizer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblTotalDraw = new System.Windows.Forms.Label();
            this.lblTotalJackpotHit = new System.Windows.Forms.Label();
            this.lvwJackpot = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwWinning = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwNo = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotalWinners = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvwJackpotNoFreq = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblC2J = new System.Windows.Forms.Label();
            this.lblC5J = new System.Windows.Forms.Label();
            this.lblC4J = new System.Windows.Forms.Label();
            this.lblC3J = new System.Windows.Forms.Label();
            this.lblC1J = new System.Windows.Forms.Label();
            this.lblOddJ = new System.Windows.Forms.Label();
            this.lblEvenJ = new System.Windows.Forms.Label();
            this.txtEven = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtC5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTotalDraw
            // 
            this.lblTotalDraw.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalDraw.Location = new System.Drawing.Point(737, 589);
            this.lblTotalDraw.Name = "lblTotalDraw";
            this.lblTotalDraw.Size = new System.Drawing.Size(253, 13);
            this.lblTotalDraw.TabIndex = 16;
            this.lblTotalDraw.Text = "Total Draw";
            // 
            // lblTotalJackpotHit
            // 
            this.lblTotalJackpotHit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalJackpotHit.Location = new System.Drawing.Point(737, 615);
            this.lblTotalJackpotHit.Name = "lblTotalJackpotHit";
            this.lblTotalJackpotHit.Size = new System.Drawing.Size(253, 13);
            this.lblTotalJackpotHit.TabIndex = 17;
            this.lblTotalJackpotHit.Text = "Total Jackpot Hit";
            // 
            // lvwJackpot
            // 
            this.lvwJackpot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwJackpot.FullRowSelect = true;
            this.lvwJackpot.GridLines = true;
            this.lvwJackpot.Location = new System.Drawing.Point(372, 160);
            this.lvwJackpot.Name = "lvwJackpot";
            this.lvwJackpot.Size = new System.Drawing.Size(250, 426);
            this.lvwJackpot.TabIndex = 26;
            this.lvwJackpot.UseCompatibleStateImageBehavior = false;
            this.lvwJackpot.View = System.Windows.Forms.View.Details;
            this.lvwJackpot.MouseHover += new System.EventHandler(this.lvwJackpot_MouseHover);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jackpot Winning Combination";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // lvwWinning
            // 
            this.lvwWinning.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvwWinning.FullRowSelect = true;
            this.lvwWinning.GridLines = true;
            this.lvwWinning.Location = new System.Drawing.Point(740, 160);
            this.lvwWinning.Name = "lvwWinning";
            this.lvwWinning.Size = new System.Drawing.Size(250, 426);
            this.lvwWinning.TabIndex = 27;
            this.lvwWinning.UseCompatibleStateImageBehavior = false;
            this.lvwWinning.View = System.Windows.Forms.View.Details;
            this.lvwWinning.MouseHover += new System.EventHandler(this.lvwWinning_MouseHover);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 25;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Winning Combination";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // lvwNo
            // 
            this.lvwNo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvwNo.FullRowSelect = true;
            this.lvwNo.GridLines = true;
            this.lvwNo.Location = new System.Drawing.Point(628, 160);
            this.lvwNo.Name = "lvwNo";
            this.lvwNo.Size = new System.Drawing.Size(106, 426);
            this.lvwNo.TabIndex = 28;
            this.lvwNo.UseCompatibleStateImageBehavior = false;
            this.lvwNo.View = System.Windows.Forms.View.Details;
            this.lvwNo.MouseHover += new System.EventHandler(this.lvwNo_MouseHover);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No.";
            this.columnHeader5.Width = 30;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Freq";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 50;
            // 
            // lblTotalWinners
            // 
            this.lblTotalWinners.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalWinners.Location = new System.Drawing.Point(737, 602);
            this.lblTotalWinners.Name = "lblTotalWinners";
            this.lblTotalWinners.Size = new System.Drawing.Size(121, 13);
            this.lblTotalWinners.TabIndex = 29;
            this.lblTotalWinners.Text = "Total Winners";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(12, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(984, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Pattern Recognition";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwJackpotNoFreq
            // 
            this.lvwJackpotNoFreq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvwJackpotNoFreq.FullRowSelect = true;
            this.lvwJackpotNoFreq.GridLines = true;
            this.lvwJackpotNoFreq.Location = new System.Drawing.Point(260, 160);
            this.lvwJackpotNoFreq.Name = "lvwJackpotNoFreq";
            this.lvwJackpotNoFreq.Size = new System.Drawing.Size(106, 426);
            this.lvwJackpotNoFreq.TabIndex = 30;
            this.lvwJackpotNoFreq.UseCompatibleStateImageBehavior = false;
            this.lvwJackpotNoFreq.View = System.Windows.Forms.View.Details;
            this.lvwJackpotNoFreq.MouseHover += new System.EventHandler(this.lvwJackpotNoFreq_MouseHover);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "No.";
            this.columnHeader7.Width = 30;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Freq";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 50;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(628, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Categorize";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(257, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Text Input";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(260, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 22);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblC2J);
            this.groupBox1.Controls.Add(this.lblC5J);
            this.groupBox1.Controls.Add(this.lblC4J);
            this.groupBox1.Controls.Add(this.lblC3J);
            this.groupBox1.Controls.Add(this.lblC1J);
            this.groupBox1.Controls.Add(this.lblOddJ);
            this.groupBox1.Controls.Add(this.lblEvenJ);
            this.groupBox1.Controls.Add(this.txtEven);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtOdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtC4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtC2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtC5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtC3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtC1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 426);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Input";
            // 
            // lblC2J
            // 
            this.lblC2J.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblC2J.ForeColor = System.Drawing.Color.Red;
            this.lblC2J.Location = new System.Drawing.Point(38, 188);
            this.lblC2J.Name = "lblC2J";
            this.lblC2J.Size = new System.Drawing.Size(25, 13);
            this.lblC2J.TabIndex = 46;
            this.lblC2J.Text = "000";
            this.lblC2J.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblC5J
            // 
            this.lblC5J.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblC5J.ForeColor = System.Drawing.Color.Red;
            this.lblC5J.Location = new System.Drawing.Point(38, 311);
            this.lblC5J.Name = "lblC5J";
            this.lblC5J.Size = new System.Drawing.Size(26, 13);
            this.lblC5J.TabIndex = 45;
            this.lblC5J.Text = "000";
            this.lblC5J.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblC4J
            // 
            this.lblC4J.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblC4J.ForeColor = System.Drawing.Color.Red;
            this.lblC4J.Location = new System.Drawing.Point(38, 270);
            this.lblC4J.Name = "lblC4J";
            this.lblC4J.Size = new System.Drawing.Size(25, 13);
            this.lblC4J.TabIndex = 44;
            this.lblC4J.Text = "000";
            this.lblC4J.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblC3J
            // 
            this.lblC3J.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblC3J.ForeColor = System.Drawing.Color.Red;
            this.lblC3J.Location = new System.Drawing.Point(38, 229);
            this.lblC3J.Name = "lblC3J";
            this.lblC3J.Size = new System.Drawing.Size(25, 13);
            this.lblC3J.TabIndex = 43;
            this.lblC3J.Text = "000";
            this.lblC3J.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblC1J
            // 
            this.lblC1J.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblC1J.ForeColor = System.Drawing.Color.Red;
            this.lblC1J.Location = new System.Drawing.Point(38, 147);
            this.lblC1J.Name = "lblC1J";
            this.lblC1J.Size = new System.Drawing.Size(25, 13);
            this.lblC1J.TabIndex = 42;
            this.lblC1J.Text = "000";
            this.lblC1J.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOddJ
            // 
            this.lblOddJ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOddJ.ForeColor = System.Drawing.Color.Red;
            this.lblOddJ.Location = new System.Drawing.Point(38, 106);
            this.lblOddJ.Name = "lblOddJ";
            this.lblOddJ.Size = new System.Drawing.Size(25, 13);
            this.lblOddJ.TabIndex = 41;
            this.lblOddJ.Text = "000";
            this.lblOddJ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEvenJ
            // 
            this.lblEvenJ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEvenJ.ForeColor = System.Drawing.Color.Red;
            this.lblEvenJ.Location = new System.Drawing.Point(39, 65);
            this.lblEvenJ.Name = "lblEvenJ";
            this.lblEvenJ.Size = new System.Drawing.Size(25, 13);
            this.lblEvenJ.TabIndex = 40;
            this.lblEvenJ.Text = "000";
            this.lblEvenJ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEven
            // 
            this.txtEven.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEven.Location = new System.Drawing.Point(70, 62);
            this.txtEven.Name = "txtEven";
            this.txtEven.Size = new System.Drawing.Size(95, 22);
            this.txtEven.TabIndex = 39;
            this.txtEven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(67, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "All Even";
            // 
            // txtOdd
            // 
            this.txtOdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtOdd.Location = new System.Drawing.Point(70, 103);
            this.txtOdd.Name = "txtOdd";
            this.txtOdd.Size = new System.Drawing.Size(95, 22);
            this.txtOdd.TabIndex = 37;
            this.txtOdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(67, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "All Odds";
            // 
            // txtC4
            // 
            this.txtC4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtC4.Location = new System.Drawing.Point(70, 267);
            this.txtC4.Name = "txtC4";
            this.txtC4.Size = new System.Drawing.Size(95, 22);
            this.txtC4.TabIndex = 35;
            this.txtC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(67, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "4 Even and 2 Odd";
            // 
            // txtC2
            // 
            this.txtC2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtC2.Location = new System.Drawing.Point(70, 185);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(95, 22);
            this.txtC2.TabIndex = 33;
            this.txtC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(67, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "2 Even and 4 Odd";
            // 
            // txtC5
            // 
            this.txtC5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtC5.Location = new System.Drawing.Point(70, 308);
            this.txtC5.Name = "txtC5";
            this.txtC5.Size = new System.Drawing.Size(95, 22);
            this.txtC5.TabIndex = 31;
            this.txtC5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(67, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "5 Even and 1 Odd";
            // 
            // txtC3
            // 
            this.txtC3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtC3.Location = new System.Drawing.Point(70, 226);
            this.txtC3.Name = "txtC3";
            this.txtC3.Size = new System.Drawing.Size(95, 22);
            this.txtC3.TabIndex = 29;
            this.txtC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(67, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "3 Even and 3 Odd";
            // 
            // txtC1
            // 
            this.txtC1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtC1.Location = new System.Drawing.Point(70, 144);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(95, 22);
            this.txtC1.TabIndex = 27;
            this.txtC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "1 Even and 5 Odd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "Open File...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvwJackpotNoFreq);
            this.Controls.Add(this.lblTotalWinners);
            this.Controls.Add(this.lvwNo);
            this.Controls.Add(this.lvwWinning);
            this.Controls.Add(this.lvwJackpot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalJackpotHit);
            this.Controls.Add(this.lblTotalDraw);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pattern Recognizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblTotalDraw;
        private System.Windows.Forms.Label lblTotalJackpotHit;
        private System.Windows.Forms.ListView lvwJackpot;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvwWinning;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvwNo;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblTotalWinners;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvwJackpotNoFreq;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblC2J;
        private System.Windows.Forms.Label lblC5J;
        private System.Windows.Forms.Label lblC4J;
        private System.Windows.Forms.Label lblC3J;
        private System.Windows.Forms.Label lblC1J;
        private System.Windows.Forms.Label lblOddJ;
        private System.Windows.Forms.Label lblEvenJ;
        private System.Windows.Forms.TextBox txtEven;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtC4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtC5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

