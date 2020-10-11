namespace Adams_Method
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.accuracyTexBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.finalAbscissaTexBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.initialOrdinateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.initialAbscissaTexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equationsList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plotPlace = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.accuracyTexBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.finalAbscissaTexBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.initialOrdinateTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.initialAbscissaTexBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.equationsList);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(653, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(653, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(386, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "accuracy =";
            // 
            // accuracyTexBox
            // 
            this.accuracyTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracyTexBox.Location = new System.Drawing.Point(465, 45);
            this.accuracyTexBox.Name = "accuracyTexBox";
            this.accuracyTexBox.Size = new System.Drawing.Size(100, 22);
            this.accuracyTexBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(192, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "x_n =";
            // 
            // finalAbscissaTexBox
            // 
            this.finalAbscissaTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finalAbscissaTexBox.Location = new System.Drawing.Point(232, 71);
            this.finalAbscissaTexBox.Name = "finalAbscissaTexBox";
            this.finalAbscissaTexBox.Size = new System.Drawing.Size(100, 22);
            this.finalAbscissaTexBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(192, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "y_0 =";
            // 
            // initialOrdinateTextBox
            // 
            this.initialOrdinateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initialOrdinateTextBox.Location = new System.Drawing.Point(232, 45);
            this.initialOrdinateTextBox.Name = "initialOrdinateTextBox";
            this.initialOrdinateTextBox.Size = new System.Drawing.Size(100, 22);
            this.initialOrdinateTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(192, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "x_0 =";
            // 
            // initialAbscissaTexBox
            // 
            this.initialAbscissaTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initialAbscissaTexBox.Location = new System.Drawing.Point(232, 19);
            this.initialAbscissaTexBox.Name = "initialAbscissaTexBox";
            this.initialAbscissaTexBox.Size = new System.Drawing.Size(100, 22);
            this.initialAbscissaTexBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an equation";
            // 
            // equationsList
            // 
            this.equationsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equationsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equationsList.FormattingEnabled = true;
            this.equationsList.Items.AddRange(new object[] {
            "y\' = (2 - y) * tg(x)",
            "y\' = e^(3x) - y",
            "y\' = x * e^(-x^2) - 2xy",
            "y\' = sin(x) + y"});
            this.equationsList.Location = new System.Drawing.Point(13, 58);
            this.equationsList.Name = "equationsList";
            this.equationsList.Size = new System.Drawing.Size(116, 24);
            this.equationsList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.plotPlace);
            this.groupBox2.Location = new System.Drawing.Point(2, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 349);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plot";
            // 
            // plotPlace
            // 
            chartArea1.Name = "ChartArea1";
            this.plotPlace.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.plotPlace.Legends.Add(legend1);
            this.plotPlace.Location = new System.Drawing.Point(6, 19);
            this.plotPlace.Name = "plotPlace";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.plotPlace.Series.Add(series1);
            this.plotPlace.Size = new System.Drawing.Size(783, 324);
            this.plotPlace.TabIndex = 0;
            this.plotPlace.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adams method";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotPlace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accuracyTexBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox finalAbscissaTexBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox initialOrdinateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox initialAbscissaTexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equationsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotPlace;
    }
}

