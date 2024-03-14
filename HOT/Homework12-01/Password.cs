using System;

namespace Homework12_01
{
    public class Password
    {
        private string _raw;
        private string _hash;

        public Password(string raw, string hash)
        {
            _raw = raw;
            _hash = hash;
        }

        public string GetRaw() => _raw;
        public string GetHash() => _hash;
    }
}
