using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using forSell.entity;
namespace forSell.presentation
{
    public partial class FormMainFlow : Form
    { 
        List<Option> options = new List<Option>();
        List<Button> butonsOption = new List<Button>();

        public FormMainFlow()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormMainFlow_Load(object sender, EventArgs e)
        {
            this.loadStepsOptions();
            this.loadStepDiagnosis();
            this.loadPanel();
    }

        private void loadStepsOptions() {
            List<ComboBoxItem<String>> items = new List<ComboBoxItem<String>>() { new ComboBoxItem<String>("Step Diagnóstico", "default", "default"), new ComboBoxItem<String>("Step simple", "step-simple", "step-simple") };
            comboBoxTypeStep.DisplayMember = "label";
            comboBoxTypeStep.Items.AddRange(items.ToArray());
            comboBoxTypeStep.SelectedItem = items[0];
        }

        private void loadStepDiagnosis()
        {
            var currentStepSelected = (ComboBoxItem<String>)comboBoxTypeStep.SelectedItem;
            groupBoxDefaultStep.Visible = currentStepSelected.Key.Equals("default");
            
        }

       private void loadPanel() {
            groupBoxPanel.Enabled = false;
            checkStatePanel.Enabled = true;
            checkStatePanel.Checked = false;
            this.loadTypePanel();
        }

        private void loadTypePanel() {
            List<ComboBoxItem<String>> items = new List<ComboBoxItem<String>>() { new ComboBoxItem<String>("Info", "info", "info"), new ComboBoxItem<String>("Warning", "warning", "warning") };
            comboBoxTypePanel.DisplayMember = "label";
            comboBoxTypePanel.Items.AddRange(items.ToArray());
            comboBoxTypePanel.SelectedItem = items[0];
            comboBoxTypePanel.SelectedValueChanged += new EventHandler(comboBoxTypePanelOnChange);
            this.controlColorTitlePanel(items[0].value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddOption formAddOption = new FormAddOption();
            formAddOption.ShowDialog();
            var result = formAddOption.DialogResult;
            if(result == DialogResult.OK)
            {
                this.options.Add(formAddOption.createdOption);
                Button button = this.getCreatedButton(formAddOption.createdButton);
                this.butonsOption.Add(button);
                //groupBoxButtonOptions.Controls.Add(button);
                this.renderButtonsOption();
            }
        }

       private void renderButtonsOption()
        {
            var parentX = this.groupBoxButtonOptions.Bounds.X;
            var parentY = this.groupBoxButtonOptions.Bounds.Y;
            int maxSpace = this.groupBoxButtonOptions.Width;
            int filledSpace = this.getSpaceFilledForButton();
            Button beforeButton = null;
            float accumulateSpaces = 0.0f;
            groupBoxButtonOptions.Controls.Clear();
            
            foreach (Button button in this.butonsOption)
            {

                float percentToFilledSpace = (((float)button.Width / (float)filledSpace)) * 100;
                var spaceForButtonContext = (groupBoxButtonOptions.Width * percentToFilledSpace) / 100;
                var spaceEmptyForButton = (spaceForButtonContext / 2) - (button.Width / 2 );
                var xButton = spaceEmptyForButton +  accumulateSpaces ;
                button.Bounds = new Rectangle((int)xButton, (groupBoxButtonOptions.Height - button.Height) / 2, button.Width, button.Height);
                groupBoxButtonOptions.Controls.Add(button);
                beforeButton = button;
                accumulateSpaces = accumulateSpaces + spaceForButtonContext;

            }
        }

        private Button getCreatedButton(Button created)
        {
            Button button = new Button();
            Font font = new Font("Microsoft Sans Serif", 13);
            button.Text = created.Text;
            Size size = TextRenderer.MeasureText(button.Text, font);
            button.Width = size.Width + 10;
            button.BackColor = created.BackColor;
            button.FlatAppearance.BorderColor = created.FlatAppearance.BorderColor;
            button.FlatStyle = created.FlatStyle;
            button.FlatAppearance.BorderSize = created.FlatAppearance.BorderSize;
            button.ForeColor = created.ForeColor;
            button.Height = 40;
            button.Font = font;
            
            return button;
        }

        private int getSpaceFilledForButton() {
            int filledSpace = 0;
            foreach (var button in this.butonsOption)
            {
                filledSpace += button.Width;
            }
            return filledSpace > this.groupBoxButtonOptions.Width ? this.groupBoxButtonOptions.Width : filledSpace;
        }

        private void comboBoxTypePanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTypePanelOnChange(object sender, System.EventArgs e)
        {
            var selectedTypePanel = (ComboBoxItem<String>)comboBoxTypePanel.SelectedItem;
            this.controlColorTitlePanel(selectedTypePanel.value);
        }
        private void controlColorTitlePanel(string typeColor) {
            switch (typeColor) {
                case "info":
                    labelTitlePanel.BackColor = System.Drawing.Color.FromArgb(1, 157, 244);
                    textBoxTitelPanel.BackColor = System.Drawing.Color.FromArgb(1, 157, 244);
                    break;
                case "warning":
                    labelTitlePanel.BackColor = System.Drawing.Color.FromArgb(245, 156, 0);
                    textBoxTitelPanel.BackColor = System.Drawing.Color.FromArgb(245, 156, 0);
                    break;                    
            }
        }

        private void checkStatePanel_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPanel.Enabled = checkStatePanel.Checked;
        }
    }
}
