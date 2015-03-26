using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();

            numbers.Add(40);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(43);
            numbers.Add(3);
            numbers.Add(65);
            numbers.Add(0);
            numbers.Add(-1);
            numbers.Add(58);
            numbers.Add(3);
            numbers.Add(42);
            numbers.Add(4);

            string numbersString = "";

            foreach (int number in numbers)
            {
                numbersString += number + ", ";
            }

            MessageBox.Show(numbersString);

            bool notSorted = false;
            int timesSorted = 0;

            do
            {
                //Kevin's algoritme
                
                for (int i = 1; i <= numbers.Count; i++)
                {
                    int currentNumber = numbers[i - 1];
                    int nextNumber = numbers[i];

                    if (currentNumber > nextNumber)
                    {
                        int tempCoin = currentNumber;
                        currentNumber = nextNumber;
                        nextNumber = tempCoin;

                        numbers[i - 1] = currentNumber;
                        numbers[i] = nextNumber;

                        numbersString = "";
                        foreach (int number in numbers)
                        {
                            numbersString += number + ", ";
                        }

                        MessageBox.Show(numbersString);
                  
                        notSorted = true;
                        timesSorted += 1;
                    }
                }
                 
                //Milton's manier
                /*
                for (int i = 1; i < numbers.Count; i++)
                {
                    int currentNumber = numbers[i - 1];
                    int nextNumber = numbers[i];

                    if (currentNumber > nextNumber)
                    {
                        int tempCoin = currentNumber;
                        currentNumber = nextNumber;
                        nextNumber = tempCoin;

                        numbers[i - 1] = currentNumber;
                        numbers[i] = nextNumber;

                        numbersString = "";
                        foreach (int number in numbers)
                        {
                            numbersString += number + ", ";
                        }

                        MessageBox.Show(numbersString);

                        notSorted = true;
                        timesSorted += 1;
                        i = 1;
                    }
                }
                 */

            } while (notSorted);

            MessageBox.Show(Convert.ToString(timesSorted));
        }
    }
}
