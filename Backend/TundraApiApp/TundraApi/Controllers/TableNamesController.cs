using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace TundraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableNamesController : ControllerBase
    {
        private IConfiguration Configuration;

        public TableNamesController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        [HttpGet] 
        public async Task<IActionResult> GetTableNames()
        {
            //Open connection to the database
            string connString = this.Configuration.GetConnectionString("Default");
            SqlConnection cnn = new SqlConnection(connString);
            cnn.Open();

            //initialization
            SqlCommand cmd;
            SqlDataReader dr;
            String sql,rowValue="";
            List<string> tableNamesList = new List<string> {};
            
            // Name of stored procedure
            sql = "dbo.spGetTableNames";

            // Create the sql command
            cmd = new SqlCommand(sql, cnn);

            // Set the command type to stored procedure
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // How to add parameters example:
            // cmd.Parameters.Add(new SqlParameter("@CustomerID", custId));

            // Execute the reader for the sql command
            dr = await cmd.ExecuteReaderAsync();
            
            //iterate through the result
            //add each to the list
            while(dr.Read())
            {
                rowValue = dr.GetValue(0).ToString();
                tableNamesList.Add(rowValue);
            }
            
            //close all objects
            dr.Close();
            cmd.Dispose();
            cnn.Close();

            
            // convert list to json
            var output = JsonConvert.SerializeObject(tableNamesList);

            return Ok(output);
        }
    }
}