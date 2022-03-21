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
    public class FailureCodeController : ControllerBase
    {

        private readonly TundraDBContext _context;
        private string dataSource = Startup.Configuration.GetConnectionString("Default");

        public FailureCodeController(TundraDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<FailureCode>>> GetFailureCode()
        {
            return await _context.FailureCode.ToListAsync();
        }

        [HttpPost]
        public JsonResult PostFailureCode(FailureCode c)
        {
            string query = @"
                            insert into dbo.condition values
                            (
                            '" + c.Counter + @"'
                            ,'" + c.FailureCode1 + @"'
                            ,'" + c.FailureLevel + @"'
                            ,'" + c.Description + @"'
                            ,'" + c.ParentCode + @"'
                            ,'" + c.Inactive + @"'
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
        public JsonResult PutFailureCode(int id, FailureCode c)
        {
            string query = @"
                        update dbo.Condition set
                         FailureCode1 = '" + c.FailureCode1 + @"'
                        ,FailureLevel = '" + c.FailureLevel + @"'
                        ,Description = '" + c.Description + @"'
                        ,ParentCode = '" + c.ParentCode + @"'
                        ,Inactive = '" + c.Inactive + @"'
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
        public JsonResult DeleteFailureCode(int id)
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