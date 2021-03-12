using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcphiMobile.Models;
using CalcphiMobile.ViewModels;
using CalcphiMobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Athena_Engine;

namespace CalcphiMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainScreen : ContentPage
    {
        public MainScreen()
        {

            InitializeComponent();
            Equation.Text = "";
            
        }

        string ans = "";

        void Zero(object sender, EventArgs e)
        {

            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "0";
        }

        void One(object sender, EventArgs e)
        {
            
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "1";
        }
        void Two(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "2";
        }
        void Three(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "3";
        }
        void Four(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "4";
        }
        void Five(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "5";
        }
        void Six(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "6";
        }
        void Seven(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "7";
        }
        void Eight(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "8";
        }
        void Nine(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "9";
        }
        void Dot(object sender, EventArgs e)
        {

            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + ".";
        }

        void Plus(object sender, EventArgs e)
        {
            if (Result.Text == "Error")
            {
                Equation.Text = Equation.Text;
                Result.Text = "";

            }

            if (Result.Text != "")
            {
                Equation.Text = Result.Text; 
                Result.Text = "";

            }

            Equation.Text = Equation.Text + "+";
        }
        void Minus(object sender, EventArgs e)
        {
            if (Result.Text == "Error")
            {
                Equation.Text = Equation.Text;
                Result.Text = "";

            }
            if (Result.Text != "")
            {
                Equation.Text = Result.Text;
                Result.Text = "";

            }
            

            Equation.Text = Equation.Text + "-";
        }
        void Multiplication(object sender, EventArgs e)
        {
            if (Result.Text == "Error")
            {
                Equation.Text = Equation.Text;
                Result.Text = "";

            }
            if (Result.Text != "")
            {
                Equation.Text = Result.Text;
                Result.Text = "";

            }

            Equation.Text = Equation.Text + "*";
        }
        void Division(object sender, EventArgs e)
        {
            if (Result.Text == "Error")
            {
                Equation.Text = Equation.Text;
                Result.Text = "";

            }
            if (Result.Text != "")
            {
                Equation.Text = Result.Text;
                Result.Text = "";

            }

            Equation.Text = Equation.Text + "/";
        }
        void Exponent(object sender, EventArgs e)
        {
            if (Result.Text == "Error")
            {
                Equation.Text = Equation.Text;
                Result.Text = "";

            }
            if (Result.Text != "")
            {
                Equation.Text = Result.Text;
                Result.Text = "";

            }

            Equation.Text = Equation.Text + "^";
        }
        void OpenBrackets(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "(";
        }
        void CloseBrackets(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + ")";
        }

        void Pi(object sender, EventArgs e)
        {

            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "π";
        }


        void EXP(object sender, EventArgs e)
        {

            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "*10^";
        }
        void Ans(object sender, EventArgs e)
        {

            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + ans;
        }
        void Backspace(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = Equation.Text.Substring(0, Equation.Text.Length);

            }
            if (Equation.Text == "")
            {
                Equation.Text = "";

            }
            else
            {
                Equation.Text = Equation.Text.Remove(Equation.Text.Length - 1);

            }

            
        }


        Tokenizer t = new Tokenizer();
        Parser p = new Parser();
        Solver s = new Solver();


        void Equal(object sender, EventArgs e)
        {

            if (Equation.Text == "")
            {
                Equation.Text = "";

            }
            else
            {
                try
                {
                    Equation.Text = Equation.Text.Replace(",", ".");
                    List<Node> nodes = t.Tokenize(RealEquation(Equation.Text));
                    Node nf = p.Parse(nodes);
                    Result.Text = Convert.ToString(s.Solve(nf));
                    ans = Result.Text;
                }
                catch
                {
                    Result.Text = "Error";
                }


            }


        }
        public static string RealEquation(string e)
        {
            string re = e.Replace("π", "pi");

            for (int i = 0; i < (re.Length - 1); i++)
            {               

                if (Char.IsDigit(re[i]) && Char.IsLetter(re[i + 1]))
                {
                    re = re.Substring(0, i + 1) + "*" + re.Substring(i + 1, re.Length - (i + 1));

                }
                if ((Char.IsDigit(re[i]) && re[i + 1] == '(') || (re[i] ==')' && Char.IsDigit(re[i+1])))
                {
                    re = re.Substring(0, i + 1) + "*" + re.Substring(i + 1, re.Length - (i + 1));

                }
                if (Char.IsLetter(re[i]) && Char.IsDigit(re[i + 1]))
                {
                    re = re.Substring(0, i + 1) + "*" + re.Substring(i + 1, re.Length - (i + 1));

                }
                if ((Char.IsLetter(re[i]) && re[i + 1] == '(') || (re[i] == ')' && Char.IsLetter(re[i + 1])))
                {
                    re = re.Substring(0, i + 1) + "*" + re.Substring(i + 1, re.Length - (i + 1));

                }
                if (re[i] == '-' && re[i + 1] == '(')
                {
                    re = re.Substring(0, i + 1) + "1*" + re.Substring(i + 1, re.Length - (i + 1));
                }



            }

            return re;
        }


    }
}