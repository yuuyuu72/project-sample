namespace Kadai03_NoughtsCrosses
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.turn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(29, 41);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(176, 149);
            this.btn11.TabIndex = 0;
            this.btn11.Text = "[ button1-1 ]";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(232, 41);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(175, 149);
            this.btn12.TabIndex = 1;
            this.btn12.Text = "[ button1-2 ]";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn13
            // 
            this.btn13.Location = new System.Drawing.Point(427, 41);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(179, 149);
            this.btn13.TabIndex = 2;
            this.btn13.Text = "[button1-3 ]";
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(29, 206);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(176, 156);
            this.btn21.TabIndex = 3;
            this.btn21.Text = "[ button2-1 ]";
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(232, 206);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(175, 156);
            this.btn22.TabIndex = 4;
            this.btn22.Text = "[ button2-2 ]";
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn23
            // 
            this.btn23.Location = new System.Drawing.Point(427, 206);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(179, 156);
            this.btn23.TabIndex = 5;
            this.btn23.Text = "[ button2-3 ]";
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn31
            // 
            this.btn31.Location = new System.Drawing.Point(29, 383);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(176, 157);
            this.btn31.TabIndex = 6;
            this.btn31.Text = "[ button3-1 ]";
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn32
            // 
            this.btn32.Location = new System.Drawing.Point(232, 383);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(175, 157);
            this.btn32.TabIndex = 7;
            this.btn32.Text = "[ button3-2 ]";
            this.btn32.UseVisualStyleBackColor = true;
            this.btn32.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn33
            // 
            this.btn33.Location = new System.Drawing.Point(427, 383);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(179, 157);
            this.btn33.TabIndex = 8;
            this.btn33.Text = "[ button3-3 ]";
            this.btn33.UseVisualStyleBackColor = true;
            this.btn33.Click += new System.EventHandler(this.btn_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(29, 559);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(577, 103);
            this.clear.TabIndex = 9;
            this.clear.Text = "クリア";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "ターン：";
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Location = new System.Drawing.Point(108, 665);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(80, 24);
            this.turn.TabIndex = 11;
            this.turn.Text = "[ turn ]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(641, 698);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "課題03 ○×ゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label turn;
    }
}

