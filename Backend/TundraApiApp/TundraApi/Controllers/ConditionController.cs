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
using System.Linq;
using TundraApi.Data;
using TundraApi.Models;

namespace TundraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConditionController : ControllerBase
    {
        private readonly TundraDBContext _context;
        private string dataSource = Startup.Configuration.GetConnectionString("Default");

        public ConditionController(TundraDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Condition>>> GetCondition()
        {
            return await _context.Condition.ToListAsync();
        }

        [HttpPost]
        public JsonResult PostCondition(Condition c)
        {
            string query = @"
                            insert into dbo.condition values
                            (
                            '" + c.Counter + @"'
                            ,'" + c.ConditionCode + @"'
                            ,'" + c.ConditionValue + @"'
                            ,'" + c.ConditionDescription + @"'
                            ,'" + c.DirtyLog + @"'
                            ,'" + c.ModifyBy + @"'
                            ,'" + c.ModifyDate + @"'
                            ,'" + c.CreatedBy + @"'
                            ,'" + c.CreationDate + @"'
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
        public JsonResult PutCondition(int id, Condition c)
        {
            string query = @"
                        update dbo.Condition set
                        ConditionCode = '" + c.ConditionCode + @"'
                        ,ConditionValue = '" + c.ConditionValue + @"'
                        ,ConditionDescription = '" + c.ConditionDescription + @"'
                        ,DirtyLog = '" + c.DirtyLog + @"'
                        ,ModifyBy = '" + c.ModifyBy + @"'
                        ,ModifyDate = '" + c.ModifyDate + @"'
                        ,CreatedBy = '" + c.CreatedBy + @"'
                        ,CreationDate = '" + c.CreationDate + @"'
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

            }

            return new JsonResult("Update Successfully");
        }


        [HttpDelete("{id}")]
        public JsonResult DeleteCondition(int id)
        {
            string query = @"
                            delete from dbo.Condition
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