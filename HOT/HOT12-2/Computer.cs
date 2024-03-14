using System;

namespace HOT12_2
{
    public class Computer
    {
        private string _name;
        private string _ipAddress;
        private int    _services;

        public Computer(string name, string ipAddress, int services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }

        public string GetName() => _name;
        public string GetIPAddress() => _ipAddress;
        public int GetServices() => _services;
    }
}
