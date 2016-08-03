namespace Clicker
{
    partial class MainForm
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
            this.readyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hourInput = new System.Windows.Forms.NumericUpDown();
            this.minuteInput = new System.Windows.Forms.NumericUpDown();
            this.secondInput = new System.Windows.Forms.NumericUpDown();
            this.msInput = new System.Windows.Forms.NumericUpDown();
            this.currentTime = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msInput)).BeginInit();
            this.SuspendLayout();
            // 
            // readyButton
            // 
            this.readyButton.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.readyButton.Location = new System.Drawing.Point(12, 341);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(357, 39);
            this.readyButton.TabIndex = 4;
            this.readyButton.Text = "Ready";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "毫秒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "秒";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "分钟";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "小时";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.hourInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.minuteInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.secondInput, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.msInput, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.currentTime, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 323);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // hourInput
            // 
            this.hourInput.Font = new System.Drawing.Font("SimSun", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hourInput.Location = new System.Drawing.Point(181, 67);
            this.hourInput.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourInput.Name = "hourInput";
            this.hourInput.Size = new System.Drawing.Size(120, 50);
            this.hourInput.TabIndex = 0;
            // 
            // minuteInput
            // 
            this.minuteInput.Font = new System.Drawing.Font("SimSun", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minuteInput.Location = new System.Drawing.Point(181, 131);
            this.minuteInput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteInput.Name = "minuteInput";
            this.minuteInput.Size = new System.Drawing.Size(120, 50);
            this.minuteInput.TabIndex = 1;
            // 
            // secondInput
            // 
            this.secondInput.Font = new System.Drawing.Font("SimSun", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.secondInput.Location = new System.Drawing.Point(181, 195);
            this.secondInput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(120, 50);
            this.secondInput.TabIndex = 2;
            // 
            // msInput
            // 
            this.msInput.Font = new System.Drawing.Font("SimSun", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msInput.Location = new System.Drawing.Point(181, 259);
            this.msInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.msInput.Name = "msInput";
            this.msInput.Size = new System.Drawing.Size(120, 50);
            this.msInput.TabIndex = 3;
            // 
            // currentTime
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.currentTime, 2);
            this.currentTime.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentTime.Location = new System.Drawing.Point(3, 3);
            this.currentTime.Name = "currentTime";
            this.currentTime.ReadOnly = true;
            this.currentTime.Size = new System.Drawing.Size(351, 31);
            this.currentTime.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 392);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.readyButton);
            this.Name = "MainForm";
            this.Text = "定时点击器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown hourInput;
        private System.Windows.Forms.NumericUpDown minuteInput;
        private System.Windows.Forms.NumericUpDown secondInput;
        private System.Windows.Forms.NumericUpDown msInput;
        private System.Windows.Forms.TextBox currentTime;
    }
}

