using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using TundraApi.Data;
using TundraApi.Models;
using TundraApi;

namespace TundraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PMOffSeasonController : ControllerBase
    {

        private readonly TundraDBContext _context;
        private string dataSource = Startup.Configuration.GetConnectionString("Default");

        public PMOffSeasonController(TundraDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<PmoffSeason>>> GetPMOffSeason()
        {
            return await _context.PMOffSeason.ToListAsync();
        }

        [HttpPost]
        public JsonResult PostPMOffSeason(PmoffSeason c)
        {
            string query = @"
                            insert into dbo.condition values
                            (
                            '" + c.Pmnum + @"'
                            ,'" + c.StartDate + @"'
                            ,'" + c.EndDate + @"'
                            ,'" + c.Counter + @"'
                            ,'" + c.Modifydate + @"'
                            ,'" + c.Creationdate + @"'
                            ,'" + c.Modifyby + @"'
                            ,'" + c.Createdby + @"'
                            ,'" + c.Dirtylog + @"'
                            ,'" + c.ChangeRemark + @"'
                            )
                            ";



        DataTable table = new DataTable();

            SqlDataReader myReader;

            using (SqlConnection myCon = new SqlConnection(dataSource))
            {

                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }

            }

            return new JsonResult("Added Successfully");

        }





        [HttpPut("{id}")]
        public JsonResult PutPMOffSeason(int id, PmoffSeason c)
        {
            string query = @"
                        update dbo.Condition set
                         Pdmnum = '" + c.Pmnum + @"'
                        ,StartDate = '" + c.StartDate + @"'
                        ,EndDate = '" + c.EndDate + @"'
                        ,Modifydate = '" + c.Modifydate + @"'
                        ,Creationdate = '" + c.Creationdate + @"'
                        ,Modifyby = '" + c.Modifyby + @"'
                        ,Createdby = '" + c.Createdby + @"'
                        ,Dirtylog = '" + c.Dirtylog + @"'
                        ,ChangeRemark = '" + c.ChangeRemark + @"'
                        where Counter = " + id + @"";



        DataTable table = new DataTable();

            SqlDataReader myReader;

            using (SqlConnection myCon = new SqlConnection(dataSource))
            {

                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();



                }

                return new JsonResult("Update Successfully");
            }
        }


        [HttpDelete("{id}")]
        public JsonResult DeletePMOffSeason(int id)
        {
            string query = @"
                            delete from dbo.Approve
                            where counter = " + id + @"";

            DataTable table = new DataTable();

            SqlDataReader myReader;




            using (SqlConnection myCon = new SqlConnection(dataSource))
            {

                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }

            }

            return new JsonResult("Delete Successfully");
        }


    }
}