
namespace ProfitCounting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.actionPrice = new System.Windows.Forms.TextBox();
            this.divValue = new System.Windows.Forms.TextBox();
            this.actionPriceText = new System.Windows.Forms.Label();
            this.dividents = new System.Windows.Forms.Label();
            this.percentPerYear = new System.Windows.Forms.Label();
            this.inputData = new System.Windows.Forms.Label();
            this.predictions = new System.Windows.Forms.Label();
            this.threeYearPred = new System.Windows.Forms.Label();
            this.threeYearPredText = new System.Windows.Forms.Label();
            this.fiveYearPredText = new System.Windows.Forms.Label();
            this.tenYearPredText = new System.Windows.Forms.Label();
            this.twentYearProdText = new System.Windows.Forms.Label();
            this.percentRow = new System.Windows.Forms.Label();
            this.thirdYearPredText = new System.Windows.Forms.Label();
            this.fiftYearPredText = new System.Windows.Forms.Label();
            this.fiveYearPred = new System.Windows.Forms.Label();
            this.tenYearPred = new System.Windows.Forms.Label();
            this.twentYearPred = new System.Windows.Forms.Label();
            this.thirdYearPred = new System.Windows.Forms.Label();
            this.fifthYearPred = new System.Windows.Forms.Label();
            this.oneyrProd = new System.Windows.Forms.Label();
            this.oneYearPred = new System.Windows.Forms.Label();
            this.sixMonthsPred = new System.Windows.Forms.Label();
            this.sixMonthsPredText = new System.Windows.Forms.Label();
            this.rubSelect = new System.Windows.Forms.RadioButton();
            this.usdSelect = new System.Windows.Forms.RadioButton();
            this.currentCourse = new System.Windows.Forms.TextBox();
            this.currentCourseText = new System.Windows.Forms.Label();
            this.yearsTotalEnter = new System.Windows.Forms.TextBox();
            this.profitTotalValue = new System.Windows.Forms.Label();
            this.yearsTotalText = new System.Windows.Forms.Label();
            this.profitTotalText = new System.Windows.Forms.Label();
            this.calculateBotton = new System.Windows.Forms.Button();
            this.advancedInvest = new System.Windows.Forms.CheckBox();
            this.advInvestValueLabel = new System.Windows.Forms.Label();
            this.AdvInvestMonth = new System.Windows.Forms.TextBox();
            this.callcExplainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // actionPrice
            // 
            this.actionPrice.Location = new System.Drawing.Point(12, 38);
            this.actionPrice.Name = "actionPrice";
            this.actionPrice.Size = new System.Drawing.Size(155, 23);
            this.actionPrice.TabIndex = 0;
            this.actionPrice.Text = "00,00";
            this.actionPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // divValue
            // 
            this.divValue.Location = new System.Drawing.Point(12, 60);
            this.divValue.Name = "divValue";
            this.divValue.Size = new System.Drawing.Size(155, 23);
            this.divValue.TabIndex = 1;
            this.divValue.Text = "00,00";
            this.divValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // actionPriceText
            // 
            this.actionPriceText.AutoSize = true;
            this.actionPriceText.Location = new System.Drawing.Point(173, 44);
            this.actionPriceText.Name = "actionPriceText";
            this.actionPriceText.Size = new System.Drawing.Size(69, 15);
            this.actionPriceText.TabIndex = 2;
            this.actionPriceText.Text = "Цена в RUB";
            // 
            // dividents
            // 
            this.dividents.AutoSize = true;
            this.dividents.Location = new System.Drawing.Point(173, 64);
            this.dividents.Name = "dividents";
            this.dividents.Size = new System.Drawing.Size(93, 15);
            this.dividents.TabIndex = 3;
            this.dividents.Text = "Дивиденты RUB";
            // 
            // percentPerYear
            // 
            this.percentPerYear.AutoSize = true;
            this.percentPerYear.Location = new System.Drawing.Point(134, 120);
            this.percentPerYear.Name = "percentPerYear";
            this.percentPerYear.Size = new System.Drawing.Size(34, 15);
            this.percentPerYear.TabIndex = 4;
            this.percentPerYear.Text = "в год";
            // 
            // inputData
            // 
            this.inputData.AutoSize = true;
            this.inputData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputData.Location = new System.Drawing.Point(67, 13);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(52, 15);
            this.inputData.TabIndex = 6;
            this.inputData.Text = "Активы";
            // 
            // predictions
            // 
            this.predictions.AutoSize = true;
            this.predictions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.predictions.Location = new System.Drawing.Point(12, 146);
            this.predictions.Name = "predictions";
            this.predictions.Size = new System.Drawing.Size(161, 15);
            this.predictions.TabIndex = 7;
            this.predictions.Text = "Прогноз по активам в RUB";
            // 
            // threeYearPred
            // 
            this.threeYearPred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threeYearPred.Location = new System.Drawing.Point(12, 216);
            this.threeYearPred.Name = "threeYearPred";
            this.threeYearPred.Size = new System.Drawing.Size(155, 23);
            this.threeYearPred.TabIndex = 8;
            this.threeYearPred.Text = "00,00";
            this.threeYearPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threeYearPredText
            // 
            this.threeYearPredText.AutoSize = true;
            this.threeYearPredText.Location = new System.Drawing.Point(173, 220);
            this.threeYearPredText.Name = "threeYearPredText";
            this.threeYearPredText.Size = new System.Drawing.Size(40, 15);
            this.threeYearPredText.TabIndex = 9;
            this.threeYearPredText.Text = "3 года";
            // 
            // fiveYearPredText
            // 
            this.fiveYearPredText.AutoSize = true;
            this.fiveYearPredText.Location = new System.Drawing.Point(173, 241);
            this.fiveYearPredText.Name = "fiveYearPredText";
            this.fiveYearPredText.Size = new System.Drawing.Size(34, 15);
            this.fiveYearPredText.TabIndex = 11;
            this.fiveYearPredText.Text = "5 лет";
            // 
            // tenYearPredText
            // 
            this.tenYearPredText.AutoSize = true;
            this.tenYearPredText.Location = new System.Drawing.Point(173, 264);
            this.tenYearPredText.Name = "tenYearPredText";
            this.tenYearPredText.Size = new System.Drawing.Size(40, 15);
            this.tenYearPredText.TabIndex = 13;
            this.tenYearPredText.Text = "10 лет";
            // 
            // twentYearProdText
            // 
            this.twentYearProdText.AutoSize = true;
            this.twentYearProdText.Location = new System.Drawing.Point(173, 286);
            this.twentYearProdText.Name = "twentYearProdText";
            this.twentYearProdText.Size = new System.Drawing.Size(40, 15);
            this.twentYearProdText.TabIndex = 15;
            this.twentYearProdText.Text = "20 лет";
            // 
            // percentRow
            // 
            this.percentRow.BackColor = System.Drawing.SystemColors.HighlightText;
            this.percentRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentRow.Location = new System.Drawing.Point(51, 117);
            this.percentRow.Name = "percentRow";
            this.percentRow.Size = new System.Drawing.Size(77, 20);
            this.percentRow.TabIndex = 17;
            this.percentRow.Text = "00,00 %";
            this.percentRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdYearPredText
            // 
            this.thirdYearPredText.AutoSize = true;
            this.thirdYearPredText.Location = new System.Drawing.Point(173, 308);
            this.thirdYearPredText.Name = "thirdYearPredText";
            this.thirdYearPredText.Size = new System.Drawing.Size(40, 15);
            this.thirdYearPredText.TabIndex = 18;
            this.thirdYearPredText.Text = "30 лет";
            // 
            // fiftYearPredText
            // 
            this.fiftYearPredText.AutoSize = true;
            this.fiftYearPredText.Location = new System.Drawing.Point(173, 330);
            this.fiftYearPredText.Name = "fiftYearPredText";
            this.fiftYearPredText.Size = new System.Drawing.Size(40, 15);
            this.fiftYearPredText.TabIndex = 20;
            this.fiftYearPredText.Text = "50 лет";
            // 
            // fiveYearPred
            // 
            this.fiveYearPred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fiveYearPred.Location = new System.Drawing.Point(12, 238);
            this.fiveYearPred.Name = "fiveYearPred";
            this.fiveYearPred.Size = new System.Drawing.Size(155, 23);
            this.fiveYearPred.TabIndex = 21;
            this.fiveYearPred.Text = "00,00";
            this.fiveYearPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenYearPred
            // 
            this.tenYearPred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenYearPred.Location = new System.Drawing.Point(12, 260);
            this.tenYearPred.Name = "tenYearPred";
            this.tenYearPred.Size = new System.Drawing.Size(155, 23);
            this.tenYearPred.TabIndex = 22;
            this.tenYearPred.Text = "00,00";
            this.tenYearPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twentYearPred
            // 
            this.twentYearPred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twentYearPred.Location = new System.Drawing.Point(12, 282);
            this.twentYearPred.Name = "twentYearPred";
            this.twentYearPred.Size = new System.Drawing.Size(155, 23);
            this.twentYearPred.TabIndex = 23;
            this.twentYearPred.Text = "00,00";
            this.twentYearPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdYearPred
            // 
            this.thirdYearPred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirdYearPred.Location = new System.Drawing.Point(12, 304);
            this.thirdYearPred.Name = "thirdYearPred";
            this.thirdYearPred.Size = new System.Drawing.Size(155, 23);
            this.thirdYearPred.TabIndex = 24;
            this.thirdYearPred.Text = "00,00";
            this.thirdYearPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fifthYearPred
            // 
            this.fifthYearPred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fifthYearPred.Location = new System.Drawing.Point(12, 326);
            this.fifthYearPred.Name = "fifthYearPred";
            this.fifthYearPred.Size = new System.Drawing.Size(155, 23);
            this.fifthYearPred.TabIndex = 25;
            this.fifthYearPred.Text = "00,00";
            this.fifthYearPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oneyrProd
            // 
            this.oneyrProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneyrProd.Location = new System.Drawing.Point(12, 194);
            this.oneyrProd.Name = "oneyrProd";
            this.oneyrProd.Size = new System.Drawing.Size(155, 23);
            this.oneyrProd.TabIndex = 26;
            this.oneyrProd.Text = "00,00";
            this.oneyrProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oneYearPred
            // 
            this.oneYearPred.AutoSize = true;
            this.oneYearPred.Location = new System.Drawing.Point(173, 198);
            this.oneYearPred.Name = "oneYearPred";
            this.oneYearPred.Size = new System.Drawing.Size(34, 15);
            this.oneYearPred.TabIndex = 27;
            this.oneYearPred.Text = "1 год";
            // 
            // sixMonthsPred
            // 
            this.sixMonthsPred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sixMonthsPred.Location = new System.Drawing.Point(12, 174);
            this.sixMonthsPred.Name = "sixMonthsPred";
            this.sixMonthsPred.Size = new System.Drawing.Size(155, 23);
            this.sixMonthsPred.TabIndex = 28;
            this.sixMonthsPred.Text = "00,00";
            this.sixMonthsPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sixMonthsPredText
            // 
            this.sixMonthsPredText.AutoSize = true;
            this.sixMonthsPredText.Location = new System.Drawing.Point(173, 175);
            this.sixMonthsPredText.Name = "sixMonthsPredText";
            this.sixMonthsPredText.Size = new System.Drawing.Size(37, 15);
            this.sixMonthsPredText.TabIndex = 29;
            this.sixMonthsPredText.Text = "6 мес";
            // 
            // rubSelect
            // 
            this.rubSelect.AutoSize = true;
            this.rubSelect.Checked = true;
            this.rubSelect.Location = new System.Drawing.Point(317, 65);
            this.rubSelect.Name = "rubSelect";
            this.rubSelect.Size = new System.Drawing.Size(56, 19);
            this.rubSelect.TabIndex = 30;
            this.rubSelect.TabStop = true;
            this.rubSelect.Text = "в RUB";
            this.rubSelect.UseVisualStyleBackColor = true;
            this.rubSelect.CheckedChanged += new System.EventHandler(this.RubSelect_CheckedChanged);
            // 
            // usdSelect
            // 
            this.usdSelect.AutoSize = true;
            this.usdSelect.Location = new System.Drawing.Point(317, 44);
            this.usdSelect.Name = "usdSelect";
            this.usdSelect.Size = new System.Drawing.Size(56, 19);
            this.usdSelect.TabIndex = 31;
            this.usdSelect.TabStop = true;
            this.usdSelect.Text = "в USD";
            this.usdSelect.UseVisualStyleBackColor = true;
            this.usdSelect.CheckedChanged += new System.EventHandler(this.USD_Select_CheckedChanged);
            // 
            // currentCourse
            // 
            this.currentCourse.Location = new System.Drawing.Point(12, 82);
            this.currentCourse.Name = "currentCourse";
            this.currentCourse.Size = new System.Drawing.Size(155, 23);
            this.currentCourse.TabIndex = 32;
            this.currentCourse.Text = "00,00";
            this.currentCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentCourseText
            // 
            this.currentCourseText.AutoSize = true;
            this.currentCourseText.Location = new System.Drawing.Point(173, 87);
            this.currentCourseText.Name = "currentCourseText";
            this.currentCourseText.Size = new System.Drawing.Size(63, 15);
            this.currentCourseText.TabIndex = 33;
            this.currentCourseText.Text = "RUB к USD";
            // 
            // yearsTotalEnter
            // 
            this.yearsTotalEnter.Location = new System.Drawing.Point(173, 381);
            this.yearsTotalEnter.Name = "yearsTotalEnter";
            this.yearsTotalEnter.Size = new System.Drawing.Size(23, 23);
            this.yearsTotalEnter.TabIndex = 36;
            this.yearsTotalEnter.Text = "1";
            this.yearsTotalEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profitTotalValue
            // 
            this.profitTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profitTotalValue.Location = new System.Drawing.Point(12, 381);
            this.profitTotalValue.Name = "profitTotalValue";
            this.profitTotalValue.Size = new System.Drawing.Size(155, 23);
            this.profitTotalValue.TabIndex = 37;
            this.profitTotalValue.Text = "00,00";
            this.profitTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearsTotalText
            // 
            this.yearsTotalText.AutoSize = true;
            this.yearsTotalText.Location = new System.Drawing.Point(202, 385);
            this.yearsTotalText.Name = "yearsTotalText";
            this.yearsTotalText.Size = new System.Drawing.Size(25, 15);
            this.yearsTotalText.TabIndex = 38;
            this.yearsTotalText.Text = "год";
            // 
            // profitTotalText
            // 
            this.profitTotalText.AutoSize = true;
            this.profitTotalText.Location = new System.Drawing.Point(67, 366);
            this.profitTotalText.Name = "profitTotalText";
            this.profitTotalText.Size = new System.Drawing.Size(48, 15);
            this.profitTotalText.TabIndex = 39;
            this.profitTotalText.Text = "Активы";
            // 
            // calculateBotton
            // 
            this.calculateBotton.Location = new System.Drawing.Point(12, 436);
            this.calculateBotton.Name = "calculateBotton";
            this.calculateBotton.Size = new System.Drawing.Size(411, 48);
            this.calculateBotton.TabIndex = 40;
            this.calculateBotton.Text = "Пересчитать";
            this.calculateBotton.UseVisualStyleBackColor = true;
            this.calculateBotton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // advancedInvest
            // 
            this.advancedInvest.AutoSize = true;
            this.advancedInvest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.advancedInvest.Location = new System.Drawing.Point(317, 84);
            this.advancedInvest.Name = "advancedInvest";
            this.advancedInvest.Size = new System.Drawing.Size(114, 19);
            this.advancedInvest.TabIndex = 41;
            this.advancedInvest.Text = "Доинвестиции";
            this.advancedInvest.UseVisualStyleBackColor = true;
            // 
            // advInvestValueLabel
            // 
            this.advInvestValueLabel.AutoSize = true;
            this.advInvestValueLabel.Location = new System.Drawing.Point(298, 140);
            this.advInvestValueLabel.Name = "advInvestValueLabel";
            this.advInvestValueLabel.Size = new System.Drawing.Size(75, 15);
            this.advInvestValueLabel.TabIndex = 42;
            this.advInvestValueLabel.Text = "RUB в месяц";
            // 
            // AdvInvestMonth
            // 
            this.AdvInvestMonth.Location = new System.Drawing.Point(259, 114);
            this.AdvInvestMonth.Name = "AdvInvestMonth";
            this.AdvInvestMonth.Size = new System.Drawing.Size(155, 23);
            this.AdvInvestMonth.TabIndex = 43;
            this.AdvInvestMonth.Text = "00,00";
            this.AdvInvestMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // callcExplainLabel
            // 
            this.callcExplainLabel.AutoSize = true;
            this.callcExplainLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.callcExplainLabel.Location = new System.Drawing.Point(315, 13);
            this.callcExplainLabel.Name = "callcExplainLabel";
            this.callcExplainLabel.Size = new System.Drawing.Size(58, 15);
            this.callcExplainLabel.TabIndex = 44;
            this.callcExplainLabel.Text = "Расчеты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(452, 518);
            this.Controls.Add(this.callcExplainLabel);
            this.Controls.Add(this.AdvInvestMonth);
            this.Controls.Add(this.advInvestValueLabel);
            this.Controls.Add(this.advancedInvest);
            this.Controls.Add(this.calculateBotton);
            this.Controls.Add(this.profitTotalText);
            this.Controls.Add(this.yearsTotalText);
            this.Controls.Add(this.profitTotalValue);
            this.Controls.Add(this.yearsTotalEnter);
            this.Controls.Add(this.currentCourseText);
            this.Controls.Add(this.currentCourse);
            this.Controls.Add(this.usdSelect);
            this.Controls.Add(this.rubSelect);
            this.Controls.Add(this.sixMonthsPredText);
            this.Controls.Add(this.sixMonthsPred);
            this.Controls.Add(this.oneYearPred);
            this.Controls.Add(this.oneyrProd);
            this.Controls.Add(this.fifthYearPred);
            this.Controls.Add(this.thirdYearPred);
            this.Controls.Add(this.twentYearPred);
            this.Controls.Add(this.tenYearPred);
            this.Controls.Add(this.fiveYearPred);
            this.Controls.Add(this.fiftYearPredText);
            this.Controls.Add(this.thirdYearPredText);
            this.Controls.Add(this.percentRow);
            this.Controls.Add(this.twentYearProdText);
            this.Controls.Add(this.tenYearPredText);
            this.Controls.Add(this.fiveYearPredText);
            this.Controls.Add(this.threeYearPredText);
            this.Controls.Add(this.threeYearPred);
            this.Controls.Add(this.predictions);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.percentPerYear);
            this.Controls.Add(this.dividents);
            this.Controls.Add(this.actionPriceText);
            this.Controls.Add(this.divValue);
            this.Controls.Add(this.actionPrice);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсчет доходов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox actionPrice;
        private System.Windows.Forms.TextBox divValue;
        private System.Windows.Forms.Label actionPriceText;
        private System.Windows.Forms.Label dividents;
        private System.Windows.Forms.Label percentPerYear;
        private System.Windows.Forms.Label inputData;
        private System.Windows.Forms.Label predictions;
        private System.Windows.Forms.Label threeYearPred;
        private System.Windows.Forms.Label threeYearPredText;
        private System.Windows.Forms.Label fiveYearPredText;
        private System.Windows.Forms.Label tenYearPredText;
        private System.Windows.Forms.Label twentYearProdText;
        private System.Windows.Forms.Label percentRow;
        private System.Windows.Forms.Label thirdYearPredText;
        private System.Windows.Forms.Label fiftYearPredText;
        private System.Windows.Forms.Label fiveYearPred;
        private System.Windows.Forms.Label tenYearPred;
        private System.Windows.Forms.Label twentYearPred;
        private System.Windows.Forms.Label thirdYearPred;
        private System.Windows.Forms.Label fifthYearPred;
        private System.Windows.Forms.Label oneyrProd;
        private System.Windows.Forms.Label oneYearPred;
        private System.Windows.Forms.Label sixMonthsPred;
        private System.Windows.Forms.Label sixMonthsPredText;
        private System.Windows.Forms.RadioButton rubSelect;
        private System.Windows.Forms.RadioButton usdSelect;
        private System.Windows.Forms.TextBox currentCourse;
        private System.Windows.Forms.Label currentCourseText;
        private System.Windows.Forms.TextBox yearsTotalEnter;
        private System.Windows.Forms.Label profitTotalValue;
        private System.Windows.Forms.Label yearsTotalText;
        private System.Windows.Forms.Label profitTotalText;
        private System.Windows.Forms.Button calculateBotton;
        private System.Windows.Forms.CheckBox advancedInvest;
        private System.Windows.Forms.Label advInvestValueLabel;
        private System.Windows.Forms.TextBox AdvInvestMonth;
        private System.Windows.Forms.Label callcExplainLabel;
    }
}

