
namespace YoketoruVS21
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Title_label = new System.Windows.Forms.Label();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Copyright_label = new System.Windows.Forms.Label();
            this.Tim_elabel = new System.Windows.Forms.Label();
            this.Itme_label = new System.Windows.Forms.Label();
            this.HighScore_label = new System.Windows.Forms.Label();
            this.GameOver_label = new System.Windows.Forms.Label();
            this.Clear_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ToTitle_button = new System.Windows.Forms.Button();
            this.temp_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Title_label.Location = new System.Drawing.Point(267, 120);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(258, 48);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "よけとる2021";
            // 
            // Startbutton
            // 
            this.Startbutton.BackColor = System.Drawing.Color.Gray;
            this.Startbutton.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Startbutton.ForeColor = System.Drawing.Color.Red;
            this.Startbutton.Location = new System.Drawing.Point(275, 249);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(250, 115);
            this.Startbutton.TabIndex = 1;
            this.Startbutton.Text = "スタート!!";
            this.Startbutton.UseVisualStyleBackColor = false;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Copyright_label
            // 
            this.Copyright_label.AutoSize = true;
            this.Copyright_label.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Copyright_label.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Copyright_label.Location = new System.Drawing.Point(281, 404);
            this.Copyright_label.Name = "Copyright_label";
            this.Copyright_label.Size = new System.Drawing.Size(239, 24);
            this.Copyright_label.TabIndex = 2;
            this.Copyright_label.Text = "Copyright© 2021 choto";
            // 
            // Tim_elabel
            // 
            this.Tim_elabel.AutoSize = true;
            this.Tim_elabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tim_elabel.Location = new System.Drawing.Point(13, 13);
            this.Tim_elabel.Name = "Tim_elabel";
            this.Tim_elabel.Size = new System.Drawing.Size(110, 24);
            this.Tim_elabel.TabIndex = 3;
            this.Tim_elabel.Text = "Time 100";
            // 
            // Itme_label
            // 
            this.Itme_label.AutoSize = true;
            this.Itme_label.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Itme_label.Location = new System.Drawing.Point(725, 9);
            this.Itme_label.Name = "Itme_label";
            this.Itme_label.Size = new System.Drawing.Size(67, 24);
            this.Itme_label.TabIndex = 4;
            this.Itme_label.Text = "★:10";
            // 
            // HighScore_label
            // 
            this.HighScore_label.AutoSize = true;
            this.HighScore_label.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HighScore_label.Location = new System.Drawing.Point(289, 190);
            this.HighScore_label.Name = "HighScore_label";
            this.HighScore_label.Size = new System.Drawing.Size(223, 33);
            this.HighScore_label.TabIndex = 5;
            this.HighScore_label.Text = "HighScore 100";
            // 
            // GameOver_label
            // 
            this.GameOver_label.AutoSize = true;
            this.GameOver_label.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GameOver_label.ForeColor = System.Drawing.Color.Maroon;
            this.GameOver_label.Location = new System.Drawing.Point(254, 120);
            this.GameOver_label.Name = "GameOver_label";
            this.GameOver_label.Size = new System.Drawing.Size(293, 48);
            this.GameOver_label.TabIndex = 6;
            this.GameOver_label.Text = "ゲームオーバー";
            this.GameOver_label.Visible = false;
            // 
            // Clear_label
            // 
            this.Clear_label.AutoSize = true;
            this.Clear_label.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Clear_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Clear_label.Location = new System.Drawing.Point(318, 120);
            this.Clear_label.Name = "Clear_label";
            this.Clear_label.Size = new System.Drawing.Size(165, 48);
            this.Clear_label.TabIndex = 7;
            this.Clear_label.Text = "クリア！";
            this.Clear_label.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ToTitle_button
            // 
            this.ToTitle_button.BackColor = System.Drawing.Color.Gray;
            this.ToTitle_button.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ToTitle_button.ForeColor = System.Drawing.Color.Blue;
            this.ToTitle_button.Location = new System.Drawing.Point(275, 249);
            this.ToTitle_button.Name = "ToTitle_button";
            this.ToTitle_button.Size = new System.Drawing.Size(250, 115);
            this.ToTitle_button.TabIndex = 8;
            this.ToTitle_button.Text = "タイトルへ";
            this.ToTitle_button.UseVisualStyleBackColor = false;
            this.ToTitle_button.Click += new System.EventHandler(this.ToTitle_button_Click);
            // 
            // temp_label
            // 
            this.temp_label.AutoSize = true;
            this.temp_label.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.temp_label.Location = new System.Drawing.Point(13, 76);
            this.temp_label.Name = "temp_label";
            this.temp_label.Size = new System.Drawing.Size(47, 33);
            this.temp_label.TabIndex = 9;
            this.temp_label.Text = "★";
            this.temp_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temp_label);
            this.Controls.Add(this.ToTitle_button);
            this.Controls.Add(this.Clear_label);
            this.Controls.Add(this.GameOver_label);
            this.Controls.Add(this.HighScore_label);
            this.Controls.Add(this.Itme_label);
            this.Controls.Add(this.Tim_elabel);
            this.Controls.Add(this.Copyright_label);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.Title_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Label Copyright_label;
        private System.Windows.Forms.Label Tim_elabel;
        private System.Windows.Forms.Label Itme_label;
        private System.Windows.Forms.Label HighScore_label;
        private System.Windows.Forms.Label GameOver_label;
        private System.Windows.Forms.Label Clear_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ToTitle_button;
        private System.Windows.Forms.Label temp_label;
    }
}

