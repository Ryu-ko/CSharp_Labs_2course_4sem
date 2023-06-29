using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }
        public string lowList = "abcdefghijklmnoprstuvwxyz";

        public float DailyCallor( float Wght, float Hght, int Age ) // (вес*10 + рост*6,25 - возраст*5|| -161 ж | +5 м)*1,38
        {
            int MaleOrFemale;
            if (this.maleButton.Checked == true)
            {
                MaleOrFemale = 5;
            }
            else
            {
                MaleOrFemale = -161;
            }
            float res = (float)(((Wght * 10) + (Hght * 6.25) - (Age * 5) + MaleOrFemale) * 1.375);
            //проверка цели
            if (WeightLoss.Checked == true)//похудение
            {
                res = (float)(res - (res * 0.15));
            }
            else if (WeightGain.Checked == true)//повышение цели
            {
                res = (float)(res + (res * 0.15));
            }
            else //поддержание
            {

            }

            return res;
        }

        private void PrintResultButton_Click( object sender, EventArgs e ) //источник события 
        {
            try
            {
                //Масса тела
                float IndexBody = (float)(Convert.ToSingle(this.Weight.Text) / Math.Pow(Convert.ToSingle(this.Height.Text) / 100, 2));
                string BodyState = " ";
                if (IndexBody <= 16)
                {
                    BodyState = "Выраженный дефицит массы тела";
                }
                else if (IndexBody >= 16.1 && IndexBody <= 18.5)
                {
                    BodyState = "Недостаточная (дефицит) масса тела";
                }
                else if (IndexBody >= 18.6 && IndexBody <= 20)
                {
                    BodyState = "Норма";
                }
                else if (IndexBody >= 20.1 && IndexBody <= 25)
                {
                    BodyState = "Норма";
                }
                else if (IndexBody >= 25.1 && IndexBody <= 30)
                {
                    BodyState = "Избыточная масса тела (предожирение)";
                }
                else if (IndexBody >= 30.1 && IndexBody <= 35)
                {
                    BodyState = "Ожирение первой степени";
                }
                else if (IndexBody >= 35.1 && IndexBody <= 40)
                {
                    BodyState = "Ожирение второй степени";
                }
                else if (IndexBody >= 40.1)
                {
                    BodyState = "Ожирение третьей степени (морбидное)";
                }

                string IndexRes;

                //Калории 
                string outputCal;
                int dailycal;
                dailycal = (int)this.DailyCallor(Convert.ToSingle(this.Weight.Text), Convert.ToSingle(this.Height.Text), Convert.ToInt32(this.Age.Text));


                //Валидация

                if (Convert.ToInt32(this.Height.Text) <= 100 || Convert.ToInt32(this.Height.Text) >= 250 || string.IsNullOrEmpty(this.Height.Text) || this.Height.Text == " " || Convert.ToInt32(this.Weight.Text) <= 20 || Convert.ToInt32(this.Weight.Text) >= 150 || string.IsNullOrEmpty(this.Weight.Text) || this.Weight.Text == " " || Convert.ToInt32(this.Age.Text) <= 10 || Convert.ToInt32(this.GoalWeight.Text) >= 150 || string.IsNullOrEmpty(this.Age.Text) || this.Age.Text == " " || Convert.ToInt32(this.GoalWeight.Text) <= 20 || Convert.ToInt32(this.GoalWeight.Text) >= 150 || string.IsNullOrEmpty(this.GoalWeight.Text) || this.GoalWeight.Text == " " || WeightLoss.Checked == false && mainingWeight.Checked == false && WeightGain.Checked == false)
                {

                    MessageBox.Show("Не корректные значения");
                    //вес
                    if (Convert.ToInt32(this.Weight.Text) <= 20 || Convert.ToInt32(this.Weight.Text) >= 150 || string.IsNullOrEmpty(this.Weight.Text) || this.Weight.Text == " ")
                    {
                        this.Weight.BackColor = Color.Red;
                    }
                    else
                    {
                        this.Weight.BackColor = Color.White;
                    }
                    //рост
                    if (Convert.ToInt32(this.Height.Text) <= 100 || Convert.ToInt32(this.Height.Text) >= 250 || string.IsNullOrEmpty(this.Height.Text) || this.Height.Text == " ")
                    {
                        this.Height.BackColor = Color.Red;
                    }
                    else
                    {
                        this.Height.BackColor = Color.White;
                    }
                    //возраст
                    if (Convert.ToInt32(this.Age.Text) <= 10 || Convert.ToInt32(this.Age.Text) >= 100 || string.IsNullOrEmpty(this.Age.Text) || this.Age.Text == " ")
                    {
                        this.Age.BackColor = Color.Red;
                    }
                    else
                    {
                        this.Age.BackColor = Color.White;
                    }

                    //желаемый вес
                    if (Convert.ToInt32(this.GoalWeight.Text) <= 20 || Convert.ToInt32(this.GoalWeight.Text) >= 150 || string.IsNullOrEmpty(this.GoalWeight.Text) || this.GoalWeight.Text == " ")
                    {
                        this.GoalWeight.BackColor = Color.Red;
                    }
                    else
                    {
                        this.GoalWeight.BackColor = Color.White;


                    }

                    //цель

                    if (WeightLoss.Checked == false && mainingWeight.Checked == false && WeightGain.Checked == false)//похудение
                    {
                        this.checkedGoals.BackColor = Color.Red;
                    }
                    else if (WeightLoss.Checked == true || mainingWeight.Checked == true || WeightGain.Checked == true)//повышение цели
                    {
                        this.checkedGoals.BackColor = Color.DarkSeaGreen;
                    }
                    else
                    {
                        this.checkedGoals.BackColor = Color.White;

                    }


                    //пол
                    if (femaleButton.Checked == false && maleButton.Checked == false)//похудение
                    {
                        this.SexCheck.BackColor = Color.Red;
                    }
                    else if (femaleButton.Checked == true || maleButton.Checked == true)//повышение цели
                    {
                        this.SexCheck.BackColor = Color.DarkSeaGreen;
                    }
                    else
                    {
                        this.SexCheck.BackColor = Color.DarkSeaGreen;

                    }


                    this.PrintResultButton.BackColor = Color.Red;
                    outputCal = " ";
                    this.dailyСaloriesResult.Text = outputCal;
                    IndexRes = " ";
                    this.ResultFolder.Text = IndexRes;

                }
                else //если все верно
                {
                    this.PrintResultButton.BackColor = Color.White;
                    this.SexCheck.BackColor = Color.DarkSeaGreen;

                    IndexRes = "Ваш результат: " + IndexBody + "\nСостояние массы тела: " + BodyState;
                    this.ResultFolder.Text = IndexRes;

                    outputCal = dailycal + "\r\n";
                    this.dailyСaloriesResult.Text = outputCal;
                    this.checkedGoals.BackColor = Color.DarkSeaGreen;

                }

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                MessageBox.Show("Некоректные данные");
                this.dailyСaloriesResult.Clear();
                this.ResultFolder.Clear();
            }
        }

        private void ResultFolder_Click( object sender, EventArgs e )
        {
            this.ResultFolder.ReadOnly = true;
        }

        private void dailyСaloriesResult_TextChanged( object sender, EventArgs e )
        {
            this.dailyСaloriesResult.ReadOnly = true;
        }

        private void Height_TextChanged( object sender, EventArgs e )
        {

        }
    }
}
