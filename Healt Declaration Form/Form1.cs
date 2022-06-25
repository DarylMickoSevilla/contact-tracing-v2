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
            Form.WriteLine("Date: " + DateBox8.Text);
            Form.WriteLine("Age: " + AgeBox2.Text);
            Form.WriteLine("Contact#: " + ContactBox3.Text);
            Form.WriteLine("Temperature: " + TemperatureBox4.Text + "°C");
            Form.WriteLine("Time-in: " + TimeinBox5.Text);
            Form.WriteLine("Time-out: " + TimeoutBox6.Text);
            Form.WriteLine("Address: " + AddressBox7.Text);
            Form.Close();

            NameBox1.Text = DateBox8.Text = AgeBox2.Text = ContactBox3.Text = TemperatureBox4.Text = TimeinBox5.Text = TimeoutBox6.Text = AddressBox7.Text = " ";
        }

        private void Recordbtn2_Click(object sender, EventArgs e)
        {

            OpenFileDialog Read = new OpenFileDialog();

            if (Read.ShowDialog() == DialogResult.OK)
            {
                RecordBox1.Text = System.IO.File.ReadAllText(Read.FileName);
            }
        }
    }
}