using System.Collections.Generic;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;
using TransportApp.Models;

namespace TransportApp
{


    public partial class App : Form
    {
        private static readonly ITransport TransportApi = new Transport();

        private static List<Station> _stations = new();

        public App()
        {
            InitializeComponent();
        }

        private void FoundStationsCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                UpdateStationBoard(_stations[e.RowIndex]);
            }
        }

        private void StationSearchBoxTextChanged(object sender, EventArgs e)
        {
            _stations = TransportApi.GetStations(stationSearchBox.Text).StationList;
            foundStations.DataSource = _stations;
            if(_stations.Count > 0)
                UpdateStationBoard(_stations[0]);
        }

        private void UpdateStationBoard(Station station)
        {
            if(station.Name != null && station.Id != null)
            {
                stationBoardHeading.Text = station.Name;
                var stationBoardListElements = new List<StationBoardListElement>();
                TransportApi.GetStationBoard(station.Name, station.Id).Entries.ForEach(e => stationBoardListElements.Add(new StationBoardListElement(e)));
                stationBoard.DataSource = stationBoardListElements;
            }
        }

        private void ConnectionSearchTextBoxTextChanged(object sender, EventArgs e)
        {
            if (fromTextBox.Text == "" && toTextBox.Text == "")
            {
                var connectionBoardListElement = new List<ConnectionBoardListElement>();
                TransportApi.GetConnections(fromTextBox.Text, toTextBox.Text).ConnectionList.ForEach(e => connectionBoardListElement.Add(new ConnectionBoardListElement(e)));
                conectionBoard.DataSource = connectionBoardListElement;
            }
            else
            {
                _stations = TransportApi.GetStations(fromTextBox.Text ?? toTextBox.Text).StationList;
                conectionBoard.DataSource = _stations;
            }



        }


    }
}   