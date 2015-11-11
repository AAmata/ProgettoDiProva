using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoDiProva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //risultatoTxt.Text = "RISULTATO";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = 0;
            numero1 = Convert.ToInt32(num1Txt.Text);

            int numero2 = 0;
            numero2 = Convert.ToInt32(num2Txt.Text);

            int numero3 = numero1 + numero2;
            risultatoTxt.Text = numero3.ToString();
        }

        private void num1Txt_TextChanged(object sender, EventArgs e)
        {

        }


        // Ho creato l'evento Validating relativo alla prima textbox. 
        // Invece di effettuare i controlli sul primo numero nel bottone "+"
        // lo sto facendo direttamente nella textbox 1
        private void num1Txt_Validating(object sender, CancelEventArgs e)
        {

            int numero1 = 0;

            // prova a convertire in intero il testo dentro num1Txt e se 
            // il testo trovato è numerico, trasferisce quel valore (numerico) nella variabile numero1
            // Infine se la conversione è riuscita il booleano assumerà valore true
            bool conversioneValida1 = int.TryParse(num1Txt.Text, out numero1);


            // controllo casella vuota
            if(num1Txt.Text=="")
            {
                MessageBox.Show("ERRORE! La prima casella è vuota");
            }

            // controllo valore <0
            if (numero1 < 0)
            {
                MessageBox.Show("ERRORE! La prima casella contiene un valore negativo");
                num1Txt.Clear();
                num1Txt.Focus();
            }

            // controllo valore non numerico
            if (!conversioneValida1)
            {
                MessageBox.Show("ERRORE! Inserire un valore numerico nella prima casella");
                num1Txt.Clear();
                num1Txt.Focus();
            }

        }

        private void num2Txt_Validating(object sender, CancelEventArgs e)
        {
            int numero2 = 0;

            // prova a convertire in intero il testo dentro num2Txt e se 
            // il testo trovato è numerico, trasferisce quel valore (numerico) nella variabile numero2
            // Infine se la conversione è riuscita il booleano assumerà valore true
            bool conversioneValida2 = int.TryParse(num2Txt.Text, out numero2);


            // controllo casella vuota
            if (num2Txt.Text == "")
            {
                MessageBox.Show("ERRORE! La seconda casella è vuota");
            }

            //controllo valore <0
            if (numero2 < 0)
            {
                MessageBox.Show("ERRORE! La seconda casella contiene un valore negativo");
                num2Txt.Clear();
                num2Txt.Focus();
            }

            // controllo valore non numerico
            if (!conversioneValida2)
            {
                MessageBox.Show("ERRORE! Inserire un valore numerico nella seconda casella");
                num2Txt.Clear();
                num2Txt.Focus();
            }
        }


        // cliccando questo bottone impongo il maiuscolo nelle textbox
        private void button1_Click_1(object sender, EventArgs e)
        {
            // imposto un cursore diverso soltanto a questo tasto
            // dopo avere cliccato sul bottone, il cursore sulla casella 
            // risultato sarà una manina
            risultatoTxt.Cursor = Cursors.Hand;


            // cosi facendo cliccando sul bottone, cambierò il font 
            // della stringa digitata sulla texbox del risultato
            risultatoTxt.Font = new Font("Comics", 40, FontStyle.Strikeout);

            
            // adesso voglio visualizzare la terza linea
            MessageBox.Show(risultatoTxt.Lines[2]);

            provaTxt.CharacterCasing = CharacterCasing.Upper;
        }

        private void memoriaAggiungi_Click(object sender, EventArgs e)
        {

        }

        private void risultatoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void provaTxt_TextChanged(object sender, EventArgs e)
        {
            
        }


        // in questo modo quando tocco la barra si sposterà in un punto casuale e
        // stamperò anche a video la coordinata di spostamento
        private void provaTxt_MouseHover(object sender, EventArgs e)
        {
            Random x = new Random();

            provaTxt.Location = new Point(x.Next(200), x.Next(200));
            MessageBox.Show(provaTxt.Location.X.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}