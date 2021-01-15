using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppData.Model;

namespace WebAppData.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PostDataController : ControllerBase
    {
        [HttpPost]
        public async Task InsertData(List<TbRealDataModel> inputs)
        {
            try
            {
                if (inputs == null || inputs.Count() == 0)
                {
                    Console.WriteLine("空值");
                }
                var realDatas = new List<TbRealDataEntity> { };

                foreach (var input in inputs)
                {
                    if (input.Updatetime == null || (DateTime.Now - (DateTime)input.Updatetime).TotalMinutes > 5)
                    {
                        continue;
                    }

                    realDatas.Add(new TbRealDataEntity
                    {
                        RealDataId = input.Id,
                        Uid = input.Uid,
                        Projectid = input.Projectid,
                        Descname = input.Descname,
                        Tagname = input.Tagname,
                        Aitype = input.Aitype,
                        Unit = input.Unit,
                        Realvalue = input.Realvalue,
                        Hihi = input.Hihi,
                        Hi = input.Hi,
                        Lolo = input.Lolo,
                        Lo = input.Lo,
                        Isalarm = input.Isalarm,
                        Isvoice = input.Isvoice,
                        Valuetype = input.Valuetype,
                        Startbyte = input.Startbyte,
                        Datalength = input.Datalength,
                        Zeromean = input.Zeromean,
                        Onemean = input.Onemean,
                        Valuesort = input.Valuesort,
                        Equid = input.Equid,
                        Controllsort = input.Controllsort,
                        Transarray = input.Transarray,
                        Datafmtdesc = input.Datafmtdesc,
                        Plcid = input.Plcid,
                        Setname = input.Setname,
                        Ismodified = input.Ismodified,
                        Standarparamid = input.Standarparamid,
                        Generatetime = ((DateTime)input.Updatetime).ToString("yyyy-MM-dd HH:mm:ss fff"),
                        Paramean = input.Paramean
                    });
                }
                if (realDatas.Count() == 0)
                {
                    return;
                }
                //string str = JsonConvert.SerializeObject(inputs);
                //Console.WriteLine(str);
                //var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
                var client = new MongoClient("mongodb://127.0.0.1:27017");
                //获取database
                var mydb = client.GetDatabase("realDataDb");
                //获取collection
                var collection = mydb.GetCollection<TbRealDataEntity>(typeof(TbRealDataEntity).Name);
                collection.InsertMany(realDatas);
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
