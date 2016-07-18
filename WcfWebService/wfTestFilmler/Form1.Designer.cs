namespace wfTestFilmler
{
    partial class Form1
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
            this.cbFilmler = new System.Windows.Forms.ComboBox();
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilmler
            // 
            this.cbFilmler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmler.FormattingEnabled = true;
            this.cbFilmler.Items.AddRange(new object[] {
            "Komedi",
            "Savaş",
            "Action",
            "Dram",
            "Bilim Kurgu"});
            this.cbFilmler.Location = new System.Drawing.Point(217, 29);
            this.cbFilmler.Name = "cbFilmler";
            this.cbFilmler.Size = new System.Drawing.Size(121, 21);
            this.cbFilmler.TabIndex = 0;
            this.cbFilmler.SelectedIndexChanged += new System.EventHandler(this.cbFilmler_SelectedIndexChanged);
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Location = new System.Drawing.Point(57, 73);
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.Size = new System.Drawing.Size(449, 193);
            this.dgvFilmler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 325);
            this.Controls.Add(this.dgvFilmler);
            this.Controls.Add(this.cbFilmler);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilmler;
        private System.Windows.Forms.DataGridView dgvFilmler;
    }
}

