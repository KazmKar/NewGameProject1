using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject1
{
    interface ICampeinsManagerService
    {
        void Add(Campeins campeins);
        void Delete();
        void Update();
    }
}
