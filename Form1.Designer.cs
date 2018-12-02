namespace _11._11Karkulyator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDevided = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.AcceptsTab = true;
            this.txtResult.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResult.ForeColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(7, 30);
            this.txtResult.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResult.Size = new System.Drawing.Size(311, 86);
            this.txtResult.TabIndex = 52;
            this.txtResult.Text = "0";
            // 
            // btnDevided
            // 
            this.btnDevided.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDevided.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevided.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevided.Location = new System.Drawing.Point(262, 124);
            this.btnDevided.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDevided.Name = "btnDevided";
            this.btnDevided.Size = new System.Drawing.Size(56, 55);
            this.btnDevided.TabIndex = 50;
            this.btnDevided.Text = "/";
            this.btnDevided.UseVisualStyleBackColor = false;
            this.btnDevided.Click += new System.EventHandler(this.btnOperationClicked);
            // 
            // btnMultiple
            // 
            this.btnMultiple.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiple.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMultiple.Location = new System.Drawing.Point(262, 187);
            this.btnMultiple.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(56, 55);
            this.btnMultiple.TabIndex = 49;
            this.btnMultiple.Text = "x";
            this.btnMultiple.UseVisualStyleBackColor = false;
            this.btnMultiple.Click += new System.EventHandler(this.btnOperationClicked);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinus.Location = new System.Drawing.Point(262, 250);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(56, 55);
            this.btnMinus.TabIndex = 48;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnOperationClicked);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlus.Location = new System.Drawing.Point(262, 313);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(56, 55);
            this.btnPlus.TabIndex = 47;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnOperationClicked);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEqual.Location = new System.Drawing.Point(262, 375);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(56, 55);
            this.btnEqual.TabIndex = 46;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnComma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnComma.Location = new System.Drawing.Point(198, 375);
            this.btnComma.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(56, 55);
            this.btnComma.TabIndex = 45;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZero.Location = new System.Drawing.Point(134, 375);
            this.btnZero.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(56, 55);
            this.btnZero.TabIndex = 44;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPi.Location = new System.Drawing.Point(6, 124);
            this.btnPi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(56, 55);
            this.btnPi.TabIndex = 42;
            this.btnPi.Text = "Pi";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFactorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFactorial.Location = new System.Drawing.Point(6, 187);
            this.btnFactorial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(56, 55);
            this.btnFactorial.TabIndex = 41;
            this.btnFactorial.Text = "n!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnOperationClicked);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnThree.Location = new System.Drawing.Point(198, 313);
            this.btnThree.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(56, 55);
            this.btnThree.TabIndex = 38;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOne.Location = new System.Drawing.Point(70, 313);
            this.btnOne.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(56, 55);
            this.btnOne.TabIndex = 37;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTwo.Location = new System.Drawing.Point(134, 313);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(56, 55);
            this.btnTwo.TabIndex = 36;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackSpace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackSpace.Location = new System.Drawing.Point(198, 124);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(56, 55);
            this.btnBackSpace.TabIndex = 35;
            this.btnBackSpace.Text = "<=";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(134, 124);
            this.btnC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(56, 55);
            this.btnC.TabIndex = 34;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCE.Location = new System.Drawing.Point(70, 124);
            this.btnCE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(56, 55);
            this.btnCE.TabIndex = 33;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNine.Location = new System.Drawing.Point(198, 187);
            this.btnNine.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(56, 55);
            this.btnNine.TabIndex = 32;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEight.Location = new System.Drawing.Point(134, 187);
            this.btnEight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(56, 55);
            this.btnEight.TabIndex = 31;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeven.Location = new System.Drawing.Point(70, 187);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(56, 55);
            this.btnSeven.TabIndex = 30;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSix.Location = new System.Drawing.Point(198, 250);
            this.btnSix.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(56, 55);
            this.btnSix.TabIndex = 29;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFive.Location = new System.Drawing.Point(134, 250);
            this.btnFive.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(56, 55);
            this.btnFive.TabIndex = 28;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFour.Location = new System.Drawing.Point(70, 250);
            this.btnFour.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(56, 55);
            this.btnFour.TabIndex = 27;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(70, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 55);
            this.button1.TabIndex = 54;
            this.button1.Text = "x2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnOperationClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 250);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 55);
            this.button2.TabIndex = 55;
            this.button2.Text = "Log10";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnOperationClicked);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Desktop;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(6, 313);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 55);
            this.button3.TabIndex = 56;
            this.button3.Text = "Log";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnOperationClicked);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Desktop;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(6, 375);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 55);
            this.button4.TabIndex = 57;
            this.button4.Text = "1/x2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnOperationClicked);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Green;
            this.button5.Location = new System.Drawing.Point(291, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 58;
            this.button5.Text = "x";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(329, 444);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDevided);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Carculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDevided;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

