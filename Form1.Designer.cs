namespace ProgettoDiProva
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sommaBtn = new System.Windows.Forms.Button();
            this.num1Txt = new System.Windows.Forms.TextBox();
            this.num2Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.risultatoTxt = new System.Windows.Forms.TextBox();
            this.risultatoMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.memoriaAggiungi = new System.Windows.Forms.ToolStripMenuItem();
            this.memoriaRichiama = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaMemoria = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.provaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.risultatoMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sommaBtn
            // 
            this.sommaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sommaBtn.Location = new System.Drawing.Point(89, 22);
            this.sommaBtn.Name = "sommaBtn";
            this.sommaBtn.Size = new System.Drawing.Size(57, 46);
            this.sommaBtn.TabIndex = 0;
            this.sommaBtn.Text = "+";
            this.sommaBtn.UseVisualStyleBackColor = true;
            this.sommaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // num1Txt
            // 
            this.num1Txt.Location = new System.Drawing.Point(26, 31);
            this.num1Txt.Name = "num1Txt";
            this.num1Txt.Size = new System.Drawing.Size(44, 20);
            this.num1Txt.TabIndex = 1;
            this.num1Txt.TextChanged += new System.EventHandler(this.num1Txt_TextChanged);
            this.num1Txt.Validating += new System.ComponentModel.CancelEventHandler(this.num1Txt_Validating);
            // 
            // num2Txt
            // 
            this.num2Txt.Location = new System.Drawing.Point(152, 31);
            this.num2Txt.Name = "num2Txt";
            this.num2Txt.Size = new System.Drawing.Size(44, 20);
            this.num2Txt.TabIndex = 2;
            this.num2Txt.Validating += new System.ComponentModel.CancelEventHandler(this.num2Txt_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // risultatoTxt
            // 
            this.risultatoTxt.ContextMenuStrip = this.risultatoMenuStrip1;
            this.risultatoTxt.Location = new System.Drawing.Point(229, 12);
            this.risultatoTxt.Multiline = true;
            this.risultatoTxt.Name = "risultatoTxt";
            this.risultatoTxt.Size = new System.Drawing.Size(166, 70);
            this.risultatoTxt.TabIndex = 4;
            this.risultatoTxt.Text = "prima \r\nseconda \r\nterza\r\n";
            this.risultatoTxt.TextChanged += new System.EventHandler(this.risultatoTxt_TextChanged);
            // 
            // risultatoMenuStrip1
            // 
            this.risultatoMenuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("risultatoMenuStrip1.BackgroundImage")));
            this.risultatoMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoriaAggiungi,
            this.memoriaRichiama,
            this.cancellaMemoria});
            this.risultatoMenuStrip1.Name = "risultatoMenuStrip1";
            this.risultatoMenuStrip1.Size = new System.Drawing.Size(172, 70);
            // 
            // memoriaAggiungi
            // 
            this.memoriaAggiungi.Name = "memoriaAggiungi";
            this.memoriaAggiungi.Size = new System.Drawing.Size(171, 22);
            this.memoriaAggiungi.Text = "memoriaAggiungi";
            this.memoriaAggiungi.Click += new System.EventHandler(this.memoriaAggiungi_Click);
            // 
            // memoriaRichiama
            // 
            this.memoriaRichiama.Name = "memoriaRichiama";
            this.memoriaRichiama.Size = new System.Drawing.Size(171, 22);
            this.memoriaRichiama.Text = "memoriaRichiama";
            // 
            // cancellaMemoria
            // 
            this.cancellaMemoria.Name = "cancellaMemoria";
            this.cancellaMemoria.Size = new System.Drawing.Size(171, 22);
            this.cancellaMemoria.Text = "Cancella Memoria";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // provaTxt
            // 
            this.provaTxt.Location = new System.Drawing.Point(26, 85);
            this.provaTxt.Multiline = true;
            this.provaTxt.Name = "provaTxt";
            this.provaTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.provaTxt.Size = new System.Drawing.Size(120, 56);
            this.provaTxt.TabIndex = 6;
            this.provaTxt.Text = "prima\r\nseconda\r\nterza\r\nquarta\r\nquinta lunghisssssssssssssssssssssssssssssssssssss" +
    "sssssssssssima\r\nsesta\r\nsettima\r\nottava";
            this.provaTxt.WordWrap = false;
            this.provaTxt.TextChanged += new System.EventHandler(this.provaTxt_TextChanged);
            this.provaTxt.MouseHover += new System.EventHandler(this.provaTxt_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Pulsante di prova per Git";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.provaTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.risultatoTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num2Txt);
            this.Controls.Add(this.num1Txt);
            this.Controls.Add(this.sommaBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.risultatoMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sommaBtn;
        private System.Windows.Forms.TextBox num1Txt;
        private System.Windows.Forms.TextBox num2Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox risultatoTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox provaTxt;
        private System.Windows.Forms.ContextMenuStrip risultatoMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memoriaAggiungi;
        private System.Windows.Forms.ToolStripMenuItem memoriaRichiama;
        private System.Windows.Forms.ToolStripMenuItem cancellaMemoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

