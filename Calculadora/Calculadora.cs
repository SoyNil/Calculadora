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
        private bool primerNumeroIngresado = false;
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void boton0_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "No se puede dividir por cero")
                pantalla.Clear();
                pantalla.Text = pantalla.Text + "0";
                primerNumeroIngresado = true;
        }
        private void boton1_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "No se puede dividir por cero")
                pantalla.Clear();
                pantalla.Text = pantalla.Text + "1";
                primerNumeroIngresado = true;
        }
        private void boton2_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "No se puede dividir por cero")
                pantalla.Clear();
                pantalla.Text = pantalla.Text + "2";
                primerNumeroIngresado = true;
        }
        private void boton3_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "No se puede dividir por cero")
                pantalla.Clear();
                pantalla.Text = pantalla.Text + "3";
                primerNumeroIngresado = true;
        }
        private void boton4_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "No se puede dividir por cero")
                pantalla.Clear();
                pantalla.Text = pantalla.Text + "4";
                primerNumeroIngresado = true;
        }
        private void boton5_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "No se puede dividir por cero")
                pantalla.Clear();
                pantalla.Text = pantalla.Text + "5";            
                primerNumeroIngresado = true;
        }
        private void boton6_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "No se puede dividir por cero")
                pantalla.Clear();
                pantalla.Text = pantalla.Text + "6";
                primerNumeroIngresado = true;
        }
        private void boton7_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "No se puede dividir por cero")
                pantalla.Clear();
                pantalla.Text = pantalla.Text + "7";
                primerNumeroIngresado = true;
        }
        private void boton8_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "No se puede dividir por cero")
                pantalla.Clear();
                pantalla.Text = pantalla.Text + "8";
                primerNumeroIngresado = true;
        }
        private void boton9_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "No se puede dividir por cero")
                pantalla.Clear();
                pantalla.Text = pantalla.Text + "9";
                primerNumeroIngresado = true;
        }
        private void botonpunto_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "No se puede dividir por cero")
                pantalla.Clear();
                pantalla.Text = pantalla.Text + ".";
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
        }
        private void suma_Click(object sender, EventArgs e)
        {
            if (!primerNumeroIngresado)
                return;
            operador = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
        private void resta_Click(object sender, EventArgs e)
        {
            if (!primerNumeroIngresado)
                return;
            operador = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
        private void multiplicacion_Click(object sender, EventArgs e)
        {
            if (!primerNumeroIngresado)
                return;
            operador = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
        private void division_Click(object sender, EventArgs e)
        {
            if (!primerNumeroIngresado)
                return;
            operador = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
        private void botonigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);
            double resultado;
            switch (operador)
            {
                case "+":
                    resultado = obj.Sumar(primero, segundo);
                    break;
                case "-":
                    resultado = obj2.Resta(primero, segundo);
                    break;
                case "*":
                    resultado = obj3.Multiplicacion(primero, segundo);
                    break;
                case "/":
                    try
                    {
                        resultado = obj4.Division(primero, segundo);
                    }
                    catch (DivideByZeroException)
                    {
                        pantalla.Text = "No se puede dividir por cero";
                        return;
                    }
                    break;
                default:
                    throw new InvalidOperationException("Operador no válido");
            }
            pantalla.Text = resultado.ToString();
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
        private void pantalla_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
