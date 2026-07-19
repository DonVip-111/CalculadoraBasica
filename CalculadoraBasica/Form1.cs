using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Calculadora : Form
    {
        public double num1, num2, resultado;
        public bool Is1, Is2, Ex_op;
        int operacion;

        public Calculadora()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }
        public void limpiar_Pantalla() //Para limpiar el textbos llamado "Pantalla"
        {
            pantalla.Text = "";
        }
        public double obtener_valor()//Transforma lo que recibe el textbox a numerico
        {
            double valor = Convert.ToDouble(pantalla.Text);
            limpiar_Pantalla();
            return valor;
        }
        public void actualizar_pantalla(String texto)//Actualiza lo que se vizualisa en el textbox
        {
            pantalla.Text = pantalla.Text + texto;
        }
        //Todos los botones del teclado
        private void btn0_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("0");
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("1");
        }
        private void bt2_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("2");
        }
        private void bt3_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("3");
        }
        private void bt4_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("4");
        }
        private void bt5_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("5");
        }
        private void bt6_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("6");
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("7");
        }
        private void bt8_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("8");
        }
        private void bt9_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("9");
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            actualizar_pantalla(".");
        }
        //Boton del C
        private void C_Click(object sender, EventArgs e)
        {
            limpiar_Pantalla();
        }
        //Boton CE
        private void ce_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length > 0)
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
        }
        //Operaciones Matematicas
        private void btnMas_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                num1 = obtener_valor();
                Is1 = true; //Actualizamos el valor de la variable de control
                operacion = 0; // 0 indica la operacion matematica suma
            }
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                num1 = obtener_valor();
                Is1 = true; //Actualizamos el valor de la variable de control
                operacion = 1; // 1 indica la operacion matematica resta
            }
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                num1 = obtener_valor();
                Is1 = true; //Actualizamos el valor de la variable de control
                operacion = 2; // 2 indica la operacion matematica multiplicacion
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                num1 = obtener_valor();
                Is1 = true; //Actualizamos el valor de la variable de control
                operacion = 3; // 3 indica la operacion matematica division
            }
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Operaciones +,-,*,/
            try
            {
                if (operacion == 0) //Si se ha presionado el boton de la "suma"
                {
                    if (Is1)
                    {
                        num2 = obtener_valor();//Obtener el segundo operando de la operacio suma
                        actualizar_pantalla(operar(num1, num2, "+").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operados");
            }
            try
            {
                if (operacion == 1) //Si se ha presionado el boton de la "resta"
                {
                    if (Is1)
                    {
                        num2 = obtener_valor();//Obtener el segundo operando de la operacio resta
                        actualizar_pantalla(operar(num1, num2, "-").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operados");
            }
            try
            {
                if (operacion == 2) //Si se ha presionado el boton de la "multiplicacion"
                {
                    if (Is1)
                    {
                        num2 = obtener_valor();//Obtener el segundo operando de la operacio multiplicacion
                        actualizar_pantalla(operar(num1, num2, "*").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operados");
            }
            try
            {
                if (operacion == 3) //Si se ha presionado el boton de la "division"
                {
                    if (Is1)
                    {
                        num2 = obtener_valor();//Obtener el segundo operando de la operacio division
                        if (num2 == 0)
                        {
                            //Si el usuario ingresa una division entre 0
                            MessageBox.Show("Error:No existe division por cero");
                            limpiar_Pantalla();
                        }
                        else
                            actualizar_pantalla(operar(num1, num2, "/").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operados");
            }
            //Cos, sen, tan, log, ln, n^x
            try
            {
                if (operacion == 4) //Si se ha presionado el boton de la "potencia"
                {
                    if (Is2)
                    {
                        num2 = obtener_valor();//Obtener el segundo operando de la operacio de potencia
                        actualizar_pantalla(operar(num1, num2, "n").ToString());
                        Is2 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operados");
            }
            try
            {
                if (operacion == 5) //Si se ha presionado el boton de la "tangente"
                {
                    if (Is2)
                    {
                        limpiar_Pantalla();
                        actualizar_pantalla(opEsp(num1, "tan").ToString());
                        Is2 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere un operador");
            }
            try
            {
                if (operacion == 6) //Si se ha presionado el boton de la "cosiente"
                {
                    if (Is2)
                    {
                        limpiar_Pantalla();
                        actualizar_pantalla(opEsp(num1, "cos").ToString());
                        Is2 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere un operador");
            }
            try
            {
                if (operacion == 7) //Si se ha presionado el boton de la "seno"
                {
                    if (Is2)
                    {
                        limpiar_Pantalla();
                        actualizar_pantalla(opEsp(num1, "sen").ToString());
                        Is2 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere un operador");
            }
            try
            {
                if (operacion == 8) //Si se ha presionado el boton de "ln"
                {
                    if (Is2)
                    {
                        limpiar_Pantalla();
                        actualizar_pantalla(opEsp(num1, "ln").ToString());
                        Is2 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere un operador");
            }
            try
            {
                if (operacion == 9) //Si se ha presionado el boton de "log"
                {
                    if (Is2)
                    {
                        limpiar_Pantalla();
                        actualizar_pantalla(opEsp(num1, "log").ToString());
                        Is2 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere un operador");
            }
        }
        //Funcion de operar para las operaciones +,-,*,/,n^x
        public double operar(double operador1, double operador2, String signo)
        {
            double Resultado = 0.0;
            switch (signo)
            {
                case "+":
                    Resultado = operador1 + operador2;
                    break;
                case "-":
                    Resultado = operador1 - operador2;
                    break;
                case "*":
                    Resultado = operador1 * operador2;
                    break;
                case "/":
                    Resultado = operador1 / operador2;
                    break;
                case "n":
                    Resultado = Math.Pow(operador1, operador2);
                    break;
                default:
                    break;
            }
            return Resultado;
        }
        //Operaciones especiales tan, sen, cos, ln, log
        public double opEsp(double operador1, String op)
        {
            double Resultado = 0.0;
            switch (op)
            {
                case "tan":
                    Resultado = Math.Tan(operador1);
                    break;
                case "sen":
                    Resultado = Math.Sin(operador1);
                    break;
                case "cos":
                    Resultado = Math.Cos(operador1);
                    break;
                case "ln":
                    Resultado = Math.Log(operador1);
                    break;
                case "log":
                    Resultado = Math.Log10(operador1);
                    break;
                default:
                    break;
            }
            return Resultado;
        }
        //Botones de operaciones especiales
        private void btnN_Click(object sender, EventArgs e)
        {
            if (!Is2)
            {
                num1 = obtener_valor();
                Is2 = true; //Actualizamos el valor de la variable de control
                operacion = 4; // 4 indica la operacion para elevar potencias
            }
        }
        private void btnTan_Click(object sender, EventArgs e)
        {
            if (!Is2)
            {
                num1 = Convert.ToDouble(pantalla.Text);//Obtener el operando de tangente
                Is2 = true; //Actualizamos el valor de la variable de control
                operacion = 5; // 5 indica la operacion para tangente
            }
        }
        private void btCos_Click(object sender, EventArgs e)
        {
            if (!Is2)
            {
                num1 = Convert.ToDouble(pantalla.Text);//Obtener el operando cosiente
                Is2 = true; //Actualizamos el valor de la variable de control
                operacion = 6; // 6 indica la operacion para cosiente
            }
        }
        private void btnSen_Click(object sender, EventArgs e)
        {
            if (!Is2)
            {
                num1 = Convert.ToDouble(pantalla.Text);//Obtener el segundo operando de seno
                Is2 = true; //Actualizamos el valor de la variable de control
                operacion = 7; // 7 indica la operacion para seno
            }
        }
        private void btnLn_Click(object sender, EventArgs e)
        {
            if (!Is2)
            {
                num1 = Convert.ToDouble(pantalla.Text);//Obtener el segundo operando de ln
                Is2 = true; //Actualizamos el valor de la variable de control
                operacion = 8; // 8 indica la operacion para ln
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (!Is2)
            {
                num1 = Convert.ToDouble(pantalla.Text);//Obtener el segundo operando de log
                Is2 = true; //Actualizamos el valor de la variable de control
                operacion = 9; // 9 indica la operacion para log
            }
        }
    }
}
