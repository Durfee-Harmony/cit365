using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
  public partial class Form1 : Form
  {

    Random randomizer = new Random();

    int timeLeft;


    int addend1;
    int addend2;

    int minuend;
    int subtrahend;

    int multiplicand;
    int multiplier;

    int dividend;
    int divisor;

    public void startTheQuiz()
    {
      addend1 = randomizer.Next(51);
      addend2 = randomizer.Next(51);
      plusLeftLable.Text = addend1.ToString();
      plusRightLable.Text = addend2.ToString();
      sum.Value = 0;

      minuend = randomizer.Next(1, 101);
      subtrahend = randomizer.Next(1, minuend);
      minusLeftLable.Text = minuend.ToString();
      minusRightLable.Text = subtrahend.ToString();
      difference.Value = 0;

      multiplicand = randomizer.Next(2, 11);
      multiplier = randomizer.Next(2, 11);
      timesLeftLable.Text = multiplicand.ToString();
      timesRightLable.Text = multiplier.ToString();
      product.Value = 0;

      divisor = randomizer.Next(2, 11);
      int tempQuotient = randomizer.Next(2, 11);
      dividend = divisor * tempQuotient;
      dividedLeftLable.Text = dividend.ToString();
      dividedRightLable.Text = divisor.ToString();
      quotient.Value = 0;   

      timeLeft = 30;
      timeLabel.Text = "30 seconds";
      timer1.Start();
      
    }
    public Form1()
    {
      InitializeComponent();
    }

    private bool CheckTheAnswer()
    {
      if (addend1 + addend2 == sum.Value 
            && minuend - subtrahend == difference.Value
            && dividend / divisor == quotient.Value
            && multiplier * multiplicand == product.Value)
      {
        return true;
      } 
      else
      {
        return false;
      }
    }


    private void startButton_Click(object sender, EventArgs e)
    {
      startTheQuiz();
      startButton.Enabled = false;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (CheckTheAnswer())
      {
        timer1.Stop();
        MessageBox.Show("You got all the answers right!", "Congratulations");
        startButton.Enabled = true;
      }
      else if (timeLeft > 0)
      {
        timeLabel.Text = --timeLeft + " seconds";
      } 
      else
      {
        timer1.Stop();
        timeLabel.Text = "Time's up!";
        MessageBox.Show("You didn't finish in time.", "Sorry!");
        sum.Value = addend1 + addend2;
        difference.Value = minuend - subtrahend;
        startButton.Enabled = true;
      }
    }

    private void answer_Enter(object sender, EventArgs e)
    {
      NumericUpDown answerBox = sender as NumericUpDown;

      if (answerBox != null)
      {
        int lengthOfAnswer = answerBox.Value.ToString().Length;
        answerBox.Select(0, lengthOfAnswer);
      }
    }
  }
}
