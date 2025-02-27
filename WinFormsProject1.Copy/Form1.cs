namespace WinFormsProject1.Copy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "GUESS THE NUMBER";
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            button1.Show();
            button1.Text = "START";
            button2.Show();
            button2.Text = "EXIT";
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "         MAIN MENU";
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Show();
            button3.Text = "PLAY";
            button3.Click += button3_Click;
            button4.Show();
            button4.Text = "STATISTICS";
            button4.Click += button4_Click;
            button5.Show();
            button5.Text = "INSTRUCTIONS";
            button5.Click += button5_Click;
            button5.Location = new Point(0, 540);
            button6.Show();
            button6.Text = "BACK";
            button6.Click += Form1_Load;
            button6.Location = new Point(0, 632);
            button6.TextAlign = ContentAlignment.MiddleCenter;
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 1";
            label2.Show();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button7_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "         STATISTICS";
            label2.Show();
            label2.Text = "GAMES : ";
            label3.Show();
            label3.Text = "ROUNDS : ";
            label4.Show();
            label4.Text = "ATTEMPTS : ";
            label5.Show();
            label5.Text = "TIME : ";
            label6.Show();
            label6.Text = "DATE : ";
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Hide();
            button8.Show();
            button8.Text = "CLEAR";
            button8.Click += button8_Click;
            button8.Location = new Point(0, 890);
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "      INSTRUCTIONS";
            label2.Show();
            label2.Text = "EACH GAME HAS 3 ROUNDS.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label3.Show();
            label3.Text = "YOU HAVE 5 ATTEMPTS PER ROUND.";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label4.Show();
            label4.Text = "IF YOU BURN ALL ATTEMPTS, YOU LOSE THE ROUND.";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label5.Show();
            label5.Text = "USING NUMPAD ON YOUR KEYBOARD IS RECOMMENDED.";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label6.Hide();
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 1";
            label2.Show();
            label2.Text = "PICK A NUMBER FROM 1 TO 5";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Hide();
            button7.Text = "CHOOSE";
            button7.Click += button7_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Show();
            checkBox1.Text = "1";
            checkBox1.Click += checkBox1_Click;
            checkBox1.Location = new Point(16, 295);
            checkBox2.Show();
            checkBox2.Text = "2";
            checkBox2.Click += checkBox2_Click;
            checkBox2.Location = new Point(184, 295);
            checkBox3.Show();
            checkBox3.Text = "3";
            checkBox3.Click += checkBox3_Click;
            checkBox3.Location = new Point(352, 295);
            checkBox4.Show();
            checkBox4.Text = "4";
            checkBox4.Click += checkBox4_Click;
            checkBox4.Location = new Point(520, 295);
            checkBox5.Show();
            checkBox5.Text = "5";
            checkBox5.Click += checkBox5_Click;
            checkBox5.Location = new Point(688, 295);
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
/*            const int limitaInferioara = 1;
            const int limitaSuperioara = 5;
            Random generatorDeNumereAleatoare = new Random();
            int[] arrayDeNumere = new int[1];
            for (int n = 0; n < arrayDeNumere.Length; n++)
            {
                arrayDeNumere[n] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                if (n == arrayDeNumere[n])
                {

                }
                if (n != arrayDeNumere[n])
                {
                    arrayDeNumere[n] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                    if (n != arrayDeNumere[n])
                    {
                        if (n == arrayDeNumere[n] - 1)
                        {

                        }
                        if (n == arrayDeNumere[n] + 1)
                        {

                        }
                        if (n == arrayDeNumere[n] - 2)
                        {

                        }
                        if (n == arrayDeNumere[n] + 2)
                        {

                        }
                    }
                }
            }*/
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 1";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+ + + +    ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button7_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 1";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+ + +      ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button7_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 1";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+ +        ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button7_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 1";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+          ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button7_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 1";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "           ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Hide();
            button7.Text = "CHOOSE";
            button7.Click += button7_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Show();
            button9.Text = "CONTINUE";
            button9.Click += button10_Click;
            button9.Location = new Point(0, 890);
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "         STATISTICS";
            label2.Show();
            label2.Text = "GAMES : 0";
            label3.Show();
            label3.Text = "ROUNDS : 0";
            label4.Show();
            label4.Text = "ATTEMPTS : 0";
            label5.Show();
            label5.Text = "TIME : 0";
            label6.Show();
            label6.Text = "DATE : 0";
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Hide();
            button8.Show();
            button8.Text = "CLEAR";
            button8.Location = new Point(0, 890);
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 1";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Show();
            label3.Text = "CONTINUE TO ROUND 2";
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "RIGHT  NUMBER  YOU  WIN";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Hide();
            button7.Text = "CHOOSE";
            button7.Click += button7_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Show();
            button9.Text = "CONTINUE";
            button9.Click += button10_Click;
            button9.Location = new Point(0, 890);
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 2";
            label2.Show();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button11_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button9.Text = "CONTINUE";
            button9.Click += button10_Click;
            button9.Location = new Point(0, 890);
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 2";
            label2.Show();
            label2.Text = "PICK A NUMBER FROM 1 TO 5";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Hide();
            button7.Text = "CHOOSE";
            button7.Click += button11_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button9.Text = "CONTINUE";
            button9.Click += button10_Click;
            button9.Location = new Point(0, 890);
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Show();
            checkBox6.Text = "1";
            checkBox6.Click += checkBox6_Click;
            checkBox6.Location = new Point(16, 295);
            checkBox7.Show();
            checkBox7.Text = "2";
            checkBox7.Click += checkBox7_Click;
            checkBox7.Location = new Point(184, 295);
            checkBox8.Show();
            checkBox8.Text = "3";
            checkBox8.Click += checkBox8_Click;
            checkBox8.Location = new Point(352, 295);
            checkBox9.Show();
            checkBox9.Text = "4";
            checkBox9.Click += checkBox9_Click;
            checkBox9.Location = new Point(520, 295);
            checkBox10.Show();
            checkBox10.Text = "5";
            checkBox10.Click += checkBox10_Click;
            checkBox10.Location = new Point(688, 295);
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
/*            const int limitaInferioara = 1;
            const int limitaSuperioara = 5;
            Random generatorDeNumereAleatoare = new Random();
            int[] arrayDeNumere = new int[1];
            for (int n = 0; n < arrayDeNumere.Length; n++)
            {
                arrayDeNumere[n] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                if (n == arrayDeNumere[n])
                {

                }
                if (n != arrayDeNumere[n])
                {
                    arrayDeNumere[n] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                    if (n != arrayDeNumere[n])
                    {
                        if (n == arrayDeNumere[n] - 1)
                        {

                        }
                        if (n == arrayDeNumere[n] + 1)
                        {

                        }
                        if (n == arrayDeNumere[n] - 2)
                        {

                        }
                        if (n == arrayDeNumere[n] + 2)
                        {

                        }
                    }
                }
            }*/
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 2";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+ + + +    ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button11_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 2";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+ + +      ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button11_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 2";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+ +        ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button11_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 2";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+          ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button11_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 2";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "           ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Hide();
            button7.Text = "CHOOSE";
            button7.Click += button11_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Show();
            button9.Text = "CONTINUE";
            button9.Click += button12_Click;
            button9.Location = new Point(0, 890);
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 3";
            label2.Show();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button13_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button9.Text = "CONTINUE";
            button9.Click += button10_Click;
            button9.Location = new Point(0, 890);
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 3";
            label2.Show();
            label2.Text = "PICK A NUMBER FROM 1 TO 5";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Hide();
            button7.Text = "CHOOSE";
            button7.Click += button12_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button9.Text = "CONTINUE";
            button9.Click += button10_Click;
            button9.Location = new Point(0, 890);
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox11.Show();
            checkBox11.Text = "1";
            checkBox11.Click += checkBox11_Click;
            checkBox11.Location = new Point(16, 295);
            checkBox12.Show();
            checkBox12.Text = "2";
            checkBox12.Click += checkBox12_Click;
            checkBox12.Location = new Point(184, 295);
            checkBox13.Show();
            checkBox13.Text = "3";
            checkBox13.Click += checkBox13_Click;
            checkBox13.Location = new Point(352, 295);
            checkBox14.Show();
            checkBox14.Text = "4";
            checkBox14.Click += checkBox14_Click;
            checkBox14.Location = new Point(520, 295);
            checkBox15.Show();
            checkBox15.Text = "5";
            checkBox15.Click += checkBox15_Click;
            checkBox15.Location = new Point(688, 295);
/*            const int limitaInferioara = 1;
            const int limitaSuperioara = 5;
            Random generatorDeNumereAleatoare = new Random();
            int[] arrayDeNumere = new int[1];
            for (int n = 0; n < arrayDeNumere.Length; n++)
            {
                arrayDeNumere[n] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                if (n == arrayDeNumere[n])
                {

                }
                if (n != arrayDeNumere[n])
                {
                    arrayDeNumere[n] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                    if (n != arrayDeNumere[n])
                    {
                        if (n == arrayDeNumere[n] - 1)
                        {

                        }
                        if (n == arrayDeNumere[n] + 1)
                        {

                        }
                        if (n == arrayDeNumere[n] - 2)
                        {

                        }
                        if (n == arrayDeNumere[n] + 2)
                        {

                        }
                    }
                }
            }*/
        }
        private void checkBox11_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 3";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+ + + +    ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button12_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 3";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+ + +      ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button12_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 3";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+ +        ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button12_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 3";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "+          ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Show();
            button7.Text = "CHOOSE";
            button7.Click += button12_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           ROUND 3";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
            label7.Text = "           ATTEMPTS  WRONG  NUMBER";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Hide();
            button7.Text = "CHOOSE";
            button7.Click += button12_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Show();
            button9.Text = "CONTINUE";
            button9.Click += button14_Click;
            button9.Location = new Point(0, 890);
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "           GAME OVER";
            label2.Hide();
            label2.Text = "+ + + + +  ATTEMPTS";
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Show();
            button6.Text = "BACK";
            button6.Click += button1_Click;
            button6.Location = new Point(0, 982);
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button7.Hide();
            button7.Text = "CHOOSE";
            button7.Click += button13_Click;
            button7.Location = new Point(0, 890);
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button8.Hide();
            button9.Hide();
            button9.Text = "CONTINUE";
            button9.Click += button10_Click;
            button9.Location = new Point(0, 890);
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
        }
    }
}
