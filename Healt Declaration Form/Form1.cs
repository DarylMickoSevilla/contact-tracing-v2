namespace Healt_Declaration_Form
{
    public partial class HealthDeclarationForm : Form
    {
        public HealthDeclarationForm()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            StreamWriter Form;

            Form = File.CreateText(@"C:\HealthDeclarationForm\HealthDeclarationForm.txt");
            Form.WriteLine("Name: " + NameBox1.Text);
            Form.WriteLine("Age: " + AgeBox2.Text);
            Form.WriteLine("Contact#: " + ContactBox3.Text);
            Form.WriteLine("Temperature: " + TemperatureBox4.Text + "°C");
            Form.Close();
            this.Close();
        }
    }
}