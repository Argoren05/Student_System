namespace Student_System
{
    partial class StudentListForm
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
            this.dataGridStudentList = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.buttonShowGrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStudentList
            // 
            this.dataGridStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudentList.Location = new System.Drawing.Point(22, 39);
            this.dataGridStudentList.Name = "dataGridStudentList";
            this.dataGridStudentList.Size = new System.Drawing.Size(1142, 443);
            this.dataGridStudentList.TabIndex = 0;
            this.dataGridStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStudentList_CellContentClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.Location = new System.Drawing.Point(770, 488);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(394, 51);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(22, 488);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(339, 51);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Dodaj nowego studenta";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tb_search
            // 
            this.tb_search.AccessibleDescription = "";
            this.tb_search.AccessibleName = "";
            this.tb_search.Font = new System.Drawing.Font("Arial", 14.25F);
            this.tb_search.Location = new System.Drawing.Point(888, 4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(276, 29);
            this.tb_search.TabIndex = 3;
            this.tb_search.Tag = "";
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // buttonShowGrade
            // 
            this.buttonShowGrade.Font = new System.Drawing.Font("Arial", 20.25F);
            this.buttonShowGrade.Location = new System.Drawing.Point(396, 488);
            this.buttonShowGrade.Name = "buttonShowGrade";
            this.buttonShowGrade.Size = new System.Drawing.Size(349, 51);
            this.buttonShowGrade.TabIndex = 22;
            this.buttonShowGrade.Text = "Wyświetl oceny";
            this.buttonShowGrade.UseVisualStyleBackColor = true;
            this.buttonShowGrade.Click += new System.EventHandler(this.buttonShowGrade_Click);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 551);
            this.Controls.Add(this.buttonShowGrade);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridStudentList);
            this.Name = "StudentListForm";
            this.Text = "StudentListForm";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox tb_search;
        public System.Windows.Forms.DataGridView dataGridStudentList;
        private System.Windows.Forms.Button buttonShowGrade;
    }
}