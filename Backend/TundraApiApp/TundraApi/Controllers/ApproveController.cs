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

namespace TundraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApproveController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public ApproveController(TundraDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Approve>>> GetBudget()
        {
            return await _context.Approve.ToListAsync();
        }

        

    }
}

// GET: api/Approve
//        [HttpGet]
//        public JsonResult GetApprove()
//        {
//            //query used in the database
//            string query = @"select * from dbo.Approve";

//            DataTable table = new DataTable();
//            string sqlDataSource = Configuration.GetConnectionString("default");
//            SqlDataReader myReader;

//            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
//            {
//                myCon.Open();
//                using (SqlCommand myCommand = new SqlCommand(query, myCon))
//                {
//                    myReader = myCommand.ExecuteReader();
//                    table.Load(myReader);

//                    myReader.Close();
//                    myCon.Close();


//                }
//            }

//            return new JsonResult(table);
//        }


//    }
//}