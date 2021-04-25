using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string position = null;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataConnection db = new DataConnection();
            SqlDataAdapter apater = new SqlDataAdapter();

            DataTable table = new DataTable();
            
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE username = @User AND password = @Pass AND position = @Pos", db.getConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsename.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
            if (radioButtonLaocong.Checked)
            {
                position = "LC";
            }
            else if (radioButtonQuanly.Checked)
            {
                position = "QL";
            }
            else position = "TT";
            command.Parameters.Add("@Pos", SqlDbType.VarChar).Value = position;

            apater.SelectCommand = command;

            apater.Fill(table);

            if ((table.Rows.Count > 0))
            {
                if (position == "LC")
                {
                    this.Hide();
                    LCForm main = new LCForm();
                    main.Show();
                }
                else if(position == "QL")
                {
                    this.Hide();
                    QLForm main = new QLForm();
                    main.Show();
                }
                else
                {
                    this.Hide();
                    TTForm main = new TTForm();
                    main.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password or Position", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
