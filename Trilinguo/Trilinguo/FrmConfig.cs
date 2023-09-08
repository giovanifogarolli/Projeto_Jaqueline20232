using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trilinguo
{
    public partial class FrmConfig : Form
    {

        public FrmConfig()
        {
            InitializeComponent();
            rdbI.Checked = Program.cfgP.Us;
            rdbJ.Checked = Program.cfgP.It;
            switch (Program.cfgP.Dificuldade)
            {
                case 1:
                    {
                        rdbF.Checked = true;
                        break;
                    }
                case 2:
                    {
                        rdbM.Checked = true;
                        break;
                    }
                case 3:
                    {
                        rdbD.Checked = true;
                        break;
                    }
            }
        }

        private void rdbI_CheckedChanged(object sender, EventArgs e)
        {
            Program.cfgP.Us = rdbI.Checked;
            Program.cfgP.It = rdbJ.Checked;
        }

        private void rdbJ_CheckedChanged(object sender, EventArgs e)
        {
            Program.cfgP.Us = rdbI.Checked;
            Program.cfgP.It = rdbJ.Checked;
        }

        private void rdbF_CheckedChanged(object sender, EventArgs e)
        {
            Program.cfgP.Dificuldade = 1;
        }

        private void rdbM_CheckedChanged(object sender, EventArgs e)
        {
            Program.cfgP.Dificuldade = 2;
        }

        private void rdbD_CheckedChanged(object sender, EventArgs e)
        {
            Program.cfgP.Dificuldade = 3;
        }
    }
}
