namespace WindowsFormsApp1
{
    partial class Workers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Role = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(516, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(540, 177);
            this.button_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(89, 79);
            this.button_Update.TabIndex = 14;
            this.button_Update.Text = "Обновить таблицу";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 436);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(208, 436);
            this.textBox_pwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(132, 22);
            this.textBox_pwd.TabIndex = 18;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(208, 404);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(132, 22);
            this.textBox_login.TabIndex = 17;
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Location = new System.Drawing.Point(208, 372);
            this.textBox_FIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(132, 22);
            this.textBox_FIO.TabIndex = 16;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(208, 340);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(132, 22);
            this.textBox_ID.TabIndex = 15;
            // 
            // textBox_Role
            // 
            this.textBox_Role.Location = new System.Drawing.Point(208, 468);
            this.textBox_Role.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Role.Name = "textBox_Role";
            this.textBox_Role.Size = new System.Drawing.Size(132, 22);
            this.textBox_Role.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 468);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Роль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 500);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Телефон";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(208, 500);
            this.textBox_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(132, 22);
            this.textBox_phone.TabIndex = 26;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(380, 459);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(152, 47);
            this.button_Save.TabIndex = 30;
            this.button_Save.Text = "Сохранить запись";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(380, 405);
            this.button_Change.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(152, 47);
            this.button_Change.TabIndex = 29;
            this.button_Change.Text = "Изменить запись";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(380, 351);
            this.button_Del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(152, 47);
            this.button_Del.TabIndex = 28;
            this.button_Del.Text = "Удалить запись";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(380, 297);
            this.button_New.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(152, 47);
            this.button_New.TabIndex = 27;
            this.button_New.Text = "Новая запись";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Найти";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(607, 15);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(132, 22);
            this.textBox_Search.TabIndex = 31;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.фон;
            this.ClientSize = new System.Drawing.Size(779, 551);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Role);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_FIO);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Workers";
            this.Text = "Workers";
            this.Load += new System.EventHandler(this.Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Search;
    }
}