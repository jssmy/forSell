using forSell.business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forSell.presentation
{
    public partial class FormInfoSpeech : Form
    {

        BSpeechInfo bSpeech = new BSpeechInfo();
        public FormInfoSpeech()
        {
            InitializeComponent();
        }

        private void FormInfoSpeech_Load(object sender, EventArgs e)
        {
            dataGridInfoSpeeches.DataSource = this.bSpeech.all();
            dataGridInfoSpeeches.Width = this.Width;
            this.format();
        }

        private void format()
        {
            dataGridInfoSpeeches.Columns[1].Width = this.Width * 10 / 100;
            dataGridInfoSpeeches.Columns[2].Width = this.Width * 10 / 100;
            dataGridInfoSpeeches.Columns[3].Width = this.Width * 30 / 100;
            dataGridInfoSpeeches.Columns[4].Width = this.Width * 30 / 100;
            dataGridInfoSpeeches.Height = this.Height;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.search(textBoxSearch.Text);
        }

        public void search(string foundText) {
            this.dataGridInfoSpeeches.DataSource = this.bSpeech.all().FindAll(speech => speech.description.Contains(foundText));
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            this.search(textBoxSearch.Text);
        }
    }
}
