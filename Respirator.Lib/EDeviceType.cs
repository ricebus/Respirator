using System;
using System.Collections.Generic;
using System.Text;

namespace Respirator.Lib
{
    public enum EDeviceType : byte
    {
        eVelaBoxVentilator = 1,
        eP980Ventilator = 2,
        eHamiltonVentilator = 3,
        eFlight60Ventilator = 4,
        eServoAirVentilator = 5,

        eAgiliaInjectomat = 100,
        eAgiliaVolumat = 101,
        eAssenaInjector = 102,

        eUnknown = 255
    }
}
