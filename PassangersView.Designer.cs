namespace ConsoleApp99
{
    partial class PassangersView
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
            groupBox1 = new GroupBox();
            middleNameBox = new TextBox();
            label5 = new Label();
            lastNameBox = new TextBox();
            label2 = new Label();
            firstNameBox = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            backButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(middleNameBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lastNameBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(firstNameBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 209);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // middleNameBox
            // 
            middleNameBox.Location = new Point(8, 173);
            middleNameBox.Margin = new Padding(5);
            middleNameBox.Name = "middleNameBox";
            middleNameBox.Size = new Size(200, 26);
            middleNameBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 150);
            label5.Margin = new Padding(5, 10, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 18);
            label5.TabIndex = 8;
            label5.Text = "Отчество";
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(8, 109);
            lastNameBox.Margin = new Padding(5);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(200, 26);
            lastNameBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 86);
            label2.Margin = new Padding(5, 10, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 6;
            label2.Text = "Фамилия";
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(8, 45);
            firstNameBox.Margin = new Padding(5);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(200, 26);
            firstNameBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 22);
            label3.Margin = new Padding(5, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 18);
            label3.TabIndex = 4;
            label3.Text = "Имя";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 57);
            dataGridView1.Margin = new Padding(6, 3, 3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1174, 792);
            dataGridView1.TabIndex = 1;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(100, 30);
            backButton.TabIndex = 3;
            backButton.Text = "К рейсам";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // PassangersView
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 861);
            Controls.Add(backButton);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MinimizeBox = false;
            MinimumSize = new Size(1440, 900);
            Name = "PassangersView";
            Text = "PassangersView";
            FormClosing += PassangersView_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button backButton;
        private Label label3;
        private TextBox firstNameBox;
        private TextBox middleNameBox;
        private Label label5;
        private TextBox lastNameBox;
        private Label label2;
    }
}