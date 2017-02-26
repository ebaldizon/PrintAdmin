using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DesignBus
    {
        public bool create(Design design)
        {
            DesignDa designDa = new DesignDa();
            return designDa.create(design);
        }

        public DataTable read(int id)
        {
            DesignDa designDa = new DesignDa();
            return designDa.read(id);
        }
    }
}
