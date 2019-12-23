namespace WindowsFormsApplication1
{
    partial class CalculatorForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Num7 = new System.Windows.Forms.Button();
            this.button_Num8 = new System.Windows.Forms.Button();
            this.button_Num9 = new System.Windows.Forms.Button();
            this.button_Multi = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_Num6 = new System.Windows.Forms.Button();
            this.button_Num5 = new System.Windows.Forms.Button();
            this.button_Num4 = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Num3 = new System.Windows.Forms.Button();
            this.button_Num2 = new System.Windows.Forms.Button();
            this.button_Num1 = new System.Windows.Forms.Button();
            this.button_Result = new System.Windows.Forms.Button();
            this.button_Deciaml = new System.Windows.Forms.Button();
            this.button_Num0 = new System.Windows.Forms.Button();
            this.button_PlusMinus = new System.Windows.Forms.Button();
            this.button_Division = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Num7
            // 
            this.button_Num7.Location = new System.Drawing.Point(12, 165);
            this.button_Num7.Name = "button_Num7";
            this.button_Num7.Size = new System.Drawing.Size(70, 44);
            this.button_Num7.TabIndex = 0;
            this.button_Num7.Text = "7";
            this.button_Num7.UseVisualStyleBackColor = true;
            this.button_Num7.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num8
            // 
            this.button_Num8.Location = new System.Drawing.Point(88, 165);
            this.button_Num8.Name = "button_Num8";
            this.button_Num8.Size = new System.Drawing.Size(70, 44);
            this.button_Num8.TabIndex = 1;
            this.button_Num8.Text = "8";
            this.button_Num8.UseVisualStyleBackColor = true;
            this.button_Num8.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num9
            // 
            this.button_Num9.Location = new System.Drawing.Point(164, 165);
            this.button_Num9.Name = "button_Num9";
            this.button_Num9.Size = new System.Drawing.Size(70, 44);
            this.button_Num9.TabIndex = 2;
            this.button_Num9.Text = "9";
            this.button_Num9.UseVisualStyleBackColor = true;
            this.button_Num9.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Multi
            // 
            this.button_Multi.Location = new System.Drawing.Point(240, 165);
            this.button_Multi.Name = "button_Multi";
            this.button_Multi.Size = new System.Drawing.Size(70, 44);
            this.button_Multi.TabIndex = 3;
            this.button_Multi.Text = "x";
            this.button_Multi.UseVisualStyleBackColor = true;
            this.button_Multi.Click += new System.EventHandler(this.button_Multi_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.Location = new System.Drawing.Point(240, 215);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(70, 44);
            this.button_Minus.TabIndex = 7;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // button_Num6
            // 
            this.button_Num6.Location = new System.Drawing.Point(164, 215);
            this.button_Num6.Name = "button_Num6";
            this.button_Num6.Size = new System.Drawing.Size(70, 44);
            this.button_Num6.TabIndex = 6;
            this.button_Num6.Text = "6";
            this.button_Num6.UseVisualStyleBackColor = true;
            this.button_Num6.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num5
            // 
            this.button_Num5.Location = new System.Drawing.Point(88, 215);
            this.button_Num5.Name = "button_Num5";
            this.button_Num5.Size = new System.Drawing.Size(70, 44);
            this.button_Num5.TabIndex = 5;
            this.button_Num5.Text = "5";
            this.button_Num5.UseVisualStyleBackColor = true;
            this.button_Num5.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num4
            // 
            this.button_Num4.Location = new System.Drawing.Point(12, 215);
            this.button_Num4.Name = "button_Num4";
            this.button_Num4.Size = new System.Drawing.Size(70, 44);
            this.button_Num4.TabIndex = 4;
            this.button_Num4.Text = "4";
            this.button_Num4.UseVisualStyleBackColor = true;
            this.button_Num4.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Plus
            // 
            this.button_Plus.Location = new System.Drawing.Point(240, 265);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(70, 44);
            this.button_Plus.TabIndex = 11;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // button_Num3
            // 
            this.button_Num3.Location = new System.Drawing.Point(164, 265);
            this.button_Num3.Name = "button_Num3";
            this.button_Num3.Size = new System.Drawing.Size(70, 44);
            this.button_Num3.TabIndex = 10;
            this.button_Num3.Text = "3";
            this.button_Num3.UseVisualStyleBackColor = true;
            this.button_Num3.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num2
            // 
            this.button_Num2.Location = new System.Drawing.Point(88, 265);
            this.button_Num2.Name = "button_Num2";
            this.button_Num2.Size = new System.Drawing.Size(70, 44);
            this.button_Num2.TabIndex = 9;
            this.button_Num2.Text = "2";
            this.button_Num2.UseVisualStyleBackColor = true;
            this.button_Num2.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num1
            // 
            this.button_Num1.Location = new System.Drawing.Point(12, 265);
            this.button_Num1.Name = "button_Num1";
            this.button_Num1.Size = new System.Drawing.Size(70, 44);
            this.button_Num1.TabIndex = 8;
            this.button_Num1.Text = "1";
            this.button_Num1.UseVisualStyleBackColor = true;
            this.button_Num1.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Result
            // 
            this.button_Result.Location = new System.Drawing.Point(240, 315);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(70, 44);
            this.button_Result.TabIndex = 15;
            this.button_Result.Text = "=";
            this.button_Result.UseVisualStyleBackColor = true;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // button_Deciaml
            // 
            this.button_Deciaml.Location = new System.Drawing.Point(164, 315);
            this.button_Deciaml.Name = "button_Deciaml";
            this.button_Deciaml.Size = new System.Drawing.Size(70, 44);
            this.button_Deciaml.TabIndex = 14;
            this.button_Deciaml.Text = ".";
            this.button_Deciaml.UseVisualStyleBackColor = true;
            this.button_Deciaml.Click += new System.EventHandler(this.button_Deciaml_Click);
            // 
            // button_Num0
            // 
            this.button_Num0.Location = new System.Drawing.Point(88, 315);
            this.button_Num0.Name = "button_Num0";
            this.button_Num0.Size = new System.Drawing.Size(70, 44);
            this.button_Num0.TabIndex = 13;
            this.button_Num0.Text = "0";
            this.button_Num0.UseVisualStyleBackColor = true;
            this.button_Num0.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_PlusMinus
            // 
            this.button_PlusMinus.Location = new System.Drawing.Point(12, 315);
            this.button_PlusMinus.Name = "button_PlusMinus";
            this.button_PlusMinus.Size = new System.Drawing.Size(70, 44);
            this.button_PlusMinus.TabIndex = 12;
            this.button_PlusMinus.Text = "±";
            this.button_PlusMinus.UseVisualStyleBackColor = true;
            this.button_PlusMinus.Click += new System.EventHandler(this.button_PlusMinus_Click);
            // 
            // button_Division
            // 
            this.button_Division.Location = new System.Drawing.Point(240, 115);
            this.button_Division.Name = "button_Division";
            this.button_Division.Size = new System.Drawing.Size(70, 44);
            this.button_Division.TabIndex = 19;
            this.button_Division.Text = "/";
            this.button_Division.UseVisualStyleBackColor = true;
            this.button_Division.Click += new System.EventHandler(this.button_Division_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(164, 115);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(70, 44);
            this.button_Back.TabIndex = 18;
            this.button_Back.Text = " ←";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(88, 115);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(70, 44);
            this.button_Clear.TabIndex = 17;
            this.button_Clear.Text = "c";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(12, 115);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(70, 44);
            this.button20.TabIndex = 16;
            this.button20.Text = "ce";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Font = new System.Drawing.Font("굴림", 9F);
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 21);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 30F);
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 53);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 373);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_Division);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.button_Deciaml);
            this.Controls.Add(this.button_Num0);
            this.Controls.Add(this.button_PlusMinus);
            this.Controls.Add(this.button_Plus);
            this.Controls.Add(this.button_Num3);
            this.Controls.Add(this.button_Num2);
            this.Controls.Add(this.button_Num1);
            this.Controls.Add(this.button_Minus);
            this.Controls.Add(this.button_Num6);
            this.Controls.Add(this.button_Num5);
            this.Controls.Add(this.button_Num4);
            this.Controls.Add(this.button_Multi);
            this.Controls.Add(this.button_Num9);
            this.Controls.Add(this.button_Num8);
            this.Controls.Add(this.button_Num7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Num7;
        private System.Windows.Forms.Button button_Num8;
        private System.Windows.Forms.Button button_Num9;
        private System.Windows.Forms.Button button_Multi;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_Num6;
        private System.Windows.Forms.Button button_Num5;
        private System.Windows.Forms.Button button_Num4;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Num3;
        private System.Windows.Forms.Button button_Num2;
        private System.Windows.Forms.Button button_Num1;
        private System.Windows.Forms.Button button_Result;
        private System.Windows.Forms.Button button_Deciaml;
        private System.Windows.Forms.Button button_Num0;
        private System.Windows.Forms.Button button_PlusMinus;
        private System.Windows.Forms.Button button_Division;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button20;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;


    }
}

