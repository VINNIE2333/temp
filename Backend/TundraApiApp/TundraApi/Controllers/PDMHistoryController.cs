using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TundraApi;
using TundraApi.Data;
using TundraApi.Models;

namespace TundraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDMHistoryController : ControllerBase
    {

        private readonly TundraDBContext _context;
        private string dataSource = Startup.Configuration.GetConnectionString("Default");

        public PDMHistoryController(TundraDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pdmhistory>>> GetPDMHistory()
        {
            return await _context.PDMHistory.ToListAsync();
        }

        [HttpPost]
        public JsonResult PostPDMHistory(Pdmhistory c)
        {
            string query = @"
                            insert into dbo.condition values
                            (
                            '" + c.Counter + @"'
                            ,'" + c.Pdmnum + @"'
                            ,'" + c.MeasurementReading + @"'
                            ,'" + c.TransDate + @"'
                            ,'" + c.ActionTriggered + @"'
                            ,'" + c.Wonum + @"'
                            ,'" + c.ModifyBy + @"'
                            ,'" + c.ModifyDate + @"'
                            ,'" + c.CreatedBy + @"'
                            ,'" + c.CreationDate + @"'
                            ,'" + c.DirtyLog + @"'
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
        public JsonResult PutPDMHistory(int id, Pdmhistory c)
        {
            string query = @"
                        update dbo.Condition set
                         Pdmnum = '" + c.Pdmnum + @"'
                        ,MeasurementReading = '" + c.MeasurementReading + @"'
                        ,TransDate = '" + c.TransDate + @"'
                        ,ActionTriggered = '" + c.ActionTriggered + @"'
                        ,Wonum = '" + c.Wonum + @"'
                        ,ModifyBy = '" + c.ModifyBy + @"'
                        ,ModifyDate = '" + c.ModifyDate + @"'
                        ,CreatedBy = '" + c.CreatedBy + @"'
                        ,CreationDate = '" + c.CreationDate + @"'
                        ,DirtyLog = '" + c.DirtyLog + @"'
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
        public JsonResult DeletePDMHistory(int id)
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