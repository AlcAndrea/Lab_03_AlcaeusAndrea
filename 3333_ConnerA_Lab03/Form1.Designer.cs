
namespace _3333_ConnerA_Lab03
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
            this.CalcRevButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ticketsBox = new System.Windows.Forms.GroupBox();
            this.totalTickets = new System.Windows.Forms.Label();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.totalT = new System.Windows.Forms.Label();
            this.classC = new System.Windows.Forms.Label();
            this.classB = new System.Windows.Forms.Label();
            this.classA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.revenueBox = new System.Windows.Forms.GroupBox();
            this.CCRev = new System.Windows.Forms.Label();
            this.CBRev = new System.Windows.Forms.Label();
            this.CARev = new System.Windows.Forms.Label();
            this.totalRevenue = new System.Windows.Forms.Label();
            this.totalR = new System.Windows.Forms.Label();
            this.classCRev = new System.Windows.Forms.Label();
            this.classBRev = new System.Windows.Forms.Label();
            this.classARev = new System.Windows.Forms.Label();
            this.summaryBox = new System.Windows.Forms.GroupBox();
            this.transactionsText = new System.Windows.Forms.Label();
            this.sumTicketsText = new System.Windows.Forms.Label();
            this.sumRevText = new System.Windows.Forms.Label();
            this.totalTrans = new System.Windows.Forms.Label();
            this.sumT = new System.Windows.Forms.Label();
            this.sumR = new System.Windows.Forms.Label();
            this.ticketsBox.SuspendLayout();
            this.revenueBox.SuspendLayout();
            this.summaryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcRevButton
            // 
            this.CalcRevButton.Location = new System.Drawing.Point(363, 337);
            this.CalcRevButton.Name = "CalcRevButton";
            this.CalcRevButton.Size = new System.Drawing.Size(80, 56);
            this.CalcRevButton.TabIndex = 31;
            this.CalcRevButton.Text = "&Calculate Revenue";
            this.CalcRevButton.UseVisualStyleBackColor = true;
            this.CalcRevButton.Click += new System.EventHandler(this.CalcRevButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(468, 337);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(80, 56);
            this.ClearButton.TabIndex = 32;
            this.ClearButton.Text = "C&lear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(563, 337);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 56);
            this.ExitButton.TabIndex = 33;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ticketsBox
            // 
            this.ticketsBox.Controls.Add(this.totalTickets);
            this.ticketsBox.Controls.Add(this.classCTextBox);
            this.ticketsBox.Controls.Add(this.classBTextBox);
            this.ticketsBox.Controls.Add(this.classATextBox);
            this.ticketsBox.Controls.Add(this.totalT);
            this.ticketsBox.Controls.Add(this.classC);
            this.ticketsBox.Controls.Add(this.classB);
            this.ticketsBox.Controls.Add(this.classA);
            this.ticketsBox.Controls.Add(this.textBox1);
            this.ticketsBox.Location = new System.Drawing.Point(24, 27);
            this.ticketsBox.Name = "ticketsBox";
            this.ticketsBox.Size = new System.Drawing.Size(321, 212);
            this.ticketsBox.TabIndex = 45;
            this.ticketsBox.TabStop = false;
            this.ticketsBox.Text = "Tickets Sold";
            // 
            // totalTickets
            // 
            this.totalTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTickets.Location = new System.Drawing.Point(117, 170);
            this.totalTickets.Name = "totalTickets";
            this.totalTickets.Size = new System.Drawing.Size(142, 26);
            this.totalTickets.TabIndex = 52;
            this.totalTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classCTextBox
            // 
            this.classCTextBox.Location = new System.Drawing.Point(117, 132);
            this.classCTextBox.Multiline = true;
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(142, 26);
            this.classCTextBox.TabIndex = 51;
            // 
            // classBTextBox
            // 
            this.classBTextBox.Location = new System.Drawing.Point(117, 96);
            this.classBTextBox.Multiline = true;
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(142, 26);
            this.classBTextBox.TabIndex = 50;
            // 
            // classATextBox
            // 
            this.classATextBox.Location = new System.Drawing.Point(117, 64);
            this.classATextBox.Multiline = true;
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(142, 26);
            this.classATextBox.TabIndex = 49;
            // 
            // totalT
            // 
            this.totalT.AutoSize = true;
            this.totalT.Location = new System.Drawing.Point(25, 170);
            this.totalT.Name = "totalT";
            this.totalT.Size = new System.Drawing.Size(72, 13);
            this.totalT.TabIndex = 48;
            this.totalT.Text = "Total Tickets:";
            // 
            // classC
            // 
            this.classC.AutoSize = true;
            this.classC.Location = new System.Drawing.Point(25, 135);
            this.classC.Name = "classC";
            this.classC.Size = new System.Drawing.Size(45, 13);
            this.classC.TabIndex = 48;
            this.classC.Text = "Class C:";
            // 
            // classB
            // 
            this.classB.AutoSize = true;
            this.classB.Location = new System.Drawing.Point(25, 100);
            this.classB.Name = "classB";
            this.classB.Size = new System.Drawing.Size(45, 13);
            this.classB.TabIndex = 2;
            this.classB.Text = "Class B:";
            // 
            // classA
            // 
            this.classA.AutoSize = true;
            this.classA.Location = new System.Drawing.Point(25, 67);
            this.classA.Name = "classA";
            this.classA.Size = new System.Drawing.Size(45, 13);
            this.classA.TabIndex = 1;
            this.classA.Text = "Class A:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(28, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Enter the number of tickets sold for each class of tickets";
            // 
            // revenueBox
            // 
            this.revenueBox.Controls.Add(this.CCRev);
            this.revenueBox.Controls.Add(this.CBRev);
            this.revenueBox.Controls.Add(this.CARev);
            this.revenueBox.Controls.Add(this.totalRevenue);
            this.revenueBox.Controls.Add(this.totalR);
            this.revenueBox.Controls.Add(this.classCRev);
            this.revenueBox.Controls.Add(this.classBRev);
            this.revenueBox.Controls.Add(this.classARev);
            this.revenueBox.Location = new System.Drawing.Point(363, 27);
            this.revenueBox.Name = "revenueBox";
            this.revenueBox.Size = new System.Drawing.Size(280, 212);
            this.revenueBox.TabIndex = 46;
            this.revenueBox.TabStop = false;
            this.revenueBox.Text = "Revenue Generated";
            // 
            // CCRev
            // 
            this.CCRev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CCRev.Location = new System.Drawing.Point(105, 128);
            this.CCRev.Name = "CCRev";
            this.CCRev.Size = new System.Drawing.Size(142, 26);
            this.CCRev.TabIndex = 56;
            this.CCRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBRev
            // 
            this.CBRev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CBRev.Location = new System.Drawing.Point(105, 93);
            this.CBRev.Name = "CBRev";
            this.CBRev.Size = new System.Drawing.Size(142, 26);
            this.CBRev.TabIndex = 55;
            this.CBRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CARev
            // 
            this.CARev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CARev.Location = new System.Drawing.Point(105, 60);
            this.CARev.Name = "CARev";
            this.CARev.Size = new System.Drawing.Size(142, 26);
            this.CARev.TabIndex = 54;
            this.CARev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalRevenue
            // 
            this.totalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRevenue.Location = new System.Drawing.Point(105, 170);
            this.totalRevenue.Name = "totalRevenue";
            this.totalRevenue.Size = new System.Drawing.Size(142, 26);
            this.totalRevenue.TabIndex = 53;
            this.totalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalR
            // 
            this.totalR.AutoSize = true;
            this.totalR.Location = new System.Drawing.Point(25, 170);
            this.totalR.Name = "totalR";
            this.totalR.Size = new System.Drawing.Size(81, 13);
            this.totalR.TabIndex = 53;
            this.totalR.Text = "Total Revenue:";
            // 
            // classCRev
            // 
            this.classCRev.AutoSize = true;
            this.classCRev.Location = new System.Drawing.Point(25, 135);
            this.classCRev.Name = "classCRev";
            this.classCRev.Size = new System.Drawing.Size(45, 13);
            this.classCRev.TabIndex = 53;
            this.classCRev.Text = "Class C:";
            // 
            // classBRev
            // 
            this.classBRev.AutoSize = true;
            this.classBRev.Location = new System.Drawing.Point(25, 100);
            this.classBRev.Name = "classBRev";
            this.classBRev.Size = new System.Drawing.Size(45, 13);
            this.classBRev.TabIndex = 53;
            this.classBRev.Text = "Class B:";
            // 
            // classARev
            // 
            this.classARev.AutoSize = true;
            this.classARev.Location = new System.Drawing.Point(25, 67);
            this.classARev.Name = "classARev";
            this.classARev.Size = new System.Drawing.Size(45, 13);
            this.classARev.TabIndex = 53;
            this.classARev.Text = "Class A:";
            // 
            // summaryBox
            // 
            this.summaryBox.Controls.Add(this.transactionsText);
            this.summaryBox.Controls.Add(this.sumTicketsText);
            this.summaryBox.Controls.Add(this.sumRevText);
            this.summaryBox.Controls.Add(this.totalTrans);
            this.summaryBox.Controls.Add(this.sumT);
            this.summaryBox.Controls.Add(this.sumR);
            this.summaryBox.Location = new System.Drawing.Point(24, 252);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(321, 141);
            this.summaryBox.TabIndex = 47;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "Summary";
            // 
            // transactionsText
            // 
            this.transactionsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionsText.Location = new System.Drawing.Point(121, 100);
            this.transactionsText.Name = "transactionsText";
            this.transactionsText.Size = new System.Drawing.Size(142, 26);
            this.transactionsText.TabIndex = 53;
            this.transactionsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumTicketsText
            // 
            this.sumTicketsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumTicketsText.Location = new System.Drawing.Point(121, 66);
            this.sumTicketsText.Name = "sumTicketsText";
            this.sumTicketsText.Size = new System.Drawing.Size(142, 26);
            this.sumTicketsText.TabIndex = 53;
            this.sumTicketsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumRevText
            // 
            this.sumRevText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumRevText.Location = new System.Drawing.Point(121, 33);
            this.sumRevText.Name = "sumRevText";
            this.sumRevText.Size = new System.Drawing.Size(142, 26);
            this.sumRevText.TabIndex = 53;
            this.sumRevText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTrans
            // 
            this.totalTrans.AutoSize = true;
            this.totalTrans.Location = new System.Drawing.Point(25, 107);
            this.totalTrans.Name = "totalTrans";
            this.totalTrans.Size = new System.Drawing.Size(71, 13);
            this.totalTrans.TabIndex = 54;
            this.totalTrans.Text = "Transactions:";
            // 
            // sumT
            // 
            this.sumT.AutoSize = true;
            this.sumT.Location = new System.Drawing.Point(25, 73);
            this.sumT.Name = "sumT";
            this.sumT.Size = new System.Drawing.Size(81, 13);
            this.sumT.TabIndex = 54;
            this.sumT.Text = "Sum of Tickets:";
            // 
            // sumR
            // 
            this.sumR.AutoSize = true;
            this.sumR.Location = new System.Drawing.Point(25, 40);
            this.sumR.Name = "sumR";
            this.sumR.Size = new System.Drawing.Size(90, 13);
            this.sumR.TabIndex = 53;
            this.sumR.Text = "Sum of Revenue:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 412);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.revenueBox);
            this.Controls.Add(this.ticketsBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalcRevButton);
            this.Name = "Form1";
            this.Text = "Stadium Seating Cost and Revenue";
            this.ticketsBox.ResumeLayout(false);
            this.ticketsBox.PerformLayout();
            this.revenueBox.ResumeLayout(false);
            this.revenueBox.PerformLayout();
            this.summaryBox.ResumeLayout(false);
            this.summaryBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CalcRevButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox ticketsBox;
        private System.Windows.Forms.Label totalT;
        private System.Windows.Forms.Label classC;
        private System.Windows.Forms.Label classB;
        private System.Windows.Forms.Label classA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox revenueBox;
        private System.Windows.Forms.GroupBox summaryBox;
        private System.Windows.Forms.Label totalTickets;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.Label totalRevenue;
        private System.Windows.Forms.Label totalR;
        private System.Windows.Forms.Label classCRev;
        private System.Windows.Forms.Label classBRev;
        private System.Windows.Forms.Label classARev;
        private System.Windows.Forms.Label transactionsText;
        private System.Windows.Forms.Label sumTicketsText;
        private System.Windows.Forms.Label sumRevText;
        private System.Windows.Forms.Label totalTrans;
        private System.Windows.Forms.Label sumT;
        private System.Windows.Forms.Label sumR;
        private System.Windows.Forms.Label CBRev;
        private System.Windows.Forms.Label CARev;
        private System.Windows.Forms.Label CCRev;
    }
}

