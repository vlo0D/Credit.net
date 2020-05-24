using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class ShowCredits : Form
    {
        public ShowCredits()
        {
            InitializeComponent();
        }
        public ShowCredits(Test f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void ShowCredits_Load(object sender, EventArgs e)
        {

        }
    }
}
