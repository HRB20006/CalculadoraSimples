namespace CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonVirg = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonRaiz = new System.Windows.Forms.Button();
            this.buttonParen = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(320, 82);
            this.textBoxDisplay.TabIndex = 1;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.Red;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEnter.Location = new System.Drawing.Point(257, 380);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 126);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Tag = "";
            this.buttonEnter.Text = "=";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonSoma
            // 
            this.buttonSoma.BackColor = System.Drawing.Color.Red;
            this.buttonSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSoma.Location = new System.Drawing.Point(257, 248);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(75, 60);
            this.buttonSoma.TabIndex = 3;
            this.buttonSoma.Text = "+";
            this.buttonSoma.UseVisualStyleBackColor = false;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.Red;
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDiv.Location = new System.Drawing.Point(257, 116);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 60);
            this.buttonDiv.TabIndex = 4;
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.BackColor = System.Drawing.Color.Red;
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMult.Location = new System.Drawing.Point(257, 182);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(75, 60);
            this.buttonMult.TabIndex = 5;
            this.buttonMult.Text = "×";
            this.buttonMult.UseVisualStyleBackColor = false;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.Color.Red;
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSub.Location = new System.Drawing.Point(257, 314);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 60);
            this.buttonSub.TabIndex = 6;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonCansel
            // 
            this.buttonCansel.BackColor = System.Drawing.Color.Red;
            this.buttonCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCansel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCansel.Location = new System.Drawing.Point(95, 116);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(75, 60);
            this.buttonCansel.TabIndex = 7;
            this.buttonCansel.Text = "CE";
            this.buttonCansel.UseVisualStyleBackColor = false;
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Red;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDel.Location = new System.Drawing.Point(14, 116);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 60);
            this.buttonDel.TabIndex = 8;
            this.buttonDel.Text = "⇐";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Red;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button0.Location = new System.Drawing.Point(95, 446);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 60);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(14, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(95, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(176, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 60);
            this.button3.TabIndex = 12;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(14, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 60);
            this.button4.TabIndex = 13;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(95, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 60);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(176, 314);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 60);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(14, 248);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 60);
            this.button7.TabIndex = 16;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(95, 248);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 60);
            this.button8.TabIndex = 17;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(176, 248);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 60);
            this.button9.TabIndex = 18;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonVirg
            // 
            this.buttonVirg.BackColor = System.Drawing.Color.Red;
            this.buttonVirg.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVirg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVirg.Location = new System.Drawing.Point(176, 446);
            this.buttonVirg.Name = "buttonVirg";
            this.buttonVirg.Size = new System.Drawing.Size(75, 60);
            this.buttonVirg.TabIndex = 19;
            this.buttonVirg.Text = ",";
            this.buttonVirg.UseVisualStyleBackColor = false;
            this.buttonVirg.Click += new System.EventHandler(this.buttonVirg_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Red;
            this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCopy.Location = new System.Drawing.Point(14, 446);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 60);
            this.buttonCopy.TabIndex = 20;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(176, 182);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 60);
            this.button10.TabIndex = 21;
            this.button10.Text = "%";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // buttonRaiz
            // 
            this.buttonRaiz.BackColor = System.Drawing.Color.Red;
            this.buttonRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaiz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRaiz.Location = new System.Drawing.Point(14, 182);
            this.buttonRaiz.Name = "buttonRaiz";
            this.buttonRaiz.Size = new System.Drawing.Size(75, 60);
            this.buttonRaiz.TabIndex = 22;
            this.buttonRaiz.Text = "√";
            this.buttonRaiz.UseVisualStyleBackColor = false;
            // 
            // buttonParen
            // 
            this.buttonParen.BackColor = System.Drawing.Color.Red;
            this.buttonParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonParen.Location = new System.Drawing.Point(176, 116);
            this.buttonParen.Name = "buttonParen";
            this.buttonParen.Size = new System.Drawing.Size(75, 60);
            this.buttonParen.TabIndex = 23;
            this.buttonParen.Text = "(  )";
            this.buttonParen.UseVisualStyleBackColor = false;
            this.buttonParen.Click += new System.EventHandler(this.buttonParen_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.BackColor = System.Drawing.Color.Red;
            this.buttonPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPi.Location = new System.Drawing.Point(95, 182);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(75, 60);
            this.buttonPi.TabIndex = 24;
            this.buttonPi.Text = "π";
            this.buttonPi.UseVisualStyleBackColor = false;
            this.buttonPi.Click += new System.EventHandler(this.buttonPi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(345, 516);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonParen);
            this.Controls.Add(this.buttonRaiz);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonVirg);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonVirg;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonRaiz;
        private System.Windows.Forms.Button buttonParen;
        private System.Windows.Forms.Button buttonPi;
    }
}

