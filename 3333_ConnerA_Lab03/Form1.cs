using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_ConnerA_Lab03
{ //Alcaeus Andrea Conner, 001031349, 02192023, 02192023
  // The application should be able to display the amomunt of income generated from each class of tickets
  // and the total revenue generated.
    public partial class Form1 : Form
    {   
        private int sumRev = 0;

        private int sumTicket = 0;

        private int Transaction = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void CalcRevButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Calculate

                //Declaring the variables.
                int classA,
                    classB,
                    classC,
                    totalClassTickets;

                int classARev,
                    classBRev,
                    classCRev,
                    totalRev;

                //Assign value forms Text Boxes
                classA = int.Parse(classATextBox.Text);
                classB = int.Parse(classBTextBox.Text);
                classC = int.Parse(classCTextBox.Text);

                //Calculate total tickets
                totalClassTickets = classA + classB + classC;
                
                //Calculate total revenue
                classARev = classA * 15;
                classBRev = classB * 12;
                classCRev = classC * 9;
                totalRev = classARev + classBRev + classCRev;

                //Total Revenue
                totalRevenue.Text = totalRev.ToString("c");

                //A Revenue
                CARev.Text = classARev.ToString("c");

                //B Revenue
                CBRev.Text = classBRev.ToString("c");

                //C Revenue
                CCRev.Text = classCRev.ToString("c");

                //Total tickets
                totalTickets.Text = totalClassTickets.ToString("n");

                //Sum Revenue
                sumRev = sumRev + totalRev;
                sumRevText.Text = sumRev.ToString("c");

                //Sum Tickets
                sumTicket = sumTicket + totalClassTickets;
                sumTicketsText.Text = sumTicket.ToString("n");

                //Transactions
                Transaction = Transaction + 1;
                transactionsText.Text = Transaction.ToString("n");
 
            }
            catch
            {
                MessageBox.Show("Invalid input. Please try again.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clears certain text boxes
            classATextBox.Text = "";
            classBTextBox.Text = "";
            classCTextBox.Text = "";
            totalRevenue.Text = "";
            totalTickets.Text = "";
            CARev.Text = "";
            CBRev.Text = "";
            CCRev.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Exits the window
            this.Close();
        }
    }
}
