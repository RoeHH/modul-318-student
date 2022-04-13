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
            connectionDateTimePicker.Value = DateTime.Now;
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
                TransportApi.GetStationBoard(station.Name, station.Id).Entries.ForEach(e => 
                    stationBoardListElements.Add(new StationBoardListElement(e)));
                stationBoard.DataSource = stationBoardListElements;
            }
        }

        private void ConnectionSearchTextBoxTextChanged(object sender, EventArgs e)
        {
            var connectionBoardListElement = new List<ConnectionBoardListElement>();
            if (fromTextBox.Text != "" && toTextBox.Text != "")
                TransportApi.GetConnections(fromTextBox.Text, toTextBox.Text, connectionDateTimePicker.Checked ? connectionDateTimePicker.Value : DateTime.Now).ConnectionList.ForEach(e => 
                    connectionBoardListElement.Add(new ConnectionBoardListElement(e)));
            else if (fromTextBox.Text != "")
                TransportApi.GetStations(fromTextBox.Text).StationList.ForEach(e =>
                    connectionBoardListElement.Add(new ConnectionBoardListElement(e.Name, true)));
            else if (toTextBox.Text != "")
                TransportApi.GetStations(toTextBox.Text).StationList.ForEach(e =>
                    connectionBoardListElement.Add(new ConnectionBoardListElement(e.Name, false)));
            conectionBoard.DataSource = connectionBoardListElement;
        }


    }
}   