namespace ProyectoArqui
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombrePC = new System.Windows.Forms.Label();
            this.nombreProcesor = new System.Windows.Forms.Label();
            this.algoritmos = new System.Windows.Forms.ComboBox();
            this.ejecutar = new System.Windows.Forms.Button();
            this.tiempoParal = new System.Windows.Forms.Label();
            this.tiempoSecuen = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.RichTextBox();
            this.cantNucleos = new System.Windows.Forms.Label();
            this.numNucleos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter3 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter4 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter5 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter6 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter7 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter8 = new System.Diagnostics.PerformanceCounter();
            this.procesador1 = new System.Windows.Forms.ProgressBar();
            this.procesador2 = new System.Windows.Forms.ProgressBar();
            this.procesador3 = new System.Windows.Forms.ProgressBar();
            this.procesador4 = new System.Windows.Forms.ProgressBar();
            this.procesador5 = new System.Windows.Forms.ProgressBar();
            this.procesador6 = new System.Windows.Forms.ProgressBar();
            this.procesador7 = new System.Windows.Forms.ProgressBar();
            this.procesador8 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.porcentaje1 = new System.Windows.Forms.Label();
            this.porcentaje2 = new System.Windows.Forms.Label();
            this.porcentaje3 = new System.Windows.Forms.Label();
            this.porcentaje4 = new System.Windows.Forms.Label();
            this.porcentaje5 = new System.Windows.Forms.Label();
            this.porcentaje6 = new System.Windows.Forms.Label();
            this.porcentaje7 = new System.Windows.Forms.Label();
            this.porcentaje8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PC: ";
            // 
            // nombrePC
            // 
            this.nombrePC.AutoSize = true;
            this.nombrePC.Location = new System.Drawing.Point(169, 7);
            this.nombrePC.Name = "nombrePC";
            this.nombrePC.Size = new System.Drawing.Size(42, 13);
            this.nombrePC.TabIndex = 2;
            this.nombrePC.Text = "nombre";
            // 
            // nombreProcesor
            // 
            this.nombreProcesor.AutoSize = true;
            this.nombreProcesor.Location = new System.Drawing.Point(169, 32);
            this.nombreProcesor.Name = "nombreProcesor";
            this.nombreProcesor.Size = new System.Drawing.Size(99, 13);
            this.nombreProcesor.TabIndex = 3;
            this.nombreProcesor.Text = "nombre Procesador";
            // 
            // algoritmos
            // 
            this.algoritmos.Items.AddRange(new object[] {
            "Ciclico Paralelo",
            "Ciclico Secuencial",
            "Ordenamiento Paralelo",
            "Ordenamiento Secuencial",
            "Recursivo Paralelo",
            "Recursivo Secuencial"});
            this.algoritmos.Location = new System.Drawing.Point(89, 103);
            this.algoritmos.Name = "algoritmos";
            this.algoritmos.Size = new System.Drawing.Size(184, 21);
            this.algoritmos.TabIndex = 4;
            // 
            // ejecutar
            // 
            this.ejecutar.Location = new System.Drawing.Point(140, 149);
            this.ejecutar.Name = "ejecutar";
            this.ejecutar.Size = new System.Drawing.Size(75, 23);
            this.ejecutar.TabIndex = 5;
            this.ejecutar.Text = "Ejecutar";
            this.ejecutar.UseVisualStyleBackColor = true;
            this.ejecutar.Click += new System.EventHandler(this.ejecutar_Click);
            // 
            // tiempoParal
            // 
            this.tiempoParal.AutoSize = true;
            this.tiempoParal.Location = new System.Drawing.Point(158, 508);
            this.tiempoParal.Name = "tiempoParal";
            this.tiempoParal.Size = new System.Drawing.Size(83, 13);
            this.tiempoParal.TabIndex = 6;
            this.tiempoParal.Text = "Tiempo Paralelo";
            // 
            // tiempoSecuen
            // 
            this.tiempoSecuen.AutoSize = true;
            this.tiempoSecuen.Location = new System.Drawing.Point(158, 539);
            this.tiempoSecuen.Name = "tiempoSecuen";
            this.tiempoSecuen.Size = new System.Drawing.Size(98, 13);
            this.tiempoSecuen.TabIndex = 7;
            this.tiempoSecuen.Text = "Tiempo Secuencial";
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(32, 190);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(283, 295);
            this.mostrar.TabIndex = 8;
            this.mostrar.Text = "";
            // 
            // cantNucleos
            // 
            this.cantNucleos.AutoSize = true;
            this.cantNucleos.Location = new System.Drawing.Point(58, 62);
            this.cantNucleos.Name = "cantNucleos";
            this.cantNucleos.Size = new System.Drawing.Size(94, 13);
            this.cantNucleos.TabIndex = 9;
            this.cantNucleos.Text = "Cantidad Nucleos:";
            // 
            // numNucleos
            // 
            this.numNucleos.AutoSize = true;
            this.numNucleos.Location = new System.Drawing.Point(169, 62);
            this.numNucleos.Name = "numNucleos";
            this.numNucleos.Size = new System.Drawing.Size(90, 13);
            this.numNucleos.TabIndex = 10;
            this.numNucleos.Text = "cantidad Nucleos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Paralelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Secuencial:";
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Procesador";
            this.performanceCounter1.CounterName = "% de tiempo de procesador";
            this.performanceCounter1.InstanceName = "0";
            // 
            // performanceCounter2
            // 
            this.performanceCounter2.CategoryName = "Procesador";
            this.performanceCounter2.CounterName = "% de tiempo de procesador";
            this.performanceCounter2.InstanceName = "1";
            // 
            // performanceCounter3
            // 
            this.performanceCounter3.CategoryName = "Procesador";
            this.performanceCounter3.CounterName = "% de tiempo de procesador";
            this.performanceCounter3.InstanceName = "2";
            // 
            // performanceCounter4
            // 
            this.performanceCounter4.CategoryName = "Procesador";
            this.performanceCounter4.CounterName = "% de tiempo de procesador";
            this.performanceCounter4.InstanceName = "3";
            // 
            // performanceCounter5
            // 
            this.performanceCounter5.CategoryName = "Procesador";
            this.performanceCounter5.CounterName = "% de tiempo de procesador";
            this.performanceCounter5.InstanceName = "4";
            // 
            // performanceCounter6
            // 
            this.performanceCounter6.CategoryName = "Procesador";
            this.performanceCounter6.CounterName = "% de tiempo de procesador";
            this.performanceCounter6.InstanceName = "5";
            // 
            // performanceCounter7
            // 
            this.performanceCounter7.CategoryName = "Procesador";
            this.performanceCounter7.CounterName = "% de tiempo de procesador";
            this.performanceCounter7.InstanceName = "6";
            // 
            // performanceCounter8
            // 
            this.performanceCounter8.CategoryName = "Procesador";
            this.performanceCounter8.CounterName = "% de tiempo de procesador";
            this.performanceCounter8.InstanceName = "7";
            // 
            // procesador1
            // 
            this.procesador1.Location = new System.Drawing.Point(441, 115);
            this.procesador1.Name = "procesador1";
            this.procesador1.Size = new System.Drawing.Size(229, 23);
            this.procesador1.TabIndex = 13;
            // 
            // procesador2
            // 
            this.procesador2.Location = new System.Drawing.Point(755, 117);
            this.procesador2.Name = "procesador2";
            this.procesador2.Size = new System.Drawing.Size(229, 23);
            this.procesador2.TabIndex = 14;
            // 
            // procesador3
            // 
            this.procesador3.Location = new System.Drawing.Point(441, 220);
            this.procesador3.Name = "procesador3";
            this.procesador3.Size = new System.Drawing.Size(229, 23);
            this.procesador3.TabIndex = 15;
            // 
            // procesador4
            // 
            this.procesador4.Location = new System.Drawing.Point(755, 220);
            this.procesador4.Name = "procesador4";
            this.procesador4.Size = new System.Drawing.Size(229, 23);
            this.procesador4.TabIndex = 16;
            // 
            // procesador5
            // 
            this.procesador5.Location = new System.Drawing.Point(441, 335);
            this.procesador5.Name = "procesador5";
            this.procesador5.Size = new System.Drawing.Size(229, 23);
            this.procesador5.TabIndex = 17;
            // 
            // procesador6
            // 
            this.procesador6.Location = new System.Drawing.Point(755, 335);
            this.procesador6.Name = "procesador6";
            this.procesador6.Size = new System.Drawing.Size(229, 23);
            this.procesador6.TabIndex = 18;
            // 
            // procesador7
            // 
            this.procesador7.Location = new System.Drawing.Point(441, 450);
            this.procesador7.Name = "procesador7";
            this.procesador7.Size = new System.Drawing.Size(229, 23);
            this.procesador7.TabIndex = 19;
            // 
            // procesador8
            // 
            this.procesador8.Location = new System.Drawing.Point(755, 450);
            this.procesador8.Name = "procesador8";
            this.procesador8.Size = new System.Drawing.Size(229, 23);
            this.procesador8.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Procesador 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(752, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Procesador 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Procesador 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(752, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Procesador 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Procesador 5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(752, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Procesador 6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(438, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Procesador 7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(752, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Procesador 8";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // porcentaje1
            // 
            this.porcentaje1.AutoSize = true;
            this.porcentaje1.Location = new System.Drawing.Point(527, 149);
            this.porcentaje1.Name = "porcentaje1";
            this.porcentaje1.Size = new System.Drawing.Size(100, 13);
            this.porcentaje1.TabIndex = 29;
            this.porcentaje1.Text = "Processor Time: 0%";
            // 
            // porcentaje2
            // 
            this.porcentaje2.AutoSize = true;
            this.porcentaje2.Location = new System.Drawing.Point(851, 149);
            this.porcentaje2.Name = "porcentaje2";
            this.porcentaje2.Size = new System.Drawing.Size(100, 13);
            this.porcentaje2.TabIndex = 30;
            this.porcentaje2.Text = "Processor Time: 0%";
            // 
            // porcentaje3
            // 
            this.porcentaje3.AutoSize = true;
            this.porcentaje3.Location = new System.Drawing.Point(527, 257);
            this.porcentaje3.Name = "porcentaje3";
            this.porcentaje3.Size = new System.Drawing.Size(100, 13);
            this.porcentaje3.TabIndex = 31;
            this.porcentaje3.Text = "Processor Time: 0%";
            // 
            // porcentaje4
            // 
            this.porcentaje4.AutoSize = true;
            this.porcentaje4.Location = new System.Drawing.Point(851, 257);
            this.porcentaje4.Name = "porcentaje4";
            this.porcentaje4.Size = new System.Drawing.Size(100, 13);
            this.porcentaje4.TabIndex = 32;
            this.porcentaje4.Text = "Processor Time: 0%";
            // 
            // porcentaje5
            // 
            this.porcentaje5.AutoSize = true;
            this.porcentaje5.Location = new System.Drawing.Point(527, 372);
            this.porcentaje5.Name = "porcentaje5";
            this.porcentaje5.Size = new System.Drawing.Size(100, 13);
            this.porcentaje5.TabIndex = 33;
            this.porcentaje5.Text = "Processor Time: 0%";
            // 
            // porcentaje6
            // 
            this.porcentaje6.AutoSize = true;
            this.porcentaje6.Location = new System.Drawing.Point(851, 372);
            this.porcentaje6.Name = "porcentaje6";
            this.porcentaje6.Size = new System.Drawing.Size(100, 13);
            this.porcentaje6.TabIndex = 34;
            this.porcentaje6.Text = "Processor Time: 0%";
            // 
            // porcentaje7
            // 
            this.porcentaje7.AutoSize = true;
            this.porcentaje7.Location = new System.Drawing.Point(527, 486);
            this.porcentaje7.Name = "porcentaje7";
            this.porcentaje7.Size = new System.Drawing.Size(100, 13);
            this.porcentaje7.TabIndex = 35;
            this.porcentaje7.Text = "Processor Time: 0%";
            // 
            // porcentaje8
            // 
            this.porcentaje8.AutoSize = true;
            this.porcentaje8.Location = new System.Drawing.Point(851, 486);
            this.porcentaje8.Name = "porcentaje8";
            this.porcentaje8.Size = new System.Drawing.Size(100, 13);
            this.porcentaje8.TabIndex = 36;
            this.porcentaje8.Text = "Processor Time: 0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 606);
            this.Controls.Add(this.porcentaje8);
            this.Controls.Add(this.porcentaje7);
            this.Controls.Add(this.porcentaje6);
            this.Controls.Add(this.porcentaje5);
            this.Controls.Add(this.porcentaje4);
            this.Controls.Add(this.porcentaje3);
            this.Controls.Add(this.porcentaje2);
            this.Controls.Add(this.porcentaje1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.procesador8);
            this.Controls.Add(this.procesador7);
            this.Controls.Add(this.procesador6);
            this.Controls.Add(this.procesador5);
            this.Controls.Add(this.procesador4);
            this.Controls.Add(this.procesador3);
            this.Controls.Add(this.procesador2);
            this.Controls.Add(this.procesador1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numNucleos);
            this.Controls.Add(this.cantNucleos);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.tiempoSecuen);
            this.Controls.Add(this.tiempoParal);
            this.Controls.Add(this.ejecutar);
            this.Controls.Add(this.algoritmos);
            this.Controls.Add(this.nombreProcesor);
            this.Controls.Add(this.nombrePC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombrePC;
        private System.Windows.Forms.Label nombreProcesor;
        private System.Windows.Forms.ComboBox algoritmos;
        private System.Windows.Forms.Button ejecutar;
        private System.Windows.Forms.Label tiempoParal;
        private System.Windows.Forms.Label tiempoSecuen;
        private System.Windows.Forms.RichTextBox mostrar;
        private System.Windows.Forms.Label cantNucleos;
        private System.Windows.Forms.Label numNucleos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Diagnostics.PerformanceCounter performanceCounter2;
        private System.Diagnostics.PerformanceCounter performanceCounter3;
        private System.Diagnostics.PerformanceCounter performanceCounter4;
        private System.Diagnostics.PerformanceCounter performanceCounter5;
        private System.Diagnostics.PerformanceCounter performanceCounter6;
        private System.Diagnostics.PerformanceCounter performanceCounter7;
        private System.Diagnostics.PerformanceCounter performanceCounter8;
        private System.Windows.Forms.ProgressBar procesador1;
        private System.Windows.Forms.ProgressBar procesador2;
        private System.Windows.Forms.ProgressBar procesador3;
        private System.Windows.Forms.ProgressBar procesador4;
        private System.Windows.Forms.ProgressBar procesador5;
        private System.Windows.Forms.ProgressBar procesador6;
        private System.Windows.Forms.ProgressBar procesador7;
        private System.Windows.Forms.ProgressBar procesador8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label porcentaje1;
        private System.Windows.Forms.Label porcentaje2;
        private System.Windows.Forms.Label porcentaje3;
        private System.Windows.Forms.Label porcentaje4;
        private System.Windows.Forms.Label porcentaje5;
        private System.Windows.Forms.Label porcentaje6;
        private System.Windows.Forms.Label porcentaje7;
        private System.Windows.Forms.Label porcentaje8;
    }
}

