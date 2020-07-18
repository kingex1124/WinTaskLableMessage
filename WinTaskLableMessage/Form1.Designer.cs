namespace WinTaskLableMessage
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.btn_ajax = new System.Windows.Forms.Button();
            this.lab_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ajax
            // 
            this.btn_ajax.Location = new System.Drawing.Point(534, 249);
            this.btn_ajax.Name = "btn_ajax";
            this.btn_ajax.Size = new System.Drawing.Size(97, 82);
            this.btn_ajax.TabIndex = 0;
            this.btn_ajax.Text = "AJAX";
            this.btn_ajax.UseVisualStyleBackColor = true;
            this.btn_ajax.Click += new System.EventHandler(this.btn_ajax_Click);
            // 
            // lab_message
            // 
            this.lab_message.AutoSize = true;
            this.lab_message.Font = new System.Drawing.Font("新細明體", 100F);
            this.lab_message.Location = new System.Drawing.Point(65, 84);
            this.lab_message.Name = "lab_message";
            this.lab_message.Size = new System.Drawing.Size(542, 200);
            this.lab_message.TabIndex = 1;
            this.lab_message.Text = "label1";
            this.lab_message.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 354);
            this.Controls.Add(this.lab_message);
            this.Controls.Add(this.btn_ajax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajax;
        private System.Windows.Forms.Label lab_message;
    }
}

