using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalcphiMobile.Models;
using CalcphiMobile.ViewModels;
using CalcphiMobile.Views;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Windows.Input;
using System.ComponentModel;


namespace CalcphiMobile.ViewModels
{
    public class MainScreenViewModel
    {
        string Equation = "hello";

        void One(object sender, EventArgs e)
        {
            Equation = Equation + "1";
        }
        void Two(object sender, EventArgs e)
        {
            Equation = Equation + "2";
        }
        void Plus(object sender, EventArgs e)
        {
            Equation = Equation + "+";
        }

    }
}