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
    public partial class Derivative : ContentPage
    {
        public Derivative()
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
        void Root(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "√(";
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

        void LetterX(object sender, EventArgs e)
        {

            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "x";
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

        void EXP(object sender, EventArgs e)
        {

            if (Result.Text != "")
            {
                Result.Text = "";
                Equation.Text = "";

            }

            Equation.Text = Equation.Text + "*10^";
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
        Simplifier simp = new Simplifier();
        Derivator d = new Derivator();

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
                    nf.f = Flags.Derivate;
                    Node nd = d.Derivate(nf);

                    Result.Text = RealResult(OrganizeTree(nd, nd));
                    ans = Result.Text;
                }
                catch
                {
                    Result.Text = "Error";

                }


            }


        }





        public static string OrganizeTree(Node n, Node previous_n) //O Diogo é Rei e fez isto sozinho
        {
            string parcel = "";
            switch (n.t)
            {
                case Types.Double:
                    parcel = Convert.ToString(n.value);

                    break;
                case Types.Operator:

                    switch (n.op)
                    {

                        case Operators.Addition:

                            parcel = "+";
                            break;
                        case Operators.Subtraction:

                            parcel = "-";
                            break;
                        case Operators.Multiplication:

                            parcel = "*";
                            break;
                        case Operators.Division:

                            parcel = "/";
                            break;
                        case Operators.Exponent:

                            parcel = "^";
                            break;

                    }

                    break;

                case Types.Variable:
                    parcel = Convert.ToString(n.var);

                    break;
            }

            if (n.exp[0] == null && n.exp[1] == null)
            {

                return parcel;

            }


            string ParcelLeft = "";
            string ParcelRight = "";

            ParcelLeft = OrganizeTree(n.exp[0], n);
            ParcelRight = OrganizeTree(n.exp[1], n);

            string Equation = "";

            if (n.priority_value > previous_n.priority_value || (n == previous_n && n.priority_value == 1))
            {
                Equation = "(" + ParcelLeft + parcel + ParcelRight + ")";
            }
            else
            {
                Equation = ParcelLeft + parcel + ParcelRight;
            }


            return Equation;

        }

        public static string RealEquation(string e)
        {
            string re = e;

            for (int i = 0; i < (re.Length - 1); i++)
            {
                if (Char.IsDigit(re[i]) && Char.IsLetter(re[i + 1]))
                {
                    re = re.Substring(0, i + 1) + "*" + re.Substring(i + 1, re.Length - (i + 1));

                }
                if ((Char.IsDigit(re[i]) && re[i + 1] == '(') || (re[i] == ')' && Char.IsDigit(re[i + 1])))
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
                if (re[i] == '-' && Char.IsLetter(re[i + 1]))
                {
                    re = re.Substring(0, i + 1) + "1*" + re.Substring(i + 1, re.Length - (i + 1));
                }
                if ((Char.IsDigit(re[i]) || Char.IsLetter(re[i])) && re[i + 1] == '√')
                {
                    re = re.Substring(0, i + 1) + "*" + re.Substring(i + 1, re.Length - (i + 1));

                }


            }

            re = re.Replace("√(", "root2(");


            return re;
        }
        public static string RealResult(string rr)
        {
            rr = rr.Replace(",", ".");

            for (int i = 0; i < (rr.Length - 2); i++)
            {
                if (Char.IsDigit(rr[i]) && rr[i + 1] == '*' && Char.IsLetter(rr[i + 2]))
                {
                    rr = rr.Remove(i + 1, 1);

                }
                if (Char.IsDigit(rr[i]) && rr[i + 1] == '*' && rr[i + 2] == '(')
                {
                    rr = rr.Remove(i + 1, 1);

                }

            }
            for (int i = 0; i < (rr.Length - 4); i++) //Transforms ^1/2 into square roots
            {
                bool foundparentesis = false;
                int extracounter = 0; //to count extra parentesis 

                if (rr.Substring(i, 5) == ")^0.5")
                {
                    for (int i2 = i - 1; foundparentesis == false; i2--)
                    {

                        if (rr[i2] == ')')
                        {

                            extracounter = extracounter + 1;

                        }

                        if (rr[i2] == '(' && extracounter == 0)
                        {
                            rr = rr.Substring(0, i2) + "√" + rr.Substring(i2, rr.Length - (i2));

                            rr = rr.Remove(i + 2, 4);

                            foundparentesis = true;
                        }
                        else if (rr[i2] == '(' && extracounter != 0)
                        {

                            extracounter = extracounter - 1;

                        }


                    }

                }
            }


            rr = rr.Replace("-1x", "-x");

            return rr;
        }
    }
}