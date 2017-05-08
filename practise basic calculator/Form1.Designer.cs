namespace practise_basic_calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calculatorBox = new System.Windows.Forms.RichTextBox();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuTitle = new System.Windows.Forms.Label();
            this.menuButton2 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.designButton = new System.Windows.Forms.Button();
            this.optionButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.CancelButtonTip = new System.Windows.Forms.ToolTip(this.components);
            this.piButton = new System.Windows.Forms.Button();
            this.buttonSquared = new System.Windows.Forms.Button();
            this.addionalButtonsMenuB = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.designPanel = new System.Windows.Forms.Panel();
            this.blueCBox = new System.Windows.Forms.CheckBox();
            this.neonCBox = new System.Windows.Forms.CheckBox();
            this.redCBox = new System.Windows.Forms.CheckBox();
            this.silverCBox = new System.Windows.Forms.CheckBox();
            this.greenCBox = new System.Windows.Forms.CheckBox();
            this.DefaultCBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addionalButtonsPanel = new System.Windows.Forms.Panel();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonPercentage = new System.Windows.Forms.Button();
            this.buttonOn = new System.Windows.Forms.Button();
            this.helloTimer = new System.Windows.Forms.Timer(this.components);
            this.helloIntro = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.designPanel.SuspendLayout();
            this.addionalButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helloIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // calculatorBox
            // 
            this.calculatorBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.calculatorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorBox.ForeColor = System.Drawing.Color.Black;
            this.calculatorBox.Location = new System.Drawing.Point(35, 44);
            this.calculatorBox.MaxLength = 15;
            this.calculatorBox.Multiline = false;
            this.calculatorBox.Name = "calculatorBox";
            this.calculatorBox.ReadOnly = true;
            this.calculatorBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.calculatorBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.calculatorBox.Size = new System.Drawing.Size(215, 33);
            this.calculatorBox.TabIndex = 0;
            this.calculatorBox.Text = "";
            this.calculatorBox.TextChanged += new System.EventHandler(this.calculatorBox_TextChanged);
            // 
            // num7
            // 
            this.num7.Enabled = false;
            this.num7.Location = new System.Drawing.Point(35, 104);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(35, 31);
            this.num7.TabIndex = 1;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Enabled = false;
            this.num8.Location = new System.Drawing.Point(76, 104);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(35, 31);
            this.num8.TabIndex = 2;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Enabled = false;
            this.num9.Location = new System.Drawing.Point(117, 104);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(35, 31);
            this.num9.TabIndex = 3;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num4
            // 
            this.num4.Enabled = false;
            this.num4.Location = new System.Drawing.Point(35, 141);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(35, 31);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Enabled = false;
            this.num5.Location = new System.Drawing.Point(76, 141);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(35, 31);
            this.num5.TabIndex = 5;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Enabled = false;
            this.num6.Location = new System.Drawing.Point(117, 141);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(35, 31);
            this.num6.TabIndex = 6;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num1
            // 
            this.num1.Enabled = false;
            this.num1.Location = new System.Drawing.Point(35, 178);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(35, 31);
            this.num1.TabIndex = 7;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Enabled = false;
            this.num2.Location = new System.Drawing.Point(76, 178);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(35, 31);
            this.num2.TabIndex = 8;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Enabled = false;
            this.num3.Location = new System.Drawing.Point(117, 178);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(35, 31);
            this.num3.TabIndex = 9;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num0
            // 
            this.num0.Enabled = false;
            this.num0.Location = new System.Drawing.Point(76, 215);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(35, 31);
            this.num0.TabIndex = 10;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Enabled = false;
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlus.Location = new System.Drawing.Point(174, 104);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(35, 31);
            this.ButtonPlus.TabIndex = 11;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Enabled = false;
            this.ButtonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDivide.Location = new System.Drawing.Point(174, 141);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(35, 31);
            this.ButtonDivide.TabIndex = 12;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Enabled = false;
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMinus.Location = new System.Drawing.Point(216, 104);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(35, 31);
            this.ButtonMinus.TabIndex = 13;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Enabled = false;
            this.ButtonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMultiply.Location = new System.Drawing.Point(216, 141);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(35, 31);
            this.ButtonMultiply.TabIndex = 14;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Enabled = false;
            this.ButtonEquals.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEquals.Location = new System.Drawing.Point(174, 215);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(77, 31);
            this.ButtonEquals.TabIndex = 15;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(117, 215);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(35, 31);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "C";
            this.CancelButtonTip.SetToolTip(this.buttonCancel, "Cancel calculation");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button1_Click);
            this.buttonCancel.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // undoButton
            // 
            this.undoButton.Enabled = false;
            this.undoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoButton.Location = new System.Drawing.Point(36, 215);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(35, 31);
            this.undoButton.TabIndex = 17;
            this.undoButton.Text = "<";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.menuTitle);
            this.menuPanel.Controls.Add(this.menuButton2);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.designButton);
            this.menuPanel.Controls.Add(this.optionButton);
            this.menuPanel.Controls.Add(this.aboutButton);
            this.menuPanel.Location = new System.Drawing.Point(0, -2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(112, 267);
            this.menuPanel.TabIndex = 19;
            this.menuPanel.Visible = false;
            this.menuPanel.Click += new System.EventHandler(this.menuPanel_Click);
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // menuTitle
            // 
            this.menuTitle.AutoSize = true;
            this.menuTitle.BackColor = System.Drawing.Color.Transparent;
            this.menuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitle.Location = new System.Drawing.Point(19, 9);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(64, 36);
            this.menuTitle.TabIndex = 0;
            this.menuTitle.Text = "Basic \r\ncalulator";
            this.menuTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuButton2
            // 
            this.menuButton2.BackColor = System.Drawing.Color.White;
            this.menuButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuButton2.Location = new System.Drawing.Point(96, 1);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Size = new System.Drawing.Size(15, 274);
            this.menuButton2.TabIndex = 23;
            this.menuButton2.Text = "<";
            this.CancelButtonTip.SetToolTip(this.menuButton2, "Close menu button");
            this.menuButton2.UseVisualStyleBackColor = false;
            this.menuButton2.Click += new System.EventHandler(this.menuButton2_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(13, 230);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // designButton
            // 
            this.designButton.Location = new System.Drawing.Point(13, 143);
            this.designButton.Name = "designButton";
            this.designButton.Size = new System.Drawing.Size(75, 35);
            this.designButton.TabIndex = 3;
            this.designButton.Text = "Design styles";
            this.designButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.designButton.UseVisualStyleBackColor = true;
            this.designButton.Click += new System.EventHandler(this.designButton_Click);
            // 
            // optionButton
            // 
            this.optionButton.Location = new System.Drawing.Point(13, 108);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(75, 23);
            this.optionButton.TabIndex = 2;
            this.optionButton.Text = "Options";
            this.optionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionButton.UseVisualStyleBackColor = true;
            this.optionButton.Click += new System.EventHandler(this.optionButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.Gainsboro;
            this.aboutButton.Location = new System.Drawing.Point(13, 73);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "About";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.menuButton.FlatAppearance.BorderSize = 2;
            this.menuButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuButton.Location = new System.Drawing.Point(-1, -4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(15, 274);
            this.menuButton.TabIndex = 18;
            this.menuButton.Text = ">";
            this.CancelButtonTip.SetToolTip(this.menuButton, "Menu button");
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
            // 
            // CancelButtonTip
            // 
            this.CancelButtonTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CancelButtonTip.ToolTipTitle = "Calculator info";
            this.CancelButtonTip.Popup += new System.Windows.Forms.PopupEventHandler(this.CancelButtonTip_Popup);
            // 
            // piButton
            // 
            this.piButton.Enabled = false;
            this.piButton.Location = new System.Drawing.Point(174, 178);
            this.piButton.Name = "piButton";
            this.piButton.Size = new System.Drawing.Size(35, 31);
            this.piButton.TabIndex = 21;
            this.piButton.Text = "π";
            this.CancelButtonTip.SetToolTip(this.piButton, "Pi button");
            this.piButton.UseVisualStyleBackColor = true;
            this.piButton.Click += new System.EventHandler(this.piButton_Click);
            // 
            // buttonSquared
            // 
            this.buttonSquared.Enabled = false;
            this.buttonSquared.Location = new System.Drawing.Point(215, 178);
            this.buttonSquared.Name = "buttonSquared";
            this.buttonSquared.Size = new System.Drawing.Size(35, 31);
            this.buttonSquared.TabIndex = 22;
            this.buttonSquared.Text = "²";
            this.CancelButtonTip.SetToolTip(this.buttonSquared, "Square button");
            this.buttonSquared.UseVisualStyleBackColor = true;
            this.buttonSquared.Click += new System.EventHandler(this.button2_Click);
            // 
            // addionalButtonsMenuB
            // 
            this.addionalButtonsMenuB.BackColor = System.Drawing.Color.White;
            this.addionalButtonsMenuB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addionalButtonsMenuB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addionalButtonsMenuB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addionalButtonsMenuB.Location = new System.Drawing.Point(269, 104);
            this.addionalButtonsMenuB.Name = "addionalButtonsMenuB";
            this.addionalButtonsMenuB.Size = new System.Drawing.Size(15, 105);
            this.addionalButtonsMenuB.TabIndex = 24;
            this.addionalButtonsMenuB.Text = "<";
            this.CancelButtonTip.SetToolTip(this.addionalButtonsMenuB, " Additional buttons  ");
            this.addionalButtonsMenuB.UseVisualStyleBackColor = false;
            this.addionalButtonsMenuB.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(0, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(15, 105);
            this.button4.TabIndex = 26;
            this.button4.Text = ">";
            this.CancelButtonTip.SetToolTip(this.button4, " Additional buttons  ");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // designPanel
            // 
            this.designPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.designPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designPanel.Controls.Add(this.blueCBox);
            this.designPanel.Controls.Add(this.neonCBox);
            this.designPanel.Controls.Add(this.redCBox);
            this.designPanel.Controls.Add(this.silverCBox);
            this.designPanel.Controls.Add(this.greenCBox);
            this.designPanel.Controls.Add(this.DefaultCBox);
            this.designPanel.Controls.Add(this.label1);
            this.designPanel.Location = new System.Drawing.Point(111, 73);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(143, 101);
            this.designPanel.TabIndex = 20;
            this.designPanel.Visible = false;
            this.designPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // blueCBox
            // 
            this.blueCBox.AutoSize = true;
            this.blueCBox.Location = new System.Drawing.Point(79, 76);
            this.blueCBox.Name = "blueCBox";
            this.blueCBox.Size = new System.Drawing.Size(47, 17);
            this.blueCBox.TabIndex = 6;
            this.blueCBox.Text = "Blue";
            this.blueCBox.UseVisualStyleBackColor = true;
            this.blueCBox.CheckedChanged += new System.EventHandler(this.blueCBox_CheckedChanged);
            // 
            // neonCBox
            // 
            this.neonCBox.AutoSize = true;
            this.neonCBox.Location = new System.Drawing.Point(10, 76);
            this.neonCBox.Name = "neonCBox";
            this.neonCBox.Size = new System.Drawing.Size(52, 17);
            this.neonCBox.TabIndex = 5;
            this.neonCBox.Text = "Neon";
            this.neonCBox.UseVisualStyleBackColor = true;
            this.neonCBox.CheckedChanged += new System.EventHandler(this.neonCBox_CheckedChanged);
            // 
            // redCBox
            // 
            this.redCBox.AutoSize = true;
            this.redCBox.Location = new System.Drawing.Point(79, 53);
            this.redCBox.Name = "redCBox";
            this.redCBox.Size = new System.Drawing.Size(46, 17);
            this.redCBox.TabIndex = 4;
            this.redCBox.Text = "Red";
            this.redCBox.UseVisualStyleBackColor = true;
            this.redCBox.CheckedChanged += new System.EventHandler(this.redCBox_CheckedChanged);
            // 
            // silverCBox
            // 
            this.silverCBox.AutoSize = true;
            this.silverCBox.Location = new System.Drawing.Point(79, 32);
            this.silverCBox.Name = "silverCBox";
            this.silverCBox.Size = new System.Drawing.Size(52, 17);
            this.silverCBox.TabIndex = 3;
            this.silverCBox.Text = "Silver";
            this.silverCBox.UseVisualStyleBackColor = true;
            this.silverCBox.CheckedChanged += new System.EventHandler(this.silverCBox_CheckedChanged);
            // 
            // greenCBox
            // 
            this.greenCBox.AutoSize = true;
            this.greenCBox.Location = new System.Drawing.Point(10, 53);
            this.greenCBox.Name = "greenCBox";
            this.greenCBox.Size = new System.Drawing.Size(55, 17);
            this.greenCBox.TabIndex = 2;
            this.greenCBox.Text = "Green";
            this.greenCBox.UseVisualStyleBackColor = true;
            this.greenCBox.CheckedChanged += new System.EventHandler(this.greenCBox_CheckedChanged);
            // 
            // DefaultCBox
            // 
            this.DefaultCBox.AutoSize = true;
            this.DefaultCBox.Checked = true;
            this.DefaultCBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultCBox.Enabled = false;
            this.DefaultCBox.Location = new System.Drawing.Point(10, 33);
            this.DefaultCBox.Name = "DefaultCBox";
            this.DefaultCBox.Size = new System.Drawing.Size(60, 17);
            this.DefaultCBox.TabIndex = 1;
            this.DefaultCBox.Text = "Default";
            this.DefaultCBox.UseVisualStyleBackColor = true;
            this.DefaultCBox.CheckedChanged += new System.EventHandler(this.DefaultCBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Design styles";
            // 
            // addionalButtonsPanel
            // 
            this.addionalButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addionalButtonsPanel.Controls.Add(this.buttonDecimal);
            this.addionalButtonsPanel.Controls.Add(this.buttonPercentage);
            this.addionalButtonsPanel.Controls.Add(this.button4);
            this.addionalButtonsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addionalButtonsPanel.Location = new System.Drawing.Point(174, 104);
            this.addionalButtonsPanel.Name = "addionalButtonsPanel";
            this.addionalButtonsPanel.Size = new System.Drawing.Size(110, 105);
            this.addionalButtonsPanel.TabIndex = 25;
            this.addionalButtonsPanel.Visible = false;
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecimal.Location = new System.Drawing.Point(21, 40);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(35, 31);
            this.buttonDecimal.TabIndex = 28;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // buttonPercentage
            // 
            this.buttonPercentage.Location = new System.Drawing.Point(21, 3);
            this.buttonPercentage.Name = "buttonPercentage";
            this.buttonPercentage.Size = new System.Drawing.Size(35, 31);
            this.buttonPercentage.TabIndex = 27;
            this.buttonPercentage.Text = "%";
            this.buttonPercentage.UseVisualStyleBackColor = true;
            this.buttonPercentage.Click += new System.EventHandler(this.percentageButton_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(225, 7);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(47, 23);
            this.buttonOn.TabIndex = 26;
            this.buttonOn.Text = "On";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.button5_Click);
            // 
            // helloTimer
            // 
            this.helloTimer.Interval = 1500;
            this.helloTimer.Tick += new System.EventHandler(this.helloTimer_Tick);
            // 
            // helloIntro
            // 
            this.helloIntro.BackColor = System.Drawing.Color.Transparent;
            this.helloIntro.Enabled = false;
            this.helloIntro.Image = global::practise_basic_calculator.Properties.Resources.Intro_turn_on_calculator_remastered_2;
            this.helloIntro.Location = new System.Drawing.Point(35, 44);
            this.helloIntro.Name = "helloIntro";
            this.helloIntro.Size = new System.Drawing.Size(215, 32);
            this.helloIntro.TabIndex = 27;
            this.helloIntro.TabStop = false;
            this.helloIntro.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addionalButtonsPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.designPanel);
            this.Controls.Add(this.helloIntro);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.addionalButtonsMenuB);
            this.Controls.Add(this.buttonSquared);
            this.Controls.Add(this.piButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.calculatorBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Basic calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.designPanel.ResumeLayout(false);
            this.designPanel.PerformLayout();
            this.addionalButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.helloIntro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox calculatorBox;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button designButton;
        private System.Windows.Forms.Button optionButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.ToolTip CancelButtonTip;
        private System.Windows.Forms.Panel designPanel;
        private System.Windows.Forms.CheckBox greenCBox;
        private System.Windows.Forms.CheckBox DefaultCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox blueCBox;
        private System.Windows.Forms.CheckBox neonCBox;
        private System.Windows.Forms.CheckBox redCBox;
        private System.Windows.Forms.CheckBox silverCBox;
        private System.Windows.Forms.Button piButton;
        private System.Windows.Forms.Button buttonSquared;
        private System.Windows.Forms.Button menuButton2;
        private System.Windows.Forms.Button addionalButtonsMenuB;
        private System.Windows.Forms.Panel addionalButtonsPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonPercentage;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Timer helloTimer;
        private System.Windows.Forms.PictureBox helloIntro;
    }
}

