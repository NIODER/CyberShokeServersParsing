using CyberShoke.Entities;
using System.Collections.Generic;

namespace CyberShoke.Services.Modes
{
    public interface ICyberShokeModes
    {
        public IEnumerable<Mode> GetCSGOModes();
        public IEnumerable<Mode> GetCS2Modes();
        public IEnumerable<string> ListAllModes();
        public IEnumerable<string> ListCSGOModes();
        public IEnumerable<string> ListCS2Modes();
    }
}
