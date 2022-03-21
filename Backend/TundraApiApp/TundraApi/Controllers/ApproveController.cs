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
    public class ApproveController : ControllerBase
    {
        private readonly TundraDBContext _context;
        private string dataSource = Startup.Configuration.GetConnectionString("Default");

        public ApproveController(TundraDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Approve>>> GetBudget()
        {
            return await _context.Approve.ToListAsync();
        }


        [HttpPost]
        public JsonResult PostApprove(Approve c)
        {
            string query = @"
                            insert into dbo.condition values
                            (
                            '" + c.Counter + @"'
                            ,'" + c.Module + @"'
                            ,'" + c.Amount + @"'
                            ,'" + c.ApproveInOrder + @"'
                            ,'" + c.OnePersonApprove + @"'
                            ,'" + c.ApproveCode + @"'
                            ,'" + c.RequiredNumber + @"'
                            ,'" + c.ModifyBy + @"'
                            ,'" + c.ModifyDate + @"'
                            ,'" + c.CreatedBy + @"'
                            ,'" + c.CreationDate + @"'
                            ,'" + c.DirtyLog + @"'
                            
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
        public JsonResult PutApprove(int id, Approve c)
        {
            string query = @"
                        update dbo.Condition set
                         Module = '" + c.Module + @"'
                        ,Amount = '" + c.Amount + @"'
                        ,ApproveInOrder = '" + c.ApproveInOrder + @"'
                        ,OnePersonApprove = '" + c.OnePersonApprove + @"'
                        ,ApproveCode = '" + c.ApproveCode + @"'
                        ,RequiredNumber = '" + c.RequiredNumber + @"'
                        ,ModifyBy = '" + c.ModifyBy + @"'
                        ,ModifyDate = '" + c.ModifyDate + @"'
                        ,CreatedBy = '" + c.CreatedBy + @"'
                        ,CreationDate = '" + c.CreationDate + @"'
                        ,DirtyLog = '" + c.DirtyLog + @"'
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
        public JsonResult DeleteApprove(int id)
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