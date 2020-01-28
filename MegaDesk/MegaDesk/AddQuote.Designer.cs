namespace MegaDesk
{
  partial class AddQuote
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
      this.TxtCustomerName = new System.Windows.Forms.TextBox();
      this.LblCustomerName = new System.Windows.Forms.Label();
      this.TxtDeskWidth = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.DeskWidth = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.DeskHeight = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      this.ComboDeskMaterials = new System.Windows.Forms.ComboBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.BtnSaveQuote = new System.Windows.Forms.Button();
      this.BtnValidateQuote = new System.Windows.Forms.Button();
      this.BtnExit = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.DeskWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DeskHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      this.SuspendLayout();
      // 
      // TxtCustomerName
      // 
      this.TxtCustomerName.Location = new System.Drawing.Point(366, 75);
      this.TxtCustomerName.Name = "TxtCustomerName";
      this.TxtCustomerName.Size = new System.Drawing.Size(119, 22);
      this.TxtCustomerName.TabIndex = 0;
      // 
      // LblCustomerName
      // 
      this.LblCustomerName.AutoSize = true;
      this.LblCustomerName.Location = new System.Drawing.Point(194, 75);
      this.LblCustomerName.Name = "LblCustomerName";
      this.LblCustomerName.Size = new System.Drawing.Size(117, 17);
      this.LblCustomerName.TabIndex = 1;
      this.LblCustomerName.Text = "Enter your name:";
      // 
      // TxtDeskWidth
      // 
      this.TxtDeskWidth.AutoSize = true;
      this.TxtDeskWidth.Location = new System.Drawing.Point(194, 116);
      this.TxtDeskWidth.Name = "TxtDeskWidth";
      this.TxtDeskWidth.Size = new System.Drawing.Size(116, 17);
      this.TxtDeskWidth.TabIndex = 3;
      this.TxtDeskWidth.Text = "Enter desk width:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(194, 160);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(123, 17);
      this.label2.TabIndex = 5;
      this.label2.Text = "Enter desk height:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(194, 202);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(124, 17);
      this.label3.TabIndex = 7;
      this.label3.Text = "Enter drawer total:";
      // 
      // DeskWidth
      // 
      this.DeskWidth.Location = new System.Drawing.Point(366, 116);
      this.DeskWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
      this.DeskWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
      this.DeskWidth.Name = "DeskWidth";
      this.DeskWidth.Size = new System.Drawing.Size(120, 22);
      this.DeskWidth.TabIndex = 8;
      this.DeskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(194, 252);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(146, 17);
      this.label1.TabIndex = 9;
      this.label1.Text = "Select desk materials:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(194, 311);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(132, 17);
      this.label4.TabIndex = 11;
      this.label4.Text = "Days to completion:";
      // 
      // DeskHeight
      // 
      this.DeskHeight.Location = new System.Drawing.Point(365, 160);
      this.DeskHeight.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
      this.DeskHeight.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
      this.DeskHeight.Name = "DeskHeight";
      this.DeskHeight.Size = new System.Drawing.Size(120, 22);
      this.DeskHeight.TabIndex = 13;
      this.DeskHeight.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.Location = new System.Drawing.Point(365, 204);
      this.numericUpDown3.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
      this.numericUpDown3.TabIndex = 14;
      this.numericUpDown3.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
      // 
      // ComboDeskMaterials
      // 
      this.ComboDeskMaterials.AllowDrop = true;
      this.ComboDeskMaterials.FormattingEnabled = true;
      this.ComboDeskMaterials.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
      this.ComboDeskMaterials.Location = new System.Drawing.Point(365, 254);
      this.ComboDeskMaterials.MaxDropDownItems = 5;
      this.ComboDeskMaterials.Name = "ComboDeskMaterials";
      this.ComboDeskMaterials.Size = new System.Drawing.Size(120, 24);
      this.ComboDeskMaterials.TabIndex = 15;
      this.ComboDeskMaterials.Text = "[Choose one]";
      // 
      // comboBox1
      // 
      this.comboBox1.AllowDrop = true;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days",
            "14 Days"});
      this.comboBox1.Location = new System.Drawing.Point(364, 310);
      this.comboBox1.MaxDropDownItems = 5;
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 24);
      this.comboBox1.TabIndex = 16;
      this.comboBox1.Text = "[Choose one]";
      // 
      // BtnSaveQuote
      // 
      this.BtnSaveQuote.Location = new System.Drawing.Point(390, 360);
      this.BtnSaveQuote.Name = "BtnSaveQuote";
      this.BtnSaveQuote.Size = new System.Drawing.Size(96, 23);
      this.BtnSaveQuote.TabIndex = 17;
      this.BtnSaveQuote.Text = "Save Quote";
      this.BtnSaveQuote.UseVisualStyleBackColor = true;
      // 
      // BtnValidateQuote
      // 
      this.BtnValidateQuote.Location = new System.Drawing.Point(294, 360);
      this.BtnValidateQuote.Name = "BtnValidateQuote";
      this.BtnValidateQuote.Size = new System.Drawing.Size(75, 23);
      this.BtnValidateQuote.TabIndex = 18;
      this.BtnValidateQuote.Text = "Validate";
      this.BtnValidateQuote.UseVisualStyleBackColor = true;
      // 
      // BtnExit
      // 
      this.BtnExit.Location = new System.Drawing.Point(197, 360);
      this.BtnExit.Name = "BtnExit";
      this.BtnExit.Size = new System.Drawing.Size(75, 23);
      this.BtnExit.TabIndex = 19;
      this.BtnExit.Text = "Exit";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
      // 
      // AddQuote
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(689, 450);
      this.Controls.Add(this.BtnExit);
      this.Controls.Add(this.BtnValidateQuote);
      this.Controls.Add(this.BtnSaveQuote);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.ComboDeskMaterials);
      this.Controls.Add(this.numericUpDown3);
      this.Controls.Add(this.DeskHeight);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.DeskWidth);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TxtDeskWidth);
      this.Controls.Add(this.LblCustomerName);
      this.Controls.Add(this.TxtCustomerName);
      this.Name = "AddQuote";
      this.Text = "Add New Quote";
      ((System.ComponentModel.ISupportInitialize)(this.DeskWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DeskHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Label TxtDeskWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DeskWidth;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown DeskHeight;
    private System.Windows.Forms.NumericUpDown numericUpDown3;
    private System.Windows.Forms.ComboBox ComboDeskMaterials;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button BtnSaveQuote;
    private System.Windows.Forms.Button BtnValidateQuote;
    private System.Windows.Forms.Button BtnExit;
  }
}