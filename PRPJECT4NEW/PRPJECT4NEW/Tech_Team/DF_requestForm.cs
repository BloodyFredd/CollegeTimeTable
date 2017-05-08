using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Tech_Team
{
    public partial class DF_requestForm : Form
    {
        public DF_requestForm()
        {
            InitializeComponent();
        }

        private void DF_requestForm_Load(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                dFrequestsBindingSource.DataSource = db.DF_requests.ToList();
                System.Collections.IList sDataLst;
                sDataLst = this.dFrequestsBindingSource.List;

                MessageBox.Show(dataGridView.Rows[1].Cells[2].Value.ToString());
                
            }
            
        }
    }
}
