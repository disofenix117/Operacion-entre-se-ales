namespace operaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.importar = new System.Windows.Forms.Button();
            this.operacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grafico2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.operar = new System.Windows.Forms.Button();
            this.grafico3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grafico4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grafico5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grafico6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ceroPos1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ceroPos2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico6)).BeginInit();
            this.SuspendLayout();
            // 
            // importar
            // 
            this.importar.Location = new System.Drawing.Point(213, 42);
            this.importar.Name = "importar";
            this.importar.Size = new System.Drawing.Size(96, 23);
            this.importar.TabIndex = 0;
            this.importar.Text = "Importar Señales";
            this.importar.UseVisualStyleBackColor = true;
            this.importar.Click += new System.EventHandler(this.importar_Click);
            // 
            // operacion
            // 
            this.operacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operacion.FormattingEnabled = true;
            this.operacion.Items.AddRange(new object[] {
            "Corrimiento",
            "Reflexion",
            "Submuestreo",
            "Escalado",
            " "});
            this.operacion.Location = new System.Drawing.Point(380, 44);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(121, 21);
            this.operacion.TabIndex = 2;
            this.operacion.Tag = "operacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Que desea hacer:";
            // 
            // NVal
            // 
            this.NVal.Location = new System.Drawing.Point(551, 22);
            this.NVal.Name = "NVal";
            this.NVal.Size = new System.Drawing.Size(23, 20);
            this.NVal.TabIndex = 4;
            this.NVal.TextChanged += new System.EventHandler(this.NVal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "valor de k:";
            // 
            // grafico1
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico1.ChartAreas.Add(chartArea1);
            this.grafico1.Location = new System.Drawing.Point(3, 135);
            this.grafico1.Name = "grafico1";
            this.grafico1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grafico1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.OrangeRed};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Señal1";
            this.grafico1.Series.Add(series1);
            this.grafico1.Size = new System.Drawing.Size(474, 343);
            this.grafico1.TabIndex = 6;
            this.grafico1.Text = "chart1";
            this.grafico1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // grafico2
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico2.ChartAreas.Add(chartArea2);
            this.grafico2.Location = new System.Drawing.Point(512, 135);
            this.grafico2.Name = "grafico2";
            this.grafico2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grafico2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Gold};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Señal2";
            this.grafico2.Series.Add(series2);
            this.grafico2.Size = new System.Drawing.Size(519, 343);
            this.grafico2.TabIndex = 7;
            this.grafico2.Text = "chart2";
            this.grafico2.Click += new System.EventHandler(this.grafico2_Click);
            // 
            // operar
            // 
            this.operar.Location = new System.Drawing.Point(658, 33);
            this.operar.Name = "operar";
            this.operar.Size = new System.Drawing.Size(85, 41);
            this.operar.TabIndex = 8;
            this.operar.Text = "Operar";
            this.operar.UseVisualStyleBackColor = true;
            this.operar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grafico3
            // 
            chartArea3.Name = "ChartArea1";
            this.grafico3.ChartAreas.Add(chartArea3);
            this.grafico3.Location = new System.Drawing.Point(3, 528);
            this.grafico3.Name = "grafico3";
            this.grafico3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grafico3.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.LightSalmon};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Señal 1";
            this.grafico3.Series.Add(series3);
            this.grafico3.Size = new System.Drawing.Size(474, 346);
            this.grafico3.TabIndex = 9;
            this.grafico3.Text = "chart1";
            // 
            // grafico4
            // 
            chartArea4.Name = "ChartArea1";
            this.grafico4.ChartAreas.Add(chartArea4);
            this.grafico4.Location = new System.Drawing.Point(512, 528);
            this.grafico4.Name = "grafico4";
            this.grafico4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grafico4.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Khaki};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "Señal 2";
            this.grafico4.Series.Add(series4);
            this.grafico4.Size = new System.Drawing.Size(519, 346);
            this.grafico4.TabIndex = 10;
            this.grafico4.Text = "chart1";
            this.grafico4.Click += new System.EventHandler(this.grafico4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "X1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "X2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Y2:";
            // 
            // grafico5
            // 
            chartArea5.Name = "ChartArea1";
            this.grafico5.ChartAreas.Add(chartArea5);
            this.grafico5.Location = new System.Drawing.Point(1056, 236);
            this.grafico5.Name = "grafico5";
            this.grafico5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grafico5.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Aquamarine};
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Name = "Y(n)";
            this.grafico5.Series.Add(series5);
            this.grafico5.Size = new System.Drawing.Size(306, 215);
            this.grafico5.TabIndex = 15;
            this.grafico5.Text = "chart1";
            // 
            // grafico6
            // 
            chartArea6.Name = "ChartArea1";
            this.grafico6.ChartAreas.Add(chartArea6);
            this.grafico6.Location = new System.Drawing.Point(1056, 579);
            this.grafico6.Name = "grafico6";
            this.grafico6.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grafico6.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime};
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Name = "Y(n):";
            this.grafico6.Series.Add(series6);
            this.grafico6.Size = new System.Drawing.Size(306, 215);
            this.grafico6.TabIndex = 16;
            this.grafico6.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(749, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(241, 94);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "MANIPULACION DE SEÑALES DISCRETAS";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Diego Suarez 1201689";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Jessica Arias 1202143";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Nicolas Torres 1202135";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // ceroPos1
            // 
            this.ceroPos1.Location = new System.Drawing.Point(561, 70);
            this.ceroPos1.Name = "ceroPos1";
            this.ceroPos1.Size = new System.Drawing.Size(23, 20);
            this.ceroPos1.TabIndex = 23;
            this.ceroPos1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(538, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "posicion de 0:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1051, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "X1+X2:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1051, 528);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "X1*X2:";
            // 
            // ceroPos2
            // 
            this.ceroPos2.Location = new System.Drawing.Point(561, 96);
            this.ceroPos2.Name = "ceroPos2";
            this.ceroPos2.Size = new System.Drawing.Size(23, 20);
            this.ceroPos2.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(509, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Señal 1:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(509, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Señal 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 895);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ceroPos2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ceroPos1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grafico6);
            this.Controls.Add(this.grafico5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grafico4);
            this.Controls.Add(this.grafico3);
            this.Controls.Add(this.operar);
            this.Controls.Add(this.grafico2);
            this.Controls.Add(this.grafico1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.importar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grafico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importar;
        private System.Windows.Forms.ComboBox operacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico1;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico2;
        private System.Windows.Forms.Button operar;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico3;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico5;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ceroPos1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ceroPos2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

