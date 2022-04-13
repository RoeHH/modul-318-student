using System.Collections.Generic;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;
using TransportApp.Models;
using Windows.Devices.Geolocation;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace TransportApp
{
    public partial class App : Form
    {
        public double Latitude;

        public double Longitude;

        private static readonly ITransport TransportApi = new Transport();

        private static List<Station> _stations = TransportApi.GetCloseStations().StationList;

        public App()
        {
            InitializeComponent();
            UpdateLocation();
            connectionDateTimePicker.Value = DateTime.Now;
            foundStations.DataSource = _stations;

            // Map Config
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
            gMapControl1.ShowCenter = false;
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

        private void SwitchFromToClick(object sender, EventArgs e)
        {
            (toTextBox.Text, fromTextBox.Text) = (fromTextBox.Text, toTextBox.Text);
        }

        private void LocationButton1Click(object sender, EventArgs e)
        {
            stationSearchBox.Text = "Aktueller Standort";
            _stations = TransportApi.GetCloseStations().StationList;
            foundStations.DataSource = _stations;
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            UpdateLocation();
            gMapControl1.Position = new PointLatLng(Latitude, Longitude);

            GMapOverlay markersOverlay = new GMapOverlay("user");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Latitude, Longitude), GMarkerGoogleType.red);
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void OnMapClick(object sender, MouseEventArgs e)
        {
            if (((GMapControl)sender).IsMouseOverMarker)
            {
                var point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                var station = TransportApi.GetStations(point.Lat, point.Lng).StationList;
                if (station.Count > 0)
                {
                    tabControl.SelectedTab = stationTab;
                    stationSearchBox.Text = station[0].Name;
                    _stations = station;
                    foundStations.DataSource = _stations;
                }
            }
        }

        private void UpdateLocation()
        {
            TransportApi.GetLocation(ref Latitude,ref Longitude);
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void stationBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}   