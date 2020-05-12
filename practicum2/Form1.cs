using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practicum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            num1Text.Text = rnd.Next(10).ToString();
            num2Text.Text = rnd.Next(10).ToString();
            num3Text.Text = rnd.Next(10).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(num1Text.Text);
            int num2 = Int32.Parse(num2Text.Text);
            int num3 = Int32.Parse(num3Text.Text);

            String output = MethodRunner.RunAllMethods(num1,num2,num3);
            methodOutput.Text = output;

            output = LambdaRunner.RunAllMethods(num1,num2,num3);
            lambdaOutput.Text = output;
            String[] splittextlambda = lambdaOutput.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
            String[] splittextmethod = methodOutput.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
            bool ok = true;
            for (int i = 0; i < splittextmethod.Length - 1; i++){
                if (splittextlambda[i].Split(new string[] { " = " }, StringSplitOptions.None).Last() != splittextmethod[i].Split(new string[] { " = " }, StringSplitOptions.None).Last()){
                    ok = false;
                    break;
                }
            }
            if (ok){
                System.Windows.Forms.MessageBox.Show("Output ok!");
            } else {
                System.Windows.Forms.MessageBox.Show("Output not ok!");
            }

        }
    }
}
