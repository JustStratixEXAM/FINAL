﻿namespace WindowsFormsApp1
{
    partial class Administrator
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
            this.button_sign_up = new System.Windows.Forms.Button();
            this.button_Tov_List = new System.Windows.Forms.Button();
            this.button_His = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_sign_up
            // 
            this.button_sign_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_sign_up.Location = new System.Drawing.Point(51, 116);
            this.button_sign_up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_sign_up.Name = "button_sign_up";
            this.button_sign_up.Size = new System.Drawing.Size(171, 50);
            this.button_sign_up.TabIndex = 0;
            this.button_sign_up.Text = "Список пользователей";
            this.button_sign_up.UseVisualStyleBackColor = false;
            this.button_sign_up.Click += new System.EventHandler(this.button_sign_up_Click);
            // 
            // button_Tov_List
            // 
            this.button_Tov_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_Tov_List.Location = new System.Drawing.Point(51, 174);
            this.button_Tov_List.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Tov_List.Name = "button_Tov_List";
            this.button_Tov_List.Size = new System.Drawing.Size(171, 47);
            this.button_Tov_List.TabIndex = 1;
            this.button_Tov_List.Text = "Посмотреть список товаров\r\n\r\n";
            this.button_Tov_List.UseVisualStyleBackColor = false;
            this.button_Tov_List.Click += new System.EventHandler(this.button_Tov_List_Click);
            // 
            // button_His
            // 
            this.button_His.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_His.Location = new System.Drawing.Point(51, 58);
            this.button_His.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_His.Name = "button_His";
            this.button_His.Size = new System.Drawing.Size(171, 50);
            this.button_His.TabIndex = 2;
            this.button_His.Text = "Просмотреть истоию входа";
            this.button_His.UseVisualStyleBackColor = false;
            this.button_His.Click += new System.EventHandler(this.button_His_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "lalble";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.фон1;
            this.ClientSize = new System.Drawing.Size(289, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_His);
            this.Controls.Add(this.button_Tov_List);
            this.Controls.Add(this.button_sign_up);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sign_up;
        private System.Windows.Forms.Button button_Tov_List;
        private System.Windows.Forms.Button button_His;
        private System.Windows.Forms.Label label1;
    }
}