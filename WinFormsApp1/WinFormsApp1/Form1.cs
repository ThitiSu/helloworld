namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {


            //textBoxC.Text = "Hello";

            // get input form texbox
            string input = textBoxC.Text;

            // convert c to f
            // f = c x 9/5 + 32
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;

            // show input to textbox
            textBoxF.Text = f.ToString();




        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input = textBoxF.Text;
            // convert f to c
            // c = 5 / 9 x (f - 32)
            double f = Convert.ToDouble(input);
            double c = (f - 32) * 5 / 9 ;

            // show input to textbox
            textBoxC.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }
    }
}