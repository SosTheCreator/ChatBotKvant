using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Чат_бот_для_определения_выбора_направления_в_Кванториуме
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Vivod = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int i = 1;
        string[] questions = File.ReadAllText("Questions.txt").Split('-');
        string[] answers = File.ReadAllText("Answers.txt").Split('-');
        private void Form1_Load(object sender, EventArgs e)
        {
            
            lQuestion.Text = questions[0];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void bAnswer_Click(object sender, EventArgs e)
        {
            Vivod[0] = int.Parse(tbAnswer.Text);
            tbAnswer.Visible = false;
            bAnswer.Visible = false;
            bYes.Visible = true;
            bNo.Visible = true;
            ltb.Visible = false;
            lQuestion.Text = questions[i];
        }

        private void bYes_Click(object sender, EventArgs e)
        {
            Vivod[i]++;
            i++;
            lQuestion.Text = questions[i];
            if (i == 10) Finish();
        }

        private void bNo_Click(object sender, EventArgs e)
        {
           i++;
           lQuestion.Text = questions[i];
           if (i == 10) Finish();
        }

        private void Finish()
        {
            bYes.Visible = false;
            bNo.Visible = false;
            if (Vivod[0] < 5) 
            { 
                lQuestion.Text = "Вы слишком малы";
                return;
            }
            else if(Vivod[0] > 11) 
            {
                lQuestion.Text = "Вы слишком стары";
                return;
            }
            if (!Vivod.Contains(1))
            {
                lQuestion.Text = "Вам ничего не подошло";
                return;
            }
            lQuestion.Text = "";
            for (int i = 1; i < 10; i++)
            {
                if (Vivod[i] == 1) lQuestion.Text += answers[i - 1] + "\n";
            }
        }


    }
}
