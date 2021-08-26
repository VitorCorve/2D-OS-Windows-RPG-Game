using System;
using System.Windows.Forms;

namespace ProfitCounting
{
    public partial class Form1 : Form
    {
        double price = 0.0;
        double divs = 0.0;
        double course = 0.0;
        double percent = 0.0;
        bool selectRUB = true;
        bool selectUSD = false;
        int years = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public double CalculatePercent(double price, double dividents)
        {
            double percentPerYear = dividents / (price / 100);
            percent = Math.Round(percentPerYear, 3);
            return Math.Round(percentPerYear, 3);
        }

        public void GetValues()
        {
            try
            {
                price = Convert.ToDouble(actionPrice.Text);
                divs = Convert.ToDouble(divValue.Text);
                course = Convert.ToDouble(currentCourse.Text);
                selectUSD = usdSelect.Checked;
                selectRUB = rubSelect.Checked;
                years = Convert.ToInt32(yearsTotalEnter.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректные данные" + ex);
            }
        }

        public void SetValues()
        {
            percentRow.Text = Convert.ToString(CalculatePercent(price, divs) + " %");
            profitTotalValue.Text = CalculateProfit(years, divs, price);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            GetValues();
            SetValues();
        }

        private void FormClick(object sender, MouseEventArgs e)
        {
            GetValues();
            if (price > 0 && divs > 0)
            {
                SetValues();
            }
            GetProfit();
        }

        private void RubSelect_CheckedChanged(object sender, EventArgs e)
        {
            GetValues();
            if (course <= 0 && rubSelect.Checked)
                MessageBox.Show("Введите текущий курс рубля.");

            if (course > 0 && !rubSelect.Checked)
                selectRUB = false;

            if (course > 0 && rubSelect.Checked)
            {
                selectRUB = true;
                ConvertValues();
                actionPriceText.Text = "Цена в RUB";
                dividents.Text = "Дивиденты RUB";
                predictions.Text = "Прогноз по активам в RUB";
            }

        }

        private void USD_Select_CheckedChanged(object sender, EventArgs e)
        {
            GetValues();

            if (course <= 0 && usdSelect.Checked)
                MessageBox.Show("Введите текущий курс рубля.");

            if (course > 0 && !usdSelect.Checked)
                selectUSD = false;

            if (course > 0 && usdSelect.Checked)
            {
                selectUSD = true;
                ConvertValues();
                actionPriceText.Text = "Цена в USD";
                dividents.Text = "Дивиденты USD";
                predictions.Text = "Прогноз по активам в USD";
            }
        }

        private void ConvertValues()
        {
            if (selectUSD == true)
            {
                price /= course;
                divs /= course;
                price = Math.Round(price, 2);
                divs = Math.Round(divs, 2);
                actionPrice.Text = Convert.ToString(price);
                divValue.Text = Convert.ToString(divs);
            }

            if (selectRUB == true)
            {
                price *= course;
                divs *= course;
                price = Math.Round(price, 2);
                divs = Math.Round(divs, 2);
                actionPrice.Text = Convert.ToString(price);
                divValue.Text = Convert.ToString(divs);
            }
        }

        private void GetProfit()
        {
            sixMonthsPred.Text = Convert.ToString(price);
            oneyrProd.Text = Convert.ToString(price+divs);
            threeYearPred.Text = CalculateProfit(3, divs, price);
            fiveYearPred.Text = CalculateProfit(5, divs, price);
            tenYearPred.Text = CalculateProfit(10, divs, price);
            twentYearPred.Text = CalculateProfit(20, divs, price);
            thirdYearPred.Text = CalculateProfit(30, divs, price);
            fifthYearPred.Text = CalculateProfit(50, divs, price);
        }

        private string CalculateProfit(int years, double dividents, double actives)
        {
            for (int i = 0; i < years; i++)
            {
                actives += dividents;
                dividents = actives / 100 * percent;
            }
            return Convert.ToString(Math.Round(actives, 2));
        }
    }
}
