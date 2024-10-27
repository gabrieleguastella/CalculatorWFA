namespace Calculator
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
            this.btnOne = new System.Windows.Forms.Button();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.btnMultiplicate = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.lblOperazione = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(5, 176);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(73, 68);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.Number_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisultato.Location = new System.Drawing.Point(4, 54);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(313, 45);
            this.lblRisultato.TabIndex = 1;
            this.lblRisultato.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMultiplicate
            // 
            this.btnMultiplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicate.Location = new System.Drawing.Point(242, 176);
            this.btnMultiplicate.Name = "btnMultiplicate";
            this.btnMultiplicate.Size = new System.Drawing.Size(73, 68);
            this.btnMultiplicate.TabIndex = 2;
            this.btnMultiplicate.Text = "x";
            this.btnMultiplicate.UseVisualStyleBackColor = true;
            this.btnMultiplicate.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(163, 176);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(73, 68);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(84, 176);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(73, 68);
            this.btnTwo.TabIndex = 4;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(84, 250);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(73, 68);
            this.btnFive.TabIndex = 8;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(163, 250);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(73, 68);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(242, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 68);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(5, 250);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(73, 68);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(84, 324);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(73, 68);
            this.btnEight.TabIndex = 12;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(163, 324);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(73, 68);
            this.btnNine.TabIndex = 11;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(242, 324);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(73, 68);
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(5, 324);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(73, 68);
            this.btnSeven.TabIndex = 9;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(5, 102);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(109, 68);
            this.btnCE.TabIndex = 13;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanc.Location = new System.Drawing.Point(120, 102);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(116, 68);
            this.btnCanc.TabIndex = 14;
            this.btnCanc.Text = "C";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(242, 102);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(73, 68);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = ":";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(5, 398);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(152, 40);
            this.btnZero.TabIndex = 16;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(242, 398);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 40);
            this.btnEqual.TabIndex = 17;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnComma
            // 
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComma.Location = new System.Drawing.Point(163, 398);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(75, 40);
            this.btnComma.TabIndex = 18;
            this.btnComma.Text = ":)";
            this.btnComma.UseVisualStyleBackColor = true;
            // 
            // lblOperazione
            // 
            this.lblOperazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperazione.Location = new System.Drawing.Point(5, 21);
            this.lblOperazione.Name = "lblOperazione";
            this.lblOperazione.Size = new System.Drawing.Size(300, 23);
            this.lblOperazione.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.lblOperazione);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnMultiplicate);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.btnOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.Button btnMultiplicate;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Label lblOperazione;
    }
}

