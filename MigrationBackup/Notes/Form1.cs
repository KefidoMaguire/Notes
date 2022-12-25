using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class Form1 : Form
    {
        SQLConnection sc = new SQLConnection();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = sc.getData();
        }

        /// <summary>
        /// inserts note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertnote_Click(object sender, EventArgs e)
        {
            sc.insertNote(newnote.Text,Convert.ToDateTime(remind.Text),user.Text);
            dataGridView1.Refresh();
        }
    }
}
