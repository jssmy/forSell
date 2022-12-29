namespace forSell.presentation
{
    partial class FormGetFlowName
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboScenary = new System.Windows.Forms.ComboBox();
            this.comboFlow = new System.Windows.Forms.ComboBox();
            this.comboSubFlow = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreatTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Cuál es el nombre del escenario?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Cuál es flujo tipo de flujo?";
            // 
            // comboScenary
            // 
            this.comboScenary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboScenary.FormattingEnabled = true;
            this.comboScenary.Location = new System.Drawing.Point(34, 229);
            this.comboScenary.Name = "comboScenary";
            this.comboScenary.Size = new System.Drawing.Size(433, 28);
            this.comboScenary.TabIndex = 7;
            // 
            // comboFlow
            // 
            this.comboFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFlow.FormattingEnabled = true;
            this.comboFlow.Location = new System.Drawing.Point(34, 58);
            this.comboFlow.Name = "comboFlow";
            this.comboFlow.Size = new System.Drawing.Size(433, 28);
            this.comboFlow.TabIndex = 8;
            this.comboFlow.SelectedIndexChanged += new System.EventHandler(this.comboFlow_SelectedIndexChanged);
            // 
            // comboSubFlow
            // 
            this.comboSubFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSubFlow.FormattingEnabled = true;
            this.comboSubFlow.Location = new System.Drawing.Point(140, 146);
            this.comboSubFlow.Name = "comboSubFlow";
            this.comboSubFlow.Size = new System.Drawing.Size(218, 28);
            this.comboSubFlow.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "¿Cuál el flujo?";
            // 
            // buttonCreatTree
            // 
            this.buttonCreatTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreatTree.Location = new System.Drawing.Point(34, 293);
            this.buttonCreatTree.Name = "buttonCreatTree";
            this.buttonCreatTree.Size = new System.Drawing.Size(433, 36);
            this.buttonCreatTree.TabIndex = 11;
            this.buttonCreatTree.Text = "CREAR FLUJO";
            this.buttonCreatTree.UseVisualStyleBackColor = true;
            this.buttonCreatTree.Click += new System.EventHandler(this.buttonCreatTree_Click);
            // 
            // FormGetFlowName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 352);
            this.Controls.Add(this.buttonCreatTree);
            this.Controls.Add(this.comboSubFlow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboFlow);
            this.Controls.Add(this.comboScenary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGetFlowName";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormGetFlowName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboScenary;
        private System.Windows.Forms.ComboBox comboFlow;
        private System.Windows.Forms.ComboBox comboSubFlow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreatTree;
    }
}