using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritm2
{
    public partial class Form1 : Form
    {
        private List<int> numbers;
        private string numbersString;
        private int timesSorted;

        public Form1()
        {
            InitializeComponent();

            numbers = new List<int>();

            Reset();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(numbers));

            switch (cbSortMethod.Text)
            {
                case "bubblesort":
                    BubbleSort();
                    Reset();
                    break;
                case "selectionsort":
                    SelectionSort();
                    Reset();
                    break;
                case "insertionsort":
                    InsertionSort();
                    Reset();
                    break;
                case "mergesort":
                    break;
            }
        }

        private void Reset()
        {
            numbers.Clear();

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

            numbersString = "";
            timesSorted = 0;
        }

        private void BubbleSort()
        {
            for (int write = 0; write < numbers.Count; write++)
            {
                for (int sort = 0; sort < numbers.Count - 1; sort++)
                {
                    if (numbers[sort] > numbers[sort + 1])
                    {
                        int temp = numbers[sort + 1];
                        numbers[sort + 1] = numbers[sort];
                        numbers[sort] = temp;

                        timesSorted++;

                        numbersString = "";
                        foreach (int number in numbers)
                        {
                            numbersString += number + ", ";
                        }
                        numbersString += " [" + timesSorted + "]";

                        MessageBox.Show(numbersString);
                    }
                }
            }
            MessageBox.Show("Result: " + numbersString);
        }

        private void SelectionSort()
        {
            int i;
            int j;

            for (i = 0; i < numbers.Count; i++)
            {
                int min = i;
                for (j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[j] < numbers[min])
                    {
                        min = j; //find min value
                        //then swap it with the beginning item of the unsorted list
                        int temp = numbers[i];
                        numbers[i] = numbers[min];
                        numbers[min] = temp;

                        timesSorted++;

                        numbersString = "";
                        foreach (int number in numbers)
                        {
                            numbersString += number + ", ";
                        }
                        numbersString += " [" + timesSorted + "]";

                        MessageBox.Show(numbersString);
                    }
                }
            }
            MessageBox.Show("Result: " + numbersString);
        }

        private void InsertionSort()
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        int temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                    j--;

                    timesSorted++;

                    numbersString = "";
                    foreach (int number in numbers)
                    {
                        numbersString += number + ", ";
                    }
                    numbersString += " [" + timesSorted + "]";

                    MessageBox.Show(numbersString);
                }
            }
            MessageBox.Show("Result: " + numbersString);
        }
    }
}
