using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl;
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
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                stationSearchBox.Text = _stations[e.RowIndex].Name;
            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                UpdateStationBoard(_stations[e.RowIndex]);
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                tabControl.SelectedIndex = 2;
                if (_stations[e.RowIndex].Coordinate.XCoordinate == null ||
                    _stations[e.RowIndex].Coordinate.YCoordinate == null)
                {
                    return;
                }
                GMapOverlay markersOverlay = new GMapOverlay("station");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(_stations[e.RowIndex].Coordinate.XCoordinate.Value, _stations[e.RowIndex].Coordinate.XCoordinate.Value), GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markersOverlay);
                
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
            if (station.Name == null || station.Id == null)
            {
                return;
            }
            stationBoardHeading.Text = station.Name;
            var stationBoardListElements = new List<StationBoardListElement>();
            TransportApi.GetStationBoard(station.Name, station.Id).Entries.ForEach(e => 
                stationBoardListElements.Add(new StationBoardListElement(e)));
            stationBoard.DataSource = stationBoardListElements;
            
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
            GMarkerCross marker = new GMarkerCross(new PointLatLng(Latitude, Longitude));
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);
        }

        private void OnMapClick(object sender, MouseEventArgs e)
        {
            var point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            var station = TransportApi.GetStations(point.Lat, point.Lng).StationList;
            station.RemoveAt(0);
            if (station.Count > 0)
            {
                tabControl.SelectedTab = stationTab;
                stationSearchBox.Text = station[0].Name;
                _stations = station;
                foundStations.DataSource = _stations;
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

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            var closeStations = TransportApi.GetCloseStations().StationList;

            GMapOverlay markersOverlay = new GMapOverlay("stations");
            foreach (var station in closeStations)
            {
                if (station.Coordinate.XCoordinate == null || station.Coordinate.YCoordinate == null)
                {
                    continue;
                }
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(station.Coordinate.XCoordinate.Value, station.Coordinate.XCoordinate.Value), GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
            }
            gMapControl1.Overlays.Add(markersOverlay);
        }

        private void conectionBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                fromTextBox.Text = conectionBoard.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                toTextBox.Text = conectionBoard.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                //Funktioniert noch nicht :(
                //ProcessStartInfo sInfo = new ProcessStartInfo(conectionBoard.Rows[e.RowIndex].Cells[5].Value.ToString());
                //Process.Start(sInfo);
            }
        }
        }
}   