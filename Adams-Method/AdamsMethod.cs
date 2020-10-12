using System;

namespace Adams_Method
{
    class AdamsMethod
    {
        private double InitialX;
        private double InitialY;
        private double FinalX;
        private double Accuracy;
        private int EquationIndex;
        private double[] RungeKuttaMethodCoefficients = new double[4];
        public double[,] Nodes { get; set; }

        public AdamsMethod(double initialX, double initialY, double finalX, double accuracy, int equationIndex)
        {
            InitialX = initialX;
            InitialY = initialY;
            FinalX = finalX;
            Accuracy = accuracy;
            EquationIndex = equationIndex;
            ComputeNodes();
        }

        private void ComputeNodes()
        {
            int stepCount = (int)Math.Truncate((FinalX - InitialX) / Accuracy) + 1;
            double h = (FinalX - InitialX) / stepCount;
            Nodes = new double[2, stepCount + 1];
            Nodes[0, 0] = InitialX;
            Nodes[1, 0] = GetFunctionDerivativeValue(InitialX, InitialY);

            for(int i = 1; i < stepCount + 1; i++)
            {
                Nodes[0, i] = Nodes[0, i - 1] + h;
            }

            //Методом Рунге-Кутта 4-ого порядка будем искать значения функции с 1 по 3
            for (int i = 1; i < 4; i++)
            {
                RungeKuttaMethodCoefficients[0] = h * GetFunctionDerivativeValue(Nodes[0, i - 1], Nodes[1, i - 1]);
                RungeKuttaMethodCoefficients[1] = h * GetFunctionDerivativeValue(Nodes[0, i - 1] + h / 2, Nodes[1, i - 1] + RungeKuttaMethodCoefficients[0] / 2);
                RungeKuttaMethodCoefficients[2] = h * GetFunctionDerivativeValue(Nodes[0, i - 1] + h / 2, Nodes[1, i - 1] + RungeKuttaMethodCoefficients[1] / 2);
                RungeKuttaMethodCoefficients[3] = h * GetFunctionDerivativeValue(Nodes[0, i - 1] + h, Nodes[1, i - 1] + RungeKuttaMethodCoefficients[2]);

                Nodes[1, i] = Nodes[1, i] + (RungeKuttaMethodCoefficients[0] + 2 * RungeKuttaMethodCoefficients[1] + 2 * RungeKuttaMethodCoefficients[2] + RungeKuttaMethodCoefficients[3]) / 6;
            }

            //Метод Адамса
            for(int i = 4; i < stepCount + 1; i++)
            {
                Nodes[1, i] = Nodes[1, i - 1] + h / 24 * (
                    55 * GetFunctionDerivativeValue(Nodes[0, i - 1], Nodes[1, i - 1])
                    - 59 * GetFunctionDerivativeValue(Nodes[0, i - 2], Nodes[1, i - 2])
                    + 37 * GetFunctionDerivativeValue(Nodes[0, i - 3], Nodes[1, i - 3])
                    - 9 * GetFunctionDerivativeValue(Nodes[0, i - 4], Nodes[1, i - 4])
                    );
            }
        }

        private double GetFunctionDerivativeValue(double x, double y)
        {
            double functionValue = 0;

            switch (EquationIndex)
            {
                case 0:
                    functionValue = (2 - y) * Math.Tan(x);
                    break;
                case 1:
                    functionValue = Math.Exp(3 * x) - y;
                    break;
                case 2:
                    functionValue = x * Math.Exp(-1 * Math.Pow(x, 2)) - 2 * x * y;
                    break;
                case 3:
                    functionValue = Math.Sin(x) + y;
                    break;
            }

            return functionValue;
        }

    }
}
