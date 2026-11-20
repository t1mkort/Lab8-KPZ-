namespace BurgerDecoratorLab
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.gbBase = new System.Windows.Forms.GroupBox();
            this.radioChicken = new System.Windows.Forms.RadioButton();
            this.radioBeef = new System.Windows.Forms.RadioButton();
            this.gbAddons = new System.Windows.Forms.GroupBox();
            this.chkSauce = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.gbPicture = new System.Windows.Forms.GroupBox();
            this.picBurger = new System.Windows.Forms.PictureBox();
            this.gbBase.SuspendLayout();
            this.gbAddons.SuspendLayout();
            this.gbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).BeginInit();
            this.SuspendLayout();
            //
            // gbBase
            //
            this.gbBase.Controls.Add(this.radioChicken);
            this.gbBase.Controls.Add(this.radioBeef);
            this.gbBase.Location = new System.Drawing.Point(12, 12);
            this.gbBase.Name = "gbBase";
            this.gbBase.Size = new System.Drawing.Size(260, 90);
            this.gbBase.TabIndex = 0;
            this.gbBase.TabStop = false;
            this.gbBase.Text = "Основа бургера";
            //
            // radioChicken
            //
            this.radioChicken.AutoSize = true;
            this.radioChicken.Location = new System.Drawing.Point(16, 52);
            this.radioChicken.Name = "radioChicken";
            this.radioChicken.Size = new System.Drawing.Size(180, 17);
            this.radioChicken.TabIndex = 1;
            this.radioChicken.Text = "Курячий бургер (100 грн)";
            this.radioChicken.UseVisualStyleBackColor = true;
            this.radioChicken.CheckedChanged += new System.EventHandler(this.radioBase_CheckedChanged);
            //
            // radioBeef
            //
            this.radioBeef.AutoSize = true;
            this.radioBeef.Checked = true;
            this.radioBeef.Location = new System.Drawing.Point(16, 26);
            this.radioBeef.Name = "radioBeef";
            this.radioBeef.Size = new System.Drawing.Size(180, 17);
            this.radioBeef.TabIndex = 0;
            this.radioBeef.TabStop = true;
            this.radioBeef.Text = "Яловичий бургер (120 грн)";
            this.radioBeef.UseVisualStyleBackColor = true;
            this.radioBeef.CheckedChanged += new System.EventHandler(this.radioBase_CheckedChanged);
            //
            // gbAddons
            //
            this.gbAddons.Controls.Add(this.chkSauce);
            this.gbAddons.Controls.Add(this.chkTomato);
            this.gbAddons.Controls.Add(this.chkBacon);
            this.gbAddons.Controls.Add(this.chkCheese);
            this.gbAddons.Location = new System.Drawing.Point(288, 12);
            this.gbAddons.Name = "gbAddons";
            this.gbAddons.Size = new System.Drawing.Size(260, 150);
            this.gbAddons.TabIndex = 1;
            this.gbAddons.TabStop = false;
            this.gbAddons.Text = "Добавки (декоратори)";
            //
            // chkSauce
            //
            this.chkSauce.AutoSize = true;
            this.chkSauce.Location = new System.Drawing.Point(16, 112);
            this.chkSauce.Name = "chkSauce";
            this.chkSauce.Size = new System.Drawing.Size(110, 17);
            this.chkSauce.TabIndex = 3;
            this.chkSauce.Text = "Соус (+5 грн)";
            this.chkSauce.UseVisualStyleBackColor = true;
            this.chkSauce.CheckedChanged += new System.EventHandler(this.chkAddon_CheckedChanged);
            //
            // chkTomato
            //
            this.chkTomato.AutoSize = true;
            this.chkTomato.Location = new System.Drawing.Point(16, 85);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(130, 17);
            this.chkTomato.TabIndex = 2;
            this.chkTomato.Text = "Помідори (+10 грн)";
            this.chkTomato.UseVisualStyleBackColor = true;
            this.chkTomato.CheckedChanged += new System.EventHandler(this.chkAddon_CheckedChanged);
            //
            // chkBacon
            //
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(16, 58);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(120, 17);
            this.chkBacon.TabIndex = 1;
            this.chkBacon.Text = "Бекон (+30 грн)";
            this.chkBacon.UseVisualStyleBackColor = true;
            this.chkBacon.CheckedChanged += new System.EventHandler(this.chkAddon_CheckedChanged);
            //
            // chkCheese
            //
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(16, 31);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(110, 17);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "Сир (+20 грн)";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkAddon_CheckedChanged);
            //
            // lblName
            //
            this.lblName.Location = new System.Drawing.Point(12, 176);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(536, 36);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Назва:";
            //
            // lblCost
            //
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(12, 216);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(38, 13);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Ціна:";
            //
            // lblLog
            //
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 248);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(130, 13);
            this.lblLog.TabIndex = 4;
            this.lblLog.Text = "Як утворився бургер:";
            //
            // lstLog
            //
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.Location = new System.Drawing.Point(12, 268);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(536, 160);
            this.lstLog.TabIndex = 5;
            //
            // gbPicture
            //
            this.gbPicture.Controls.Add(this.picBurger);
            this.gbPicture.Location = new System.Drawing.Point(564, 12);
            this.gbPicture.Name = "gbPicture";
            this.gbPicture.Size = new System.Drawing.Size(284, 416);
            this.gbPicture.TabIndex = 6;
            this.gbPicture.TabStop = false;
            this.gbPicture.Text = "Ваш бургер";
            //
            // picBurger
            //
            this.picBurger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBurger.Location = new System.Drawing.Point(6, 20);
            this.picBurger.Name = "picBurger";
            this.picBurger.Size = new System.Drawing.Size(272, 388);
            this.picBurger.TabIndex = 0;
            this.picBurger.TabStop = false;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 440);
            this.Controls.Add(this.gbPicture);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gbAddons);
            this.Controls.Add(this.gbBase);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Декоратор: бургер";
            this.gbBase.ResumeLayout(false);
            this.gbBase.PerformLayout();
            this.gbAddons.ResumeLayout(false);
            this.gbAddons.PerformLayout();
            this.gbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBase;
        private System.Windows.Forms.RadioButton radioChicken;
        private System.Windows.Forms.RadioButton radioBeef;
        private System.Windows.Forms.GroupBox gbAddons;
        private System.Windows.Forms.CheckBox chkSauce;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.GroupBox gbPicture;
        private System.Windows.Forms.PictureBox picBurger;
    }
}
