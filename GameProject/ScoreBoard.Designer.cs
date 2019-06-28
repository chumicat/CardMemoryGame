namespace GameProject
{
    partial class ScoreBoard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.l_Scores = new System.Windows.Forms.Label();
            this.r_Scores = new System.Windows.Forms.Label();
            this.l_Time = new System.Windows.Forms.Label();
            this.r_Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 245);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 178);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(272, 64);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(139, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.l_Scores, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.r_Scores, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.l_Time, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.r_Time, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(272, 169);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // l_Scores
            // 
            this.l_Scores.AutoSize = true;
            this.l_Scores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Scores.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l_Scores.Location = new System.Drawing.Point(3, 0);
            this.l_Scores.Name = "l_Scores";
            this.l_Scores.Size = new System.Drawing.Size(130, 56);
            this.l_Scores.TabIndex = 0;
            this.l_Scores.Text = "Scores";
            // 
            // r_Scores
            // 
            this.r_Scores.AutoSize = true;
            this.r_Scores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_Scores.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.r_Scores.Location = new System.Drawing.Point(139, 0);
            this.r_Scores.Name = "r_Scores";
            this.r_Scores.Size = new System.Drawing.Size(130, 56);
            this.r_Scores.TabIndex = 1;
            // 
            // l_Time
            // 
            this.l_Time.AutoSize = true;
            this.l_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Time.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l_Time.Location = new System.Drawing.Point(3, 56);
            this.l_Time.Name = "l_Time";
            this.l_Time.Size = new System.Drawing.Size(130, 56);
            this.l_Time.TabIndex = 2;
            this.l_Time.Text = "Time";
            // 
            // r_Time
            // 
            this.r_Time.AutoSize = true;
            this.r_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_Time.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.r_Time.Location = new System.Drawing.Point(139, 56);
            this.r_Time.Name = "r_Time";
            this.r_Time.Size = new System.Drawing.Size(130, 56);
            this.r_Time.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 245);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ScoreBoard";
            this.Text = "ScoreBoard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label l_Scores;
        private System.Windows.Forms.Label r_Scores;
        private System.Windows.Forms.Label l_Time;
        private System.Windows.Forms.Label r_Time;
        private System.Windows.Forms.Label label1;
    }
}