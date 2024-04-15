namespace University
{
    partial class WorkerForm
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
            tabControl = new TabControl();
            tabPageApplications = new TabPage();
            dateTimePicker = new DateTimePicker();
            label4 = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageLevels = new TabPage();
            buttonSaveChangesLevels = new Button();
            dataGridViewLevels = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            MaxPoints = new DataGridViewTextBoxColumn();
            tabPageSpecilaties = new TabPage();
            buttonSaveChangesSpecialties = new Button();
            dataGridViewSpecialties = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            IdEducationLevel = new DataGridViewComboBoxColumn();
            tabControl.SuspendLayout();
            tabPageApplications.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            tabPageLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLevels).BeginInit();
            tabPageSpecilaties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpecialties).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageApplications);
            tabControl.Controls.Add(tabPageLevels);
            tabControl.Controls.Add(tabPageSpecilaties);
            tabControl.Location = new Point(21, 21);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1334, 921);
            tabControl.TabIndex = 0;
            // 
            // tabPageApplications
            // 
            tabPageApplications.Controls.Add(dateTimePicker);
            tabPageApplications.Controls.Add(label4);
            tabPageApplications.Controls.Add(flowLayoutPanel);
            tabPageApplications.Location = new Point(4, 46);
            tabPageApplications.Name = "tabPageApplications";
            tabPageApplications.Padding = new Padding(3);
            tabPageApplications.Size = new Size(1326, 871);
            tabPageApplications.TabIndex = 0;
            tabPageApplications.Text = "Заявления";
            tabPageApplications.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(137, 31);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 41);
            dateTimePicker.TabIndex = 2;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 31);
            label4.Name = "label4";
            label4.Size = new Size(53, 37);
            label4.TabIndex = 1;
            label4.Text = "Дата";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(panel1);
            flowLayoutPanel.Location = new Point(50, 93);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(1226, 744);
            flowLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1223, 108);
            panel1.TabIndex = 0;
            panel1.DoubleClick += panel_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1093, 39);
            label3.Name = "label3";
            label3.Size = new Size(69, 37);
            label3.TabIndex = 2;
            label3.Text = "Статус";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 39);
            label2.Name = "label2";
            label2.Size = new Size(85, 37);
            label2.TabIndex = 1;
            label2.Text = "№4587563";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 39);
            label1.Name = "label1";
            label1.Size = new Size(53, 37);
            label1.TabIndex = 0;
            label1.Text = "Дата";
            // 
            // tabPageLevels
            // 
            tabPageLevels.Controls.Add(buttonSaveChangesLevels);
            tabPageLevels.Controls.Add(dataGridViewLevels);
            tabPageLevels.Location = new Point(4, 29);
            tabPageLevels.Name = "tabPageLevels";
            tabPageLevels.Padding = new Padding(3);
            tabPageLevels.Size = new Size(1326, 888);
            tabPageLevels.TabIndex = 1;
            tabPageLevels.Text = "Уровни образования";
            tabPageLevels.UseVisualStyleBackColor = true;
            // 
            // buttonSaveChangesLevels
            // 
            buttonSaveChangesLevels.BackColor = Color.Turquoise;
            buttonSaveChangesLevels.Enabled = false;
            buttonSaveChangesLevels.Location = new Point(1159, 798);
            buttonSaveChangesLevels.Name = "buttonSaveChangesLevels";
            buttonSaveChangesLevels.Size = new Size(145, 41);
            buttonSaveChangesLevels.TabIndex = 1;
            buttonSaveChangesLevels.Text = "Сохранить";
            buttonSaveChangesLevels.UseVisualStyleBackColor = false;
            buttonSaveChangesLevels.Click += buttonSaveChangesLevels_Click;
            // 
            // dataGridViewLevels
            // 
            dataGridViewLevels.AllowUserToResizeColumns = false;
            dataGridViewLevels.AllowUserToResizeRows = false;
            dataGridViewLevels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLevels.BackgroundColor = Color.White;
            dataGridViewLevels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLevels.Columns.AddRange(new DataGridViewColumn[] { Id, Title, MaxPoints });
            dataGridViewLevels.Location = new Point(20, 28);
            dataGridViewLevels.Name = "dataGridViewLevels";
            dataGridViewLevels.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewLevels.RowHeadersVisible = false;
            dataGridViewLevels.RowHeadersWidth = 51;
            dataGridViewLevels.RowTemplate.Height = 29;
            dataGridViewLevels.ScrollBars = ScrollBars.Vertical;
            dataGridViewLevels.Size = new Size(1284, 742);
            dataGridViewLevels.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Title
            // 
            Title.HeaderText = "Наименование";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            // 
            // MaxPoints
            // 
            MaxPoints.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaxPoints.HeaderText = "Максимальный балл при поступлении";
            MaxPoints.MinimumWidth = 6;
            MaxPoints.Name = "MaxPoints";
            MaxPoints.Width = 191;
            // 
            // tabPageSpecilaties
            // 
            tabPageSpecilaties.Controls.Add(buttonSaveChangesSpecialties);
            tabPageSpecilaties.Controls.Add(dataGridViewSpecialties);
            tabPageSpecilaties.Location = new Point(4, 29);
            tabPageSpecilaties.Name = "tabPageSpecilaties";
            tabPageSpecilaties.Padding = new Padding(3);
            tabPageSpecilaties.Size = new Size(1326, 888);
            tabPageSpecilaties.TabIndex = 2;
            tabPageSpecilaties.Text = "Направления";
            tabPageSpecilaties.UseVisualStyleBackColor = true;
            // 
            // buttonSaveChangesSpecialties
            // 
            buttonSaveChangesSpecialties.BackColor = Color.Turquoise;
            buttonSaveChangesSpecialties.Enabled = false;
            buttonSaveChangesSpecialties.Location = new Point(1144, 799);
            buttonSaveChangesSpecialties.Name = "buttonSaveChangesSpecialties";
            buttonSaveChangesSpecialties.Size = new Size(145, 41);
            buttonSaveChangesSpecialties.TabIndex = 2;
            buttonSaveChangesSpecialties.Text = "Сохранить";
            buttonSaveChangesSpecialties.UseVisualStyleBackColor = false;
            buttonSaveChangesSpecialties.Click += buttonSaveChangesSpecialties_Click;
            // 
            // dataGridViewSpecialties
            // 
            dataGridViewSpecialties.AllowUserToResizeColumns = false;
            dataGridViewSpecialties.AllowUserToResizeRows = false;
            dataGridViewSpecialties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSpecialties.BackgroundColor = Color.White;
            dataGridViewSpecialties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSpecialties.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, IdEducationLevel });
            dataGridViewSpecialties.Location = new Point(20, 28);
            dataGridViewSpecialties.Name = "dataGridViewSpecialties";
            dataGridViewSpecialties.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewSpecialties.RowHeadersVisible = false;
            dataGridViewSpecialties.RowHeadersWidth = 51;
            dataGridViewSpecialties.RowTemplate.Height = 29;
            dataGridViewSpecialties.ScrollBars = ScrollBars.Vertical;
            dataGridViewSpecialties.Size = new Size(1284, 742);
            dataGridViewSpecialties.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.HeaderText = "Код специальности";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 172;
            // 
            // IdEducationLevel
            // 
            IdEducationLevel.HeaderText = "Уровень образования";
            IdEducationLevel.MinimumWidth = 6;
            IdEducationLevel.Name = "IdEducationLevel";
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1367, 954);
            Controls.Add(tabControl);
            Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 6, 3, 6);
            MaximumSize = new Size(1385, 1001);
            MinimumSize = new Size(1385, 1001);
            Name = "WorkerForm";
            Text = "Прием заявлений";
            tabControl.ResumeLayout(false);
            tabPageApplications.ResumeLayout(false);
            tabPageApplications.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageLevels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLevels).EndInit();
            tabPageSpecilaties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpecialties).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private TabControl tabControl;
        private TabPage tabPageApplications;
        private TabPage tabPageLevels;
        private TabPage tabPageSpecilaties;
        private DataGridView dataGridViewLevels;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn MaxPoints;
        private Button buttonSaveChangesLevels;
        private DataGridView dataGridViewSpecialties;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewComboBoxColumn IdEducationLevel;
        private Button buttonSaveChangesSpecialties;
        private FlowLayoutPanel flowLayoutPanel;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private Label label4;
    }
}