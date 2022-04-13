
namespace SwissTransport.Core
{
    using System;
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        Stations GetStations(double latitude, double longitude);

        Stations GetCloseStations();

        StationBoardRoot GetStationBoard(string station, string id);

        Connections GetConnections(string fromStation, string toStation, DateTime date);

        void GetLocation(ref double latitude, ref double longitude);

    }
}