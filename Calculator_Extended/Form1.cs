using System.Linq.Expressions;

namespace Calculator_Extended
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var workingDaysText = workingDaysTextBox.Text;
                var minutesOfWorkInADayText = workingMinutesTextBox.Text;

                var workingDays = decimal.Parse(workingDaysText);
                var minutesOfWorkInADay = decimal.Parse(minutesOfWorkInADayText);

                if (workingDays < 0)
                {
                    workingDaysTextBox.Text = "Type a positive number";
                }
                else
                {
                    var result = workingDays * minutesOfWorkInADay;

                    SubtotalWorkingMinutesTextBox.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                workingDaysTextBox.Text = "Only numbers allowed";


            }


        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                var subtotalWorkingMinutes = decimal.Parse(SubtotalWorkingMinutesTextBox.Text);
                var additionalOrMissingMinutes = decimal.Parse(AdditionalOrMissingMinutesTextbox.Text);
                var totalResult = subtotalWorkingMinutes + additionalOrMissingMinutes;

                TotalResultTextBox.Text = totalResult.ToString();

            }
            catch (Exception ex)
            {
                AdditionalOrMissingMinutesTextbox.Text = "Write a positive or negative number";

            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var workingDays = decimal.Parse(numericUpDown1_ValueChanged);
            //var minutesOfWorkInADay = decimal.Parse(numericUpDown1_ValueChanged);
            //var result = WorkingDays * 480;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calculateTotalMinutes();
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotalMinutes();
        }
        private void calculateTotalMinutes()
        {
            var workingDays = numericUpDown1.Value;
            var result = workingDays * 480;
            textBox1.Text = "The number of working minutes is: " + result.ToString();
        }

    }
}