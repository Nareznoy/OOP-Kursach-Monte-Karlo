namespace KR_OOP_Monte_Karlo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calculateButton = new System.Windows.Forms.Button();
            this.ePoint_textBox = new System.Windows.Forms.TextBox();
            this.aPoint_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPointsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testCaseRadioButton = new System.Windows.Forms.RadioButton();
            this.manualInputRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateButton.Location = new System.Drawing.Point(69, 55);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(145, 30);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ePoint_textBox
            // 
            this.ePoint_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ePoint_textBox.Location = new System.Drawing.Point(69, 3);
            this.ePoint_textBox.Name = "ePoint_textBox";
            this.ePoint_textBox.Size = new System.Drawing.Size(145, 20);
            this.ePoint_textBox.TabIndex = 3;
            // 
            // aPoint_textBox
            // 
            this.aPoint_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aPoint_textBox.Location = new System.Drawing.Point(69, 29);
            this.aPoint_textBox.Name = "aPoint_textBox";
            this.aPoint_textBox.Size = new System.Drawing.Size(145, 20);
            this.aPoint_textBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Точка e";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Точка a";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Square,
            this.numberOfPointsColumn,
            this.timeColumn,
            this.errorColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 233);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(735, 206);
            this.dataGridView.TabIndex = 10;
            // 
            // Type
            // 
            this.Type.HeaderText = "Кол-во точек";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Square
            // 
            this.Square.HeaderText = "Площадь Монте-Карло";
            this.Square.Name = "Square";
            this.Square.ReadOnly = true;
            // 
            // numberOfPointsColumn
            // 
            this.numberOfPointsColumn.HeaderText = "Кол-во точек внутри фигуры";
            this.numberOfPointsColumn.Name = "numberOfPointsColumn";
            this.numberOfPointsColumn.ReadOnly = true;
            // 
            // timeColumn
            // 
            this.timeColumn.HeaderText = "Время";
            this.timeColumn.Name = "timeColumn";
            this.timeColumn.ReadOnly = true;
            // 
            // errorColumn
            // 
            this.errorColumn.HeaderText = "Погрешность, %";
            this.errorColumn.Name = "errorColumn";
            this.errorColumn.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.aPoint_textBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.calculateButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ePoint_textBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 88);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(288, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 215);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // testCaseRadioButton
            // 
            this.testCaseRadioButton.AutoSize = true;
            this.testCaseRadioButton.Location = new System.Drawing.Point(40, 137);
            this.testCaseRadioButton.Name = "testCaseRadioButton";
            this.testCaseRadioButton.Size = new System.Drawing.Size(129, 17);
            this.testCaseRadioButton.TabIndex = 13;
            this.testCaseRadioButton.Text = "Конрольный пример";
            this.testCaseRadioButton.UseVisualStyleBackColor = true;
            this.testCaseRadioButton.CheckedChanged += new System.EventHandler(this.testCaseRadioButton_CheckedChanged);
            // 
            // manualInputRadioButton
            // 
            this.manualInputRadioButton.AutoSize = true;
            this.manualInputRadioButton.Checked = true;
            this.manualInputRadioButton.Location = new System.Drawing.Point(40, 160);
            this.manualInputRadioButton.Name = "manualInputRadioButton";
            this.manualInputRadioButton.Size = new System.Drawing.Size(87, 17);
            this.manualInputRadioButton.TabIndex = 14;
            this.manualInputRadioButton.TabStop = true;
            this.manualInputRadioButton.Text = "Ручной ввод";
            this.manualInputRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 451);
            this.Controls.Add(this.manualInputRadioButton);
            this.Controls.Add(this.testCaseRadioButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Монте-Карло ООП";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox ePoint_textBox;
        private System.Windows.Forms.TextBox aPoint_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Square;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPointsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton testCaseRadioButton;
        private System.Windows.Forms.RadioButton manualInputRadioButton;
    }
}

