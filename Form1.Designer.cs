namespace ADO_Connect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.maleAndFemaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(853, 441);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.femaleRadioBtn);
            this.groupBox1.Controls.Add(this.maleRadioBtn);
            this.groupBox1.Controls.Add(this.maleAndFemaleRadioBtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(873, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(337, 441);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All Positions",
            "Developer",
            "Leader",
            "Tester",
            "Manager"});
            this.comboBox1.Location = new System.Drawing.Point(81, 233);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Position";
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Location = new System.Drawing.Point(17, 181);
            this.femaleRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(78, 24);
            this.femaleRadioBtn.TabIndex = 2;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            this.femaleRadioBtn.CheckedChanged += new System.EventHandler(this.femaleRadioBtn_CheckedChanged);
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Location = new System.Drawing.Point(17, 148);
            this.maleRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(63, 24);
            this.maleRadioBtn.TabIndex = 2;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            this.maleRadioBtn.CheckedChanged += new System.EventHandler(this.maleRadioBtn_CheckedChanged);
            // 
            // maleAndFemaleRadioBtn
            // 
            this.maleAndFemaleRadioBtn.AutoSize = true;
            this.maleAndFemaleRadioBtn.Location = new System.Drawing.Point(17, 115);
            this.maleAndFemaleRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maleAndFemaleRadioBtn.Name = "maleAndFemaleRadioBtn";
            this.maleAndFemaleRadioBtn.Size = new System.Drawing.Size(117, 24);
            this.maleAndFemaleRadioBtn.TabIndex = 2;
            this.maleAndFemaleRadioBtn.TabStop = true;
            this.maleAndFemaleRadioBtn.Text = "Male/Female";
            this.maleAndFemaleRadioBtn.UseVisualStyleBackColor = true;
            this.maleAndFemaleRadioBtn.CheckedChanged += new System.EventHandler(this.maleAndFemaleRadioBtn_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label2;
        private RadioButton femaleRadioBtn;
        private RadioButton maleRadioBtn;
        private RadioButton maleAndFemaleRadioBtn;
        private TextBox textBox1;
        private Label label1;
    }
}