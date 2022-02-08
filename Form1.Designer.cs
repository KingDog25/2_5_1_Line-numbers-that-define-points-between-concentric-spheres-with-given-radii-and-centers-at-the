
namespace _23_variant_CSarp_2_5_1
{
    partial class ConsentricSpheres
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
            this.labelMinSum = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxInputEl = new System.Windows.Forms.TextBox();
            this.labelInputEl = new System.Windows.Forms.Label();
            this.radioButtonHandle = new System.Windows.Forms.RadioButton();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_r1 = new System.Windows.Forms.TextBox();
            this.textBox_R2 = new System.Windows.Forms.TextBox();
            this.labelRadiusesCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMinSum
            // 
            this.labelMinSum.AutoSize = true;
            this.labelMinSum.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMinSum.Location = new System.Drawing.Point(13, 418);
            this.labelMinSum.Name = "labelMinSum";
            this.labelMinSum.Size = new System.Drawing.Size(0, 19);
            this.labelMinSum.TabIndex = 22;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(598, 35);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(106, 41);
            this.buttonInput.TabIndex = 23;
            this.buttonInput.Text = "Рассчитать";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxInputEl
            // 
            this.textBoxInputEl.Enabled = false;
            this.textBoxInputEl.Location = new System.Drawing.Point(275, 9);
            this.textBoxInputEl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInputEl.Name = "textBoxInputEl";
            this.textBoxInputEl.Size = new System.Drawing.Size(290, 26);
            this.textBoxInputEl.TabIndex = 19;
            // 
            // labelInputEl
            // 
            this.labelInputEl.AutoSize = true;
            this.labelInputEl.Font = new System.Drawing.Font("Segoe UI", 9.163636F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelInputEl.Location = new System.Drawing.Point(-1, 9);
            this.labelInputEl.Name = "labelInputEl";
            this.labelInputEl.Size = new System.Drawing.Size(270, 19);
            this.labelInputEl.TabIndex = 20;
            this.labelInputEl.Text = "Введите(через пробел) аргументы X:";
            // 
            // radioButtonHandle
            // 
            this.radioButtonHandle.AutoSize = true;
            this.radioButtonHandle.Location = new System.Drawing.Point(13, 44);
            this.radioButtonHandle.Name = "radioButtonHandle";
            this.radioButtonHandle.Size = new System.Drawing.Size(199, 23);
            this.radioButtonHandle.TabIndex = 25;
            this.radioButtonHandle.Text = "Вввести значения вручную";
            this.radioButtonHandle.UseVisualStyleBackColor = true;
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Checked = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(13, 73);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(235, 23);
            this.radioButtonRandom.TabIndex = 27;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Заполнить случайными числами";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(910, 419);
            this.dataGridView1.TabIndex = 21;
            // 
            // textBox_r1
            // 
            this.textBox_r1.Location = new System.Drawing.Point(275, 68);
            this.textBox_r1.Name = "textBox_r1";
            this.textBox_r1.Size = new System.Drawing.Size(123, 26);
            this.textBox_r1.TabIndex = 28;
            this.textBox_r1.Text = "Введите радиус r";
            this.textBox_r1.Enter += new System.EventHandler(this.textBox_r1_Enter);
            // 
            // textBox_R2
            // 
            this.textBox_R2.Location = new System.Drawing.Point(438, 68);
            this.textBox_R2.Name = "textBox_R2";
            this.textBox_R2.Size = new System.Drawing.Size(127, 26);
            this.textBox_R2.TabIndex = 29;
            this.textBox_R2.Text = "Введите радиус R";
            this.textBox_R2.Enter += new System.EventHandler(this.textBox_R2_Enter);
            // 
            // labelRadiusesCount
            // 
            this.labelRadiusesCount.AutoSize = true;
            this.labelRadiusesCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelRadiusesCount.Location = new System.Drawing.Point(0, 563);
            this.labelRadiusesCount.Name = "labelRadiusesCount";
            this.labelRadiusesCount.Size = new System.Drawing.Size(0, 19);
            this.labelRadiusesCount.TabIndex = 30;
            // 
            // ConsentricSpheres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 582);
            this.Controls.Add(this.labelRadiusesCount);
            this.Controls.Add(this.textBox_R2);
            this.Controls.Add(this.textBox_r1);
            this.Controls.Add(this.radioButtonRandom);
            this.Controls.Add(this.radioButtonHandle);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.labelMinSum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelInputEl);
            this.Controls.Add(this.textBoxInputEl);
            this.Name = "ConsentricSpheres";
            this.Text = "\"Программа для определения, находится ли точка между двумя концентрическими сфера" +
    "ми";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMinSum;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBoxInputEl;
        private System.Windows.Forms.Label labelInputEl;
        private System.Windows.Forms.RadioButton radioButtonHandle;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_r1;
        private System.Windows.Forms.TextBox textBox_R2;
        private System.Windows.Forms.Label labelRadiusesCount;
    }
}

