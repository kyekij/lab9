namespace WindowsFormsApp1
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
            this.countObserverCheckBox = new System.Windows.Forms.CheckBox();
            this.timeObserverCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSetState = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // countObserverCheckBox
            // 
            this.countObserverCheckBox.AutoSize = true;
            this.countObserverCheckBox.Location = new System.Drawing.Point(717, 70);
            this.countObserverCheckBox.Name = "countObserverCheckBox";
            this.countObserverCheckBox.Size = new System.Drawing.Size(150, 29);
            this.countObserverCheckBox.TabIndex = 5;
            this.countObserverCheckBox.Text = "checkBox2";
            this.countObserverCheckBox.UseVisualStyleBackColor = true;
            // 
            // timeObserverCheckBox
            // 
            this.timeObserverCheckBox.AutoSize = true;
            this.timeObserverCheckBox.Location = new System.Drawing.Point(70, 76);
            this.timeObserverCheckBox.Name = "timeObserverCheckBox";
            this.timeObserverCheckBox.Size = new System.Drawing.Size(150, 29);
            this.timeObserverCheckBox.TabIndex = 4;
            this.timeObserverCheckBox.Text = "checkBox1";
            this.timeObserverCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSetState
            // 
            this.btnSetState.Location = new System.Drawing.Point(377, 409);
            this.btnSetState.Name = "btnSetState";
            this.btnSetState.Size = new System.Drawing.Size(286, 67);
            this.btnSetState.TabIndex = 3;
            this.btnSetState.Text = "button1";
            this.btnSetState.UseVisualStyleBackColor = true;
            this.btnSetState.Click += new System.EventHandler(this.btnSetState_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(316, 168);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(420, 64);
            this.outputTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 499);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.countObserverCheckBox);
            this.Controls.Add(this.timeObserverCheckBox);
            this.Controls.Add(this.btnSetState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox countObserverCheckBox;
        private System.Windows.Forms.CheckBox timeObserverCheckBox;
        private System.Windows.Forms.Button btnSetState;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

