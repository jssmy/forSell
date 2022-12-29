using System;
using System.Collections.Generic;
using System.Windows.Forms;
using forSell.entity;
using forSell.business;
using System.Drawing;

namespace forSell.presentation
{
    public partial class FormAddOption : Form
    {   
        public Option createdOption = new Option();
        public Button createdButton = new Button();
        public List<AdditionalData> conditions = new List<AdditionalData>();
        public FormAddOption()
        {
            InitializeComponent();
        }

        private void FormAddOption_Load(object sender, EventArgs e)
        {
            this.loadDefaultValues();
            this.setStyleButton();
            this.loadConditions();
        }

        private void loadDefaultValues() {
            radioButtonUnelevated.Checked = true;
            textBoxColor.Text = "primary";
            
        }

        private void setStyleButton()
        {
            var selectedColor = textBoxColor.Text;
            SettingColor settingColor = BSSettingColor.all().Find(color => color.name.Equals(selectedColor.ToLower()));
            if(settingColor != null)
            {
                buttonPreview.BackColor = ColorTranslator.FromHtml(settingColor.backHexaColor);
                buttonPreview.ForeColor = ColorTranslator.FromHtml(settingColor.fontHexaColor);
                buttonPreview.FlatStyle = FlatStyle.Flat;
                buttonPreview.FlatAppearance.BorderColor = ColorTranslator.FromHtml(settingColor.backHexaColor);
                buttonPreview.FlatAppearance.BorderSize = 1;
                if(radioButtonOutlined.Checked)
                {
                    var defaultButton = (new Button());
                    buttonPreview.BackColor = defaultButton.BackColor;
                    buttonPreview.ForeColor = ColorTranslator.FromHtml(settingColor.backHexaColor);
                }

            }
        }
        private void loadConditions()
        {
            List<ComboBoxItem<String>> items = new List<ComboBoxItem<String>>() {
                new ComboBoxItem<String>("Perfil", "profiles", "profiles"),
                new ComboBoxItem<String>("Migrado", "migrated", "migrated"),
                new ComboBoxItem<String>("Tecnología", "technology", "technology"),
                new ComboBoxItem<String>("Escenario", "scenary", "scenary"),
                new ComboBoxItem<String>("Flujo de diagnóstico", "diagnosis-flow", "diagnosis-flow"),
                new ComboBoxItem<String>("Descartes iniciales", "initial-discard", "initial-discard")
            };
            comboBoxCondition.DisplayMember = "label";
            comboBoxCondition.Items.AddRange(items.ToArray());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLabel_TextChanged(object sender, EventArgs e)
        {
            buttonPreview.Text = textBoxLabel.Text;
        }

        private void buttonPreview_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioButtonUnelevated_CheckedChanged(object sender, EventArgs e)
        {
            this.setStyleButton();
        }

        private void radioButtonOutlined_CheckedChanged(object sender, EventArgs e)
        {
            this.setStyleButton();
        }

        private void buttonSaveOption_Click(object sender, EventArgs e)
        {
            if(textBoxLabel.Text != null && textBoxKey.Text != null && textBoxValue.Text != null && textBoxColor.Text != null)  {
                this.createdOption.value = this.textBoxLabel.Text;
                this.createdOption.key = this.textBoxKey.Text;
                this.createdOption.stylebutton = this.getStyleButtonSelected();
                this.createdOption.color = this.textBoxColor.Text;
                this.createdOption.validations = this.conditions;
                this.createdButton = buttonPreview;
                this.DialogResult = DialogResult.OK;
                this.Close();    
            }
        }

        private string getStyleButtonSelected()
        {
            if(this.radioButtonOutlined.Checked)
            {
                return this.radioButtonOutlined.Text;
            }
            if(this.radioButtonUnelevated.Checked) {
                return this.radioButtonUnelevated.Text;
            }
            return "";
        }

        private void buttonAddContition_Click(object sender, EventArgs e)
        {
            if(comboBoxCondition.SelectedItem != null && textBoxConditionValue.Text != null)
            {   
                
                AdditionalData condition = new AdditionalData(((ComboBoxItem<string>)comboBoxCondition.SelectedItem).Key, textBoxConditionValue.Text);
                this.conditions.Add(condition);
                dataGridViewConditions.DataSource = this.conditions.ToArray();
            }
        }

        private void buttonRemoveCondition_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridViewConditions.SelectedCells)
            {
                if (oneCell.Selected) {
                    this.conditions.RemoveAt(oneCell.RowIndex);
                    dataGridViewConditions.DataSource = this.conditions.ToArray();
                }
            }
        }
    }
}
