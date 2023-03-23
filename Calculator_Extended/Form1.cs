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
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SubtotalWorkingMinutes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            var subtotalWorkingMinutes = decimal.Parse(SubtotalWorkingMinutesTextBox.Text);
            var additionalOrMissingMinutes = decimal.Parse(AdditionalOrMissingMinutesTextbox.Text);
            var totalResult = subtotalWorkingMinutes + additionalOrMissingMinutes;

          

            TotalResultTextBox.Text = totalResult.ToString();
        }

        private void AdditionalOrMissingMinutesTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }

     
    }