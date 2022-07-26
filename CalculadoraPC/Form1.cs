using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Ejecutanos la variable ultimaEntrada y ejecutamos la funcion NINGUNA
            ultimaEntrada = Entrada.NINGUNA;
            comaDecimal = false;
            operador = '\0'; //INICIAR LA VARIABLE NULO
            numOperandos = 0;
            operando1 = 0;
            operando2 = 0;
        }

        private enum Entrada
        {
            NINGUNA,
            DIGITO,
            OPERADOR,
            CE
        }

        private Entrada ultimaEntrada;
        //Crearemos una nueva variable llamada comaDecimal que nos servira para que cada vez que se
        //se precione el boton, este se pondra y aparte no se podra repetir
        private bool comaDecimal;
        private char operador;
        private byte numOperandos;
        private double operando1;
        private double operando2;

        /*Para este evento tendremosque seleccionar desde el boton 0 al 9*/
        private void btDigito_Click(object sender, EventArgs e)
        {
            /*con este comando cuando demos click a un boton de los 10 seleccionados aparecera
             * en el texbox es decir cambiara el texto por el numero que seleccionemos ya que toma 
             * el texto del boton y lo pone en el texbox.*/
            Button objButton = (Button)sender;

            /*Explicacion del if cada vez que introducimos un digito este eliminara el texto
             * y se colocara y se ira sumando es decir se ira escribiendo.
             *      Pero si se escribe al iniciar un 0 no ara nada es decir el texto quedara
             *      igual.*/
            if (ultimaEntrada != Entrada.DIGITO)
            {
                //Este comando solo funcionara si el primer diguito es 0
                if (objButton.Text == "0") return;
                {
                    textBox1.Text = "";
                    ultimaEntrada = Entrada.DIGITO;
                    comaDecimal = false;
                }
            }

            textBox1.Text += objButton.Text;
        }

        /*Con este if cuando nosotros damos en el boton coma este realizara la siguiente accion dependiedo
         * de si se avia introduciodo antes un numero o si no, y se agregara la coma pero al momento de que se
         * agrega la coma este bloqueara por asi decirlo ya que tomara el valor de true.*/
        private void button11_Click(object sender, EventArgs e)
        {
            if (ultimaEntrada != Entrada.DIGITO)
            {
                textBox1.Text = "0,";
                ultimaEntrada = Entrada.DIGITO;
            }
            else if (comaDecimal == false)
            {
                textBox1.Text = textBox1.Text + ",";
            }
            comaDecimal = true;
        }

        /*Lo que hace esta funcion es que cuando nosotros seleccionamos algun boton de 
         * operaciones esta no aparecera pero estara por asi decirlo ya ejecutandoce,
         * asi que cuando seleccionamos un boton no realizara la operacion.*/
        private void btOperacion(object sender, EventArgs e)
        {
                    /*Explicacion de esta funcion: Cuando nosotros colocamos el numero este queda guardado en 
                     * Entrada.DIGITO pero cuando seleccionamos algun boton de operacion este sumara 1 a numOperandos
                     * dando asi un valor 1 al tener este valor pasara a operando1 a tener el valor del textbox1 en
                     * ese momento es decir tendra la cantidad introducida despues de eso el textbox no cambiara su
                     * texto, pero si pasara a poder recibir nuevamente datos ya que Entrada sera OPERADOR,
                     * y cuando introducimos nuevamente los numeros tendra que sumar 1 a numOperandos sando asi 2 
                     * por lo que tomara ese valor y como esta dentro de ese if permitira hacer los case dependiendo
                     * del boton que apretamos dando asi el resultado.*/
            try
            {
                //Obtener el ID del boton que genero el evento
                //Usando el sender como ya lo realisamos con el juego del gato
                Button objButton = (Button)sender;

                //Texto del botton pulsado
                string textoBoton = objButton.Text;

                if (ultimaEntrada == Entrada.DIGITO)
                {
                    numOperandos += 1;
                }
                if (numOperandos == 1)
                {
                    operando1 = double.Parse(textBox1.Text);
                }
                else if (numOperandos == 2)
                {
                    operando2 = double.Parse(textBox1.Text);

                    switch (operador)
                    {
                        case '+':
                            operando1 += operando2;
                            break;
                        case '-':
                            operando1 -= operando2;
                            break;
                        case 'x':
                            operando1 *= operando2;
                            break;
                        case '/':
                            operando1 /= operando2;
                            break;
                        case '=':
                            operando1 = operando2;
                            break;
                    }

                    //Visualizamos el resultado
                    textBox1.Text = operando1.ToString();
                    numOperandos = 1;
                }
                operador = textoBoton[0]; //Caracter de la posicion 0
                ultimaEntrada = Entrada.OPERADOR;
            }
            catch (Exception error)
            {
                MessageBox.Show("Preccione solamente los botones: " + error.Message);
            }
        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            double resultado;
            if (ultimaEntrada == Entrada.DIGITO)
            {
                resultado = operando1 * double.Parse(textBox1.Text) / 100;
                //Visualizar el resultado
                textBox1.Text = resultado.ToString();
                //Simular que se ha hecho click en =
                btnigual.PerformClick();
                //Enfocar la tecla %
                btnporcentaje.Focus();
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0.";
            ultimaEntrada = Entrada.NINGUNA;
            comaDecimal = false;
            operador = '\0';
            numOperandos = 0;
            operando1 = 0;
            operando2 = 0;
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0.";
            ultimaEntrada = Entrada.CE;
            comaDecimal = false;
        }
    }
}
