namespace forSell.presentation
{
    partial class FormMainFlow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonIdentifyProblem = new System.Windows.Forms.Button();
            this.buttonDoDiscards = new System.Windows.Forms.Button();
            this.buttonConfirmSolution = new System.Windows.Forms.Button();
            this.buttonOverDiagnosis = new System.Windows.Forms.Button();
            this.groupBoxDefaultStep = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeStep = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddOption = new System.Windows.Forms.Button();
            this.groupBoxButtonOptions = new System.Windows.Forms.GroupBox();
            this.groupBoxPanel = new System.Windows.Forms.GroupBox();
            this.checkStatePanel = new System.Windows.Forms.CheckBox();
            this.labelTitlePanel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxTypePanel = new System.Windows.Forms.ComboBox();
            this.textBoxTitelPanel = new System.Windows.Forms.TextBox();
            this.groupBoxDefaultStep.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(320, 41);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(312, 24);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Revisando el estado del servicio";
            // 
            // buttonIdentifyProblem
            // 
            this.buttonIdentifyProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIdentifyProblem.Location = new System.Drawing.Point(85, 19);
            this.buttonIdentifyProblem.Name = "buttonIdentifyProblem";
            this.buttonIdentifyProblem.Size = new System.Drawing.Size(75, 52);
            this.buttonIdentifyProblem.TabIndex = 1;
            this.buttonIdentifyProblem.Text = "1";
            this.buttonIdentifyProblem.UseVisualStyleBackColor = true;
            // 
            // buttonDoDiscards
            // 
            this.buttonDoDiscards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoDiscards.Location = new System.Drawing.Point(281, 19);
            this.buttonDoDiscards.Name = "buttonDoDiscards";
            this.buttonDoDiscards.Size = new System.Drawing.Size(75, 52);
            this.buttonDoDiscards.TabIndex = 2;
            this.buttonDoDiscards.Text = "2";
            this.buttonDoDiscards.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmSolution
            // 
            this.buttonConfirmSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmSolution.Location = new System.Drawing.Point(485, 19);
            this.buttonConfirmSolution.Name = "buttonConfirmSolution";
            this.buttonConfirmSolution.Size = new System.Drawing.Size(75, 52);
            this.buttonConfirmSolution.TabIndex = 3;
            this.buttonConfirmSolution.Text = "3";
            this.buttonConfirmSolution.UseVisualStyleBackColor = true;
            // 
            // buttonOverDiagnosis
            // 
            this.buttonOverDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOverDiagnosis.Location = new System.Drawing.Point(673, 19);
            this.buttonOverDiagnosis.Name = "buttonOverDiagnosis";
            this.buttonOverDiagnosis.Size = new System.Drawing.Size(75, 52);
            this.buttonOverDiagnosis.TabIndex = 4;
            this.buttonOverDiagnosis.Text = "4";
            this.buttonOverDiagnosis.UseVisualStyleBackColor = true;
            // 
            // groupBoxDefaultStep
            // 
            this.groupBoxDefaultStep.Controls.Add(this.label4);
            this.groupBoxDefaultStep.Controls.Add(this.label3);
            this.groupBoxDefaultStep.Controls.Add(this.label2);
            this.groupBoxDefaultStep.Controls.Add(this.label1);
            this.groupBoxDefaultStep.Controls.Add(this.buttonOverDiagnosis);
            this.groupBoxDefaultStep.Controls.Add(this.buttonIdentifyProblem);
            this.groupBoxDefaultStep.Controls.Add(this.buttonConfirmSolution);
            this.groupBoxDefaultStep.Controls.Add(this.buttonDoDiscards);
            this.groupBoxDefaultStep.Location = new System.Drawing.Point(115, 81);
            this.groupBoxDefaultStep.Name = "groupBoxDefaultStep";
            this.groupBoxDefaultStep.Size = new System.Drawing.Size(806, 103);
            this.groupBoxDefaultStep.TabIndex = 5;
            this.groupBoxDefaultStep.TabStop = false;
            this.groupBoxDefaultStep.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fin del diagnóstic";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirmar solución";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Realizar los descartes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Identificar el problema";
            // 
            // comboBoxTypeStep
            // 
            this.comboBoxTypeStep.FormattingEnabled = true;
            this.comboBoxTypeStep.Location = new System.Drawing.Point(115, 46);
            this.comboBoxTypeStep.Name = "comboBoxTypeStep";
            this.comboBoxTypeStep.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeStep.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(115, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 166);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Validaciones realizadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(55)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(521, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Escenario: Nombre de escenario";
            // 
            // buttonAddOption
            // 
            this.buttonAddOption.Location = new System.Drawing.Point(115, 609);
            this.buttonAddOption.Name = "buttonAddOption";
            this.buttonAddOption.Size = new System.Drawing.Size(133, 23);
            this.buttonAddOption.TabIndex = 8;
            this.buttonAddOption.Text = "Agregar opción";
            this.buttonAddOption.UseVisualStyleBackColor = true;
            this.buttonAddOption.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxButtonOptions
            // 
            this.groupBoxButtonOptions.Location = new System.Drawing.Point(115, 638);
            this.groupBoxButtonOptions.Name = "groupBoxButtonOptions";
            this.groupBoxButtonOptions.Size = new System.Drawing.Size(806, 74);
            this.groupBoxButtonOptions.TabIndex = 9;
            this.groupBoxButtonOptions.TabStop = false;
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.Controls.Add(this.textBoxTitelPanel);
            this.groupBoxPanel.Controls.Add(this.comboBoxTypePanel);
            this.groupBoxPanel.Controls.Add(this.richTextBox1);
            this.groupBoxPanel.Controls.Add(this.labelTitlePanel);
            this.groupBoxPanel.Location = new System.Drawing.Point(115, 229);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Size = new System.Drawing.Size(806, 138);
            this.groupBoxPanel.TabIndex = 10;
            this.groupBoxPanel.TabStop = false;
            // 
            // checkStatePanel
            // 
            this.checkStatePanel.AutoSize = true;
            this.checkStatePanel.Location = new System.Drawing.Point(115, 215);
            this.checkStatePanel.Name = "checkStatePanel";
            this.checkStatePanel.Size = new System.Drawing.Size(93, 17);
            this.checkStatePanel.TabIndex = 0;
            this.checkStatePanel.Text = "Habilitar panel";
            this.checkStatePanel.UseVisualStyleBackColor = true;
            this.checkStatePanel.CheckedChanged += new System.EventHandler(this.checkStatePanel_CheckedChanged);
            // 
            // labelTitlePanel
            // 
            this.labelTitlePanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTitlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePanel.ForeColor = System.Drawing.Color.White;
            this.labelTitlePanel.Location = new System.Drawing.Point(7, 16);
            this.labelTitlePanel.Name = "labelTitlePanel";
            this.labelTitlePanel.Size = new System.Drawing.Size(793, 34);
            this.labelTitlePanel.TabIndex = 1;
            this.labelTitlePanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(794, 73);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // comboBoxTypePanel
            // 
            this.comboBoxTypePanel.FormattingEnabled = true;
            this.comboBoxTypePanel.Location = new System.Drawing.Point(673, 23);
            this.comboBoxTypePanel.Name = "comboBoxTypePanel";
            this.comboBoxTypePanel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypePanel.TabIndex = 3;
            this.comboBoxTypePanel.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypePanel_SelectedIndexChanged);
            // 
            // textBoxTitelPanel
            // 
            this.textBoxTitelPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxTitelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTitelPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitelPanel.ForeColor = System.Drawing.Color.White;
            this.textBoxTitelPanel.Location = new System.Drawing.Point(11, 19);
            this.textBoxTitelPanel.Name = "textBoxTitelPanel";
            this.textBoxTitelPanel.Size = new System.Drawing.Size(257, 26);
            this.textBoxTitelPanel.TabIndex = 4;
            this.textBoxTitelPanel.Text = "Comunicación al asesor";
            // 
            // FormMainFlow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 734);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.groupBoxButtonOptions);
            this.Controls.Add(this.buttonAddOption);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkStatePanel);
            this.Controls.Add(this.comboBoxTypeStep);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.groupBoxDefaultStep);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainFlow";
            this.Load += new System.EventHandler(this.FormMainFlow_Load);
            this.groupBoxDefaultStep.ResumeLayout(false);
            this.groupBoxDefaultStep.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPanel.ResumeLayout(false);
            this.groupBoxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonIdentifyProblem;
        private System.Windows.Forms.Button buttonDoDiscards;
        private System.Windows.Forms.Button buttonConfirmSolution;
        private System.Windows.Forms.Button buttonOverDiagnosis;
        private System.Windows.Forms.GroupBox groupBoxDefaultStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeStep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddOption;
        private System.Windows.Forms.GroupBox groupBoxButtonOptions;
        private System.Windows.Forms.GroupBox groupBoxPanel;
        private System.Windows.Forms.CheckBox checkStatePanel;
        private System.Windows.Forms.Label labelTitlePanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxTypePanel;
        private System.Windows.Forms.TextBox textBoxTitelPanel;
    }
}