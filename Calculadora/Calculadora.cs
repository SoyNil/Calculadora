using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClaseSuma obj = new Clases.ClaseSuma();
        Clases.ClaseResta obj2 = new Clases.ClaseResta();
        Clases.ClaseMultiplicacion obj3 = new Clases.ClaseMultiplicacion();
        Clases.ClaseDivision obj4 = new Clases.ClaseDivision();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void boton0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void botonpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void division_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botonigual_Click(object sender, EventArgs e)
        {
            segundo=double.Parse(pantalla.Text);
            double Sum;
            double Res;
            double Mul;
            double Div;
            switch(operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    pantalla.Text=Sum.ToString();
                    break;
                case "-":
                    Res=obj2.Resta((primero), (segundo));
                    pantalla.Text = Res.ToString();
                    break;
                case "*":
                    Mul=obj3.Multiplicacion((primero), (segundo));
                    pantalla.Text=Mul.ToString();
                    break;
                case "/":
                    Div=obj4.Division((primero), (segundo));
                    pantalla.Text=(Div.ToString());
                    break;
            }

        }

        private void botonborrar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void botoneliminar_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length == 1) 
                pantalla.Text = "";
            else
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
        }
    }
}
