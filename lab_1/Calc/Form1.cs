namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // textBox1.Text = comboBox2.Items[1].ToString();

        }

        private void myButton5_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Output.BackColor = Color.BlanchedAlmond;
                Output.Text = "Вы не человек, Вы - машина. Вам не нужны Ккал-рии";
            }

            var Human = new Calculator(int.Parse(age.Text), int.Parse(weight.Text),
                int.Parse(height.Text), radioButton1.Checked ? radioButton1.Text : radioButton2.Text, goal.Text);

            Output.BackColor = Color.BlanchedAlmond;
            Output.Text = Human.CalcImt();
            Output.AppendText(Human.CalcKkal());
        }
    }
}