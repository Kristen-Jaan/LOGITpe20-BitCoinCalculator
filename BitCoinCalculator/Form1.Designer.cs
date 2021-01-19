
namespace BitCoinCalculator
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
            this.CurrencyMenu = new System.Windows.Forms.ComboBox();
            this.GetRatesBTN = new System.Windows.Forms.Button();
            this.AmountOfBTC = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrencyMenu
            // 
            this.CurrencyMenu.FormattingEnabled = true;
            this.CurrencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.CurrencyMenu.Location = new System.Drawing.Point(80, 111);
            this.CurrencyMenu.Name = "CurrencyMenu";
            this.CurrencyMenu.Size = new System.Drawing.Size(182, 33);
            this.CurrencyMenu.TabIndex = 0;
            this.CurrencyMenu.Text = "Select Currency";
            // 
            // GetRatesBTN
            // 
            this.GetRatesBTN.Location = new System.Drawing.Point(299, 111);
            this.GetRatesBTN.Name = "GetRatesBTN";
            this.GetRatesBTN.Size = new System.Drawing.Size(112, 34);
            this.GetRatesBTN.TabIndex = 1;
            this.GetRatesBTN.Text = "Get Rates";
            this.GetRatesBTN.UseVisualStyleBackColor = true;
            this.GetRatesBTN.Click += new System.EventHandler(this.GetRatesBTN_Click);
            // 
            // AmountOfBTC
            // 
            this.AmountOfBTC.Location = new System.Drawing.Point(80, 198);
            this.AmountOfBTC.Name = "AmountOfBTC";
            this.AmountOfBTC.PlaceholderText = "Amount Of BitCoin";
            this.AmountOfBTC.Size = new System.Drawing.Size(182, 31);
            this.AmountOfBTC.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(80, 339);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(331, 31);
            this.Result.TabIndex = 3;
            this.Result.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(80, 300);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(59, 25);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            this.resultLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.AmountOfBTC);
            this.Controls.Add(this.GetRatesBTN);
            this.Controls.Add(this.CurrencyMenu);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrencyMenu;
        private System.Windows.Forms.Button GetRatesBTN;
        private System.Windows.Forms.TextBox AmountOfBTC;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label resultLabel;
    }
}

