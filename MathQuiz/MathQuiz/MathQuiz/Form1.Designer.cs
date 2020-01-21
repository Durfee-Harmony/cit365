namespace MathQuiz
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
      this.timeLabel = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.plusLeftLable = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.te = new System.Windows.Forms.Label();
      this.plusRightLable = new System.Windows.Forms.Label();
      this.sum = new System.Windows.Forms.NumericUpDown();
      this.difference = new System.Windows.Forms.NumericUpDown();
      this.minusRightLable = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.minusLeftLable = new System.Windows.Forms.Label();
      this.product = new System.Windows.Forms.NumericUpDown();
      this.timesRightLable = new System.Windows.Forms.Label();
      this.nvmnd = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.timesLeftLable = new System.Windows.Forms.Label();
      this.quotient = new System.Windows.Forms.NumericUpDown();
      this.dividedRightLable = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.dividedLeftLable = new System.Windows.Forms.Label();
      this.startButton = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.todaysDate = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
      this.SuspendLayout();
      // 
      // timeLabel
      // 
      this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.timeLabel.Location = new System.Drawing.Point(265, 26);
      this.timeLabel.Name = "timeLabel";
      this.timeLabel.Size = new System.Drawing.Size(200, 30);
      this.timeLabel.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(116, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(127, 31);
      this.label1.TabIndex = 1;
      this.label1.Text = "Time Left";
      // 
      // plusLeftLable
      // 
      this.plusLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.plusLeftLable.Location = new System.Drawing.Point(50, 75);
      this.plusLeftLable.Name = "plusLeftLable";
      this.plusLeftLable.Size = new System.Drawing.Size(60, 50);
      this.plusLeftLable.TabIndex = 2;
      this.plusLeftLable.Text = "?";
      this.plusLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(260, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 50);
      this.label2.TabIndex = 3;
      this.label2.Text = "=";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // te
      // 
      this.te.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.te.Location = new System.Drawing.Point(116, 75);
      this.te.Name = "te";
      this.te.Size = new System.Drawing.Size(60, 50);
      this.te.TabIndex = 4;
      this.te.Text = "+";
      this.te.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // plusRightLable
      // 
      this.plusRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.plusRightLable.Location = new System.Drawing.Point(182, 75);
      this.plusRightLable.Name = "plusRightLable";
      this.plusRightLable.Size = new System.Drawing.Size(60, 50);
      this.plusRightLable.TabIndex = 5;
      this.plusRightLable.Text = "?";
      this.plusRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // sum
      // 
      this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sum.Location = new System.Drawing.Point(326, 80);
      this.sum.Name = "sum";
      this.sum.Size = new System.Drawing.Size(100, 41);
      this.sum.TabIndex = 2;
      this.sum.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // difference
      // 
      this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.difference.Location = new System.Drawing.Point(326, 130);
      this.difference.Name = "difference";
      this.difference.Size = new System.Drawing.Size(100, 41);
      this.difference.TabIndex = 3;
      this.difference.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // minusRightLable
      // 
      this.minusRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.minusRightLable.Location = new System.Drawing.Point(182, 125);
      this.minusRightLable.Name = "minusRightLable";
      this.minusRightLable.Size = new System.Drawing.Size(60, 50);
      this.minusRightLable.TabIndex = 10;
      this.minusRightLable.Text = "?";
      this.minusRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(116, 125);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 50);
      this.label4.TabIndex = 9;
      this.label4.Text = "-";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(260, 125);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(60, 50);
      this.label5.TabIndex = 8;
      this.label5.Text = "=";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // minusLeftLable
      // 
      this.minusLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.minusLeftLable.Location = new System.Drawing.Point(50, 125);
      this.minusLeftLable.Name = "minusLeftLable";
      this.minusLeftLable.Size = new System.Drawing.Size(60, 50);
      this.minusLeftLable.TabIndex = 7;
      this.minusLeftLable.Text = "?";
      this.minusLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // product
      // 
      this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.product.Location = new System.Drawing.Point(325, 180);
      this.product.Name = "product";
      this.product.Size = new System.Drawing.Size(100, 41);
      this.product.TabIndex = 4;
      this.product.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // timesRightLable
      // 
      this.timesRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.timesRightLable.Location = new System.Drawing.Point(181, 175);
      this.timesRightLable.Name = "timesRightLable";
      this.timesRightLable.Size = new System.Drawing.Size(60, 50);
      this.timesRightLable.TabIndex = 15;
      this.timesRightLable.Text = "?";
      this.timesRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // nvmnd
      // 
      this.nvmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nvmnd.Location = new System.Drawing.Point(115, 175);
      this.nvmnd.Name = "nvmnd";
      this.nvmnd.Size = new System.Drawing.Size(60, 50);
      this.nvmnd.TabIndex = 14;
      this.nvmnd.Text = "*";
      this.nvmnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label9
      // 
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(259, 175);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(60, 50);
      this.label9.TabIndex = 13;
      this.label9.Text = "=";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // timesLeftLable
      // 
      this.timesLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.timesLeftLable.Location = new System.Drawing.Point(49, 175);
      this.timesLeftLable.Name = "timesLeftLable";
      this.timesLeftLable.Size = new System.Drawing.Size(60, 50);
      this.timesLeftLable.TabIndex = 12;
      this.timesLeftLable.Text = "?";
      this.timesLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // quotient
      // 
      this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.quotient.Location = new System.Drawing.Point(325, 230);
      this.quotient.Name = "quotient";
      this.quotient.Size = new System.Drawing.Size(100, 41);
      this.quotient.TabIndex = 5;
      this.quotient.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // dividedRightLable
      // 
      this.dividedRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dividedRightLable.Location = new System.Drawing.Point(181, 225);
      this.dividedRightLable.Name = "dividedRightLable";
      this.dividedRightLable.Size = new System.Drawing.Size(60, 50);
      this.dividedRightLable.TabIndex = 20;
      this.dividedRightLable.Text = "?";
      this.dividedRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label12
      // 
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(115, 225);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(60, 50);
      this.label12.TabIndex = 19;
      this.label12.Text = "/";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label13
      // 
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(259, 225);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(60, 50);
      this.label13.TabIndex = 18;
      this.label13.Text = "=";
      this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dividedLeftLable
      // 
      this.dividedLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dividedLeftLable.Location = new System.Drawing.Point(49, 225);
      this.dividedLeftLable.Name = "dividedLeftLable";
      this.dividedLeftLable.Size = new System.Drawing.Size(60, 50);
      this.dividedLeftLable.TabIndex = 17;
      this.dividedLeftLable.Text = "?";
      this.dividedLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // startButton
      // 
      this.startButton.AutoSize = true;
      this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startButton.Location = new System.Drawing.Point(293, 290);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(172, 39);
      this.startButton.TabIndex = 1;
      this.startButton.Text = "Start the Quiz!";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // todaysDate
      // 
      this.todaysDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.todaysDate.Location = new System.Drawing.Point(12, 290);
      this.todaysDate.Name = "todaysDate";
      this.todaysDate.Size = new System.Drawing.Size(239, 39);
      System.DateTime today = System.DateTime.Today;
      this.todaysDate.Text = today.Day + " " + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(today.Month) + " " + today.Year;
      this.todaysDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(478, 349);
      this.Controls.Add(this.todaysDate);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.quotient);
      this.Controls.Add(this.dividedRightLable);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.dividedLeftLable);
      this.Controls.Add(this.product);
      this.Controls.Add(this.timesRightLable);
      this.Controls.Add(this.nvmnd);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.timesLeftLable);
      this.Controls.Add(this.difference);
      this.Controls.Add(this.minusRightLable);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.minusLeftLable);
      this.Controls.Add(this.sum);
      this.Controls.Add(this.plusRightLable);
      this.Controls.Add(this.te);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.plusLeftLable);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.timeLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Ryan Cross - Math Quiz";
      ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label timeLabel;
    private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label te;
        private System.Windows.Forms.Label plusRightLable;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label minusRightLable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minusLeftLable;
    private System.Windows.Forms.NumericUpDown product;
    private System.Windows.Forms.Label timesRightLable;
    private System.Windows.Forms.Label nvmnd;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label timesLeftLable;
    private System.Windows.Forms.NumericUpDown quotient;
    private System.Windows.Forms.Label dividedRightLable;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label dividedLeftLable;
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label todaysDate;
  }
}

