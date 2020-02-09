using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        private Form mainMenu;

        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                                                               .Cast<DesktopMaterial>()
                                                                .ToList();
            materialType.DataSource = materials;
            materialType.SelectedIndex = -1;

            loadGrid();

    

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.mainMenu.Show();
            this.Close();
        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenu.Show();
        }



        private void loadGrid()
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.DaysToComplete,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.NumberOfDrawers,
                   // SurfaceMaterial = d.Desk.Material,
                   // DeliveryType = d.DeliveryType,
                    QuoteAmount = d.QuotePrice.ToString("c")

                }).ToList();

            }
        }

        private void materialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo;
            if(combo.SelectedIndex < 0)
            {
                loadGrid();
            }
            else
            {
                loadGrid((Desk.DesktopMaterials)combo.SelectedValue);
            }
        }
    }
}
