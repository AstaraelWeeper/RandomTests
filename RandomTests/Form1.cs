using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomTests
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            loadNumbers();
            lblTotal.Text = "Total = " + AddNumbers();
        }

        private void loadNumbers()
        {
            string[] numbersString;
            string textbox;
            textbox = txtNumbersList.Text;
            numbersString = textbox.Split(',');

                    foreach (string number in numbersString)
                    {
                        int numberInt = Int32.Parse(number);
                        numbers.Add(numberInt);
                    }
                
        }

        private string AddNumbers()
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total.ToString();
        }
        /// <summary>
        /// ////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnListCombine_Click(object sender, EventArgs e)
        {
            string [][] bothLists = LoadLists();
            List<string> combinedList = CombineLists(bothLists);
            lstCombinedLists.DataSource = combinedList;
        }

        private string[][] LoadLists()
        {
            string List1string = txtList1.Text;
            string[] List1 = List1string.Split(',');
            string List2string = txtList2.Text;
            string[] List2 = List2string.Split(',');

            string[][] bothLists = { List1, List2 };
            return bothLists;
        }

        private List<string> CombineLists (string[][] pies)
        {
            string[] List1 = pies[0];
            string[] List2 = pies[1];
            int smallestListLength = 0;
            int largestListLength = 0;
            int i = 0;
            List<string> combinedList = new List<string>();
            string[] largestList;

            if (List1.Length > List2.Length)
            {
                smallestListLength = List2.Length;
                largestListLength = List1.Length;
                largestList = List1;
            }
            else
            {
                smallestListLength = List1.Length;
                largestListLength = List2.Length;
                largestList = List2;
            }

            for (; i < smallestListLength; i++)
            {
                combinedList.Add(List1[i]);
                combinedList.Add(List2[i]);
            }
            for (; i < largestListLength; i++)
            {
                combinedList.Add(largestList[i]);
            }
            return combinedList;
        }

        /// <summary>
        /// ////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            txtFibonacciResult.Text = CalculateFibonacci();
        }

        private string CalculateFibonacci()
        {
            int first = 0;
            int second = 1;
            int total = 0;

            string Results = "";
                
            Results += (first.ToString()) + ", ";
            Results += (second.ToString()) + ", ";

            for (int i = 0; i < 20; i++)
            {
                
                total = first + second;
                Results += (total.ToString()) + ", ";
                first = second;
                second = total;
                total = 0;
            }
            return Results;
        }

        /// <summary>
        /// ///////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnRearrange_Click(object sender, EventArgs e)
        {
            List<int> ints = LoadIntegers();
           List<string> pies = ParseInts(ints);
           string finalValue="";
           for (int i = 0; i < pies.Count; i++)
           {
               finalValue += pies[i];
           }
           txtRearranged.Text = finalValue;
        }

        private List<int> LoadIntegers()
        {
            string[] numbersString;
            string textbox;
            textbox = txtNumbersToRearrange.Text;
            numbersString = textbox.Split(',');
            List<int> ints = new List<int>();
            if (string.IsNullOrEmpty(textbox))
            {
            }
            else{
                 foreach (string number in numbersString)
                 {
                    int numberInt = Int32.Parse(number);
                    ints.Add(numberInt);
                 }
                }
                return ints;
            
        }

        private List<string> ParseInts(List<int> ints)
        {
            List<string> returnNumberList = new List<string>();
            if (ints.Count != 0)
            {
                List<int> firstDigits = new List<int>();
                List<int> singleDigits = new List<int>();
                

                    for (int i = 0; i < ints.Count; i++) //get first digits only and add to firstDigits
                    {  
                        int ones = 0;
                        if (ints[i] < 9)
                        {
                            singleDigits.Add(-1);
                            firstDigits.Add(ints[i]);
                        }

                        else
                        {
                            if (ints[i] < 100)
                            {
                                ones = ints[i] % 10;

                            }
                            else if (ints[i] < 1000)
                            {
                                ones = ints[i] % 100;
                            }
                            else if (ints[i] < 10000)
                            {
                                ones = ints[i] % 1000;
                            }
                                
                            int firstDigit = ints[i] - ones; //tens numbers
                            singleDigits.Add(ones);
                            firstDigits.Add(firstDigit);
                        }

                    }

              while (firstDigits[0] < firstDigits.Max())
               {
                    for (int i = 0; i < firstDigits.Count-1; i++)//rearrange BOTH ARRAYS
                    {
                        int firstDigitsSpare = 0;
                        int singleDigitsSpare = 0;

                        if(firstDigits[i]<firstDigits[i+1]) //swap
                        {
                            firstDigitsSpare = firstDigits[i]; 
                            singleDigitsSpare = singleDigits[i];
                            firstDigits[i] = firstDigits[i + 1];
                            singleDigits[i] = singleDigits[i + 1];
                            firstDigits[i + 1] = firstDigitsSpare;
                            singleDigits[i + 1] = singleDigitsSpare;

                        }
                        
                    }
                }

              for (int i = 0; i < firstDigits.Count; i++) //put numbers back together
              {
                  int toAddInt;
                  if (singleDigits[i] > 0)
                  {
                      toAddInt = (firstDigits[i] + singleDigits[i]);
                      returnNumberList.Add(toAddInt.ToString());
                  }
                  else if (singleDigits[i] == -1)
                  {
                      toAddInt = firstDigits[i];
                      returnNumberList.Add(toAddInt.ToString());
                  }
              }
                
                return returnNumberList;
            }
            else
            {
                returnNumberList.Add("failed");
                return returnNumberList;
            }
        }

        
        //////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> FizzBuzz = new List<string>();
            

            for (int i = 0; i < 10; i++)
            {
                string line = "";
                for (int j = 1; j < 5; j++)
                {
                    
                    if (j != 4)
                    {
                        line += j.ToString() + ", ";
                    }
                    else if (j == 4)
                    {
                        line += "FizzBuzz!";
                    }
                    
                    
                }
                FizzBuzz.Add(line);
            }
            lstFB.DataSource = FizzBuzz;
        }

        private void btnFBmod_Click(object sender, EventArgs e)
        {
            List<string> FizzBuzz = new List<string>();

            bool fizz = false;
            bool buzz = false;
            bool newline = false;

            string line = "";

            for (int j = 1; j < 60; j++)
            {
               
                if (j % 3 == 0)
                {
                    fizz = true;
                }
                if (j % 5 == 0)
                {
                    buzz = true;
                }
                if (j % 10 == 0)
                {
                    newline = true;
                }


                if (!fizz && !buzz)
                {
                    line += j.ToString() + ", ";
                }

                else if (fizz && !buzz)
                {
                    line += "Fizz, ";
                }
                else if (buzz && !fizz)
                {
                    line += "Buzz, "; 
                }
                else if (fizz && buzz)
                {
                    line += "FizzBuzz! ";
                }

                if (newline)
                {
                    FizzBuzz.Add(line);
                    line = "";
                }
                fizz = false;
                buzz = false;
                newline = false;
               
            }

            lstFBmod.DataSource = FizzBuzz;
        }
        

    }
}
