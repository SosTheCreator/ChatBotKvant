
namespace Чат_бот_для_определения_выбора_направления_в_Кванториуме
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.ltb = new System.Windows.Forms.Label();
            this.lQuestion = new System.Windows.Forms.Label();
            this.bNo = new System.Windows.Forms.Button();
            this.bYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAnswer
            // 
            this.bAnswer.Location = new System.Drawing.Point(345, 386);
            this.bAnswer.Name = "bAnswer";
            this.bAnswer.Size = new System.Drawing.Size(75, 23);
            this.bAnswer.TabIndex = 0;
            this.bAnswer.Text = "Ответить";
            this.bAnswer.UseVisualStyleBackColor = true;
            this.bAnswer.Click += new System.EventHandler(this.bAnswer_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "ChatBot";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(303, 285);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(104, 20);
            this.tbAnswer.TabIndex = 2;
            this.tbAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ltb
            // 
            this.ltb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltb.Location = new System.Drawing.Point(162, 285);
            this.ltb.Name = "ltb";
            this.ltb.Size = new System.Drawing.Size(135, 20);
            this.ltb.TabIndex = 3;
            this.ltb.Text = "Введите ответ :";
            // 
            // lQuestion
            // 
            this.lQuestion.Location = new System.Drawing.Point(142, 50);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(550, 223);
            this.lQuestion.TabIndex = 4;
            this.lQuestion.Text = "label3";
            this.lQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lQuestion.Click += new System.EventHandler(this.label3_Click);
            // 
            // bNo
            // 
            this.bNo.Location = new System.Drawing.Point(500, 328);
            this.bNo.Name = "bNo";
            this.bNo.Size = new System.Drawing.Size(75, 23);
            this.bNo.TabIndex = 5;
            this.bNo.Text = "Нет";
            this.bNo.UseVisualStyleBackColor = true;
            this.bNo.Visible = false;
            this.bNo.Click += new System.EventHandler(this.bNo_Click);
            // 
            // bYes
            // 
            this.bYes.Location = new System.Drawing.Point(187, 328);
            this.bYes.Name = "bYes";
            this.bYes.Size = new System.Drawing.Size(75, 23);
            this.bYes.TabIndex = 6;
            this.bYes.Text = "Да";
            this.bYes.UseVisualStyleBackColor = true;
            this.bYes.Visible = false;
            this.bYes.Click += new System.EventHandler(this.bYes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bYes);
            this.Controls.Add(this.bNo);
            this.Controls.Add(this.lQuestion);
            this.Controls.Add(this.ltb);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label ltb;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Button bNo;
        private System.Windows.Forms.Button bYes;
    }
}

