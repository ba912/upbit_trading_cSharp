namespace wsHoldings
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_1sce = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rsiBuy = new System.Windows.Forms.TextBox();
            this.txt_rsiSell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lossCut = new System.Windows.Forms.TextBox();
            this.txt_unitPrice = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lu_coin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer_10min = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer_1sce
            // 
            this.timer_1sce.Interval = 1000;
            this.timer_1sce.Tick += new System.EventHandler(this.timer_1sce_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSI 매수 기준 (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "RSI 매도 기준 (%)";
            // 
            // txt_rsiBuy
            // 
            this.txt_rsiBuy.Location = new System.Drawing.Point(517, 19);
            this.txt_rsiBuy.Name = "txt_rsiBuy";
            this.txt_rsiBuy.Size = new System.Drawing.Size(100, 21);
            this.txt_rsiBuy.TabIndex = 2;
            // 
            // txt_rsiSell
            // 
            this.txt_rsiSell.Location = new System.Drawing.Point(517, 52);
            this.txt_rsiSell.Name = "txt_rsiSell";
            this.txt_rsiSell.Size = new System.Drawing.Size(100, 21);
            this.txt_rsiSell.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "손절률 (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "개당 매수 금액";
            // 
            // txt_lossCut
            // 
            this.txt_lossCut.Location = new System.Drawing.Point(728, 19);
            this.txt_lossCut.Name = "txt_lossCut";
            this.txt_lossCut.Size = new System.Drawing.Size(100, 21);
            this.txt_lossCut.TabIndex = 6;
            // 
            // txt_unitPrice
            // 
            this.txt_unitPrice.Location = new System.Drawing.Point(728, 52);
            this.txt_unitPrice.Name = "txt_unitPrice";
            this.txt_unitPrice.Size = new System.Drawing.Size(100, 21);
            this.txt_unitPrice.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(845, 19);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 51);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "저장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lu_coin
            // 
            this.lu_coin.FormattingEnabled = true;
            this.lu_coin.Location = new System.Drawing.Point(61, 35);
            this.lu_coin.Name = "lu_coin";
            this.lu_coin.Size = new System.Drawing.Size(121, 20);
            this.lu_coin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "코인";
            // 
            // timer_10min
            // 
            this.timer_10min.Tick += new System.EventHandler(this.timer_10min_Tick);
            // 
            // button1
            // 
            this.button1.Image = global::wsHoldings.Properties.Resources.siren_32;
            this.button1.Location = new System.Drawing.Point(960, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lu_coin);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_unitPrice);
            this.Controls.Add(this.txt_lossCut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_rsiSell);
            this.Controls.Add(this.txt_rsiBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_1sce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rsiBuy;
        private System.Windows.Forms.TextBox txt_rsiSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lossCut;
        private System.Windows.Forms.TextBox txt_unitPrice;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox lu_coin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer_10min;
        private System.Windows.Forms.Button button1;
    }
}

