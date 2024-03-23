namespace CompMathLab3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewCoordinates = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddCoordinate = new System.Windows.Forms.Button();
            this.buttonDeleteCoordinate = new System.Windows.Forms.Button();
            this.comboBoxMethods = new System.Windows.Forms.ComboBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.buttonUseMethod = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDownDegree = new System.Windows.Forms.NumericUpDown();
            this.labelDegree = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMeme = new System.Windows.Forms.Label();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.textBoxA3 = new System.Windows.Forms.TextBox();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.textBoxA4 = new System.Windows.Forms.TextBox();
            this.textBoxA0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.Maximum = 10D;
            chartArea2.AxisX.Minimum = -1D;
            chartArea2.AxisY.Maximum = 20D;
            chartArea2.AxisY.Minimum = -1D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(18, 10);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Purple;
            series5.Name = "Series1";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Name = "Series2";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Name = "Series3";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Name = "Series4";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(513, 333);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Графики";
            // 
            // dataGridViewCoordinates
            // 
            this.dataGridViewCoordinates.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewCoordinates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoordinates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridViewCoordinates.Location = new System.Drawing.Point(536, 12);
            this.dataGridViewCoordinates.Name = "dataGridViewCoordinates";
            this.dataGridViewCoordinates.Size = new System.Drawing.Size(240, 258);
            this.dataGridViewCoordinates.TabIndex = 5;
            // 
            // x
            // 
            this.x.Frozen = true;
            this.x.HeaderText = "x";
            this.x.Name = "x";
            // 
            // y
            // 
            this.y.Frozen = true;
            this.y.HeaderText = "y";
            this.y.Name = "y";
            // 
            // buttonAddCoordinate
            // 
            this.buttonAddCoordinate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCoordinate.Location = new System.Drawing.Point(536, 266);
            this.buttonAddCoordinate.Name = "buttonAddCoordinate";
            this.buttonAddCoordinate.Size = new System.Drawing.Size(240, 36);
            this.buttonAddCoordinate.TabIndex = 6;
            this.buttonAddCoordinate.Text = "Добавить точку";
            this.buttonAddCoordinate.UseVisualStyleBackColor = true;
            this.buttonAddCoordinate.Click += new System.EventHandler(this.buttonAddCoordinate_Click);
            // 
            // buttonDeleteCoordinate
            // 
            this.buttonDeleteCoordinate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCoordinate.Location = new System.Drawing.Point(536, 308);
            this.buttonDeleteCoordinate.Name = "buttonDeleteCoordinate";
            this.buttonDeleteCoordinate.Size = new System.Drawing.Size(240, 36);
            this.buttonDeleteCoordinate.TabIndex = 7;
            this.buttonDeleteCoordinate.Text = "Удалить точку";
            this.buttonDeleteCoordinate.UseVisualStyleBackColor = true;
            this.buttonDeleteCoordinate.Click += new System.EventHandler(this.buttonDeleteCoordinate_Click);
            // 
            // comboBoxMethods
            // 
            this.comboBoxMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxMethods.FormattingEnabled = true;
            this.comboBoxMethods.Items.AddRange(new object[] {
            "Метод Лагранжа",
            "Метод Ньютона",
            "Метод наименьших квадратов"});
            this.comboBoxMethods.Location = new System.Drawing.Point(781, 40);
            this.comboBoxMethods.Name = "comboBoxMethods";
            this.comboBoxMethods.Size = new System.Drawing.Size(236, 32);
            this.comboBoxMethods.TabIndex = 8;
            this.comboBoxMethods.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethods_SelectedIndexChanged);
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMethod.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMethod.ForeColor = System.Drawing.Color.White;
            this.labelMethod.Location = new System.Drawing.Point(807, 12);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(177, 27);
            this.labelMethod.TabIndex = 9;
            this.labelMethod.Text = "Выберите метод";
            // 
            // buttonUseMethod
            // 
            this.buttonUseMethod.BackColor = System.Drawing.Color.Transparent;
            this.buttonUseMethod.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUseMethod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUseMethod.Location = new System.Drawing.Point(781, 78);
            this.buttonUseMethod.Name = "buttonUseMethod";
            this.buttonUseMethod.Size = new System.Drawing.Size(236, 41);
            this.buttonUseMethod.TabIndex = 10;
            this.buttonUseMethod.Text = "Применить метод";
            this.buttonUseMethod.UseVisualStyleBackColor = false;
            this.buttonUseMethod.Click += new System.EventHandler(this.buttonUseMethod_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(781, 124);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // numericUpDownDegree
            // 
            this.numericUpDownDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownDegree.Location = new System.Drawing.Point(781, 313);
            this.numericUpDownDegree.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDegree.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownDegree.Name = "numericUpDownDegree";
            this.numericUpDownDegree.Size = new System.Drawing.Size(236, 29);
            this.numericUpDownDegree.TabIndex = 11;
            this.numericUpDownDegree.Visible = false;
            this.numericUpDownDegree.ValueChanged += new System.EventHandler(this.numericUpDownDegree_ValueChanged);
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDegree.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDegree.ForeColor = System.Drawing.Color.White;
            this.labelDegree.Location = new System.Drawing.Point(776, 283);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(93, 27);
            this.labelDegree.TabIndex = 12;
            this.labelDegree.Text = "Степень";
            this.labelDegree.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1022, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelMeme
            // 
            this.labelMeme.AutoSize = true;
            this.labelMeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMeme.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMeme.ForeColor = System.Drawing.Color.White;
            this.labelMeme.Location = new System.Drawing.Point(1116, 28);
            this.labelMeme.Name = "labelMeme";
            this.labelMeme.Size = new System.Drawing.Size(159, 27);
            this.labelMeme.TabIndex = 14;
            this.labelMeme.Text = "Я программист";
            // 
            // textBoxA1
            // 
            this.textBoxA1.Location = new System.Drawing.Point(928, 170);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(89, 20);
            this.textBoxA1.TabIndex = 15;
            this.textBoxA1.Visible = false;
            // 
            // textBoxA3
            // 
            this.textBoxA3.Location = new System.Drawing.Point(797, 196);
            this.textBoxA3.Name = "textBoxA3";
            this.textBoxA3.Size = new System.Drawing.Size(89, 20);
            this.textBoxA3.TabIndex = 16;
            this.textBoxA3.Visible = false;
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(796, 222);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(90, 20);
            this.textBoxA2.TabIndex = 17;
            this.textBoxA2.Visible = false;
            // 
            // textBoxA4
            // 
            this.textBoxA4.Location = new System.Drawing.Point(797, 170);
            this.textBoxA4.Name = "textBoxA4";
            this.textBoxA4.Size = new System.Drawing.Size(89, 20);
            this.textBoxA4.TabIndex = 18;
            this.textBoxA4.Visible = false;
            // 
            // textBoxA0
            // 
            this.textBoxA0.Location = new System.Drawing.Point(928, 196);
            this.textBoxA0.Name = "textBoxA0";
            this.textBoxA0.Size = new System.Drawing.Size(88, 20);
            this.textBoxA0.TabIndex = 19;
            this.textBoxA0.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(903, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "a0";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(903, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "a1";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "a2";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "a3";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(778, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "a4";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1313, 367);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxA0);
            this.Controls.Add(this.textBoxA4);
            this.Controls.Add(this.textBoxA2);
            this.Controls.Add(this.textBoxA3);
            this.Controls.Add(this.textBoxA1);
            this.Controls.Add(this.labelMeme);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDegree);
            this.Controls.Add(this.numericUpDownDegree);
            this.Controls.Add(this.buttonUseMethod);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.comboBoxMethods);
            this.Controls.Add(this.buttonDeleteCoordinate);
            this.Controls.Add(this.buttonAddCoordinate);
            this.Controls.Add(this.dataGridViewCoordinates);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chart1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "АППРОКСИМАТОР ФУНКЦИЙ";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridViewCoordinates;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Button buttonAddCoordinate;
        private System.Windows.Forms.Button buttonDeleteCoordinate;
        private System.Windows.Forms.ComboBox comboBoxMethods;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Button buttonUseMethod;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDownDegree;
        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMeme;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.TextBox textBoxA3;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.TextBox textBoxA4;
        private System.Windows.Forms.TextBox textBoxA0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

