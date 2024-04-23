namespace WFlab11
{
    partial class MainForm
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
            this.btnSetState = new System.Windows.Forms.Button();
            this.timeObserverCheckBox = new System.Windows.Forms.CheckBox();
            this.countObserverCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSetState
            // 
            this.btnSetState.Location = new System.Drawing.Point(350, 512);
            this.btnSetState.Name = "btnSetState";
            this.btnSetState.Size = new System.Drawing.Size(286, 67);
            this.btnSetState.TabIndex = 0;
            this.btnSetState.Text = "button1";
            this.btnSetState.UseVisualStyleBackColor = true;
            this.btnSetState.Click += new System.EventHandler(this.btnSetState_Click);
            // 
            // timeObserverCheckBox
            // 
            this.timeObserverCheckBox.AutoSize = true;
            this.timeObserverCheckBox.Location = new System.Drawing.Point(43, 179);
            this.timeObserverCheckBox.Name = "timeObserverCheckBox";
            this.timeObserverCheckBox.Size = new System.Drawing.Size(150, 29);
            this.timeObserverCheckBox.TabIndex = 1;
            this.timeObserverCheckBox.Text = "checkBox1";
            this.timeObserverCheckBox.UseVisualStyleBackColor = true;
            this.timeObserverCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // countObserverCheckBox
            // 
            this.countObserverCheckBox.AutoSize = true;
            this.countObserverCheckBox.Location = new System.Drawing.Point(690, 173);
            this.countObserverCheckBox.Name = "countObserverCheckBox";
            this.countObserverCheckBox.Size = new System.Drawing.Size(150, 29);
            this.countObserverCheckBox.TabIndex = 2;
            this.countObserverCheckBox.Text = "checkBox2";
            this.countObserverCheckBox.UseVisualStyleBackColor = true;
            this.countObserverCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 606);
            this.Controls.Add(this.countObserverCheckBox);
            this.Controls.Add(this.timeObserverCheckBox);
            this.Controls.Add(this.btnSetState);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetState;
        private System.Windows.Forms.CheckBox timeObserverCheckBox;
        private System.Windows.Forms.CheckBox countObserverCheckBox;
    }
}

