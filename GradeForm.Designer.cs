namespace Student_System
{
    partial class GradeForm
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
            this.dataGridGradeList = new System.Windows.Forms.DataGridView();
            this.buttonAddGrade = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGradeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGradeList
            // 
            this.dataGridGradeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGradeList.Location = new System.Drawing.Point(12, 12);
            this.dataGridGradeList.Name = "dataGridGradeList";
            this.dataGridGradeList.Size = new System.Drawing.Size(1083, 440);
            this.dataGridGradeList.TabIndex = 0;
            // 
            // buttonAddGrade
            // 
            this.buttonAddGrade.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddGrade.Location = new System.Drawing.Point(769, 468);
            this.buttonAddGrade.Name = "buttonAddGrade";
            this.buttonAddGrade.Size = new System.Drawing.Size(326, 51);
            this.buttonAddGrade.TabIndex = 5;
            this.buttonAddGrade.Text = "Dodaj ocene";
            this.buttonAddGrade.UseVisualStyleBackColor = true;
            this.buttonAddGrade.Click += new System.EventHandler(this.buttonAddGrade_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.Location = new System.Drawing.Point(12, 468);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(363, 51);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Cofnij";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.Location = new System.Drawing.Point(407, 468);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(326, 51);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 531);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAddGrade);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridGradeList);
            this.Name = "GradeForm";
            this.Text = "GradeForm";
            this.Load += new System.EventHandler(this.GradeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGradeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddGrade;
        private System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.DataGridView dataGridGradeList;
        private System.Windows.Forms.Button buttonRefresh;
    }
}