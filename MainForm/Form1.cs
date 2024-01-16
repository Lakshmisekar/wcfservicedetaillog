using ServiceReference1;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System;
using System.Windows.Forms;
namespace MainForm
{
    public partial class Form1 : Form
    {
        private StudentServiceClient studentServiceClient;

        public Form1()
        {
            InitializeComponent();
            studentServiceClient = new StudentServiceClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //comboBox1.DataSource=Enum.GetNames(typeof(StudentGroup));   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student
                {
                    Name = textBox1.Text,
                    DateOfBirth = dateTimePicker1.Value,
                    IsMale = radioButton1.Checked,
                    PhoneNumber = textBox2.Text,
                    Group = (StudentGroup)(comboBox1.SelectedItem ?? default(StudentGroup))
                };

                studentServiceClient.RegisterStudentAsync(student);
                MessageBox.Show("Student registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}
