namespace Project5_RMateo
{
    partial class TravelExpenseForm
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
            this.TravelExpenseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoGroupBox = new System.Windows.Forms.GroupBox();
            this.BuickRadioBtn = new System.Windows.Forms.RadioButton();
            this.ChevyRadioBtn = new System.Windows.Forms.RadioButton();
            this.RouteGroupBox = new System.Windows.Forms.GroupBox();
            this.FreewayRadioBtn = new System.Windows.Forms.RadioButton();
            this.CityRadioBtn = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.MileageLabel = new System.Windows.Forms.Label();
            this.TotalMilesLabel = new System.Windows.Forms.Label();
            this.MileageValue = new System.Windows.Forms.Label();
            this.TotalMilesValue = new System.Windows.Forms.Label();
            this.GasPriceLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.TotalCostValue = new System.Windows.Forms.Label();
            this.GasPriceValue = new System.Windows.Forms.TextBox();
            this.AutoGroupBox.SuspendLayout();
            this.RouteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TravelExpenseLabel
            // 
            this.TravelExpenseLabel.AutoSize = true;
            this.TravelExpenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelExpenseLabel.Location = new System.Drawing.Point(106, 21);
            this.TravelExpenseLabel.Name = "TravelExpenseLabel";
            this.TravelExpenseLabel.Size = new System.Drawing.Size(157, 24);
            this.TravelExpenseLabel.TabIndex = 0;
            this.TravelExpenseLabel.Text = "Travel Expense";
            this.TravelExpenseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management Information System";
            // 
            // AutoGroupBox
            // 
            this.AutoGroupBox.Controls.Add(this.ChevyRadioBtn);
            this.AutoGroupBox.Controls.Add(this.BuickRadioBtn);
            this.AutoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoGroupBox.Location = new System.Drawing.Point(32, 69);
            this.AutoGroupBox.Name = "AutoGroupBox";
            this.AutoGroupBox.Size = new System.Drawing.Size(151, 88);
            this.AutoGroupBox.TabIndex = 2;
            this.AutoGroupBox.TabStop = false;
            this.AutoGroupBox.Text = "Auto";
            this.AutoGroupBox.Enter += new System.EventHandler(this.AutoGroupBox_Enter);
            // 
            // BuickRadioBtn
            // 
            this.BuickRadioBtn.AutoSize = true;
            this.BuickRadioBtn.Location = new System.Drawing.Point(8, 25);
            this.BuickRadioBtn.Name = "BuickRadioBtn";
            this.BuickRadioBtn.Size = new System.Drawing.Size(109, 19);
            this.BuickRadioBtn.TabIndex = 0;
            this.BuickRadioBtn.Text = "Buick Electra";
            this.BuickRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ChevyRadioBtn
            // 
            this.ChevyRadioBtn.AutoSize = true;
            this.ChevyRadioBtn.Location = new System.Drawing.Point(8, 53);
            this.ChevyRadioBtn.Name = "ChevyRadioBtn";
            this.ChevyRadioBtn.Size = new System.Drawing.Size(114, 19);
            this.ChevyRadioBtn.TabIndex = 1;
            this.ChevyRadioBtn.Text = "Chevy Lumina";
            this.ChevyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // RouteGroupBox
            // 
            this.RouteGroupBox.Controls.Add(this.CityRadioBtn);
            this.RouteGroupBox.Controls.Add(this.FreewayRadioBtn);
            this.RouteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteGroupBox.Location = new System.Drawing.Point(32, 163);
            this.RouteGroupBox.Name = "RouteGroupBox";
            this.RouteGroupBox.Size = new System.Drawing.Size(151, 87);
            this.RouteGroupBox.TabIndex = 3;
            this.RouteGroupBox.TabStop = false;
            this.RouteGroupBox.Text = "Route";
            // 
            // FreewayRadioBtn
            // 
            this.FreewayRadioBtn.AutoSize = true;
            this.FreewayRadioBtn.Location = new System.Drawing.Point(8, 20);
            this.FreewayRadioBtn.Name = "FreewayRadioBtn";
            this.FreewayRadioBtn.Size = new System.Drawing.Size(78, 19);
            this.FreewayRadioBtn.TabIndex = 0;
            this.FreewayRadioBtn.Text = "Freeway";
            this.FreewayRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CityRadioBtn
            // 
            this.CityRadioBtn.AutoSize = true;
            this.CityRadioBtn.Location = new System.Drawing.Point(8, 50);
            this.CityRadioBtn.Name = "CityRadioBtn";
            this.CityRadioBtn.Size = new System.Drawing.Size(48, 19);
            this.CityRadioBtn.TabIndex = 1;
            this.CityRadioBtn.Text = "City";
            this.CityRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(32, 266);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(108, 266);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MileageLabel
            // 
            this.MileageLabel.AutoSize = true;
            this.MileageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MileageLabel.Location = new System.Drawing.Point(200, 98);
            this.MileageLabel.Name = "MileageLabel";
            this.MileageLabel.Size = new System.Drawing.Size(51, 13);
            this.MileageLabel.TabIndex = 6;
            this.MileageLabel.Text = "Mileage";
            // 
            // TotalMilesLabel
            // 
            this.TotalMilesLabel.AutoSize = true;
            this.TotalMilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMilesLabel.Location = new System.Drawing.Point(200, 126);
            this.TotalMilesLabel.Name = "TotalMilesLabel";
            this.TotalMilesLabel.Size = new System.Drawing.Size(69, 13);
            this.TotalMilesLabel.TabIndex = 7;
            this.TotalMilesLabel.Text = "Total Miles";
            // 
            // MileageValue
            // 
            this.MileageValue.AutoSize = true;
            this.MileageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MileageValue.Location = new System.Drawing.Point(280, 98);
            this.MileageValue.Name = "MileageValue";
            this.MileageValue.Size = new System.Drawing.Size(0, 13);
            this.MileageValue.TabIndex = 8;
            this.MileageValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalMilesValue
            // 
            this.TotalMilesValue.AutoSize = true;
            this.TotalMilesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMilesValue.Location = new System.Drawing.Point(280, 126);
            this.TotalMilesValue.Name = "TotalMilesValue";
            this.TotalMilesValue.Size = new System.Drawing.Size(0, 13);
            this.TotalMilesValue.TabIndex = 9;
            // 
            // GasPriceLabel
            // 
            this.GasPriceLabel.AutoSize = true;
            this.GasPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GasPriceLabel.Location = new System.Drawing.Point(200, 187);
            this.GasPriceLabel.Name = "GasPriceLabel";
            this.GasPriceLabel.Size = new System.Drawing.Size(62, 13);
            this.GasPriceLabel.TabIndex = 10;
            this.GasPriceLabel.Text = "Gas Price";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(200, 217);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(65, 13);
            this.TotalCostLabel.TabIndex = 11;
            this.TotalCostLabel.Text = "Total Cost";
            // 
            // TotalCostValue
            // 
            this.TotalCostValue.AutoSize = true;
            this.TotalCostValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostValue.Location = new System.Drawing.Point(280, 217);
            this.TotalCostValue.Name = "TotalCostValue";
            this.TotalCostValue.Size = new System.Drawing.Size(0, 13);
            this.TotalCostValue.TabIndex = 12;
            // 
            // GasPriceValue
            // 
            this.GasPriceValue.Location = new System.Drawing.Point(271, 184);
            this.GasPriceValue.Name = "GasPriceValue";
            this.GasPriceValue.Size = new System.Drawing.Size(54, 20);
            this.GasPriceValue.TabIndex = 13;
            this.GasPriceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GasPriceValue.TextChanged += new System.EventHandler(this.GasPriceValue_TextChanged);
            this.GasPriceValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GasPriceValue_KeyPress);
            // 
            // TravelExpenseForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 327);
            this.Controls.Add(this.GasPriceValue);
            this.Controls.Add(this.TotalCostValue);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.GasPriceLabel);
            this.Controls.Add(this.TotalMilesValue);
            this.Controls.Add(this.MileageValue);
            this.Controls.Add(this.TotalMilesLabel);
            this.Controls.Add(this.MileageLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.RouteGroupBox);
            this.Controls.Add(this.AutoGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TravelExpenseLabel);
            this.Name = "TravelExpenseForm";
            this.Text = "Travel Expense System";
            this.Load += new System.EventHandler(this.TravelExpenseForm_Load);
            this.AutoGroupBox.ResumeLayout(false);
            this.AutoGroupBox.PerformLayout();
            this.RouteGroupBox.ResumeLayout(false);
            this.RouteGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TravelExpenseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox AutoGroupBox;
        private System.Windows.Forms.RadioButton ChevyRadioBtn;
        private System.Windows.Forms.RadioButton BuickRadioBtn;
        private System.Windows.Forms.GroupBox RouteGroupBox;
        private System.Windows.Forms.RadioButton CityRadioBtn;
        private System.Windows.Forms.RadioButton FreewayRadioBtn;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label MileageLabel;
        private System.Windows.Forms.Label TotalMilesLabel;
        private System.Windows.Forms.Label MileageValue;
        private System.Windows.Forms.Label TotalMilesValue;
        private System.Windows.Forms.Label GasPriceLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label TotalCostValue;
        private System.Windows.Forms.TextBox GasPriceValue;
    }
}

