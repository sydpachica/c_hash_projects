using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lottery_Pattern_Recognizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> Digits = new List<int>();
        List<int> DigitsJ = new List<int>();
        List<int> Winning_Combos = new List<int>();
        List<int> Jackpot_Combos = new List<int>();
        List<string> Winning_Combos_String = new List<string>();
        List<string> Jackpot_Combos_String = new List<string>();

        int totalDraw = 1, total_jackpot = 0, totalWinner=0, combo1 = 0, combo2 = 0, combo3 = 0, combo4 = 0, combo5 = 0, allOdd = 0, allEven = 0;
        int jackpot_c1 = 0, jackpot_c2 = 0, jackpot_c3 = 0, jackpot_c4 = 0, jackpot_c5 = 0, jackpot_even = 0, jackpot_odd = 0;
        int max_no = 1; int max_no_j = 1;
        int one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen,
            nineteen, twenty, twenty_one, twenty_two, twenty_three, twenty_four, twenty_five, twenty_six, twenty_seven, twenty_eight, twenty_nine,
            thirty, thirty_one, thirty_two, thirty_three, thirty_four, thirty_five, thirty_six, thirty_seven, thirty_eight, thirty_nine, fourty,
            fourty_one, fourty_two, fourty_three, fourty_four, fourty_five, fourty_six, fourty_seven, fourty_eight, fourty_nine, fifty, fifty_one,
            fifty_two, fifty_three, fifty_four, fifty_five, fifty_six, fifty_seven, fifty_eight;

        int one_j, two_j, three_j, four_j, five_j, six_j, seven_j, eight_j, nine_j, ten_j, eleven_j, twelve_j, thirteen_j, fourteen_j, fifteen_j, sixteen_j, seventeen_j, eighteen_j, nineteen_j, twenty_j, twenty_one_j, twenty_two_j, twenty_three_j, twenty_four_j, twenty_five_j, twenty_six_j, twenty_seven_j, twenty_eight_j, twenty_nine_j, thirty_j, thirty_one_j, thirty_two_j, thirty_three_j, thirty_four_j, thirty_five_j, thirty_six_j, thirty_seven_j, thirty_eight_j, thirty_nine_j, fourty_j, fourty_one_j, fourty_two_j, fourty_three_j, fourty_four_j, fourty_five_j, fourty_six_j, fourty_seven_j, fourty_eight_j, fourty_nine_j, fifty_j, fifty_one_j, fifty_two_j, fifty_three_j, fifty_four_j, fifty_five_j, fifty_six_j, fifty_seven_j, fifty_eight_j;
        bool isExit = false;

        private void AddNumberstoList()
        {
            Digits.Add(one);
            Digits.Add(two);
            Digits.Add(three);
            Digits.Add(four);
            Digits.Add(five);
            Digits.Add(six);
            Digits.Add(seven);
            Digits.Add(eight);
            Digits.Add(nine);
            Digits.Add(ten);
            Digits.Add(eleven);
            Digits.Add(twelve);
            Digits.Add(thirteen);
            Digits.Add(fourteen);
            Digits.Add(fifteen);
            Digits.Add(sixteen);
            Digits.Add(seventeen);
            Digits.Add(eighteen);
            Digits.Add(nineteen);
            Digits.Add(twenty);
            Digits.Add(twenty_one);
            Digits.Add(twenty_two);
            Digits.Add(twenty_three);
            Digits.Add(twenty_four);
            Digits.Add(twenty_five);
            Digits.Add(twenty_six);
            Digits.Add(twenty_seven);
            Digits.Add(twenty_eight);
            Digits.Add(twenty_nine);
            Digits.Add(thirty);
            Digits.Add(thirty_one);
            Digits.Add(thirty_two);
            Digits.Add(thirty_three);
            Digits.Add(thirty_four);
            Digits.Add(thirty_five);
            Digits.Add(thirty_six);
            Digits.Add(thirty_seven);
            Digits.Add(thirty_eight);
            Digits.Add(thirty_nine);
            Digits.Add(fourty);
            Digits.Add(fourty_one);
            Digits.Add(fourty_two);
            Digits.Add(fourty_three);
            Digits.Add(fourty_four);
            Digits.Add(fourty_five);
            Digits.Add(fourty_six);
            Digits.Add(fourty_seven);
            Digits.Add(fourty_eight);
            Digits.Add(fourty_nine);
            Digits.Add(fifty);
            Digits.Add(fifty_one);
            Digits.Add(fifty_two);
            Digits.Add(fifty_three);
            Digits.Add(fifty_four);
            Digits.Add(fifty_five);
            Digits.Add(fifty_six);
            Digits.Add(fifty_seven);
            Digits.Add(fifty_eight);
        }

        private void AddNumberstoListJ()
        {
            DigitsJ.Add(one_j);
            DigitsJ.Add(two_j);
            DigitsJ.Add(three_j);
            DigitsJ.Add(four_j);
            DigitsJ.Add(five_j);
            DigitsJ.Add(six_j);
            DigitsJ.Add(seven_j);
            DigitsJ.Add(eight_j);
            DigitsJ.Add(nine_j);
            DigitsJ.Add(ten_j);
            DigitsJ.Add(eleven_j);
            DigitsJ.Add(twelve_j);
            DigitsJ.Add(thirteen_j);
            DigitsJ.Add(fourteen_j);
            DigitsJ.Add(fifteen_j);
            DigitsJ.Add(sixteen_j);
            DigitsJ.Add(seventeen_j);
            DigitsJ.Add(eighteen_j);
            DigitsJ.Add(nineteen_j);
            DigitsJ.Add(twenty_j);
            DigitsJ.Add(twenty_one_j);
            DigitsJ.Add(twenty_two_j);
            DigitsJ.Add(twenty_three_j);
            DigitsJ.Add(twenty_four_j);
            DigitsJ.Add(twenty_five_j);
            DigitsJ.Add(twenty_six_j);
            DigitsJ.Add(twenty_seven_j);
            DigitsJ.Add(twenty_eight_j);
            DigitsJ.Add(twenty_nine_j);
            DigitsJ.Add(thirty_j);
            DigitsJ.Add(thirty_one_j);
            DigitsJ.Add(thirty_two_j);
            DigitsJ.Add(thirty_three_j);
            DigitsJ.Add(thirty_four_j);
            DigitsJ.Add(thirty_five_j);
            DigitsJ.Add(thirty_six_j);
            DigitsJ.Add(thirty_seven_j);
            DigitsJ.Add(thirty_eight_j);
            DigitsJ.Add(thirty_nine_j);
            DigitsJ.Add(fourty_j);
            DigitsJ.Add(fourty_one_j);
            DigitsJ.Add(fourty_two_j);
            DigitsJ.Add(fourty_three_j);
            DigitsJ.Add(fourty_four_j);
            DigitsJ.Add(fourty_five_j);
            DigitsJ.Add(fourty_six_j);
            DigitsJ.Add(fourty_seven_j);
            DigitsJ.Add(fourty_eight_j);
            DigitsJ.Add(fourty_nine_j);
            DigitsJ.Add(fifty_j);
            DigitsJ.Add(fifty_one_j);
            DigitsJ.Add(fifty_two_j);
            DigitsJ.Add(fifty_three_j);
            DigitsJ.Add(fifty_four_j);
            DigitsJ.Add(fifty_five_j);
            DigitsJ.Add(fifty_six_j);
            DigitsJ.Add(fifty_seven_j);
            DigitsJ.Add(fifty_eight_j);
        }
        
        private void Reckon_Number(int n)
        {
            if (n == 1) { one += 1; }
            if (n == 2) { two += 1; }
            if (n == 3) { three += 1; }
            if (n == 4) { four += 1; }
            if (n == 5) { five += 1; }
            if (n == 6) { six += 1; }
            if (n == 7) { seven += 1; }
            if (n == 8) { eight += 1; }
            if (n == 9) { nine += 1; }
            if (n == 10) { ten += 1; }
            if (n == 11) { eleven += 1; }
            if (n == 12) { twelve += 1; }
            if (n == 13) { thirteen += 1; }
            if (n == 14) { fourteen += 1; }
            if (n == 15) { fifteen += 1; }
            if (n == 16) { sixteen += 1; }
            if (n == 17) { seventeen += 1; }
            if (n == 18) { eighteen += 1; }
            if (n == 19) { nineteen += 1; }
            if (n == 20) { twenty += 1; }
            if (n == 21) { twenty_one += 1; }
            if (n == 22) { twenty_two += 1; }
            if (n == 23) { twenty_three += 1; }
            if (n == 24) { twenty_four += 1; }
            if (n == 25) { twenty_five += 1; }
            if (n == 26) { twenty_six += 1; }
            if (n == 27) { twenty_seven += 1; }
            if (n == 28) { twenty_eight += 1; }
            if (n == 29) { twenty_nine += 1; }
            if (n == 30) { thirty += 1; }
            if (n == 31) { thirty_one += 1; }
            if (n == 32) { thirty_two += 1; }
            if (n == 33) { thirty_three += 1; }
            if (n == 34) { thirty_four += 1; }
            if (n == 35) { thirty_five += 1; }
            if (n == 36) { thirty_six += 1; }
            if (n == 37) { thirty_seven += 1; }
            if (n == 38) { thirty_eight += 1; }
            if (n == 39) { thirty_nine += 1; }
            if (n == 40) { fourty += 1; }
            if (n == 41) { fourty_one += 1; }
            if (n == 42) { fourty_two += 1; }
            if (n == 43) { fourty_three += 1; }
            if (n == 44) { fourty_four += 1; }
            if (n == 45) { fourty_five += 1; }
            if (n == 46) { fourty_six += 1; }
            if (n == 47) { fourty_seven += 1; }
            if (n == 48) { fourty_eight += 1; }
            if (n == 49) { fourty_nine += 1; }
            if (n == 50) { fifty += 1; }
            if (n == 51) { fifty_one += 1; }
            if (n == 52) { fifty_two += 1; }
            if (n == 53) { fifty_three += 1; }
            if (n == 54) { fifty_four += 1; }
            if (n == 55) { fifty_five += 1; }
            if (n == 56) { fifty_six += 1; }
            if (n == 57) { fifty_seven += 1; }
            if (n == 58) { fifty_eight += 1; }
        }

        private void Reckon_NumberJ(int n)
        {
            if (n == 1) { one_j += 1; }
            if (n == 2) { two_j += 1; }
            if (n == 3) { three_j += 1; }
            if (n == 4) { four_j += 1; }
            if (n == 5) { five_j += 1; }
            if (n == 6) { six_j += 1; }
            if (n == 7) { seven_j += 1; }
            if (n == 8) { eight_j += 1; }
            if (n == 9) { nine_j += 1; }
            if (n == 10) { ten_j += 1; }
            if (n == 11) { eleven_j += 1; }
            if (n == 12) { twelve_j += 1; }
            if (n == 13) { thirteen_j += 1; }
            if (n == 14) { fourteen_j += 1; }
            if (n == 15) { fifteen_j += 1; }
            if (n == 16) { sixteen_j += 1; }
            if (n == 17) { seventeen_j += 1; }
            if (n == 18) { eighteen_j += 1; }
            if (n == 19) { nineteen_j += 1; }
            if (n == 20) { twenty_j += 1; }
            if (n == 21) { twenty_one_j += 1; }
            if (n == 22) { twenty_two_j += 1; }
            if (n == 23) { twenty_three_j += 1; }
            if (n == 24) { twenty_four_j += 1; }
            if (n == 25) { twenty_five_j += 1; }
            if (n == 26) { twenty_six_j += 1; }
            if (n == 27) { twenty_seven_j += 1; }
            if (n == 28) { twenty_eight_j += 1; }
            if (n == 29) { twenty_nine_j += 1; }
            if (n == 30) { thirty_j += 1; }
            if (n == 31) { thirty_one_j += 1; }
            if (n == 32) { thirty_two_j += 1; }
            if (n == 33) { thirty_three_j += 1; }
            if (n == 34) { thirty_four_j += 1; }
            if (n == 35) { thirty_five_j += 1; }
            if (n == 36) { thirty_six_j += 1; }
            if (n == 37) { thirty_seven_j += 1; }
            if (n == 38) { thirty_eight_j += 1; }
            if (n == 39) { thirty_nine_j += 1; }
            if (n == 40) { fourty_j += 1; }
            if (n == 41) { fourty_one_j += 1; }
            if (n == 42) { fourty_two_j += 1; }
            if (n == 43) { fourty_three_j += 1; }
            if (n == 44) { fourty_four_j += 1; }
            if (n == 45) { fourty_five_j += 1; }
            if (n == 46) { fourty_six_j += 1; }
            if (n == 47) { fourty_seven_j += 1; }
            if (n == 48) { fourty_eight_j += 1; }
            if (n == 49) { fourty_nine_j += 1; }
            if (n == 50) { fifty_j += 1; }
            if (n == 51) { fifty_one_j += 1; }
            if (n == 52) { fifty_two_j += 1; }
            if (n == 53) { fifty_three_j += 1; }
            if (n == 54) { fifty_four_j += 1; }
            if (n == 55) { fifty_five_j += 1; }
            if (n == 56) { fifty_six_j += 1; }
            if (n == 57) { fifty_seven_j += 1; }
            if (n == 58) { fifty_eight_j += 1; }
        }

        private int getDigit(string input, int start, int end)
        {
            int number = 0;
            try
            {
                number = Convert.ToInt32(input.Substring(start, end));
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Please check your File format. Please make sure the line follow this format, XX-XX-XX-XX-XX XX.");
                number = -1;
                isExit = true;
            }
            
            return number;
        }

        private void Determine(List<int> Combo)
        {
            int even = 0, odd = 0;

            //Get number of odd and even
            for (int i = 0; i < Combo.Count; i++)
            {
                //MessageBox.Show(">> " + Combo[i]);
                Reckon_Number(Combo[i]);

                if (Combo[i] % 2 == 1) { odd++; }
                if (Combo[i] % 2 == 0) { even++; }
                if (Combo[i] > max_no) { max_no = Combo[i]; }
            }

            //Identify Combinations
            if ((odd == 1) && (even == 5)) { combo1++; }
            else if ((odd == 2) && (even == 4)) { combo2++; }
            else if ((odd == 3) && (even == 3)) { combo3++; }
            else if ((odd == 4) && (even == 2)) { combo4++; }
            else if ((odd == 5) && (even == 1)) { combo5++; }
            else if (odd == 6) { allOdd++; }
            else if (even == 6) { allEven++; }

            txtC1.Text = combo1.ToString();
            txtC2.Text = combo2.ToString();
            txtC3.Text = combo3.ToString();
            txtC4.Text = combo4.ToString();
            txtC5.Text = combo5.ToString();
            txtEven.Text = allEven.ToString();
            txtOdd.Text = allOdd.ToString();

            even = 0; odd = 0;
        }

        private void InitVar()
        {
            lvwWinning.Items.Clear(); lvwJackpot.Items.Clear(); lvwNo.Items.Clear(); lvwNo.Items.Clear(); lvwJackpotNoFreq.Items.Clear();

            combo1 = 0; combo2 = 0; combo3 = 0; combo4 = 0; combo5 = 0; allOdd = 0; allEven = 0;
            jackpot_c1 = 0; jackpot_c2 = 0; jackpot_c3 = 0; jackpot_c4 = 0; jackpot_c5 = 0; jackpot_even = 0; jackpot_odd = 0;
            totalDraw = 0; total_jackpot = 0; totalWinner = 0; max_no = 1; max_no_j = 1;

            one = 0; two = 0; three = 0; four = 0; five = 0; six = 0; seven = 0; eight = 0; nine = 0; ten = 0; eleven = 0; twelve = 0; thirteen = 0; fourteen = 0; fifteen = 0; sixteen = 0; seventeen = 0; eighteen = 0;
            nineteen = 0; twenty = 0; twenty_one = 0; twenty_two = 0; twenty_three = 0; twenty_four = 0; twenty_five = 0; twenty_six = 0; twenty_seven = 0; twenty_eight = 0; twenty_nine = 0;
            thirty = 0; thirty_one = 0; thirty_two = 0; thirty_three = 0; thirty_four = 0; thirty_five = 0; thirty_six = 0; thirty_seven = 0; thirty_eight = 0; thirty_nine = 0; fourty = 0;
            fourty_one = 0; fourty_two = 0; fourty_three = 0; fourty_four = 0; fourty_five = 0; fourty_six = 0; fourty_seven = 0; fourty_eight = 0; fourty_nine = 0; fifty = 0; fifty_one = 0;
            fifty_two = 0; fifty_three = 0; fifty_four = 0; fifty_five = 0; fifty_six = 0; fifty_seven = 0; fifty_eight = 0;

            one_j = 0; two_j = 0; three_j = 0; four_j = 0; five_j = 0; six_j = 0; seven_j = 0; eight_j = 0; nine_j = 0; ten_j = 0; eleven_j = 0; twelve_j = 0; thirteen_j = 0; fourteen_j = 0; fifteen_j = 0; sixteen_j = 0; seventeen_j = 0; eighteen_j = 0; nineteen_j = 0; twenty_j = 0; twenty_one_j = 0; twenty_two_j = 0; twenty_three_j = 0; twenty_four_j = 0; twenty_five_j = 0; twenty_six_j = 0; twenty_seven_j = 0; twenty_eight_j = 0; twenty_nine_j = 0; thirty_j = 0; thirty_one_j = 0; thirty_two_j = 0; thirty_three_j = 0; thirty_four_j = 0; thirty_five_j = 0; thirty_six_j = 0; thirty_seven_j = 0; thirty_eight_j = 0; thirty_nine_j = 0; fourty_j = 0; fourty_one_j = 0; fourty_two_j = 0; fourty_three_j = 0; fourty_four_j = 0; fourty_five_j = 0; fourty_six_j = 0; fourty_seven_j = 0; fourty_eight_j = 0; fourty_nine_j = 0; fifty_j = 0; fifty_one_j = 0; fifty_two_j = 0; fifty_three_j = 0; fifty_four_j = 0; fifty_five_j = 0; fifty_six_j = 0; fifty_seven_j = 0; fifty_eight_j = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitVar();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName.ToString();

                #region Open and reading a file.

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = String.Empty;
                    while (((s = sr.ReadLine()) != null) && (isExit != true) )
                    {
                        //Just displaying the winning combinations to listview.
                        string curr_comb = s;
                        string[] Wrow = { " ", s };
                        ListViewItem Witem = new ListViewItem(Wrow);
                        lvwWinning.Items.Add(Witem);
                        
                        totalDraw++;

                        #region Convert the line to numbers.

                        Winning_Combos.Add(getDigit(s, 0, 2));
                        if (isExit == true) { lvwWinning.Items.Clear(); lvwJackpot.Items.Clear(); lvwNo.Items.Clear(); lvwJackpotNoFreq.Items.Clear();  break; } s = s.Remove(0, 3);
                        Winning_Combos.Add(getDigit(s, 0, 2));
                        if (isExit == true) { lvwWinning.Items.Clear(); lvwJackpot.Items.Clear(); lvwNo.Items.Clear(); lvwJackpotNoFreq.Items.Clear();  break; } s = s.Remove(0, 3);
                        Winning_Combos.Add(getDigit(s, 0, 2));
                        if (isExit == true) { lvwWinning.Items.Clear(); lvwJackpot.Items.Clear(); lvwNo.Items.Clear(); lvwJackpotNoFreq.Items.Clear(); break; } s = s.Remove(0, 3);
                        Winning_Combos.Add(getDigit(s, 0, 2));
                        if (isExit == true) { lvwWinning.Items.Clear(); lvwJackpot.Items.Clear(); lvwNo.Items.Clear(); lvwJackpotNoFreq.Items.Clear(); break; } s = s.Remove(0, 3);
                        Winning_Combos.Add(getDigit(s, 0, 2));
                        if (isExit == true) { lvwWinning.Items.Clear(); lvwJackpot.Items.Clear(); lvwNo.Items.Clear(); lvwJackpotNoFreq.Items.Clear(); break; } s = s.Remove(0, 3);
                        Winning_Combos.Add(getDigit(s, 0, 2));
                        if (isExit == true) { lvwWinning.Items.Clear(); lvwJackpot.Items.Clear(); lvwNo.Items.Clear(); lvwJackpotNoFreq.Items.Clear(); break; } s = s.Remove(0, 3);
                        
                        #endregion

                        #region Determine the number of Jackpot hit and get jackpot number combinations
                        
                        int n = getDigit(s, 0, s.Length);
                        if (isExit == true) { lvwWinning.Items.Clear(); lvwJackpot.Items.Clear(); lvwNo.Items.Clear(); lvwJackpotNoFreq.Items.Clear(); break; } 
                        if ( (n != 0) && (isExit != true) )
                        {
                            //Get the sum of jackpot winners.
                            totalWinner += n;

                            //Add to ListView of Jackpot Combination
                            string[] Jrow = { " ", curr_comb };
                            ListViewItem Jitem = new ListViewItem(Jrow);
                            lvwJackpot.Items.Add(Jitem);

                            //Remove the jackpot combination to the list of winning combinations.
                            lvwWinning.Items.Remove(Witem);

                            //Equalize the winning combination to another list, identify the jackpot combination's category.
                            Jackpot_Combos = Winning_Combos.ToList();
                            total_jackpot++;
                        }
                        
                        #endregion

                        Determine(Winning_Combos);
                        Determine_Jackpot(Jackpot_Combos);

                        Jackpot_Combos.Clear();
                        Winning_Combos.Clear();
                    }
                }

                #endregion

                if (isExit != true)
                {

                    #region Showing frequency of each number on Winning Combinations..

                    AddNumberstoList();
                    for (int i = 0; i < max_no; i++)
                    {
                        string[] Frow = { (i + 1).ToString(), Digits[i].ToString() };
                        ListViewItem Fitem = new ListViewItem(Frow);
                        lvwNo.Items.Add(Fitem);
                    }

                    #endregion

                    #region Showing Frequency of each numbers on Jackpot Combinations.

                    AddNumberstoListJ();
                    for (int i = 0; i < max_no_j; i++)
                    {
                        string[] Frow = { (i + 1).ToString(), DigitsJ[i].ToString() };
                        ListViewItem Fitem = new ListViewItem(Frow);
                        lvwJackpotNoFreq.Items.Add(Fitem);
                    }

                    #endregion

                    lblTotalDraw.Text = "Total Draw:      " + totalDraw.ToString();
                    lblTotalJackpotHit.Text = "Total Jackpot Hit:      " + total_jackpot.ToString();
                    lblTotalWinners.Text = "Total Winners:      " + totalWinner.ToString();
                }

                //List<int> MaxNoTemp = new List<int>();
                //List<int> TempList = new List<int>();
                
                //TempList = DigitsJ.ToList();
                //int max=0, min=0, capacity=0;

                //for (int i = 0; i < TempList.Count; i++) { if (TempList[i] > max) { max = TempList[i]; } }
                //for (int i = 0; i < TempList.Count; i++) { if (TempList[i] < min) { min = TempList[i]; } }


                //MessageBox.Show("Minimum: " + min.ToString());
                //MessageBox.Show("Maximum: " + max.ToString());

                //for (int i = 0; i < TempList.Count; i++)
                //{
                //    for (int j = 0; j < TempList.Count; j++) { if (TempList[j] > max) { max = TempList[j]; } }
                //    if (TempList[i] >= max)
                //    {
                //        max = TempList[i];
                //        MaxNoTemp.Add(i);
                //        TempList.RemoveAt(i);
                //        capacity++;
                //    }
                //    if (capacity == 12) { break; }
                //}
            }

            Jackpot_Combos_String.Clear();
            Winning_Combos_String.Clear();
            Digits.Clear();

        }

        private void Determine_Jackpot(List<int> Combo)
        {
            int even = 0, odd = 0;

            //Get number of odd and even
            for (int i = 0; i < Combo.Count; i++)
            {
                Reckon_NumberJ(Combo[i]);

                if (Combo[i] % 2 == 1) { odd++; }
                if (Combo[i] % 2 == 0) { even++; }
                if (Combo[i] > max_no_j) { max_no_j = Combo[i]; }
            }

            //Identify Combinations
            if ((odd == 1) && (even == 5)) { jackpot_c1++; }
            else if ((odd == 2) && (even == 4)) { jackpot_c2++; }
            else if ((odd == 3) && (even == 3)) { jackpot_c3++; }
            else if ((odd == 4) && (even == 2)) { jackpot_c4++; }
            else if ((odd == 5) && (even == 1)) { jackpot_c5++; }
            else if (odd == 6) { jackpot_even++; }
            else if (even == 6) { jackpot_odd++; }

            lblC1J.Text = jackpot_c1.ToString();
            lblC2J.Text = jackpot_c2.ToString();
            lblC3J.Text = jackpot_c3.ToString();
            lblC4J.Text = jackpot_c4.ToString();
            lblC5J.Text = jackpot_c5.ToString();
            lblEvenJ.Text = jackpot_even.ToString();
            lblOddJ.Text = jackpot_odd.ToString();

            even = 0; odd = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Determine_Input(List<int> Combo)
        {
            int even = 0, odd = 0;

            //Get number of odd and even
            for (int i = 0; i < Combo.Count; i++)
            {
                if (Combo[i] % 2 == 1) { odd++; }
                if (Combo[i] % 2 == 0) { even++; }
            }

            //Identify Combinations
            if ((odd == 1) && (even == 5)) { MessageBox.Show("1 Odd and 5 Even."); }
            else if ((odd == 2) && (even == 4)) { MessageBox.Show("2 Odd and 4 Even."); }
            else if ((odd == 3) && (even == 3)) { MessageBox.Show("3 Odd and 3 Even."); }
            else if ((odd == 4) && (even == 2)) { MessageBox.Show("4 Odd and 2 Even."); }
            else if ((odd == 5) && (even == 1)) { MessageBox.Show("5 Odd and 1 Even."); }
            else if (odd == 6) { MessageBox.Show("All odd numbers."); }
            else if (even == 6) { MessageBox.Show("All even numbers."); }

            even = 0; odd = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> InputList = new List<int>();

            string s = textBox1.Text;
            InputList.Add(getDigit(s, 0, 2)); s = s.Remove(0, 3);
            InputList.Add(getDigit(s, 0, 2)); s = s.Remove(0, 3);
            InputList.Add(getDigit(s, 0, 2)); s = s.Remove(0, 3);
            InputList.Add(getDigit(s, 0, 2)); s = s.Remove(0, 3);
            InputList.Add(getDigit(s, 0, 2)); s = s.Remove(0, 3);
            InputList.Add(getDigit(s, 0, s.Length));

            Determine_Input(InputList);
            InputList.Clear();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") { button2.Enabled = true; }
            else { button2.Enabled = false; }
        }

        private void lvwNo_MouseHover(object sender, EventArgs e)
        {
            ToolTip tTip = new ToolTip();
            tTip.SetToolTip(lvwNo, "Shows each numbers' frequency on Winning Combination.");
            tTip.InitialDelay = 100;
        }

        private void lvwWinning_MouseHover(object sender, EventArgs e)
        {
            ToolTip tTip = new ToolTip();
            tTip.SetToolTip(lvwWinning, "Shows Winning Combinations from a particular time period.");
            tTip.InitialDelay = 100;
        }

        private void lvwJackpot_MouseHover(object sender, EventArgs e)
        {
            ToolTip tTip = new ToolTip();
            tTip.SetToolTip(lvwJackpot, "Shows Jackpot Combinations from a particular time period.");
            tTip.InitialDelay = 100;
        }

        private void lvwJackpotNoFreq_MouseHover(object sender, EventArgs e)
        {
            ToolTip tTip = new ToolTip();
            tTip.SetToolTip(lvwJackpotNoFreq, "Shows each numbers' frequency on Jackpot Combination.");
            tTip.InitialDelay = 100;
        }
    }
}
