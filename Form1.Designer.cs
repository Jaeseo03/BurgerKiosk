namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpMenu = new GroupBox();
            grpOption = new GroupBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            button1 = new Button();
            btnlnit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpMenu.SuspendLayout();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = SystemColors.Highlight;
            lblAppName.Location = new Point(12, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(557, 81);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(6, 66);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(143, 50);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(6, 187);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(211, 50);
            rdoBulgogiBurger.TabIndex = 2;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(6, 309);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(177, 50);
            rdoChickenBurger.TabIndex = 3;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(226, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(226, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(226, 309);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(6, 50);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(178, 50);
            chkPotato.TabIndex = 7;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(6, 119);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(110, 50);
            chkCola.TabIndex = 8;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(6, 190);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(190, 50);
            chkCheese.TabIndex = 9;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(6, 260);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(190, 50);
            chkSauce.TabIndex = 10;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(pictureBox1);
            grpMenu.Controls.Add(pictureBox2);
            grpMenu.Controls.Add(pictureBox3);
            grpMenu.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(43, 129);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(382, 409);
            grpMenu.TabIndex = 11;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkPotato);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(483, 129);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(250, 319);
            grpOption.TabIndex = 12;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(778, 129);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(250, 281);
            grpOrder.TabIndex = 13;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.ImageAlign = ContentAlignment.MiddleLeft;
            lblTotalCost.Location = new Point(6, 222);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(195, 41);
            lblTotalCost.TabIndex = 3;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(6, 46);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(238, 168);
            lstOrder.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(778, 438);
            button1.Name = "button1";
            button1.Size = new Size(104, 45);
            button1.TabIndex = 1;
            button1.Text = "주문하기";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnlnit
            // 
            btnlnit.BackColor = Color.FromArgb(192, 0, 0);
            btnlnit.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnlnit.Location = new Point(901, 438);
            btnlnit.Name = "btnlnit";
            btnlnit.Size = new Size(100, 45);
            btnlnit.TabIndex = 2;
            btnlnit.Text = "초기화";
            btnlnit.UseVisualStyleBackColor = false;
            btnlnit.Click += btnlnit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 587);
            Controls.Add(grpOrder);
            Controls.Add(btnlnit);
            Controls.Add(grpOption);
            Controls.Add(button1);
            Controls.Add(grpMenu);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private GroupBox grpOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button button1;
        private Button btnlnit;
    }
}
