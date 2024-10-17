using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGeo.Model
{
    public class VGeo
    {
        public class Feature
        {
            public string Type { get; set; }
            public Geometry Geometry { get; set; }
            public Properties Properties { get; set; }
        }

        public class Geometry
        {
            public string Type { get; set; }
            public List<List<double>> Coordinates { get; set; }
        }

        public class Properties
        {
            public string Br { get; set; }
            public string SgTpTrecho { get; set; }
            public string Uf { get; set; }
            public string CdTpTrecho { get; set; }
            public string Rota { get; set; }
            public string Data { get; set; }
            public int Km { get; set; }
        }

    }
}
