﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SevenZip.Compression.LZMA;

using System.IO;

using System.Windows;

namespace MinesProgram
{
    public partial class Form1 : Form
    {
        bool IsClicked = false;
        bool test2 = false;

        
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            richTextBox1.Text = "03.01.2020\n\n              Новое в сборке 1.00.0\n\n - Релиз программы\n - Выход из закрытой беты\n\n";
            textBox1.Text = "Введите программу";//подсказка
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Введите программу";//подсказка
            textBox2.ForeColor = Color.Gray;
            label6.Text = "Сборка 1.00.3";
            label2.Text = "Версия 1.1";
            checkBox1.Enabled = false;
            checkBox1.Visible = false;
            label8.Text = "Программа от группы";
            linkLabel1.Text = "Новости Шахт";
        }

        static void ShiftElements(int[] arr)
        {
            int last = arr[arr.Length - 1];

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                arr[i + 1] = arr[i];
            }

            arr[0] = last;
        }

        static void massiv(string[] txn)
        {
            
            string[] sim1 = { "-", "=", "~" };
            string[] sim2 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "[", "]", "{", "}", ",", ".", "<", ">", "?", "/", ";", ":", "|", "~" };
            int f = 0; int t = 1; int gss = 0;

            for (int i = 0; i < txn.Length; i++)
            {
                txn[0] = "_";

                if (i < 90 && i > 0)
                {



                    if (f < sim2.Length)
                    {
                        txn[i] = sim1[0] + sim2[f + 2];
                        f++;
                    }
                    if (f == sim2.Length) f = 0;





                }

                if (i > 89)
                {
                    if (t < 10)
                    {
                        if (gss < sim2.Length)
                        {
                            txn[i] = sim1[1] + t + sim2[gss];
                            gss++;
                        }
                        if (gss == sim2.Length) { gss = 0; t++; }
                    }
                    else
                    {
                        if (gss < sim2.Length)
                        {
                            txn[i] = sim1[2] + t + sim2[gss];
                            gss++;
                        }
                        if (gss == sim2.Length) { gss = 0; t++; }
                    }

                }

            }
        }

        static void zamena(string str)
        {
            
            string a = "Z"; string b = "0";

            string[] simvoly = str.Split((new[] { "," }), StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < simvoly.Length; i++)
            {
                if (simvoly[i] == a)
                {
                    simvoly[i] = ",";
                }
            }
            string str1 = "";
            str1 = string.Join("", simvoly);
            str = str1;

        }

        static void massiv2(string[] txn1)
        {
            string[] sim1 = { "-", "=", "~" };
            string[] sim2 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "[", "]", "{", "}", ",", ".", "<", ">", "?", "/", ";", ":", "|", "~" };
            int f = 0; int t = 1; int gss = 0;
            for (int i = 0; i < txn1.Length; i++)
            {
                txn1[0] = "_";

                if (i < 90 && i > 0)
                {



                    if (f < sim2.Length)
                    {
                        txn1[i] = sim2[f + 2];
                        f++;
                    }
                    if (f == sim2.Length) f = 0;





                }

                if (i > 89)
                {
                    if (t < 10)
                    {
                        if (gss < sim2.Length)
                        {
                            txn1[i] = t + sim2[gss];
                            gss++;
                        }
                        if (gss == sim2.Length) { gss = 0; t++; }
                    }
                    else
                    {
                        if (gss < sim2.Length)
                        {
                            txn1[i] = t + sim2[gss];
                            gss++;
                        }
                        if (gss == sim2.Length) { gss = 0; t++; }
                    }

                }


            }

        }

        static void Cut(ref string[] array, int startIndex, int numberOfElements)
        {
            string[] tempArr = new string[array.Length - numberOfElements];
            int counter = 0;
            for (int j = 0; j < startIndex; j++)
            {
                tempArr[counter++] = array[j];
            }
            for (int j = startIndex + numberOfElements; j < array.Length; j++)
            {
                tempArr[counter++] = array[j];
            }
            array = tempArr;
        }

        static string[] Delete(string[] array, int indexToDelete)
        {
            var output = new string[array.Length - 1];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == indexToDelete) continue;
                output[counter] = array[i];
                counter++;
            }

            return output;
        }

        private Point mouseOffset;
        private bool isMouseDown = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Раздел в разработке", "Внимание!");

        }
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }



        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //тут код, который нужно выполнить, если нажали кнопку Нет
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            richTextBox2.Enabled = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            button6.Visible = false;
            button6.Enabled = false;
            textBox2.Visible = false;
            textBox2.Enabled = false;
            button9.Visible = false;
            button9.Enabled = false;
            richTextBox3.Visible = false;
            richTextBox3.Enabled = false;
            checkBox1.Enabled = false;
            checkBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label2.Visible = false;
            richTextBox1.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label5.Visible = true;
            label3.Visible = true;
            richTextBox2.Visible = true;
            richTextBox2.Enabled = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            button6.Visible = true;
            button6.Enabled = true;
            textBox2.Visible = false;
            textBox2.Enabled = false;
            button9.Visible = false;
            button9.Enabled = false;
            richTextBox3.Visible = false;
            richTextBox3.Enabled = false;
            checkBox1.Enabled = false;
            checkBox1.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label2.Visible = false;
            label6.Visible = false;
            richTextBox1.Visible = false;
            pictureBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox2.Enabled = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            button6.Visible = false;
            button6.Enabled = false;
            textBox2.Visible = true;
            textBox2.Enabled = true;
            button9.Visible = true;
            button9.Enabled = true;
            richTextBox3.Visible = true;
            richTextBox3.Enabled = true;
            //checkBox1.Enabled = true;
            //checkBox1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите программу")
            {
                textBox1.Text = null;
                //    textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {
            if (textBox1.Visible == false && textBox1.Text == "")
            {
                textBox1.Text = "Введите программу";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите программу")
            {
                textBox2.Text = null;
                //    textBox1.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_VisibleChanged(object sender, EventArgs e)
        {
            if (textBox2.Visible == false && textBox2.Text == "")
            {
                textBox2.Text = "Введите программу";//подсказка
                textBox2.ForeColor = Color.Gray;
            }
        }
        private void button6_Click_1(object sender, EventArgs e)// конвертация в старый код+
        {
            //
            string[] tx3 = new string[3071];
            massiv2(tx3);
            int num = 0;
            string s = textBox1.Text;
            if (s.Trim() != "")
            {
                byte[] array = SevenZipHelper.Decompress(Convert.FromBase64String(s));

                num = BitConverter.ToInt32(array, 0);
                int[] number = new int[16 * 12 * 16];
                string t;
                t = BitConverter.ToString(array);

                string h = Encoding.UTF8.GetString(array);
                string[] valu = t.Split('-');

                //тестовая функция
                string[] tmp1 = new string[valu.Length];

                for (int i = 0; i < valu.Length; i++)
                {
                    tmp1[i] = Convert.ToInt32(valu[i], 16).ToString();
                }

                int g = 0;
                for (int i = 4; i < num + 4; i++)
                {
                    if (tmp1[i] == "40")
                    {
                        g += 1;
                    }
                }
                int[] number1 = new int[g];
                int gg = 0;
                for (int i = 4; i < num + 4; i++)
                {

                    if (tmp1[i] == "40" && gg <= g)
                    {
                        number1[gg] = i - 4;
                        gg++;
                    }
                    //gg++;

                }
                string f = String.Join(" ", number1);
                Cut(ref valu, num + 4, array.Length - num - 4);
                Cut(ref valu, 0, 4);
                string[] tmp = new string[valu.Length];




                for (int i = 0; i < valu.Length; i++)
                {

                    tmp[i] = Convert.ToInt32(valu[i], 16).ToString();
                    


                }
                MessageBox.Show("Прога сконвертировалась в старый код и скопирована в буфер обмена!", "Сконвертировано!");
                               
                int[] nums = new int[16 * 12 * 16];
                int[] codes = new int[16 * 12 * 16];
                string[] code_labels = new string[16 * 12 * 16];

                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        for (int k = 0; k < 16; k++)
                        {
                            codes[i * 16 * 12 + j * 16 + k] = 0;
                            nums[i * 16 * 12 + j * 16 + k] = 0;
                            code_labels[i * 16 * 12 + j * 16 + k] = "0";
                        }
                    }
                }


                int n = BitConverter.ToInt32(array, 0);
                for (int i = 0; i < n; i++)
                {
                    codes[i] = (int)Convert.ToInt16(array[i + 4]);
                }
                string[] array2 = Encoding.UTF8.GetString(array, num + 4, array.Length - num - 4).Split(new char[]
                {
                 ':'
                });
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j].Contains("@"))
                    {
                        string[] array3 = array2[j].Split(new char[]
                        {
                            '@'
                        });
                        code_labels[j] = array3[0];
                        nums[j] = int.Parse(array3[1]);
                    }
                    else
                    {
                        code_labels[j] = array2[j];
                        nums[j] = 0;
                    }
                }
                string[] str_codes = new string[codes.Length];
                for (int i = 0; i < codes.Length; i++)
                {
                    str_codes[i] = codes[i].ToString();

                }
                string[] cod = new string[tmp.Length];
                for (int i = 0; i < tmp.Length; i++)
                {
                    cod[i] = tmp[i];
                }
                string[] s1 = new string[tmp.Length - 1];

                int[] s100 = new int[33];
                for (int i = 0; i < s100.Length; i++)
                {
                    s100[i] = i + 1;
                }

                if (tmp.Length == 2 && tmp[1] == "0")
                {
                    for (int i = 0; i < s1.Length; i++)
                    {
                        s1[i] = tmp[i];
                    }
                    for (int j = 0; j < s1.Length; j++)
                    {
                        if (s1[j] == "24")
                        {
                            s1[j] = "G2(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "25")
                        {
                            s1[j] = "G3(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "26")
                        {
                            s1[j] = "G4(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "40")
                        {
                            s1[j] = "L(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "137")
                        {
                            s1[j] = "G5(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "139")
                        {
                            s1[j] = "G0(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "140")
                        {
                            s1[j] = "G1(" + code_labels[j] + ")";
                        }


                        ////
                        if (s1[j] == "1")
                        {
                            s1[j] = "\\";
                        }
                        if (s1[j] == "2")
                        {
                            s1[j] = ">";
                        }
                        if (s1[j] == "3")
                        {
                            s1[j] = "<";
                        }
                        if (s1[j] == "4")
                        {
                            s1[j] = "W";
                        }
                        if (s1[j] == "5")
                        {
                            s1[j] = "A";
                        }
                        if (s1[j] == "6")
                        {
                            s1[j] = "S";
                        }
                        if (s1[j] == "7")
                        {
                            s1[j] = "D";
                        }
                        if (s1[j] == "8")
                        {
                            s1[j] = "Z0";
                        }
                        if (s1[j] == "9")
                        {
                            s1[j] = "w";
                        }
                        if (s1[j] == "10")
                        {
                            s1[j] = "a";
                        }
                        if (s1[j] == "11")
                        {
                            s1[j] = "s";
                        }
                        if (s1[j] == "12")
                        {
                            s1[j] = "d";
                        }
                        if (s1[j] == "13")
                        {
                            //???
                        }
                        if (s1[j] == "14")
                        {
                            s1[j] = "Z2";
                        }
                        if (s1[j] == "15")
                        {
                            s1[j] = "Z3";
                        }
                        if (s1[j] == "16")
                        {
                            s1[j] = "Z4";
                        }
                        if (s1[j] == "17")
                        {
                            s1[j] = "Zc";
                        }
                        if (s1[j] == "18")
                        {
                            s1[j] = "Ze";
                        }
                        if (s1[j] == "19")
                        {
                            s1[j] = "Zd";
                        }
                        if (s1[j] == "20")
                        {
                            s1[j] = "Zf";
                        }
                        if (s1[j] == "21")
                        {
                            s1[j] = "Zg";
                        }
                        if (s1[j] == "22")
                        {
                            s1[j] = "Zq";
                        }
                        if (s1[j] == "23")
                        {
                            s1[j] = "Zh";
                        }
                        if (s1[j] == "27")
                        {
                            s1[j] = "R0";
                        }
                        if (s1[j] == "28")
                        {
                            s1[j] = "R1";
                        }
                        if (s1[j] == "138")
                        {
                            s1[j] = "R2";
                        }
                        if (s1[j] == "29")
                        {
                            s1[j] = "C0";
                        }
                        if (s1[j] == "30")
                        {
                            s1[j] = "C8";
                        }
                        if (s1[j] == "31")
                        {
                            s1[j] = "C1";
                        }
                        if (s1[j] == "32")
                        {
                            s1[j] = "C2";
                        }
                        if (s1[j] == "33")
                        {
                            s1[j] = "C3";
                        }
                        if (s1[j] == "35")
                        {
                            s1[j] = "C5";
                        }
                        if (s1[j] == "36")
                        {
                            s1[j] = "C6";
                        }
                        if (s1[j] == "37")
                        {
                            s1[j] = "C7";
                        }
                        if (s1[j] == "38")
                        {
                            s1[j] = "M0";
                        }
                        if (s1[j] == "39")
                        {
                            s1[j] = "M1";
                        }
                        if (s1[j] == "43")
                        {
                            s1[j] = "c0";
                        }
                        if (s1[j] == "44")
                        {
                            s1[j] = "c1";
                        }
                        if (s1[j] == "45")
                        {
                            s1[j] = "c2";
                        }
                        if (s1[j] == "46")
                        {
                            s1[j] = "ck";
                        }
                        if (s1[j] == "47")
                        {
                            s1[j] = "cl";
                        }
                        if (s1[j] == "48")
                        {
                            s1[j] = "cj";
                        }
                        if (s1[j] == "49")
                        {
                            s1[j] = "cd";
                        }
                        if (s1[j] == "50")
                        {
                            s1[j] = "cm";
                        }
                        if (s1[j] == "51")
                        {
                            s1[j] = "cn";
                        }
                        if (s1[j] == "52")
                        {
                            s1[j] = "cv";
                        }
                        if (s1[j] == "53")
                        {
                            s1[j] = "ca";
                        }
                        if (s1[j] == "54")
                        {
                            s1[j] = "ci";
                        }
                        if (s1[j] == "57")
                        {
                            s1[j] = "ce";
                        }
                        if (s1[j] == "58")
                        {
                            s1[j] = "cf";
                        }
                        if (s1[j] == "59")
                        {
                            s1[j] = "cg";
                        }
                        if (s1[j] == "60")
                        {
                            s1[j] = "ch";
                        }
                        if (s1[j] == "74")
                        {
                            s1[j] = "ct";
                        }
                        if (s1[j] == "76")
                        {
                            s1[j] = "cu";
                        }
                        if (s1[j] == "77")
                        {
                            s1[j] = "cs";
                        }
                        if (s1[j] == "162")
                        {
                            s1[j] = "B1";
                        }
                        if (s1[j] == "163")
                        {
                            s1[j] = "B3";
                        }
                        if (s1[j] == "164")
                        {
                            s1[j] = "B2";
                        }
                        if (s1[j] == "165")
                        {
                            s1[j] = "VB";
                        }
                        if (s1[j] == "131")
                        {
                            s1[j] = "C9";
                        }
                        if (s1[j] == "132")
                        {
                            s1[j] = "Ca";
                        }
                        if (s1[j] == "133")
                        {
                            s1[j] = "Cb";
                        }
                        if (s1[j] == "134")
                        {
                            s1[j] = "Cc";
                        }
                        if (s1[j] == "135")
                        {
                            s1[j] = "Cd";
                        }
                        if (s1[j] == "136")
                        {
                            s1[j] = "Ce";
                        }
                        if (s1[j] == "158")
                        {
                            s1[j] = "Qig+";
                        }
                        if (s1[j] == "159")
                        {
                            s1[j] = "Qig-";
                        }
                        if (s1[j] == "160")
                        {
                            s1[j] = "gr+";
                        }
                        if (s1[j] == "161")
                        {
                            s1[j] = "gr-";
                        }
                        if (s1[j] == "120")
                        {
                            s1[j] = "VLe(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (s1[j] == "119")
                        {
                            s1[j] = "VMore(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (s1[j] == "123")
                        {
                            s1[j] = "VEqu(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (s1[j] == "141")
                        {
                            s1[j] = "iggS";
                        }
                        if (s1[j] == "142")
                        {
                            s1[j] = "Build";
                        }
                        if (s1[j] == "143")
                        {
                            s1[j] = "Hea";
                        }
                        if (s1[j] == "145")
                        {
                            s1[j] = "MineS";
                        }
                        if (s1[j] == "156")
                        {
                            s1[j] = "CLeftH";
                        }
                        if (s1[j] == "157")
                        {
                            s1[j] = "CRightH";
                        }

                        if (s1[j] == "146")
                        {
                            s1[j] = "CGun";
                        }
                        if (s1[j] == "147")
                        {
                            s1[j] = "FGun";
                        }
                        if (s1[j] == "148")
                        {
                            s1[j] = "hpf";
                        }
                        if (s1[j] == "149")
                        {
                            s1[j] = "hpp";
                        }
                        if (s1[j] == "144")
                        {
                            s1[j] = "Flip";
                        }
                        
                    }

                    richTextBox2.Text = string.Join(" ", s1);
                }
                else
                {
                    for (int i = 0; i < tmp.Length; i++)
                    {

                    }



                    for (int j = 0; j < tmp.Length; j++)
                    {
                        if (tmp[j] == "24")
                        {
                            tmp[j] = "G2(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "25")
                        {
                            tmp[j] = "G3(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "26")
                        {
                            tmp[j] = "G4(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "40")
                        {
                            tmp[j] = "L(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "137")
                        {
                            tmp[j] = "G5(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "139")
                        {
                            tmp[j] = "G0(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "140")
                        {
                            tmp[j] = "G1(" + code_labels[j] + ")";
                        }


                        ////
                        if (tmp[j] == "1")
                        {
                            tmp[j] = "\\";
                        }
                        if (tmp[j] == "2")
                        {
                            tmp[j] = ">";
                        }
                        if (tmp[j] == "3")
                        {
                            tmp[j] = "<";
                        }
                        if (tmp[j] == "4")
                        {
                            tmp[j] = "W";
                        }
                        if (tmp[j] == "5")
                        {
                            tmp[j] = "A";
                        }
                        if (tmp[j] == "6")
                        {
                            tmp[j] = "S";
                        }
                        if (tmp[j] == "7")
                        {
                            tmp[j] = "D";
                        }
                        if (tmp[j] == "8")
                        {
                            tmp[j] = "Z0";
                        }
                        if (tmp[j] == "9")
                        {
                            tmp[j] = "w";
                        }
                        if (tmp[j] == "10")
                        {
                            tmp[j] = "a";
                        }
                        if (tmp[j] == "11")
                        {
                            tmp[j] = "s";
                        }
                        if (tmp[j] == "12")
                        {
                            tmp[j] = "d";
                        }
                        if (tmp[j] == "13")
                        {

                        }
                        if (tmp[j] == "14")
                        {
                            tmp[j] = "Z2";
                        }
                        if (tmp[j] == "15")
                        {
                            tmp[j] = "Z3";
                        }
                        if (tmp[j] == "16")
                        {
                            tmp[j] = "Z4";
                        }
                        if (tmp[j] == "17")
                        {
                            tmp[j] = "Zc";
                        }
                        if (tmp[j] == "18")
                        {
                            tmp[j] = "Ze";
                        }
                        if (tmp[j] == "19")
                        {
                            tmp[j] = "Zd";
                        }
                        if (tmp[j] == "20")
                        {
                            tmp[j] = "Zf";
                        }
                        if (tmp[j] == "21")
                        {
                            tmp[j] = "Zg";
                        }
                        if (tmp[j] == "22")
                        {
                            tmp[j] = "Zq";
                        }
                        if (tmp[j] == "23")
                        {
                            tmp[j] = "Zh";
                        }

                        if (tmp[j] == "27")
                        {
                            tmp[j] = "R0";
                        }
                        if (tmp[j] == "28")
                        {
                            tmp[j] = "R1";
                        }
                        if (tmp[j] == "138")
                        {
                            tmp[j] = "R2";
                        }
                        if (tmp[j] == "29")
                        {
                            tmp[j] = "C0";
                        }
                        if (tmp[j] == "30")
                        {
                            tmp[j] = "C8";
                        }
                        if (tmp[j] == "31")
                        {
                            tmp[j] = "C1";
                        }
                        if (tmp[j] == "32")
                        {
                            tmp[j] = "C2";
                        }
                        if (tmp[j] == "33")
                        {
                            tmp[j] = "C3";
                        }
                        if (tmp[j] == "35")
                        {
                            tmp[j] = "C5";
                        }
                        if (tmp[j] == "36")
                        {
                            tmp[j] = "C6";
                        }
                        if (tmp[j] == "37")
                        {
                            tmp[j] = "C7";
                        }
                        if (tmp[j] == "38")
                        {
                            tmp[j] = "M0";
                        }
                        if (tmp[j] == "39")
                        {
                            tmp[j] = "M1";
                        }
                        if (tmp[j] == "43")
                        {
                            tmp[j] = "c0";
                        }
                        if (tmp[j] == "44")
                        {
                            tmp[j] = "c1";
                        }
                        if (tmp[j] == "45")
                        {
                            tmp[j] = "c2";
                        }


                        if (tmp[j] == "46")
                        {
                            tmp[j] = "ck";
                        }
                        if (tmp[j] == "47")
                        {
                            tmp[j] = "cl";
                        }
                        if (tmp[j] == "48")
                        {
                            tmp[j] = "cj";
                        }
                        if (tmp[j] == "49")
                        {
                            tmp[j] = "cd";
                        }
                        if (tmp[j] == "50")
                        {
                            tmp[j] = "cm";
                        }
                        if (tmp[j] == "51")
                        {
                            tmp[j] = "cn";
                        }
                        if (tmp[j] == "52")
                        {
                            tmp[j] = "cv";
                        }
                        if (tmp[j] == "53")
                        {
                            tmp[j] = "ca";
                        }
                        if (tmp[j] == "54")
                        {
                            tmp[j] = "ci";
                        }
                        if (tmp[j] == "57")
                        {
                            tmp[j] = "ce";
                        }
                        if (tmp[j] == "58")
                        {
                            tmp[j] = "cf";
                        }
                        if (tmp[j] == "59")
                        {
                            tmp[j] = "cg";
                        }
                        if (tmp[j] == "60")
                        {
                            tmp[j] = "ch";
                        }
                        if (tmp[j] == "74")
                        {
                            tmp[j] = "ct";
                        }
                        if (tmp[j] == "76")
                        {
                            tmp[j] = "cu";
                        }
                        if (tmp[j] == "77")
                        {
                            tmp[j] = "cs";
                        }
                        if (tmp[j] == "162")
                        {
                            tmp[j] = "B1";
                        }
                        if (tmp[j] == "163")
                        {
                            tmp[j] = "B3";
                        }
                        if (tmp[j] == "164")
                        {
                            tmp[j] = "B2";
                        }
                        if (tmp[j] == "165")
                        {
                            tmp[j] = "VB";
                        }
                        if (tmp[j] == "131")
                        {
                            tmp[j] = "C9";
                        }
                        if (tmp[j] == "132")
                        {
                            tmp[j] = "Ca";
                        }
                        if (tmp[j] == "133")
                        {
                            tmp[j] = "Cb";
                        }
                        if (tmp[j] == "134")
                        {
                            tmp[j] = "Cc";
                        }
                        if (tmp[j] == "135")
                        {
                            tmp[j] = "Cd";
                        }
                        if (tmp[j] == "136")
                        {
                            tmp[j] = "Ce";
                        }
                        if (tmp[j] == "158")
                        {
                            tmp[j] = "Qig+";
                        }
                        if (tmp[j] == "159")
                        {
                            tmp[j] = "Qig-";
                        }
                        if (tmp[j] == "160")
                        {
                            tmp[j] = "gr+";
                        }
                        if (tmp[j] == "161")
                        {
                            tmp[j] = "gr-";
                        }
                        if (tmp[j] == "120")
                        {
                            tmp[j] = "VLe(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (tmp[j] == "119")
                        {
                            tmp[j] = "VMore(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (tmp[j] == "123")
                        {
                            tmp[j] = "VEqu(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (tmp[j] == "141")
                        {
                            tmp[j] = "iggS";
                        }
                        if (tmp[j] == "142")
                        {
                            tmp[j] = "Build";
                        }
                        if (tmp[j] == "143")
                        {
                            tmp[j] = "Hea";
                        }
                        if (tmp[j] == "145")
                        {
                            tmp[j] = "MineS";
                        }
                        if (tmp[j] == "156")
                        {
                            tmp[j] = "CRightH";
                        }
                        if (tmp[j] == "157")
                        {
                            tmp[j] = "CLeftH";
                        }

                        if (tmp[j] == "146")
                        {
                            tmp[j] = "CGun";
                        }
                        if (tmp[j] == "147")
                        {
                            tmp[j] = "FGun";
                        }
                        if (tmp[j] == "148")
                        {
                            tmp[j] = "hpf";
                        }
                        if (tmp[j] == "149")
                        {
                            tmp[j] = "hpp";
                        }
                        if (tmp[j] == "144")
                        {
                            tmp[j] = "Flip";
                        }
                        if (tmp[j] == "0")
                        {
                            tmp[j] = "-";
                        }
                        
                    }



                    string text;
                    int[] numbers = new int[16 * 12 * 16];
                    int s2 = 0;
                    text = string.Join("", tmp);
                    int length, maxLength = 0;
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (tmp[i] == "-")
                        {
                            length = 0;
                            for (int j = i; j < tmp.Length && tmp[j] == "-"; j++)
                            {
                                length++;

                            }
                            i += length;
                            if (length > maxLength) maxLength = length;
                            number[s2] = length;
                            s2++;



                        }


                    }
                    int[] tmp2 = new int[s2];
                    for (int i = 0; i < number.Length; i++)
                    {

                        if (i < tmp2.Length)
                        {
                            tmp2[i] = number[i];
                        }


                    }
                    int RS = 0;
                    for (int i = 0; i < tmp2.Length; i++)
                    {
                        RS = RS + tmp2[i];
                    }
                    int[] g2s = new int[s2];

                    int g3 = 0;
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (i == 0)
                        {
                            if (tmp[i] == "-")
                            {
                                g2s[g3] = i;
                                g3++;
                            }
                        }
                        if (i > 0)
                        {
                            if (tmp[i] == "-" && tmp[i - 1] != "-")
                            {
                                g2s[g3] = i;
                                g3++;
                            }
                        }



                    }
                    int g4 = 0; int g5 = 0; int g6 = 0; int g7 = 0;
                    string[] tmp3 = new string[tmp.Length - RS];
                    string[] tmp6 = new string[tmp2.Length];
                    for (int i = 0; i < tmp2.Length; i++)
                    {
                        tmp6[i] = tmp2[i].ToString();
                    }

                    for (int i = 0; i < tmp6.Length; i++)
                    {
                        for (int j = 10; j < tx3.Length; j++)
                        {
                            if (tmp6[i] == (j + 1).ToString())
                            {
                                tmp6[i] = tx3[j];
                            }
                        }

                        if (tmp6[i] == "10")
                        {
                            tmp6[i] = "a";
                        }

                        ////
                    }

                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (g4 < g2s.Length)
                        {
                            if (tmp2[g4] != 1)
                            {
                                if (tmp2[g4] < 91)
                                    tmp[g2s[g4]] = "-" + tmp6[g4];
                                if (tmp2[g4] >= 91 && tmp2[g4] < 910)
                                    tmp[g2s[g4]] = "=" + tmp6[g4];
                                if (tmp2[g4] >= 910)
                                    tmp[g2s[g4]] = "~" + tmp6[g4];

                            }
                            else tmp[g2s[g4]] = "_";
                            g4++;
                        }

                    }
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (g5 < g2s.Length)//&&g6<g2s[g5])
                        {
                            for (int j = 0; j < tmp2[g7] - 1; j++)
                            {
                                if (tmp2[g5] != 1)
                                {
                                    tmp = Delete(tmp, g2s[g5] - g6 + 1 + j);
                                    g6++;
                                }
                                else tmp[g2s[g5]] = "_";

                            }
                            g7++;
                        }
                        g5++;
                    }
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (tmp[i] == "=a")
                        {
                            tmp[i] = "=10";
                        }
                        if (tmp[i] == "~a")
                        {
                            tmp[i] = "~10";
                        }
                    }

                    // }
                    richTextBox2.Text = string.Join("", tmp);
                    
                }
            }
            
        }
        private void button9_Click(object sender, EventArgs e)// конвертация в новый код
        {
            int undefired = 0;


            string[] sim3 = { "+", "&", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "cb", "cc", "Z1", "Zk", "Zl", "Zm", "Zn", "Zo", "Zp", "Zi", "Zj", "co", "cp", "cq", "cr", "cO", "cP", "cS", "Cf", "Cg", "Cj", "Ch", "Ci", "cQ", "cR" };

            string[] tx2 = new string[3071];
            massiv(tx2);
            string text; text = textBox2.Text;

            string[] codes_text; string[] code_labels = new string[16 * 12 * 16]; int[] nums = new int[16 * 12 * 16]; int[] codes = new int[16 * 12 * 16]; int[] newStr = new int[16 * 12 * 16];
            string[] newStr2 = new string[16 * 12 * 16];
            string[] newStr3 = new string[2];
            string[] t1 = new string[16 * 12 * 16];
            string[] t2 = new string[16 * 12 * 16];
            int[] g3 = new int[16 * 12 * 16];
            string[] codes_t2 = new string[16 * 12 * 16];
            string[] code_labels2 = new string[16 * 12 * 16];

            int[] zzz = new int[12 * 16 * 16]; int z00 = 0;


            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    for (int k = 0; k < 16; k++)
                    {
                        codes[i * 16 * 12 + j * 16 + k] = 0;

                        newStr[i * 16 * 12 + j * 16 + k] = -1;
                        newStr2[i * 16 * 12 + j * 16 + k] = "0";
                        t1[i * 16 * 12 + j * 16 + k] = "-1";
                        t2[i * 16 * 12 + j * 16 + k] = "-1";
                        g3[i * 16 * 12 + j * 16 + k] = -1;
                        codes_t2[i * 16 * 12 + j * 16 + k] = "0";
                        zzz[i * 16 * 12 + j * 16 + k] = -1;
                    }
                }
            }


            if (text.Trim() != "")
            {
                char[] str1 = text.ToCharArray();
                char[] str = new char[str1.Length];



                string testt2;
                testt2 = new string(str);


                text = text.Replace("/", "/,");
                text = text.Replace("\\", "\\,");
                text = text.Replace(">", ">,");
                text = text.Replace("<", "<,");
                text = text.Replace("W", "W,");
                text = text.Replace("A", "A,");
                text = text.Replace("S", "S,");
                text = text.Replace("D", "D,");
                text = text.Replace("Z0", "Z0,");
                text = text.Replace("w", "w,");
                text = text.Replace("a", "a,");
                text = text.Replace("s", "s,");
                text = text.Replace("d", "d,");
                text = text.Replace("Z2", "Z2,");
                text = text.Replace("Z3", "Z3,");
                text = text.Replace("Z4", "Z4,");
                text = text.Replace("Zc", "Zc,");
                text = text.Replace("Ze", "Ze,");
                text = text.Replace("Zd", "Zd,");
                text = text.Replace("Zf", "Zf,");
                text = text.Replace("Zg", "Zg,");
                text = text.Replace("Zq", "Zq,");
                text = text.Replace("Zh", "Zh,");
                text = text.Replace("R0", "R0,");
                text = text.Replace("R1", "R1,");
                text = text.Replace("R2", "R2,");
                text = text.Replace("C0", "C0,");
                text = text.Replace("C8", "C8,");
                text = text.Replace("C1", "C1,");
                text = text.Replace("C2", "C2,");
                text = text.Replace("C3", "C3,");
                text = text.Replace("C5", "C5,");
                text = text.Replace("C6", "C6,");
                text = text.Replace("C7", "C7,");
                text = text.Replace("M0", "M0,");
                text = text.Replace("M1", "M1,");
                text = text.Replace("c0", "c0,");
                text = text.Replace("c1", "c1,");
                text = text.Replace("c2", "c2,");
                text = text.Replace("ck", "ck,");
                text = text.Replace("cl", "cl,");
                text = text.Replace("cj", "cj,");
                text = text.Replace("cd", "cd,");
                text = text.Replace("cm", "cm,");
                text = text.Replace("cn", "cn,");
                text = text.Replace("cv", "cv,");
                text = text.Replace("ca", "ca,");
                text = text.Replace("ci", "ci,");
                text = text.Replace("ce", "ce,");
                text = text.Replace("cf", "cf,");
                text = text.Replace("cg", "cg,");
                text = text.Replace("ch", "ch,");
                text = text.Replace("ct", "ct,");
                text = text.Replace("cu", "cu,");
                text = text.Replace("cs", "cs,");
                text = text.Replace("B1", "B1,");
                text = text.Replace("B3", "B3,");
                text = text.Replace("B2", "B2,");
                text = text.Replace("VB", "VB,");
                text = text.Replace("C9", "C9,");
                text = text.Replace("Ca", "Ca,");
                text = text.Replace("Cb", "Cb,");
                text = text.Replace("Cc", "Cc,");
                text = text.Replace("Cd", "Cd,");
                text = text.Replace("Ce", "Ce,");
                text = text.Replace("Qig+", "Qig+,");
                text = text.Replace("Qig-", "Qig-,");
                text = text.Replace("gr+", "gr+,");
                text = text.Replace("gr-", "gr-,");
                text = text.Replace("iggS", "iggS,");
                text = text.Replace("Build", "Build,");
                text = text.Replace("MineS", "MineS,");
                text = text.Replace("CLeftH", "CLeftH,");
                text = text.Replace("CRightH", "CRightH,");
                text = text.Replace("CGun", "CGun,");
                text = text.Replace("FGun", "FGun,");
                text = text.Replace("hpf", "hpf,");
                text = text.Replace("hpp", "hpp,");
                text = text.Replace("Flip", "Flip,");
                text = text.Replace("Hea", "Hea,");
                //text = text.Replace("@", "@,");

                for (int i = 0; i < tx2.Length; i++)
                    if (i < tx2.Length)
                        text = text.Replace(tx2[i], tx2[i] + ",");




                text = text.Replace("L(", "L(,");
                text = text.Replace("VEqu(", "VEqu(,");
                text = text.Replace("VMore(", "VMore(,");
                text = text.Replace("VLe(", "VLe(,");
                text = text.Replace("G0(", "G0(,");
                text = text.Replace("G1(", "G1(,");
                text = text.Replace("G2(", "G2(,");
                text = text.Replace("G3(", "G3(,");
                text = text.Replace("G4(", "G4(,");
                text = text.Replace("G5(", "G5(,");
                text = text.Replace(")", ",),");

                for (int i = 0; i < sim3.Length; i++)

                    text = text.Replace(sim3[i], sim3[i] + ",");


                string[] separator = { "," };
                int z0 = 0;

                codes_text = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int g12 = 0; int z01 = zzz[0]; int z02 = 0;


                for (int i = 0; i < codes_text.Length; i++)
                {
                   
                }


                for (int i = 0; i < codes_text.Length; i++)
                {
                    if (codes_text[i] == "->")
                    {
                        zzz[z00] = i;
                        z00++;
                    }

                }

                z02 = zzz[0]; int z3 = 0;
                
                int zzz3 = 0;
                
                string[] codes_t = new string[16 * 12 * 16 + codes_text.Length * 3 / 2];
                for (int i = 0; i < codes_text.Length; i++)
                {
                    codes_t[i] = codes_text[i];
                }

                int z4 = 0;
                for (int i = 0; i < codes_text.Length; i++)
                {
                    for (int j = 0; j < tx2.Length; j++)
                        if (codes_text[i] == tx2[j])

                        { z4 += j - 1 + 1; }

                    if (codes_text[i] == "/")
                    {
                        if (codes_text[i + 1] == "/")
                        {
                            if (codes_text[i + 2] == "/")
                            {
                                if (codes_text[i + 3] == "/")
                                {
                                    if (codes_text[i + 4] == "/")
                                    {
                                        if (codes_text[i + 5] == "/")
                                        {
                                            if (codes_text[i + 6] == "/")
                                            {
                                                if (codes_text[i + 7] == "/")
                                                {

                                                }

                                            }

                                        }

                                    }

                                }

                            }
                            z4 += 191;
                        }
                        z4 += 191;
                        if (z4 > 191 && z4 < 384) z4 = 191;
                        if (z4 > 384 - 1 && z4 < 576) z4 = 384 - 1;
                        if (z4 > 576 - 1 && z4 < 768) z4 = 576 - 1;
                        if (z4 > 768 - 1 && z4 < 960) z4 = 768 - 1;
                        if (z4 > 960 - 1 && z4 < 1152) z4 = 960 - 1;
                        if (z4 > 1152 - 1 && z4 < 1344) z4 = 1152 - 1;
                        if (z4 > 1344 - 1 && z4 < 1536) z4 = 1344 - 1;
                        if (z4 > 1536 - 1 && z4 < 1728) z4 = 1536 - 1;
                        if (codes_text[i + 1] == "/")
                        {
                            z4 = z4 + 191 + 191;
                        }



                    }
                    z4++;

                }
                
                int label = 0; int label1 = 0; int label2 = 0; int label3 = 0; int label4 = 0;
                for (int i = 0; i < codes_t.Length; i++)
                {
                    if (codes_t[i] == "L(")
                    {
                        while (codes_t[i + 1] != ")")

                            if (codes_t[i + 1] != ")")
                            {
                                if (label == 1)
                                {
                                    label1 = i;
                                }
                                code_labels[label1] = code_labels[label1] + codes_t[i + 1];
                                codes_t = Delete(codes_t, i + 1);
                                
                            }
                        label1++;

                        if (codes_t[i + 1] == ")")
                        {
                            codes_t = Delete(codes_t, i + 1);
                        }
                    }
                    if (codes_t[i] == "G0(")
                    {
                        while (codes_t[i + 1] != ")")

                            if (codes_t[i + 1] != ")")
                            {
                                
                                if (label == 1)
                                {
                                    label1 = i;
                                }
                                code_labels[label1] = code_labels[label1] + codes_t[i + 1];
                                codes_t = Delete(codes_t, i + 1);
                                
                            }
                        label1++;

                        if (codes_t[i + 1] == ")")
                        {
                            codes_t = Delete(codes_t, i + 1);
                        }
                    }
                    if (codes_t[i] == "G1(")
                    {
                        while (codes_t[i + 1] != ")")

                            if (codes_t[i + 1] != ")")
                            {
                                //label++;
                                if (label == 1)
                                {
                                    label1 = i;
                                }
                                code_labels[label1] = code_labels[label1] + codes_t[i + 1];
                                codes_t = Delete(codes_t, i + 1);
                                
                            }
                        label1++;

                        if (codes_t[i + 1] == ")")
                        {
                            codes_t = Delete(codes_t, i + 1);
                        }
                    }
                    if (codes_t[i] == "G2(")
                    {
                        while (codes_t[i + 1] != ")")

                            if (codes_t[i + 1] != ")")
                            {
                                //label++;
                                if (label == 1)
                                {
                                    label1 = i;
                                }
                                code_labels[label1] = code_labels[label1] + codes_t[i + 1];
                                codes_t = Delete(codes_t, i + 1);
                                //label1++;
                            }
                        label1++;

                        if (codes_t[i + 1] == ")")
                        {
                            codes_t = Delete(codes_t, i + 1);
                        }
                    }
                    if (codes_t[i] == "G3(")
                    {
                        while (codes_t[i + 1] != ")")

                            if (codes_t[i + 1] != ")")
                            {
                                
                                if (label == 1)
                                {
                                    label1 = i;
                                }
                                code_labels[label1] = code_labels[label1] + codes_t[i + 1];
                                codes_t = Delete(codes_t, i + 1);
                                
                            }
                        label1++;

                        if (codes_t[i + 1] == ")")
                        {
                            codes_t = Delete(codes_t, i + 1);
                        }
                    }
                    if (codes_t[i] == "G4(")
                    {
                        while (codes_t[i + 1] != ")")

                            if (codes_t[i + 1] != ")")
                            {
                                
                                if (label == 1)
                                {
                                    label1 = i;
                                }
                                code_labels[label1] = code_labels[label1] + codes_t[i + 1];
                                codes_t = Delete(codes_t, i + 1);
                                
                            }
                        label1++;

                        if (codes_t[i + 1] == ")")
                        {
                            codes_t = Delete(codes_t, i + 1);
                        }
                    }
                    if (codes_t[i] == "G5(")
                    {
                        while (codes_t[i + 1] != ")")

                            if (codes_t[i + 1] != ")")
                            {
                                
                                if (label == 1)
                                {
                                    label1 = i;
                                }
                                code_labels[label1] = code_labels[label1] + codes_t[i + 1];
                                codes_t = Delete(codes_t, i + 1);
                                
                            }
                        label1++;

                        if (codes_t[i + 1] == ")")
                        {
                            codes_t = Delete(codes_t, i + 1);
                        }
                    }
                    if (codes_t[i] == "VEqu(")
                    {
                        while (codes_t[i + 1] != ")")

                            if (codes_t[i + 1] != ")")
                            {
                                
                                if (label == 1)
                                {
                                    label1 = i;
                                }
                                code_labels[label1] = code_labels[label1] + codes_t[i + 1];
                                codes_t = Delete(codes_t, i + 1);
                                
                            }
                        label1++;

                        if (codes_t[i + 1] == ")")
                        {
                            codes_t = Delete(codes_t, i + 1);
                        }
                    }
                    if (codes_t[i] == "VMore(")
                    {
                        while (codes_t[i + 1] != ")")

                            if (codes_t[i + 1] != ")")
                            {
                                
                                if (label == 1)
                                {
                                    label1 = i;
                                }
                                code_labels[label1] = code_labels[label1] + codes_t[i + 1];
                                codes_t = Delete(codes_t, i + 1);
                                
                            }
                        label1++;

                        if (codes_t[i + 1] == ")")
                        {
                            codes_t = Delete(codes_t, i + 1);
                        }
                    }
                    if (codes_t[i] == "VLe(")
                    {
                        while (codes_t[i + 1] != ")")

                            if (codes_t[i + 1] != ")")
                            {
                                
                                if (label == 1)
                                {
                                    label1 = i;
                                }
                                code_labels[label1] = code_labels[label1] + codes_t[i + 1];
                                codes_t = Delete(codes_t, i + 1);
                                
                            }
                        label1++;

                        if (codes_t[i + 1] == ")")
                        {
                            codes_t = Delete(codes_t, i + 1);
                        }
                    }
                }

                int[] label5 = new int[codes_t.Length];
                for (int i = 0; i < codes_t.Length; i++)
                {
                    if (codes_t[i] == "L(" || codes_t[i] == "G0(" || codes_t[i] == "G1(" || codes_t[i] == "G2(" || codes_t[i] == "G3(" || codes_t[i] == "G4(" || codes_t[i] == "G5(" || codes_t[i] == "VEqu(" || codes_t[i] == "VMore(" || codes_t[i] == "VLe(")
                        label5[i] = 1;


                    else label5[i] = 0;
                }


                string[] cl1 = new string[code_labels.Length];

                for (int i = 0; i < label5.Length; i++)
                {

                    if (label5[i] == 1)
                    {
                        cl1[i] = code_labels[label4]; label4++;
                    }



                }
                
                if (test2)
                {
                    /////
                    string[] codes_t4 = new string[codes_t.Length];
                    string[] code_labels4 = new string[code_labels.Length];
                    for (int i = 0; i < codes_t.Length; i++) codes_t4[i] = codes_t[i];
                    for (int i = 0; i < code_labels.Length; i++) code_labels4[i] = code_labels[i];

                    int go1 = 13; int g02 = 0;
                    while (g02 != 3)
                    {
                        var temp = code_labels[code_labels.Length - 1];
                        Array.Copy(code_labels, 0, code_labels, 1, code_labels.Length - 1);
                        code_labels[go1] = temp;

                        var temp1 = codes_t[codes_t.Length - 1];
                        Array.Copy(codes_t, 0, codes_t, 1, codes_t.Length - 1);
                        codes_t[go1] = temp1;
                        g02++;

                    }

                    for (int i = 0; i < codes_t.Length; i++)
                    {
                        if (i < 13)
                        {
                            codes_t[i] = codes_t4[i];
                        }
                    }

                    for (int i = 0; i < code_labels.Length; i++)
                    {
                        if (i < 13)
                        {
                            code_labels[i] = code_labels4[i];
                        }
                    }

                    for (int i = 0; i < codes_t.Length; i++) codes_t4[i] = codes_t[i];
                    for (int i = 0; i < code_labels.Length; i++) code_labels4[i] = code_labels[i];

                    go1 = 30; g02 = 0;

                    while (g02 != 2)
                    {
                        var temp = code_labels[code_labels.Length - 1];
                        Array.Copy(code_labels, 0, code_labels, 1, code_labels.Length - 1);
                        code_labels[go1] = temp;

                        var temp1 = codes_t[codes_t.Length - 1];
                        Array.Copy(codes_t, 0, codes_t, 1, codes_t.Length - 1);
                        codes_t[go1] = temp1;
                        g02++;

                    }

                    for (int i = 0; i < codes_t.Length; i++)
                    {
                        if (i < 30)
                        {
                            codes_t[i] = codes_t4[i];
                        }
                    }

                    for (int i = 0; i < code_labels.Length; i++)
                    {
                        if (i < 30)
                        {
                            code_labels[i] = code_labels4[i];
                        }
                    }

                    int h12 = 30; g02 = 0;
                    while (h12 < 1500)
                    {
                        h12 += 16;
                        for (int j = 0; j < codes_t.Length; j++) codes_t4[j] = codes_t[j];
                        for (int j = 0; j < code_labels.Length; j++) code_labels4[j] = code_labels[j];

                        while (g02 != 2)
                        {
                            
                            var temp = code_labels[code_labels.Length - 1];
                            Array.Copy(code_labels, 0, code_labels, 1, code_labels.Length - 1);
                            code_labels[h12] = temp;



                            var temp1 = codes_t[codes_t.Length - 1];
                            Array.Copy(codes_t, 0, codes_t, 1, codes_t.Length - 1);
                            codes_t[h12] = temp1;

                            //}
                            g02++;
                        }

                        for (int j = 0; j < codes_t.Length; j++)
                        {
                            if (j < h12)
                            {
                                codes_t[j] = codes_t4[j];
                            }
                        }

                        for (int j = 0; j < code_labels.Length; j++)
                        {
                            if (j < h12)
                            {
                                code_labels[j] = code_labels4[j];
                            }
                        }
                        g02 = 0;

                    }


                    
                }

                string[] code_labels5 = new string[code_labels.Length];

                
                int z223 = 0;

                

                string[] codes_t20 = new string[code_labels.Length];
                
                string[] codes_t21 = new string[code_labels.Length];



                string[] codes_t22 = new string[codes_t.Length];




                for (int i = 0; i < codes_text.Length; i++)
                {
                    
                }

                int z222 = 0;
                string[] codes_tt = new string[codes_t.Length];

                int j21 = 0;

                int zzz1 = 0; 

                int zzz30 = 0; 
                int zzz31 = 0;


                for (int i = 0; i < codes_text.Length; i++)
                {
                    if (codes_text[i] == "L(")
                    {
                        while (codes_text[i + 1] != ")")
                            if (codes_text[i + 1] != ")")
                            {
                                codes_text = Delete(codes_text, i + 1);
                            }

                        if (codes_text[i + 1] == ")")
                        {
                            codes_text = Delete(codes_text, i + 1);
                        }
                    }

                    if (codes_text[i] == "VEqu(")
                    {
                        while (codes_text[i + 1] != ")")
                            if (codes_text[i + 1] != ")")
                            {
                                codes_text = Delete(codes_text, i + 1);
                            }

                        if (codes_text[i + 1] == ")")
                        {
                            codes_text = Delete(codes_text, i + 1);
                        }
                    }

                    if (codes_text[i] == "VMore(")
                    {
                        while (codes_text[i + 1] != ")")
                            if (codes_text[i + 1] != ")")
                            {

                                codes_text = Delete(codes_text, i + 1);
                            }

                        if (codes_text[i + 1] == ")")
                        {
                            codes_text = Delete(codes_text, i + 1);
                        }
                    }
                    if (codes_text[i] == "VLe(")
                    {
                        while (codes_text[i + 1] != ")")
                            if (codes_text[i + 1] != ")")
                            {

                                codes_text = Delete(codes_text, i + 1);
                            }

                        if (codes_text[i + 1] == ")")
                        {
                            codes_text = Delete(codes_text, i + 1);
                        }
                    }
                    if (codes_text[i] == "G0(")
                    {
                        while (codes_text[i + 1] != ")")
                            if (codes_text[i + 1] != ")")
                            {

                                codes_text = Delete(codes_text, i + 1);
                            }

                        if (codes_text[i + 1] == ")")
                        {
                            codes_text = Delete(codes_text, i + 1);
                        }
                    }
                    if (codes_text[i] == "G1(")
                    {
                        while (codes_text[i + 1] != ")")
                            if (codes_text[i + 1] != ")")
                            {

                                codes_text = Delete(codes_text, i + 1);
                            }

                        if (codes_text[i + 1] == ")")
                        {
                            codes_text = Delete(codes_text, i + 1);
                        }
                    }
                    if (codes_text[i] == "G2(")
                    {
                        while (codes_text[i + 1] != ")")
                            if (codes_text[i + 1] != ")")
                            {

                                codes_text = Delete(codes_text, i + 1);
                            }

                        if (codes_text[i + 1] == ")")
                        {
                            codes_text = Delete(codes_text, i + 1);
                        }
                    }
                    if (codes_text[i] == "G3(")
                    {
                        while (codes_text[i + 1] != ")")
                            if (codes_text[i + 1] != ")")
                            {

                                codes_text = Delete(codes_text, i + 1);
                            }

                        if (codes_text[i + 1] == ")")
                        {
                            codes_text = Delete(codes_text, i + 1);
                        }
                    }
                    if (codes_text[i] == "G4(")
                    {
                        while (codes_text[i + 1] != ")")
                            if (codes_text[i + 1] != ")")
                            {

                                codes_text = Delete(codes_text, i + 1);
                            }

                        if (codes_text[i + 1] == ")")
                        {
                            codes_text = Delete(codes_text, i + 1);
                        }
                    }
                    if (codes_text[i] == "G5(")
                    {
                        while (codes_text[i + 1] != ")")
                            if (codes_text[i + 1] != ")")
                            {

                                codes_text = Delete(codes_text, i + 1);
                            }

                        if (codes_text[i + 1] == ")")
                        {
                            codes_text = Delete(codes_text, i + 1);
                        }
                    }
                }



                int z200 = 0; string[] codes_t200 = new string[16 * 12 * 16];

                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        for (int k = 0; k < 16; k++)
                        {

                            codes_t200[i * 16 * 12 + j * 16 + k] = "0";

                        }
                    }
                }

                int z100; z100 = 0; int z101; z101 = 0;
                string[] code_labels6 = new string[cl1.Length];

                for (int i = 0; i < codes_t.Length; i++)
                {
                    for (int j = 0; j < tx2.Length; j++)
                    {
                        if (codes_t[i] == tx2[j])

                        { z100 += j - 1 + 1; }

                    }



                    z101 = i;
                    if (codes_t[z101] == "L(")
                    {

                        code_labels6[z100] = code_labels6[z100] + cl1[i];

                    }

                    if (codes_t[z101] == "G0(")
                    {

                        code_labels6[z100] = code_labels6[z100] + cl1[i];

                    }
                    if (codes_t[z101] == "G1(")
                    {

                        code_labels6[z100] = code_labels6[z100] + cl1[i];

                    }
                    if (codes_t[z101] == "G2(")
                    {

                        code_labels6[z100] = code_labels6[z100] + cl1[i];

                    }
                    if (codes_t[z101] == "G3(")
                    {

                        code_labels6[z100] = code_labels6[z100] + cl1[i];

                    }
                    if (codes_t[z101] == "G4(")
                    {

                        code_labels6[z100] = code_labels6[z100] + cl1[i];

                    }

                    if (codes_t[z101] == "G5(")
                    {

                        code_labels6[z100] = code_labels6[z100] + cl1[i];

                    }
                    if (codes_t[z101] == "VEqu(")
                    {

                        code_labels6[z100] = code_labels6[z100] + cl1[i];

                    }

                    if (codes_t[z101] == "VMore(")
                    {

                        code_labels6[z100] = code_labels6[z100] + cl1[i];

                    }

                    if (codes_t[z101] == "VLe(")
                    {

                        code_labels6[z100] = code_labels6[z100] + cl1[i];

                    }

                    z100++;



                }

               
                for (int i = 0; i < codes_t.Length; i++)
                {
                    if (codes_t[i] == "0")
                    {

                        codes_t[i] = null;
                    }
                }




                for (int i = 0; i < codes_text.Length; i++)
                {
                    for (int j = 0; j < tx2.Length; j++)
                        if (codes_text[i] == tx2[j])
                        {



                            z200 += j + 1;
                            codes_text = Delete(codes_text, i);




                        }
                    codes_t200[z200] = codes_text[i];
                    z200++;
                }

               

                for (int i = 0; i < code_labels.Length; i++) code_labels5[i] = code_labels6[i];



                for (int i = 0; i < codes_t200.Length; i++)
                {
                    if (codes_t200[i] == "L(")
                    {
                        codes_t200[i] = "L";
                    }
                    if (codes_t200[i] == "VEqu(")
                    {
                        codes_t200[i] = "VEqu";
                    }
                    if (codes_t200[i] == "VMore(")
                    {
                        codes_t200[i] = "VMore";
                    }
                    if (codes_t200[i] == "VLe(")
                    {
                        codes_t200[i] = "VLe";
                    }
                    if (codes_t200[i] == "G0(")
                    {
                        codes_t200[i] = "G0";
                    }
                    if (codes_t200[i] == "G1(")
                    {
                        codes_t200[i] = "G1";
                    }
                    if (codes_t200[i] == "G2(")
                    {
                        codes_t200[i] = "G2";
                    }
                    if (codes_t200[i] == "G3(")
                    {
                        codes_t200[i] = "G3";
                    }
                    if (codes_t200[i] == "G4(")
                    {
                        codes_t200[i] = "G4";
                    }
                    if (codes_t200[i] == "G5(")
                    {
                        codes_t200[i] = "G5";
                    }

                }

                ;

                for (int i = 0; i < codes.Length; i++)
                {
                    if (i < codes_t200.Length)
                    {
                        codes[i] = 0;
                        if (codes_t200[i] == "L")
                        {
                            codes[i] = 40;

                        }
                        if (codes_t200[i] == "S")
                        {
                            codes[i] = 6;
                        }
                        if (codes_t200[i] == "Z0")
                        {
                            codes[i] = 8;
                        }
                        if (codes_t200[i] == "VEqu")
                        {
                            codes[i] = 123;
                        }
                        if (codes_t200[i] == "VMore")
                        {
                            codes[i] = 119;
                        }
                        if (codes_t200[i] == "VLe")
                        {
                            codes[i] = 120;
                        }
                        if (codes_t200[i] == "G2")
                        {
                            codes[i] = 24;

                        }
                        if (codes_t200[i] == "G3")
                        {
                            codes[i] = 25;

                        }
                        if (codes_t200[i] == "G4")
                        {
                            codes[i] = 26;

                        }
                        if (codes_t200[i] == "G5")
                        {
                            codes[i] = 137;

                        }
                        if (codes_t200[i] == "G0")
                        {
                            codes[i] = 139;

                        }
                        if (codes_t200[i] == "G1")
                        {
                            codes[i] = 140;

                        }
                        if (codes_t200[i] == "\\")
                        {
                            codes[i] = 1;
                        }
                        if (codes_t200[i] == ">")
                        {
                            codes[i] = 2;
                        }
                        if (codes_t200[i] == "<")
                        {
                            codes[i] = 3;
                        }
                        if (codes_t200[i] == "W")
                        {
                            codes[i] = 4;
                        }
                        if (codes_t200[i] == "A")
                        {
                            codes[i] = 5;
                        }
                        if (codes_t200[i] == "S")
                        {
                            codes[i] = 6;
                        }
                        if (codes_t200[i] == "D")
                        {
                            codes[i] = 7;
                        }
                        if (codes_t200[i] == "Z0")
                        {
                            codes[i] = 8;
                        }
                        if (codes_t200[i] == "w")
                        {
                            codes[i] = 9;
                        }
                        if (codes_t200[i] == "a")
                        {
                            codes[i] = 10;
                        }
                        if (codes_t200[i] == "s")
                        {
                            codes[i] = 11;
                        }
                        if (codes_t200[i] == "d")
                        {
                            codes[i] = 12;
                        }
                        if (codes_t200[i] == "Z2")
                        {
                            codes[i] = 14;
                        }
                        if (codes_t200[i] == "Z3")
                        {
                            codes[i] = 15;
                        }
                        if (codes_t200[i] == "Z4")
                        {
                            codes[i] = 16;
                        }
                        if (codes_t200[i] == "Zc")
                        {
                            codes[i] = 17;
                        }
                        if (codes_t200[i] == "Ze")
                        {
                            codes[i] = 18;
                        }
                        if (codes_t200[i] == "Zd")
                        {
                            codes[i] = 19;
                        }
                        if (codes_t200[i] == "Zf")
                        {
                            codes[i] = 20;
                        }
                        if (codes_t200[i] == "Zg")
                        {
                            codes[i] = 21;
                        }
                        if (codes_t200[i] == "Zq")
                        {
                            codes[i] = 22;
                        }
                        if (codes_t200[i] == "Zh")
                        {
                            codes[i] = 23;
                        }
                        if (codes_t200[i] == "R0")
                        {
                            codes[i] = 27;
                        }
                        if (codes_t200[i] == "R1")
                        {
                            codes[i] = 28;
                        }
                        if (codes_t200[i] == "R2")
                        {
                            codes[i] = 138;
                        }
                        if (codes_t200[i] == "C0")
                        {
                            codes[i] = 29;
                        }
                        if (codes_t200[i] == "C8")
                        {
                            codes[i] = 30;
                        }
                        if (codes_t200[i] == "C1")
                        {
                            codes[i] = 31;
                        }
                        if (codes_t200[i] == "C2")
                        {
                            codes[i] = 32;
                        }
                        if (codes_t200[i] == "C3")
                        {
                            codes[i] = 33;
                        }
                        if (codes_t200[i] == "C5")
                        {
                            codes[i] = 35;
                        }
                        if (codes_t200[i] == "C6")
                        {
                            codes[i] = 36;
                        }
                        if (codes_t200[i] == "C7")
                        {
                            codes[i] = 37;
                        }
                        if (codes_t200[i] == "M0")
                        {
                            codes[i] = 38;
                        }
                        if (codes_t200[i] == "M1")
                        {
                            codes[i] = 39;
                        }
                        if (codes_t200[i] == "c0")
                        {
                            codes[i] = 43;
                        }
                        if (codes_t200[i] == "c1")
                        {
                            codes[i] = 44;
                        }
                        if (codes_t200[i] == "c2")
                        {
                            codes[i] = 45;
                        }
                        if (codes_t200[i] == "ck")
                        {
                            codes[i] = 46;
                        }
                        if (codes_t200[i] == "cl")
                        {
                            codes[i] = 47;
                        }
                        if (codes_t200[i] == "cj")
                        {
                            codes[i] = 48;
                        }
                        if (codes_t200[i] == "cd")
                        {
                            codes[i] = 49;
                        }
                        if (codes_t200[i] == "cm")
                        {
                            codes[i] = 50;
                        }
                        if (codes_t200[i] == "cn")
                        {
                            codes[i] = 51;
                        }
                        if (codes_t200[i] == "cv")
                        {
                            codes[i] = 52;
                        }
                        if (codes_t200[i] == "ca")
                        {
                            codes[i] = 53;
                        }
                        if (codes_t200[i] == "ci")
                        {
                            codes[i] = 54;
                        }
                        if (codes_t200[i] == "ce")
                        {
                            codes[i] = 57;
                        }
                        if (codes_t200[i] == "cf")
                        {
                            codes[i] = 58;
                        }
                        if (codes_t200[i] == "cg")
                        {
                            codes[i] = 59;
                        }
                        if (codes_t200[i] == "ch")
                        {
                            codes[i] = 60;
                        }
                        if (codes_t200[i] == "ct")
                        {
                            codes[i] = 74;
                        }
                        if (codes_t200[i] == "cu")
                        {
                            codes[i] = 76;
                        }
                        if (codes_t200[i] == "cs")
                        {
                            codes[i] = 77;
                        }
                        if (codes_t200[i] == "B1")
                        {
                            codes[i] = 162;
                        }
                        if (codes_t200[i] == "B3")
                        {
                            codes[i] = 163;
                        }
                        if (codes_t200[i] == "B2")
                        {
                            codes[i] = 164;
                        }
                        if (codes_t200[i] == "VB")
                        {
                            codes[i] = 165;
                        }
                        if (codes_t200[i] == "C9")
                        {
                            codes[i] = 131;
                        }
                        if (codes_t200[i] == "Ca")
                        {
                            codes[i] = 132;
                        }
                        if (codes_t200[i] == "Cb")
                        {
                            codes[i] = 133;
                        }
                        if (codes_t200[i] == "Cc")
                        {
                            codes[i] = 134;
                        }
                        if (codes_t200[i] == "Cd")
                        {
                            codes[i] = 135;
                        }
                        if (codes_t200[i] == "Ce")
                        {
                            codes[i] = 136;
                        }
                        if (codes_t200[i] == "Qig+")
                        {
                            codes[i] = 158;
                        }
                        if (codes_t200[i] == "Qig-")
                        {
                            codes[i] = 159;
                        }
                        if (codes_t200[i] == "gr+")
                        {
                            codes[i] = 160;
                        }
                        if (codes_t200[i] == "gr-")
                        {
                            codes[i] = 161;
                        }
                        if (codes_t200[i] == "iggS")
                        {
                            codes[i] = 141;
                        }
                        if (codes_t200[i] == "Build")
                        {
                            codes[i] = 142;
                        }
                        if (codes_t200[i] == "Hea")
                        {
                            codes[i] = 143;
                        }
                        if (codes_t200[i] == "MineS")
                        {
                            codes[i] = 145;
                        }
                        if (codes_t200[i] == "CLeftH")
                        {
                            codes[i] = 156;
                        }
                        if (codes_t200[i] == "CRightH")
                        {
                            codes[i] = 157;
                        }
                        if (codes_t200[i] == "CGun")
                        {
                            codes[i] = 146;
                        }
                        if (codes_t200[i] == "FGun")
                        {
                            codes[i] = 147;
                        }
                        if (codes_t200[i] == "hpf")
                        {
                            codes[i] = 148;
                        }
                        if (codes_t200[i] == "hpp")
                        {
                            codes[i] = 149;
                        }
                        if (codes_t200[i] == "Flip")
                        {
                            codes[i] = 144;
                        }
                        for (int j = 0; j < sim3.Length; j++)
                            if (codes_t200[i] == sim3[j])
                            {
                                codes[i] = 0;
                                undefired++;
                            }
                    }

                }

                string[] t10 = new string[16 * 12 * 16];
                string[] t22 = new string[16 * 12 * 16];

                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        for (int k = 0; k < 16; k++)
                        {
                            t10[i * 16 * 12 + j * 16 + k] = "-1";
                            t22[i * 16 * 12 + j * 16 + k] = "-1";
                        }
                    }
                }

                ////
                string[] line = { "@" };
                int s20 = 0;
                
                for (int j = 0; j < code_labels5.Length; j++)
                {
                    if (j < newStr.Length && code_labels5[j] != null)
                    {

                        if (code_labels5[j].IndexOf(line[0]) > 0)
                        {
                            
                            newStr2[j] = code_labels5[j];
                        }
                        
                    }
                }

               
                for (int i = 0; i < newStr2.Length; i++)
                {                   
                    if (newStr2[i] != "0")
                    {
                        newStr3 = newStr2[i].Split('@');
                        t10[i] = newStr3[0];
                        t22[i] = newStr3[1];
                    }
                }

                int z7 = 0;
                
                for (int i = 0; i < code_labels5.Length; i++)
                {
                    if (z7 < t10.Length)
                    {
                        if (t10[z7] != "-1")
                        {
                            if (code_labels5[i] != null)
                            {
                                code_labels5[i] = t10[z7];
                                z7++;
                            }

                        }
                    }
                }





                int z8 = 0;

                for (int i = 0; i < codes.Length; i++)
                {
                    if (z8 < t22.Length)
                    {
                        if (t22[z8] != "-1")
                        {
                            if (codes[i] == 123 || codes[i] == 120 || codes[i] == 119)
                            {
                                nums[i] = int.Parse(t22[z8]);

                            }
                            z8++;
                        }
                    }
                }
               
                int num = 0; int num2 = 0;
                for (int i = 0; i < codes.Length; i++)
                {
                    if (codes[i] != 0)
                    {
                        num = i;
                    }
                }
                if (num == 0)
                {
                    num = 1;
                }
                for (int j = 0; j < code_labels5.Length; j++)
                {
                    if (code_labels5[j] != "0" || nums[j] != 0)
                    {
                        num2 = j;
                    }
                }
                if (num2 == 0)
                {
                    num2 = 1;
                }
                string[] array = new string[num2 + 1];
                Array.Copy(code_labels5, array, num2 + 1);
                for (int k = 0; k < array.Length; k++)
                {
                    if (nums[k] != 0)
                    {
                        string[] array2 = array;
                        int num3 = k;
                        array2[num3] = array2[num3] + "@" + nums[k];
                    }
                }
                string s = string.Join(":", array);
                byte[] array3 = new byte[num + 1];
                for (int l = 0; l < array3.Length; l++)
                {
                    array3[l] = Convert.ToByte(codes[l]);
                }
                byte[] bytes = Encoding.UTF8.GetBytes(s);
                byte[] bytes2 = BitConverter.GetBytes(array3.Length);
                byte[] array4 = new byte[bytes2.Length + array3.Length + bytes.Length];
                Buffer.BlockCopy(bytes2, 0, array4, 0, bytes2.Length);
                Buffer.BlockCopy(array3, 0, array4, bytes2.Length, array3.Length);
                Buffer.BlockCopy(bytes, 0, array4, bytes2.Length + array3.Length, bytes.Length);

                string result;
                //richTextBox1.Text = String.Join(";", code_labels);
                result = Convert.ToBase64String(SevenZipHelper.Compress(array4));



                

                string message = "";
                if (undefired == 1) message = "Найден символ из предыдущей версии программатора и не найденный в новом! Он будет заменен на пустые строчки";
                else message = "Найдены " + undefired + " символа из предыдущей версии программатора и не найденный в новом! Они будут заменены на пустые строчки";

                if (undefired > 0)
                {

                    MessageBox.Show(message, "Внимание!");
                    undefired = 0;
                }

                string[] tes1 = new string[16 * 12 * 16];

                for (int i = 0; i < tes1.Length; i++)
                {
                    tes1[i] = "L(100)";
                }
               
                richTextBox3.Text = string.Join(";", result);


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Раздел в разработке", "Внимание!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/mines_news");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("Эта функция не до конца проверена, вы действительно хотите её активировать?", "Экспериментальная функция - перенос строчки", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    test2 = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    checkBox1.Checked = false;
                    
                }
            }
            else test2 = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveAsOwnTextFormat(string filename, string textToSave)

        {

            try

            {

                string dir = Path.GetDirectoryName(Application.ExecutablePath);

                StreamWriter sw = File.CreateText(@dir +"\\"+ filename);
                //StreamWriter sw = new StreamWriter(File.Create(Path.Combine(dir,filename)));


                sw.WriteLine(textToSave);

                

                sw.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show

                ("Error: " + ex.Message);

            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string text = "";
            text = textBox3.Text;
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            //string dir = Path.GetTempPath();
            string test = ""; //string dir = Path.GetPathRoot(Application.ExecutablePath);
            test = dir + "\\" + text + ".txt";
            

            saveAsOwnTextFormat(text+".txt", "Программа: " + textBox3.Text + "\n\n" + "Старый код:\n\n" + richTextBox2.Text + "\n\nНовый код:\n\n" + richTextBox3.Text);
            //richTextBox3.Text = string.Join(";", test);

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
