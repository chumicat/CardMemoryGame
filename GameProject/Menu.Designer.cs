﻿namespace GameProject
{
    partial class Menu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.b_game5 = new System.Windows.Forms.Button();
            this.b_game6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.l_CardType = new System.Windows.Forms.Label();
            this.r_CardType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.b_game5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.b_game6, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 275);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 267);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // b_game5
            // 
            this.b_game5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_game5.Image = global::GameProject.Properties.Resources.menu01;
            this.b_game5.Location = new System.Drawing.Point(3, 3);
            this.b_game5.Name = "b_game5";
            this.b_game5.Size = new System.Drawing.Size(380, 261);
            this.b_game5.TabIndex = 0;
            this.b_game5.Text = "Memory Matching";
            this.b_game5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_game5.UseVisualStyleBackColor = true;
            this.b_game5.Click += new System.EventHandler(this.b_game5_Click);
            // 
            // b_game6
            // 
            this.b_game6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_game6.ImageKey = "(無)";
            this.b_game6.Location = new System.Drawing.Point(389, 3);
            this.b_game6.Name = "b_game6";
            this.b_game6.Size = new System.Drawing.Size(380, 261);
            this.b_game6.TabIndex = 1;
            this.b_game6.Text = "button2";
            this.b_game6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.03268F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.96732F));
            this.tableLayoutPanel3.Controls.Add(this.l_CardType, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.r_CardType, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.42105F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.57895F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(772, 266);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // l_CardType
            // 
            this.l_CardType.AutoSize = true;
            this.l_CardType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_CardType.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l_CardType.Location = new System.Drawing.Point(3, 0);
            this.l_CardType.Name = "l_CardType";
            this.l_CardType.Size = new System.Drawing.Size(303, 46);
            this.l_CardType.TabIndex = 0;
            this.l_CardType.Text = "Card Type";
            this.l_CardType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l_CardType.Click += new System.EventHandler(this.l_playerNumber_Click);
            // 
            // r_CardType
            // 
            this.r_CardType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_CardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.r_CardType.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.r_CardType.FormattingEnabled = true;
            this.r_CardType.Items.AddRange(new object[] {
            "T00. Color Heaven",
            "T01. Cat and Fish"});
            this.r_CardType.Location = new System.Drawing.Point(312, 3);
            this.r_CardType.Name = "r_CardType";
            this.r_CardType.Size = new System.Drawing.Size(457, 40);
            this.r_CardType.TabIndex = 1;
            this.r_CardType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button b_game5;
        private System.Windows.Forms.Button b_game6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label l_CardType;
        private System.Windows.Forms.ComboBox r_CardType;
    }
}

