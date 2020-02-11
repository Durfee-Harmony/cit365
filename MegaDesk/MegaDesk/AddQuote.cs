using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
  public partial class AddQuote : Form
  {
    MainMenu mainMenu;
    public AddQuote(MainMenu mainMenu)
    {
      InitializeComponent();
      this.mainMenu = mainMenu;
      MainMenu _mainMenu = mainMenu;

      List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                                                         .Cast<DesktopMaterial>()
                                                          .ToList();
      ComDesktopMaterial.DataSource = materials;
      ComDesktopMaterial.SelectedIndex = -1;
    }


    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.mainMenu.Show();
      this.Close();
    }

    private void FormClosingEvent(object sender, FormClosingEventArgs e)
    {
      this.mainMenu.Show();
    }

    private void BtnSaveQuote_Click(object sender, EventArgs e)
    {
      Desk userDesk = new Desk();
      userDesk.Width = (int)(NumDeskWidth.Value);
      userDesk.Depth = (int)(NumDeskDepth.Value);
      userDesk.NumberOfDrawers = (int)(NumNumberOfDrawers.Value);
      userDesk.DesktopMaterial = (DesktopMaterial)ComDesktopMaterial.SelectedItem;

      // OutputBox.Text = ComDesktopMaterial.SelectedItem.ToString();
      DeskQuote userQuote = new DeskQuote();
      userQuote.CustomerName = TxtCustomerName.Text;
      userQuote.DaysToComplete = Convert.ToInt32(ComDaysToComplete.SelectedValue);
      userQuote.Desk = userDesk;
      userQuote.getRushOrderPrices();

      userQuote.CalculateQuotePrice();

      OutputBox.Text = userQuote.FinalPrice.ToString();
    }

  }
}