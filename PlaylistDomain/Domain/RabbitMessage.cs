using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Domain
{
    public abstract class RabbitMessage
    {
        public abstract string GetMessage();
    }
}
