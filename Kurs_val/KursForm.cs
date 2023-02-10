using BankReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Kurs_val
{
    public partial class KursForm : Form
    {

        private BindingList<Valuta> _allValutes = new();
        private BindingList<Valuta> _favoritesValutes = new();
        public KursForm()
        {
            InitializeComponent();
            LoadValute();
            LoadFavoriteValute();
            LoadDataGrid();
            RefreshStatusStrip();
        }
        private void LoadDataGrid()
        {
            forFavouritesDataGrid.AutoGenerateColumns = false;
            using var context = new ValutaContext();
            if (_favoritesValutes.Count == 0)
            {
                ((DataGridViewButtonColumn)forFavouritesDataGrid.Columns["Button"]!).Text = "Добавить";
                KursTab.SelectedIndex = 0;
                forFavouritesDataGrid.Parent = Kursval1;
                forFavouritesDataGrid.DataSource = _allValutes;
            }
            else
            {
                ((DataGridViewButtonColumn)forFavouritesDataGrid.Columns["Button"]!).Text = "Удалить";
                KursTab.SelectedIndex = 1;
                forFavouritesDataGrid.Parent = Favourites1;
                forFavouritesDataGrid.DataSource = _favoritesValutes;
            }
        }

        private void LoadValute()
        {

            var bank = new DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            var response = bank.GetCursOnDateXML(DateTime.Today);

            foreach (XmlNode valute in response.ChildNodes)
            {
                var model = new Valuta
                {
                    Code = valute["VchCode"]!.InnerText,
                    Name = valute["Vname"]!.InnerText.Trim(),
                    Nominal = int.Parse(valute["Vnom"]!.InnerText),
                    Curs = decimal.Parse(valute["Vcurs"]!.InnerText, CultureInfo.InvariantCulture)
                };

                _allValutes.Add(model);
            }
        }
        private void LoadFavoriteValute()
        {
            _favoritesValutes.Clear();
            using var context = new ValutaContext();
            var codes = context.Favorites.Select(x => x.Code);
            var valutes = _allValutes.Where(x => codes.Contains(x.Code));
            foreach (var valute in valutes)
            {
                _favoritesValutes.Add(valute);
            }
        }
        private void KursTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (KursTab.SelectedIndex)
            {
                case 0:
                    ((DataGridViewButtonColumn)forFavouritesDataGrid.Columns["Button"]!).Text = "Добавить";
                    KursTab.SelectedIndex = 0;
                    forFavouritesDataGrid.Parent = Kursval1;
                    forFavouritesDataGrid.DataSource = _allValutes;
                    break;
                case 1:
                    ((DataGridViewButtonColumn)forFavouritesDataGrid.Columns["Button"]!).Text = "Удалить";
                    KursTab.SelectedIndex = 1;
                    forFavouritesDataGrid.Parent = Favourites1;
                    forFavouritesDataGrid.DataSource = _favoritesValutes;
                    break;
            }

            RefreshStatusStrip();
        }
        private void forFavouritesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (forFavouritesDataGrid.Columns[e.ColumnIndex] is not DataGridViewButtonColumn) return;

            var row = e.RowIndex;
            var code = (string)forFavouritesDataGrid[0, row].Value;
            using var context = new ValutaContext();

            switch (KursTab.SelectedIndex)
            {
                case 0:
                    if (context.Favorites.Find(code) == null)
                    {
                        context.Add(new Favorite(code));
                    }
                    break;
                case 1:
                    context.Favorites.Remove(context.Favorites.First(x => x.Code == code));
                    RefreshStatusStrip();
                    break;
            }

            context.SaveChanges();
            LoadFavoriteValute();

        }
        private void RefreshStatusStrip()
        {
            statusStrip1.Items[0].Text = $@"Курс для {forFavouritesDataGrid.RowCount} валют";
        }


    }
}
