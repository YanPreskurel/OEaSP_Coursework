namespace AFConverter
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.ConvertioButtonClick = new System.Windows.Forms.Button();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelIn = new System.Windows.Forms.Label();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxIn = new System.Windows.Forms.ComboBox();
            this.OpenFileButtonClick = new System.Windows.Forms.Button();
            this.listViewAudio = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ConvertioButtonClick
            // 
            this.ConvertioButtonClick.AutoSize = true;
            this.ConvertioButtonClick.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConvertioButtonClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertioButtonClick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.ConvertioButtonClick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ConvertioButtonClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertioButtonClick.Location = new System.Drawing.Point(151, 292);
            this.ConvertioButtonClick.Margin = new System.Windows.Forms.Padding(0);
            this.ConvertioButtonClick.Name = "ConvertioButtonClick";
            this.ConvertioButtonClick.Size = new System.Drawing.Size(120, 40);
            this.ConvertioButtonClick.TabIndex = 0;
            this.ConvertioButtonClick.Text = "Convertio";
            this.ConvertioButtonClick.UseVisualStyleBackColor = false;
            this.ConvertioButtonClick.Click += new System.EventHandler(this.ConvertioButton_Click);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.Location = new System.Drawing.Point(84, 73);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(54, 23);
            this.labelFrom.TabIndex = 3;
            this.labelFrom.Text = "From";
            this.labelFrom.Click += new System.EventHandler(this.LabelFrom_Click);
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIn.Location = new System.Drawing.Point(84, 131);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(27, 23);
            this.labelIn.TabIndex = 4;
            this.labelIn.Text = "In";
            this.labelIn.Click += new System.EventHandler(this.LabelIn_Click);
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(151, 73);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 27);
            this.comboBoxFrom.TabIndex = 5;
            this.comboBoxFrom.Text = "Choose";
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFrom_SelectedIndexChanged);
            // 
            // comboBoxIn
            // 
            this.comboBoxIn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.comboBoxIn.FormattingEnabled = true;
            this.comboBoxIn.Location = new System.Drawing.Point(151, 131);
            this.comboBoxIn.Name = "comboBoxIn";
            this.comboBoxIn.Size = new System.Drawing.Size(120, 27);
            this.comboBoxIn.TabIndex = 6;
            this.comboBoxIn.Text = "Choose";
            this.comboBoxIn.SelectedIndexChanged += new System.EventHandler(this.ComboBoxIn_SelectedIndexChanged);
            // 
            // OpenFileButtonClick
            // 
            this.OpenFileButtonClick.AutoSize = true;
            this.OpenFileButtonClick.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenFileButtonClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileButtonClick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.OpenFileButtonClick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OpenFileButtonClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButtonClick.Location = new System.Drawing.Point(151, 182);
            this.OpenFileButtonClick.Margin = new System.Windows.Forms.Padding(0);
            this.OpenFileButtonClick.Name = "OpenFileButtonClick";
            this.OpenFileButtonClick.Size = new System.Drawing.Size(120, 40);
            this.OpenFileButtonClick.TabIndex = 7;
            this.OpenFileButtonClick.Text = "Open file";
            this.OpenFileButtonClick.UseVisualStyleBackColor = false;
            this.OpenFileButtonClick.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // listViewAudio
            // 
            this.listViewAudio.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewAudio.HideSelection = false;
            this.listViewAudio.LabelWrap = false;
            this.listViewAudio.Location = new System.Drawing.Point(89, 235);
            this.listViewAudio.Name = "listViewAudio";
            this.listViewAudio.Size = new System.Drawing.Size(183, 43);
            this.listViewAudio.TabIndex = 8;
            this.listViewAudio.UseCompatibleStateImageBehavior = false;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(422, 414);
            this.Controls.Add(this.listViewAudio);
            this.Controls.Add(this.OpenFileButtonClick);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.comboBoxIn);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.ConvertioButtonClick);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 461);
            this.MinimumSize = new System.Drawing.Size(440, 461);
            this.Name = "Converter";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Converter";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertioButtonClick;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxIn;
        private System.Windows.Forms.Button OpenFileButtonClick;
        private System.Windows.Forms.ListView listViewAudio;
    }
}

