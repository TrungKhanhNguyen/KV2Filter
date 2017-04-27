using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KV2Project.MappingObject
{
    public class ChinhDoiObject
    {
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<decimal> Tanso { get; set; }
        public string PTLienlac { get; set; }
        public string Hohieu { get; set; }
        public string Noidung { get; set; }
        public Nullable<decimal> Huongdo { get; set; }
        public string Mangdai { get; set; }
        public string Giong { get; set; }
        public string Ghichu { get; set; }
        public string Diaban { get; set; }
        public Nullable<decimal> HohieuDecimal { get; set; }
        public bool IsChinh { get; set; }
    }
}
