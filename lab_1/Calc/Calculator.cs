using Microsoft.VisualBasic.FileIO;

namespace Calc
{
    internal class Calculator
    {
        private int age;
        private int weight;
        private int height;
        private string gender;
        private Goals goal;

        public enum Goals
        {
            less = 1, rapidless, normal
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 117)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("wrong age");
                }
            }
        }

        public Goals Goal
        {
            get { return (Goals)(int)goal; }
            set
            {
                goal = value;
            }
        }

        public string Gender { get; set; }

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value > 0 && value < 300)
                {
                    weight = value;
                }
                else
                {
                    throw new Exception("wrong weight");
                }
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0 && value < 272)
                {
                    height = value;
                }
                else
                {
                    throw new Exception("wrong height");
                }
            }
        }

        public Calculator(int age, int weight, int height, string gender, string goal)
        {
            this.age = age;
            this.weight = weight;
            this.height = height;
            this.gender = gender;
            if (goal == null)
            {
                throw new Exception("wrong goal");
            }
            if (goal == "weight loss")
            {
                this.goal = Goals.less;
            }
            else if (goal == "rapid weight loss")
            {
                this.goal = Goals.rapidless;
            }
            else
            {
                this.goal = Goals.normal;
            }

        }



        public string CalcImt()
        {
            //само imt
            var imt = ((double) weight / Math.Pow( ((double) height / 100),(double)2));


            string finalMessage = "imt = " + (int)imt + "\n У вас: ";
                //
            for (;;) {
                if (gender == "Male")
                {
                    if (imt <= 20)
                    {
                        finalMessage += "Дефицит веса";
                        break;
                    }
                    else if (imt > 20 && imt <=25)
                    {
                        finalMessage += "Нормальный вес";
                        break;
                    }
                    else if (imt > 25 && imt <= 30)
                    {
                        finalMessage += "Избыточный вес";
                        break;
                    }
                    else if (imt > 30 && imt <= 40)
                    {
                        finalMessage += "Ожирение";
                        break;
                    }
                    else if (imt > 40)
                    {
                        finalMessage += "Тяжелое ожирение";
                        break;
                    }
                }
                else
                {
                    if (imt <= 19)
                    {
                        finalMessage += "Дефицит веса";
                        break;
                    }
                    else if (imt > 19 && imt <= 24)
                    {
                        finalMessage += "Нормальный вес";
                        break;
                    }
                    else if (imt > 24 && imt <= 30)
                    {
                        finalMessage += "Избыточный вес";
                        break;
                    }
                    else if (imt > 30 && imt <= 40)
                    {
                        finalMessage += "Ожирение";
                        break;
                    }
                    else if (imt > 40)
                    {
                        finalMessage += "Тяжелое ожирение";
                        break;
                    }
                }
            }

            finalMessage += "\n";
            return finalMessage;
        }

        public string CalcKkal()
        {
            double kkal;
            if (gender == "Male")
            {
                 kkal = 66.5 + 13.75 * (double) weight + 5.003 * (double) height - 6.775 * (double) age;
            }
            else
            {
                 kkal = 655.1 + 13.75 * (double)weight + 1.85 * (double)height - 4.676 * (double)age;
            }

            string finalLine = "";

            switch (goal)
            {
                case Goals.less:
                    finalLine +=
                        $"Для вашей цели(уменьшения веса) суточную норму составляет {(int) kkal - kkal * 0.15} Ккал";
                    break;
                case Goals.rapidless:;
                    finalLine +=
                        $"Для вашей цели(быстрое уменьшения веса) суточную норму составляет {(int) kkal - kkal * 0.25} Ккал";
                    break;
                case Goals.normal:
                    finalLine +=
                        $"Для вашей цели(нормального веса) суточную норму составляет {(int) kkal } Ккал";
                    break;
            }

            return finalLine;
        }
    }
}
