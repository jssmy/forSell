namespace forSell.presentation
{
    partial class FormInfoSpeech
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
            this.dataGridInfoSpeeches = new System.Windows.Forms.DataGridView();
            this.labelTitleMain = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfoSpeeches)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridInfoSpeeches
            // 
            this.dataGridInfoSpeeches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfoSpeeches.Location = new System.Drawing.Point(1, 103);
            this.dataGridInfoSpeeches.Name = "dataGridInfoSpeeches";
            this.dataGridInfoSpeeches.Size = new System.Drawing.Size(799, 335);
            this.dataGridInfoSpeeches.TabIndex = 0;
            // 
            // labelTitleMain
            // 
            this.labelTitleMain.AutoSize = true;
            this.labelTitleMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleMain.Location = new System.Drawing.Point(13, 13);
            this.labelTitleMain.Name = "labelTitleMain";
            this.labelTitleMain.Size = new System.Drawing.Size(312, 31);
            this.labelTitleMain.TabIndex = 1;
            this.labelTitleMain.Text = "Todos los InfoSpeechs";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(19, 57);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(308, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(359, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormInfoSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelTitleMain);
            this.Controls.Add(this.dataGridInfoSpeeches);
            this.Name = "FormInfoSpeech";
            this.Text = "FormInfoSpeech";
            this.Load += new System.EventHandler(this.FormInfoSpeech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfoSpeeches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridInfoSpeeches;
        private System.Windows.Forms.Label labelTitleMain;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}