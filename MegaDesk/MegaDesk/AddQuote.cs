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
     // _mainMenu = mainMenu;
       //List<MegaDesk.DesktopMaterial> materials = Enum.GetValues(typeof(MegaDesk.DesktopMaterial))
         //                                                   .Cast<MegaDesk.DesktopMaterial>()
           //                                                    .ToList();

      // comSurfaceMaterial.DataSource = materials;

      // comSurfaceMaterial.SelectedIndex = -1;
    }
    private void button3_Click(object sender, EventArgs e)
    {
    // search quotes
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.mainMenu.Show();
      this.Close();
    }

  }
}