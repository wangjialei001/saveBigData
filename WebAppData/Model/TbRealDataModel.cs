using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppData.Model
{
    public class InsertDataStrModel
    {
        public string Input { get; set; }
    }
    public class TbRealDataModel
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public long? Projectid { get; set; }
        public string Descname { get; set; }
        public string Tagname { get; set; }
        public string Aitype { get; set; }
        public string Unit { get; set; }
        public string Realvalue { get; set; }
        public float? Hihi { get; set; }
        public float? Hi { get; set; }
        public float? Lolo { get; set; }
        public float? Lo { get; set; }
        public short? Isalarm { get; set; }
        public short? Isvoice { get; set; }
        public string Valuetype { get; set; }
        public int? Startbyte { get; set; }
        public int? Datalength { get; set; }
        public string Zeromean { get; set; }
        public string Onemean { get; set; }
        public int? Valuesort { get; set; }
        public long? Equid { get; set; }
        public int? Controllsort { get; set; }
        public int? Transarray { get; set; }
        public float? Datafmtdesc { get; set; }
        public long? Plcid { get; set; }
        public string Setname { get; set; }
        public short? Ismodified { get; set; }
        public long? Standarparamid { get; set; }
        public DateTime? Updatetime { get; set; }
        public string Paramean { get; set; }
    }
    public class TbRealDataEntity
    {
        public long RealDataId { get; set; }
        public string Uid { get; set; }
        public long? Projectid { get; set; }
        public string Descname { get; set; }
        public string Tagname { get; set; }
        public string Aitype { get; set; }
        public string Unit { get; set; }
        public string Realvalue { get; set; }
        public float? Hihi { get; set; }
        public float? Hi { get; set; }
        public float? Lolo { get; set; }
        public float? Lo { get; set; }
        public short? Isalarm { get; set; }
        public short? Isvoice { get; set; }
        public string Valuetype { get; set; }
        public int? Startbyte { get; set; }
        public int? Datalength { get; set; }
        public string Zeromean { get; set; }
        public string Onemean { get; set; }
        public int? Valuesort { get; set; }
        public long? Equid { get; set; }
        public int? Controllsort { get; set; }
        public int? Transarray { get; set; }
        public float? Datafmtdesc { get; set; }
        public long? Plcid { get; set; }
        public string Setname { get; set; }
        public short? Ismodified { get; set; }
        public long? Standarparamid { get; set; }
        public string Generatetime { get; set; }
        public string Paramean { get; set; }
    }
}
