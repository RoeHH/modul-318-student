using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Models;

namespace TransportApp.Models
{
    internal class ConnectionBoardListElement
    {

        public string Departure { get; private set; }
        
        public string Arrival { get; private set; }

        public string TravelTime { get; private set; }

        public string FromWithPlatform { get; private set; }
        
        public string ToWithPlatform { get; private set; }

        public string Link { get; private set; }


        public ConnectionBoardListElement(Connection connection)
        {
            Departure = Convert.ToDateTime(connection.From.Departure).ToString("dd/MM HH:mm");
            Arrival = Convert.ToDateTime(connection.To.Arrival).ToString("dd/MM HH:mm");
            TravelTime = Convert.ToDateTime(connection.Duration.Substring(3)).ToString("HH:mm");
            Link = "https://haha.ch"; //"mailto:adress@domain.xx?subject=TransportApp&body=" + connection.From.Station.Name + " - " + connection.To.Station.Name + " " + Departure + " - " + Arrival;
            
            if (connection.From.Platform != "")
                FromWithPlatform = connection.From.Station.Name + " (PL:" + connection.From.Platform + ")";
            else
                FromWithPlatform = connection.From.Station.Name;
            
            if (connection.To.Platform != "")
                ToWithPlatform = connection.To.Station.Name + " (PL:" + connection.To.Platform + ")";
            else
                ToWithPlatform = connection.To.Station.Name;
        }

        public ConnectionBoardListElement(string station, bool isFrom)
        {
            Departure = "";
            Arrival = "";
            TravelTime = "";
            FromWithPlatform = "";
            ToWithPlatform = "";
            Link = "";
            if (isFrom)
                FromWithPlatform = station;
            else
                ToWithPlatform = station;
        }

    }
}
