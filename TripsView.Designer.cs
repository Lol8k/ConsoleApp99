namespace ConsoleApp99
{
    partial class TripsView
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
            timeInBox = new TextBox();
            label4 = new Label();
            timeOutBox = new TextBox();
            label5 = new Label();
            toTownBox = new TextBox();
            label2 = new Label();
            fromTownBox = new TextBox();
            label3 = new Label();
            companyBox = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            backButton = new Button();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            viewPassangers = new Button();
            adminPanel = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            adminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(timeInBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(timeOutBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(toTownBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(fromTownBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(companyBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 337);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // timeInBox
            // 
            timeInBox.Location = new Point(8, 299);
            timeInBox.Margin = new Padding(5);
            timeInBox.Name = "timeInBox";
            timeInBox.Size = new Size(200, 26);
            timeInBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 276);
            label4.Margin = new Padding(5, 10, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 18);
            label4.TabIndex = 10;
            label4.Text = "По дате прилета";
            // 
            // timeOutBox
            // 
            timeOutBox.Location = new Point(8, 235);
            timeOutBox.Margin = new Padding(5);
            timeOutBox.Name = "timeOutBox";
            timeOutBox.Size = new Size(200, 26);
            timeOutBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 212);
            label5.Margin = new Padding(5, 10, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 18);
            label5.TabIndex = 8;
            label5.Text = "По дате вылета";
            // 
            // toTownBox
            // 
            toTownBox.Location = new Point(8, 171);
            toTownBox.Margin = new Padding(5);
            toTownBox.Name = "toTownBox";
            toTownBox.Size = new Size(200, 26);
            toTownBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 148);
            label2.Margin = new Padding(5, 10, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 6;
            label2.Text = "В город";
            // 
            // fromTownBox
            // 
            fromTownBox.Location = new Point(8, 107);
            fromTownBox.Margin = new Padding(5);
            fromTownBox.Name = "fromTownBox";
            fromTownBox.Size = new Size(200, 26);
            fromTownBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 84);
            label3.Margin = new Padding(5, 10, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 4;
            label3.Text = "Из города";
            // 
            // companyBox
            // 
            companyBox.FormattingEnabled = true;
            companyBox.Location = new Point(8, 45);
            companyBox.Margin = new Padding(5, 5, 3, 3);
            companyBox.Name = "companyBox";
            companyBox.Size = new Size(200, 26);
            companyBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 22);
            label1.Margin = new Padding(5, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 18);
            label1.TabIndex = 0;
            label1.Text = "По компании";
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
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addButton.Location = new Point(6, 32);
            addButton.Margin = new Padding(3, 10, 3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(200, 40);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editButton.Location = new Point(8, 90);
            editButton.Margin = new Padding(3, 15, 3, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(200, 40);
            editButton.TabIndex = 5;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deleteButton.Location = new Point(8, 148);
            deleteButton.Margin = new Padding(3, 15, 3, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(200, 40);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // viewPassangers
            // 
            viewPassangers.Location = new Point(1112, 12);
            viewPassangers.Name = "viewPassangers";
            viewPassangers.Size = new Size(300, 30);
            viewPassangers.TabIndex = 7;
            viewPassangers.Text = "Просмотр списка пассажиров";
            viewPassangers.UseVisualStyleBackColor = true;
            viewPassangers.Click += viewPassangers_Click;
            // 
            // adminPanel
            // 
            adminPanel.Controls.Add(addButton);
            adminPanel.Controls.Add(editButton);
            adminPanel.Controls.Add(deleteButton);
            adminPanel.Location = new Point(12, 646);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(215, 203);
            adminPanel.TabIndex = 8;
            adminPanel.TabStop = false;
            adminPanel.Text = "Админ панель";
            // 
            // TripsView
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 861);
            Controls.Add(adminPanel);
            Controls.Add(viewPassangers);
            Controls.Add(backButton);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MinimizeBox = false;
            MinimumSize = new Size(1440, 900);
            Name = "TripsView";
            Text = "TripsView";
            FormClosing += TripsView_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            adminPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button backButton;
        private Label label3;
        private ComboBox companyBox;
        private Label label1;
        private TextBox fromTownBox;
        private TextBox timeInBox;
        private Label label4;
        private TextBox timeOutBox;
        private Label label5;
        private TextBox toTownBox;
        private Label label2;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button viewPassangers;
        private GroupBox adminPanel;
    }
}