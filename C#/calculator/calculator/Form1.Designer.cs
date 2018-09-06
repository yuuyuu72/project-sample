namespace kadai01
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
            this.inputName1 = new System.Windows.Forms.Label();
            this.inputName2 = new System.Windows.Forms.Label();
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.inputBox2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.divided = new System.Windows.Forms.Button();
            this.cal = new System.Windows.Forms.Label();
            this.resultTitle = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.calResult = new System.Windows.Forms.Label();
            this.calResultTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputName1
            // 
            this.inputName1.AutoSize = true;
            this.inputName1.Location = new System.Drawing.Point(29, 48);
            this.inputName1.Name = "inputName1";
            this.inputName1.Size = new System.Drawing.Size(58, 24);
            this.inputName1.TabIndex = 0;
            this.inputName1.Text = "値1：";
            // 
            // inputName2
            // 
            this.inputName2.AutoSize = true;
            this.inputName2.Location = new System.Drawing.Point(29, 91);
            this.inputName2.Name = "inputName2";
            this.inputName2.Size = new System.Drawing.Size(58, 24);
            this.inputName2.TabIndex = 1;
            this.inputName2.Text = "値2：";
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(93, 48);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(237, 31);
            this.inputBox1.TabIndex = 2;
            // 
            // inputBox2
            // 
            this.inputBox2.Location = new System.Drawing.Point(93, 91);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(237, 31);
            this.inputBox2.TabIndex = 3;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(105, 150);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 50);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(162, 150);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 50);
            this.minus.TabIndex = 5;
            this.minus.Text = "－";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(218, 150);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(50, 50);
            this.times.TabIndex = 6;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // divided
            // 
            this.divided.Location = new System.Drawing.Point(274, 150);
            this.divided.Name = "divided";
            this.divided.Size = new System.Drawing.Size(50, 50);
            this.divided.TabIndex = 7;
            this.divided.Text = "/";
            this.divided.UseVisualStyleBackColor = true;
            this.divided.Click += new System.EventHandler(this.divided_Click);
            // 
            // cal
            // 
            this.cal.AutoSize = true;
            this.cal.Location = new System.Drawing.Point(29, 159);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(70, 24);
            this.cal.TabIndex = 8;
            this.cal.Text = "演算：";
            // 
            // resultTitle
            // 
            this.resultTitle.AutoSize = true;
            this.resultTitle.Location = new System.Drawing.Point(29, 236);
            this.resultTitle.Name = "resultTitle";
            this.resultTitle.Size = new System.Drawing.Size(70, 24);
            this.resultTitle.TabIndex = 9;
            this.resultTitle.Text = "結果：";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(105, 236);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(96, 24);
            this.result.TabIndex = 10;
            this.result.Text = "[ result ]";
            // 
            // calResult
            // 
            this.calResult.AutoSize = true;
            this.calResult.Location = new System.Drawing.Point(129, 288);
            this.calResult.Name = "calResult";
            this.calResult.Size = new System.Drawing.Size(131, 24);
            this.calResult.TabIndex = 11;
            this.calResult.Text = "[ calResult ]";
            // 
            // calResultTitle
            // 
            this.calResultTitle.AutoSize = true;
            this.calResultTitle.Location = new System.Drawing.Point(29, 288);
            this.calResultTitle.Name = "calResultTitle";
            this.calResultTitle.Size = new System.Drawing.Size(94, 24);
            this.calResultTitle.TabIndex = 12;
            this.calResultTitle.Text = "計算式：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 343);
            this.Controls.Add(this.calResultTitle);
            this.Controls.Add(this.calResult);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultTitle);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.divided);
            this.Controls.Add(this.times);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.inputName2);
            this.Controls.Add(this.inputName1);
            this.Name = "Form1";
            this.Text = "課題01 電卓";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputName1;
        private System.Windows.Forms.Label inputName2;
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button divided;
        private System.Windows.Forms.Label cal;
        private System.Windows.Forms.Label resultTitle;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label calResult;
        private System.Windows.Forms.Label calResultTitle;
    }
}

