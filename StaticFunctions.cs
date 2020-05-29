using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public static class StaticFunctions
    {
        public static void ChangeScreens(Form f1, Form f2)
        {
            f1.Hide();
            f2.ShowDialog();
            f1.Close();
        }
    }
}
