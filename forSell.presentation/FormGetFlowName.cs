using System;
using System.Windows.Forms;
using forSell.business;
using forSell.entity;
namespace forSell.presentation
{
    public partial class FormGetFlowName : Form
    {
        public Flow flow { get; set; }
        public SubFlow subFlow { get; set; }
        public Scenary scenary { get; set; }

        public FormGetFlowName()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormGetFlowName_Load(object sender, EventArgs e)
        {
            this.loadFlow();
            this.loadScenary();
        }

        private void loadFlow() {
            comboFlow.DisplayMember = "name";
            comboFlow.ValueMember = "id";
            var flows = BSFlow.all();
            foreach (var flow in flows)
            {
                
                comboFlow.Items.Add(flow);
            }
        
        }

        private void loadScenary()
        {
            comboScenary.DisplayMember = "scene";
            comboScenary.ValueMember = "scene";
            var scenries = BSScenary.all();
            foreach(var scenry in scenries)
            {
                comboScenary.Items.Add(scenry);
            }
        }
        private void comboFlow_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seelcted = (Flow)comboFlow.SelectedItem;
            comboSubFlow.DisplayMember = "name";
            comboSubFlow.ValueMember = "id";
            var subflows = BSSubFlow.getAllByParentId(seelcted.id);
            comboSubFlow.Items.Clear();
            comboSubFlow.Text = "";
            foreach (var subflow in subflows)
            {
                comboSubFlow.Items.Add(subflow);
            }
        }

        private void buttonCreatTree_Click(object sender, EventArgs e)
        {
            if(comboFlow.SelectedItem != null && comboScenary.SelectedItem != null && comboSubFlow.SelectedItem != null)
            {
                this.Close();
            }
        }
    }
}
