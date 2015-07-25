using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ar_clavier
{
    public partial class Form1 : Form
    {


        private void textFR_TextChanged(object sender, EventArgs e)
        {
            convert();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convert()
        {

            char charFr;
            char PrevCharFr;
            bool testRemoveEndChar = false;
            string TextFr = textFR.Text;
            string ar = "";
            if (TextFr.Length >= 1)
            {
                
                for (int end = 0; end < TextFr.Length; end++)
                {
                    
                    charFr = char.Parse(TextFr.Substring(end, 1));
                    switch (charFr)
                    {
                        case 'a':
                            charFr = 'ا';
                            break;
                        case 'h':
                            charFr = 'ح';
                            break;                        
                        case 'A':
                            charFr = 'أ';
                            break;
                        case 'à':
                            charFr = 'آ';
                            break;
                        case 'b':
                            charFr = 'ب';
                            break;
                        case 'p':
                            charFr = 'پ';
                            break;
                        case 't':
                            charFr = 'ت';
                            break;
                        case 'j':
                            charFr = 'ج';
                            break;
                        case 'd':
                            charFr = 'د';
                            break;
                        case 'r':
                            charFr = 'ر';
                            break;
                        case 's':
                            charFr = 'ص';
                            break;
                        case 'c':
                            charFr = 'س';
                            break;
                        case 'D':
                            charFr = 'ض';
                            break;
                        case 'T':
                            charFr = 'ط';
                            break;
                        case 'f':
                            charFr = 'ف';
                            break;
                        case 'I':
                            charFr = 'إ';
                            break;
                        case 'v':
                            charFr = 'ڢ';
                            break;
                        case 'q':
                            charFr = 'ق';
                            break;
                        case 'k':
                            charFr = 'ك';
                            break;
                        case 'l':
                            charFr = 'ل';
                            break;
                        case 'm':
                            charFr = 'م';
                            break;
                        case 'n':
                            charFr = 'ن';
                            break;
                        case 'H':
                            charFr = 'ه';
                            break;
                        case 'w':
                            charFr = 'و';
                            break;
                        case 'y':
                            charFr = 'ي';
                            break;
                        case 'Y':
                            charFr = 'ى';
                            break;
                        case 'g':
                            charFr = 'ع';
                            break;
                        case 'z':
                            charFr = 'ز';
                            break;
                        //case '\n':                        Clipboard.SetText(tbAr.Text);                    break;
                        case '\'':
                            PrevCharFr = char.Parse(TextFr.Substring(end - 1, 1));
                            testRemoveEndChar = false;
                            switch (PrevCharFr)
                            {
                                case 't':
                                    charFr = 'ث';
                                    testRemoveEndChar = true;
                                    break;
                                case 'h':
                                    charFr = 'خ';
                                    testRemoveEndChar = true;
                                    break;
                                case 'j':
                                    charFr = 'چ';
                                    testRemoveEndChar = true;
                                    break;
                                case 'd':
                                    charFr = 'ذ';
                                    testRemoveEndChar = true;
                                    break;
                                case 'r':
                                    charFr = 'ز';
                                    testRemoveEndChar = true;
                                    break;
                                case 'c':
                                    charFr = 'ش';
                                    testRemoveEndChar = true;
                                    break;
                                case 's':
                                    charFr = 'ض';
                                    testRemoveEndChar = true;
                                    break;
                                case 'T':
                                    charFr = 'ظ';
                                    testRemoveEndChar = true;
                                    break;
                                case 'g':
                                    charFr = 'غ';
                                    testRemoveEndChar = true;
                                    break;
                                case 'f':
                                    charFr = 'ڤ';
                                    testRemoveEndChar = true;
                                    break;
                                case 'q':
                                    charFr = 'ڨ';
                                    testRemoveEndChar = true;
                                    break;
                                case 'k':
                                    charFr = 'ڭ';
                                    testRemoveEndChar = true;
                                    break;
                                case 'H':
                                    charFr = 'ة';
                                    testRemoveEndChar = true;
                                    break;

                            }
                            break;

                    }
                    if (testRemoveEndChar)
                    {
                        ar = ar.Remove(ar.Length - 1);
                        testRemoveEndChar = false;
                    }
                    ar += charFr;
                }

                textAR.Text = ar;
                Clipboard.SetText(ar);

            }
        }
        private void Ba_Click(object sender, EventArgs e)
        {
            textFR.Text += 'a';
        }
        private void Bh_Click(object sender, EventArgs e)
        {
            textFR.Text += 'h';
        }
        private void BAA_Click(object sender, EventArgs e)
        {
            textFR.Text += 'A';
        }
        private void B_a_Click(object sender, EventArgs e)
        {
            textFR.Text += 'à';
        }
        private void Bb_Click(object sender, EventArgs e)
        {
            textFR.Text += 'b';
        }
        private void Bp_Click(object sender, EventArgs e)
        {
            textFR.Text += 'p';
        }
        private void Bt_Click(object sender, EventArgs e)
        {
            textFR.Text += 't';
        }
        private void Bj_Click(object sender, EventArgs e)
        {
            textFR.Text += 'j';
        }
        private void Bd_Click(object sender, EventArgs e)
        {
            textFR.Text += 'd';
        }
        private void Br_Click(object sender, EventArgs e)
        {
            textFR.Text += 'r';
        }
        private void Bs_Click(object sender, EventArgs e)
        {
            textFR.Text += 's';
        }
        private void Bc_Click(object sender, EventArgs e)
        {
            textFR.Text += 'c';
        }
        private void BDD_Click(object sender, EventArgs e)
        {
            textFR.Text += 'D';
        }
        private void BTT_Click(object sender, EventArgs e)
        {
            textFR.Text += 'T';
        }
        private void Bf_Click(object sender, EventArgs e)
        {
            textFR.Text += 'f';
        }
        private void BII_Click(object sender, EventArgs e)
        {
            textFR.Text += 'I';
        }
        private void Bv_Click(object sender, EventArgs e)
        {
            textFR.Text += 'v';
        }
        private void Bq_Click(object sender, EventArgs e)
        {
            textFR.Text += 'q';
        }
        private void Bk_Click(object sender, EventArgs e)
        {
            textFR.Text += 'k';
        }
        private void Bl_Click(object sender, EventArgs e)
        {
            textFR.Text += 'l';
        }
        private void Bm_Click(object sender, EventArgs e)
        {
            textFR.Text += 'm';
        }
        private void Bn_Click(object sender, EventArgs e)
        {
            textFR.Text += 'n';
        }
        private void BHH_Click(object sender, EventArgs e)
        {
            textFR.Text += 'H';
        }
        private void Bw_Click(object sender, EventArgs e)
        {
            textFR.Text += 'w';
        }
        private void By_Click(object sender, EventArgs e)
        {
            textFR.Text += 'y';
        }
        private void BYY_Click(object sender, EventArgs e)
        {
            textFR.Text += 'Y';
        }
        private void Bg_Click(object sender, EventArgs e)
        {
            textFR.Text += 'g';
        }
        private void Bz_Click(object sender, EventArgs e)
        {
            textFR.Text += 'z';
        }
        private void Bt0_Click(object sender, EventArgs e)
        {
            textFR.Text += "t'";                      
        }
        private void Bh0_Click(object sender, EventArgs e)
        {
            textFR.Text += "h'";
        }
        private void Bj0_Click(object sender, EventArgs e)
        {
            textFR.Text += "j'";
        }
        private void Bd0_Click(object sender, EventArgs e)
        {
            textFR.Text += "d'";
        }
        private void Br0_Click(object sender, EventArgs e)
        {
            textFR.Text += "r'";
        }
        private void Bc0_Click(object sender, EventArgs e)
        {
            textFR.Text += "c'";
        }
        private void Bs0_Click(object sender, EventArgs e)
        {
            textFR.Text += "s'";
        }
        private void Bg0_Click(object sender, EventArgs e)
        {
            textFR.Text += "g'";
        }
        private void Bf0_Click(object sender, EventArgs e)
        {
            textFR.Text += "f'";
        }
        private void Bq0_Click(object sender, EventArgs e)
        {
            textFR.Text += "q'";
        }
        private void Bk0_Click(object sender, EventArgs e)
        {
            textFR.Text += "k'";
        }
        private void BHH0_Click(object sender, EventArgs e)
        {
            textFR.Text += "H'";
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link.");
            }
        }



        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited 
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser 
            //with a URL:
            System.Diagnostics.Process.Start("http://www.touch3d.tn");
        }
        
    }
}

/*
 * 
<td><input type="button" class="bt" onclick="alpha('ض')" value="ض"a></td>
<td><input type="button" class="bt" onclick="alpha('ص')" value="ص"a></td>
<td><input type="button" class="bt" onclick="alpha('ش')" value="ش"></td>
<td><input type="button" class="bt" onclick="alpha('س')" value="س"></td>
<td><input type="button" class="bt" onclick="alpha('ز')" value="ز"></td>
<td><input type="button" class="bt" onclick="alpha('ر')" value="ر"></td>
<td><input type="button" class="bt" onclick="alpha('ذ')" value="ذ"></td>
<td><input type="button" class="bt" onclick="alpha('د')" value="د"></td>
<td><input type="button" class="bt" onclick="alpha('خ')" value="خ"></td>
<td><input type="button" class="bt" onclick="alpha('ح')" value="ح"></td>
<td><input type="button" class="bt" onclick="alpha('ج')" value="ج"></td>
<td><input type="button" class="bt" onclick="alpha('ث')" value="ث"></td>
<td><input type="button" class="bt" onclick="alpha('ت')" value="ت"></td>
<td><input type="button" class="bt" onclick="alpha('ب')" value="ب"></td>
<td><input type="button" class="btb" onclick="alpha('ا')" value="ا"></td>
        private void button1_Click(objecharFr sender, EventArgs e)
        {
            //Définition des variables
            string contenu = "";
            char carac = 'a', carac2 = '4', carac3 = 'e', carac4 = '3';


            //on vide le contenu de la txtBoxBas au cas ou
            tb.Text = "";

            //on met le contenu de la txtBoxNormal dans la variable contenu
            contenu = textBox1.Text;

            //boucle qui s'effecharFrue sur la longueur de la chaine de caracharFrère contenu
            for (int i = 0; i < contenu.Length; i++)
            {
                //on cherche dans la chaine de caracharFrère a et on le remplace par 4
                if (carac == char.Parse(contenu.Substring(i, 1)))
                {
                    contenu.Replace(carac, carac2);
                    
                }
                //on cherche dans la chaine de caracharFrère e et on le remplace par 3
                if (carac3 == char.Parse(contenu.Substring(i, 1)))
                {
                    contenu.Replace(carac3, carac4);
                }

            }
            tb.Text = contenu.Replace(carac, carac2).Replace(carac3, carac4);
            //Label1.Text = Label1.Text.Replace("/r/n", "<br/>");
            //on affiche dans la txtBox du bas le résultat des modifications de la variable contenu
            //textBox2.Text = contenu;

        }

        private void textBox2_TextChanged(objecharFr sender, EventArgs e)
        {

        }

       
    }
}*/
/*
</tr>
<tr align="center"> 
<td><input type="button" class="bt" onclick="alpha('ض')" value="ض"a></td>
<td><input type="button" class="bt" onclick="alpha('ص')" value="ص"a></td>
<td><input type="button" class="bt" onclick="alpha('ش')" value="ش"></td>
<td><input type="button" class="bt" onclick="alpha('س')" value="س"></td>
<td><input type="button" class="bt" onclick="alpha('ز')" value="ز"></td>
<td><input type="button" class="bt" onclick="alpha('ر')" value="ر"></td>
<td><input type="button" class="bt" onclick="alpha('ذ')" value="ذ"></td>
<td><input type="button" class="bt" onclick="alpha('د')" value="د"></td>
<td><input type="button" class="bt" onclick="alpha('خ')" value="خ"></td>
<td><input type="button" class="bt" onclick="alpha('ح')" value="ح"></td>
<td><input type="button" class="bt" onclick="alpha('ج')" value="ج"></td>
<td><input type="button" class="bt" onclick="alpha('ث')" value="ث"></td>
<td><input type="button" class="bt" onclick="alpha('ت')" value="ت"></td>
<td><input type="button" class="bt" onclick="alpha('ب')" value="ب"></td>
<td><input type="button" class="btb" onclick="alpha('ا')" value="ا"></td>
</tr>
</table>
<br>
<table>
<tr align="center"> 
<td><input type="button" class="bt" onclick="alpha('ء')" value="ء"></td>
<td><input type="button" class="bt" onclick="alpha('ي')" value="ي"></td>
<td><input type="button" class="bt" onclick="alpha('و')" value="و"></td>
<td><input type="button" class="bt" onclick="alpha('ه')" value="ه"></td>
<td><input type="button" class="bt" onclick="alpha('ن')" value="ن"></td>
<td><input type="button" class="bt" onclick="alpha('م')" value="م"></td>
<td><input type="button" class="bt" onclick="alpha('ل')" value="ل"></td>
<td><input type="button" class="bt" onclick="alpha('ك')" value="ك"></td>
<td><input type="button" class="bt" onclick="alpha('ق')" value="ق"></td>
<td><input type="button" class="bt" onclick="alpha('ف')" value="ف"></td>
<td><input type="button" class="bt" onclick="alpha('غ')" value="غ"></td>
<td><input type="button" class="bt" onclick="alpha('ع')" value="ع"></td>
<td><input type="button" class="bt" onclick="alpha('ظ')" value="ظ"></td>
<td><input type="button" class="bt" onclick="alpha('ط')" value="ط"></td>
</tr>
</table>
<br>
<table>
<tr valign="top"> 
<td><input type="button" class="bt" onclick="alpha('ى')" value="ى"></td>
<td><input type="button" class="bt" onclick="alpha('ئ')" value="ئ"></td>
<td><input type="button" class="bt" onclick="alpha('ؤ')" value="ؤ"></td>
<td><input type="button" class="bt" onclick="alpha('ة')" value="ة"></td>
<td><input type="button" class="btb" onclick="alpha('إ')" value="إ"></td>
<td><input type="button" class="btb" onclick="alpha('أ')" value="أ"></td>
<td><input type="button" class="btb" onclick="alpha('ٱ')" value="ٱ"></td>
<td><input type="button" class="btb" onclick="alpha('آ')" value="آ"></td>
<td><input type="button" class="btb" title="fatḥa" onclick="alpha('َ')" value="َ&nbsp;"></td>
<td><input type="button" class="btb" title="tanwīn" onclick="alpha('ً')" value="ً&nbsp;"></td>
<td><input type="button" class="btb" title="ḍamma" onclick="alpha('ُ')" value="ُ&nbsp;"></td>
<td><input type="button" class="btb" title="tanwīn" onclick="alpha('ٌ')" value="ٌ&nbsp;"></td>
<td><input type="button" class="btb" title="šadda" onclick="alpha('ّ')" value="ّ&nbsp;"></td>
<td><input type="button" class="btb" title="sukūn" onclick="alpha('ْ')" value="ْ&nbsp;"></td>
<td><input type="button" class="btb" title="kasra" onclick="alpha('ِ')" value="ِ&nbsp;"></td>
<td><input type="button" class="btb" title="tanwīn" onclick="alpha('ٍ')" value="&#1613;&nbsp;"></td>
</tr>
</table>
<br>
<table>
<tr valign="top"> 
<td><input type="button" class="bt" onclick="alpha('؟')" value="؟"></td>
<td><input type="button" class="bt" onclick="alpha('؛')" value="؛"></td>
<td><input type="button" class="bt" onclick="alpha('،')" value="،"></td>
<td><input type="button" class="bt"  title="tatwil" onclick="alpha('ـ')" value="ـ"></td>
</tr>
</table>
<br>
<table>
<tr align="center"> 
<td>0</td>
<td>1</td>
<td>2</td>
<td>3</td>
<td>4</td>
<td>5</td>
<td>6</td>
<td>7</td>
<td>8</td>
<td>9</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr align="center"> 
<td><input type="button" class="bt" onclick="alpha('٠')" value="٠"></td>
<td><input type="button" class="bt" onclick="alpha('١')" value="١"></td>
<td><input type="button" class="bt" onclick="alpha('٢')" value="٢"></td>
<td><input type="button" class="bt" onclick="alpha('٣')" value="٣"></td>
<td><input type="button" class="bt" onclick="alpha('٤')" value="٤"></td>
<td><input type="button" class="bt" onclick="alpha('٥')" value="٥"></td>
<td><input type="button" class="bt" onclick="alpha('٦')" value="٦"></td>
<td><input type="button" class="bt" onclick="alpha('٧')" value="٧"></td>
<td><input type="button" class="bt" onclick="alpha('٨')" value="٨"></td>
<td><input type="button" class="bt" onclick="alpha('٩')" value="٩"></td>
<td><input type="button" class="bt"   title="séparateur de milliers" onclick="alpha('&#1644;')" value="&#1644;"></td>
<td><input type="button" class="bt"   title="séparateur décimal" onclick="alpha('&#1643;')" value="&#1643;"></td>
<td><input type="button" class="bt"   title="pourcentage" onclick="alpha('&#1642;')" value="&#1642;"></td>
*/