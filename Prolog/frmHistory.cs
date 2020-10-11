using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolog
{
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }
        public frmHistory(String history)
        {
            InitializeComponent();
            this.rtb_history.Text = history;
        }
        private void frmHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
