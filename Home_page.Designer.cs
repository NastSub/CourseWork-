
namespace students
{
    partial class Home_page
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_page));
            this.label1 = new System.Windows.Forms.Label();
            this.studentsTable = new System.Windows.Forms.DataGridView();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.sortAscendButton = new System.Windows.Forms.Button();
            this.sortDescendButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Magneto", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(391, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о студентах";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // studentsTable
            // 
            this.studentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(224)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentsTable.Location = new System.Drawing.Point(45, 105);
            this.studentsTable.Margin = new System.Windows.Forms.Padding(4);
            this.studentsTable.Name = "studentsTable";
            this.studentsTable.RowHeadersWidth = 51;
            this.studentsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsTable.Size = new System.Drawing.Size(968, 506);
            this.studentsTable.TabIndex = 1;
            this.studentsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsTable_CellContentClick);
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.addStudentButton.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.Location = new System.Drawing.Point(1048, 105);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(366, 73);
            this.addStudentButton.TabIndex = 2;
            this.addStudentButton.Text = "Добавить студента";
            this.addStudentButton.UseVisualStyleBackColor = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.deleteStudentButton.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStudentButton.Location = new System.Drawing.Point(1048, 214);
            this.deleteStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(366, 69);
            this.deleteStudentButton.TabIndex = 3;
            this.deleteStudentButton.Text = "Удалить студента";
            this.deleteStudentButton.UseVisualStyleBackColor = false;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // sortAscendButton
            // 
            this.sortAscendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sortAscendButton.Font = new System.Drawing.Font("Gill Sans MT", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortAscendButton.Location = new System.Drawing.Point(1048, 471);
            this.sortAscendButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortAscendButton.Name = "sortAscendButton";
            this.sortAscendButton.Size = new System.Drawing.Size(179, 67);
            this.sortAscendButton.TabIndex = 6;
            this.sortAscendButton.Text = "По фамилии ↑";
            this.sortAscendButton.UseVisualStyleBackColor = false;
            this.sortAscendButton.Click += new System.EventHandler(this.sortAscendButton_Click);
            // 
            // sortDescendButton
            // 
            this.sortDescendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sortDescendButton.Font = new System.Drawing.Font("Gill Sans MT", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortDescendButton.Location = new System.Drawing.Point(1235, 471);
            this.sortDescendButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortDescendButton.Name = "sortDescendButton";
            this.sortDescendButton.Size = new System.Drawing.Size(179, 67);
            this.sortDescendButton.TabIndex = 7;
            this.sortDescendButton.Text = "По фамилии ↓";
            this.sortDescendButton.UseVisualStyleBackColor = false;
            this.sortDescendButton.Click += new System.EventHandler(this.sortDescendButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1048, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Поиск студента";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Gill Sans MT", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1235, 546);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 65);
            this.button3.TabIndex = 12;
            this.button3.Text = "По рейтингу↓";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1048, 544);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 67);
            this.button2.TabIndex = 11;
            this.button2.Text = "По рейтингу ↑";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1165, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сортировка:";
            // 
            // Home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::students.Properties.Resources._1579562240_32_p_nezh;
            this.ClientSize = new System.Drawing.Size(1464, 668);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortDescendButton);
            this.Controls.Add(this.sortAscendButton);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.studentsTable);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home_page";
            this.Text = "Информация о студентах";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView studentsTable;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button sortAscendButton;
        private System.Windows.Forms.Button sortDescendButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}