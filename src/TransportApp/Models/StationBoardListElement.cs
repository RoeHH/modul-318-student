using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Models;

namespace TransportApp.Models
{
    internal class StationBoardListElement
    {
        public string To { get; private set; }
        public string Operator { get; private set; }
        public DateTime Departure { get; private set; }

        public StationBoardListElement(StationBoard stationBoard)
        {
            To = stationBoard.To;
            Operator = stationBoard.Operator;
            Departure = stationBoard.Stop.Departure;
        }

    }
}
