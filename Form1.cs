using ADO_Connect.DAO;
using System.Windows;
namespace ADO_Connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeDAO.GetEmployeesTest();
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPosition = comboBox1.SelectedItem.ToString() ?? "";
            if (selectedPosition.ToLower().Equals("all positions") || String.IsNullOrEmpty(selectedPosition))
            {
                dataGridView1.DataSource = EmployeeDAO.GetEmployeesTest();
                return;
            }
            try
            {
                dataGridView1.DataSource = EmployeeDAO.GetByPosition(selectedPosition);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void maleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            string selectedPosition = maleRadioBtn.Text ?? "";
            if (selectedPosition.ToLower().Equals("male/female") || String.IsNullOrEmpty(selectedPosition))
            {
                dataGridView1.DataSource = EmployeeDAO.GetEmployeesTest();
                return;
            }
            try
            {
                dataGridView1.DataSource = EmployeeDAO.GetBySex(selectedPosition);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void femaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            string selectedPosition = femaleRadioBtn.Text ?? "";
            if (selectedPosition.ToLower().Equals("male/female") || String.IsNullOrEmpty(selectedPosition))
            {
                dataGridView1.DataSource = EmployeeDAO.GetEmployeesTest();
                return;
            }
            try
            {
                dataGridView1.DataSource = EmployeeDAO.GetBySex(selectedPosition);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void maleAndFemaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeDAO.GetEmployeesTest();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            Console.WriteLine(input);
            dataGridView1.DataSource = EmployeeDAO.GetByName(input);
        }
    }
}