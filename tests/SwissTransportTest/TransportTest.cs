﻿using System;

namespace SwissTransport
{
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using Xunit;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public void Locations()
        {
            Stations stations = this.testee.GetStations("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void GeoLocationStation()
        {
            Stations stations = this.testee.GetStations(47.37, 8.54);

            stations.StationList.Should().HaveCount(10);
            stations.StationList[0].Name.Should().Be("Waaggasse 3, Zürich");
        }

        [Fact]
        public void CloseStations()
        {
            Stations stations = this.testee.GetCloseStations();

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void StationBoard()
        {
            StationBoardRoot stationBoard = this.testee.GetStationBoard("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void Connections()
        {
            Connections connections = this.testee.GetConnections("Sursee", "Luzern", DateTime.Now);

            connections.Should().NotBeNull();
        }

        [Fact]
        public void UserLocation()
        {
            double latitude = 0.0;
            double longitude = 0.0;
            testee.GetLocation(ref latitude, ref longitude);
            latitude.Should().BeGreaterThan(0.0);
            longitude.Should().BeGreaterThan(0.0);
        }
    }
}