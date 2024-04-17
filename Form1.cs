using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Експертна_Система
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int scores = 0;
            if (checkBox1.Checked) scores = scores + 1;
            if (checkBox2.Checked) scores = scores + 1;
            if (checkBox3.Checked) scores = scores + 1;
            if (checkBox4.Checked) scores = scores + 1;
            if (checkBox5.Checked) scores = scores + 1;
            if (checkBox6.Checked) scores = scores + 1;
            if (checkBox7.Checked) scores = scores + 1;
            if (checkBox8.Checked) scores = scores + 1;
            if (checkBox9.Checked) scores = scores + 1;
            if (checkBox10.Checked) scores = scores + 1;

            label12.Text = "Кількість набраних балів: " + scores.ToString();
            if (scores >= 0 && scores <= 3) label11.Text = "Ваш низький рівень фінансової грамотності та нестабільний фінансовий стан вимагають уваги до деталей у фінансовому плануванні. Рекомендується активно займатися вивченням фінансових аспектів, розглянути можливість отримання консультацій з фінансових питань та розробити план виходу на стабільний фінансовий шлях.";
            if (scores >= 4 && scores <= 8) label11.Text = "Ваш середній рівень фінансової грамотності та чітко сформульовані фінансові цілі є підґрунтям для подальшого удосконалення управління фінансами. Рекомендується зосередитися на розвитку фінансової грамотності, систематично перевіряти та оновлювати фінансові плани, а також розглянути можливості для додаткового інвестування.";
            if (scores >= 9 && scores <= 10) label11.Text = "Ваш високий рівень фінансової грамотності та стабільний фінансовий стан дають змогу ефективно управляти своїми фінансами. Рекомендується продовжувати дотримуватися дисциплінованого фінансового плану, регулярно переглядати інвестиційні стратегії та шукати можливості для росту та оптимізації фінансових активів.";

        }
    }
}
