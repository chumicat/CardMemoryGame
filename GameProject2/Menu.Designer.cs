namespace GameProject2
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
            this.b_Game6 = new System.Windows.Forms.Button();
            this.l_Rule = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.l_SelectType = new System.Windows.Forms.Label();
            this.r_SelectType = new System.Windows.Forms.ComboBox();
            this.l_Level = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.tableLayoutPanel2.Controls.Add(this.b_Game6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.l_Rule, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 275);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 267);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // b_Game6
            // 
            this.b_Game6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_Game6.Image = global::GameProject2.Properties.Resources.menu02;
            this.b_Game6.Location = new System.Drawing.Point(3, 3);
            this.b_Game6.Name = "b_Game6";
            this.b_Game6.Size = new System.Drawing.Size(380, 261);
            this.b_Game6.TabIndex = 0;
            this.b_Game6.Text = "Happy Farmer";
            this.b_Game6.UseVisualStyleBackColor = true;
            this.b_Game6.Click += new System.EventHandler(this.b_Game6_Click);
            // 
            // l_Rule
            // 
            this.l_Rule.AutoSize = true;
            this.l_Rule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Rule.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l_Rule.Location = new System.Drawing.Point(389, 0);
            this.l_Rule.Name = "l_Rule";
            this.l_Rule.Size = new System.Drawing.Size(380, 267);
            this.l_Rule.TabIndex = 1;
            this.l_Rule.Text = "Rule";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.tableLayoutPanel3.Controls.Add(this.l_SelectType, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.r_SelectType, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.l_Level, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(772, 266);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // l_SelectType
            // 
            this.l_SelectType.AutoSize = true;
            this.l_SelectType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_SelectType.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l_SelectType.Location = new System.Drawing.Point(3, 50);
            this.l_SelectType.Name = "l_SelectType";
            this.l_SelectType.Size = new System.Drawing.Size(202, 50);
            this.l_SelectType.TabIndex = 0;
            this.l_SelectType.Text = "Select Type";
            this.l_SelectType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r_SelectType
            // 
            this.r_SelectType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_SelectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.r_SelectType.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.r_SelectType.FormattingEnabled = true;
            this.r_SelectType.Items.AddRange(new object[] {
            "Mouse Down",
            "Mouse Move"});
            this.r_SelectType.Location = new System.Drawing.Point(211, 53);
            this.r_SelectType.Name = "r_SelectType";
            this.r_SelectType.Size = new System.Drawing.Size(558, 40);
            this.r_SelectType.TabIndex = 1;
            // 
            // l_Level
            // 
            this.l_Level.AutoSize = true;
            this.l_Level.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Level.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l_Level.Location = new System.Drawing.Point(3, 0);
            this.l_Level.Name = "l_Level";
            this.l_Level.Size = new System.Drawing.Size(202, 50);
            this.l_Level.TabIndex = 2;
            this.l_Level.Text = "Level";
            this.l_Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Die!!!"});
            this.comboBox1.Location = new System.Drawing.Point(211, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(558, 40);
            this.comboBox1.TabIndex = 3;
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
            this.Text = "Happy Farmer - Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button b_Game6;
        private System.Windows.Forms.Label l_Rule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label l_SelectType;
        private System.Windows.Forms.ComboBox r_SelectType;
        private System.Windows.Forms.Label l_Level;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

