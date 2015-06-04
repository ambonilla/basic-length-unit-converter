namespace Length_Unit_Converter
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.unit_list_1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_input_1 = new System.Windows.Forms.NumericUpDown();
            this.num_input_2 = new System.Windows.Forms.NumericUpDown();
            this.unit_list_2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_input_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_input_2)).BeginInit();
            this.SuspendLayout();
            // 
            // unit_list_1
            // 
            this.unit_list_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unit_list_1.FormattingEnabled = true;
            this.unit_list_1.Items.AddRange(new object[] {
            "Centímetros (cm)",
            "Kilómetros (Km)",
            "Metros (m)",
            "Milímetros (mm)",
            "Millas (mi)",
            "Pies (ft)",
            "Pulgadas (in)",
            "Yardas (yd)"});
            this.unit_list_1.Location = new System.Drawing.Point(12, 81);
            this.unit_list_1.Name = "unit_list_1";
            this.unit_list_1.Size = new System.Drawing.Size(147, 108);
            this.unit_list_1.TabIndex = 0;
            this.unit_list_1.SelectedIndexChanged += new System.EventHandler(this.unit_list_1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // num_input_1
            // 
            this.num_input_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_input_1.DecimalPlaces = 2;
            this.num_input_1.Location = new System.Drawing.Point(12, 27);
            this.num_input_1.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.num_input_1.Name = "num_input_1";
            this.num_input_1.Size = new System.Drawing.Size(147, 20);
            this.num_input_1.TabIndex = 4;
            this.num_input_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_input_1.ThousandsSeparator = true;
            this.num_input_1.ValueChanged += new System.EventHandler(this.num_input_1_ValueChanged);
            // 
            // num_input_2
            // 
            this.num_input_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_input_2.DecimalPlaces = 2;
            this.num_input_2.Location = new System.Drawing.Point(284, 27);
            this.num_input_2.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            131072});
            this.num_input_2.Name = "num_input_2";
            this.num_input_2.ReadOnly = true;
            this.num_input_2.Size = new System.Drawing.Size(147, 20);
            this.num_input_2.TabIndex = 5;
            this.num_input_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_input_2.ThousandsSeparator = true;
            this.num_input_2.ValueChanged += new System.EventHandler(this.num_input_2_ValueChanged);
            // 
            // unit_list_2
            // 
            this.unit_list_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unit_list_2.FormattingEnabled = true;
            this.unit_list_2.Items.AddRange(new object[] {
            "Centímetros (cm)",
            "Kilómetros (Km)",
            "Metros (m)",
            "Milímetros (mm)",
            "Millas (mi)",
            "Pies (ft)",
            "Pulgadas (in)",
            "Yardas (yd)"});
            this.unit_list_2.Location = new System.Drawing.Point(284, 81);
            this.unit_list_2.Name = "unit_list_2";
            this.unit_list_2.Size = new System.Drawing.Size(147, 108);
            this.unit_list_2.TabIndex = 6;
            this.unit_list_2.SelectedIndexChanged += new System.EventHandler(this.unit_list_2_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 201);
            this.Controls.Add(this.unit_list_2);
            this.Controls.Add(this.num_input_2);
            this.Controls.Add(this.num_input_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unit_list_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Convertidor de Medidas";
            ((System.ComponentModel.ISupportInitialize)(this.num_input_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_input_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox unit_list_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_input_1;
        private System.Windows.Forms.NumericUpDown num_input_2;
        private System.Windows.Forms.ListBox unit_list_2;
    }
}

