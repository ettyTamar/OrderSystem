using Microsoft.Owin.Security.Cookies;
using OrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Data;


namespace OrderSystem.Controllers
{
    public class UserRoleController : ApiController
    {
        System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        [Authorize]
        [HttpPost]
        [Route("GetUserByRole")]
        public IHttpActionResult GetUserByRole(UserRole role)
        {
            int role_id = role.ID;
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Users1 WHERE roll_id = " + role_id + ";", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            UserRoleAnswer answer = new UserRoleAnswer();
            List<User> users = new List<User>();

            foreach (System.Data.DataRow user_row in dt.Rows)
            {
                User user = new User();
                user.UserId = (int)user_row[0];

                if (user_row[1] is System.DBNull)
                    user.FirstName = "";
                else
                    user.FirstName = (string)user_row[1];
                if (user_row[2] is System.DBNull)
                    user.LastName = "";
                else
                    user.LastName = (string)user_row[2];
                user.Email = (string)user_row[3];
                user.RoleId = (int)user_row[4];
                if (user_row[5] is System.DBNull)
                    user.Phone = "";
                else
                    user.Phone = (string)user_row[5];
                users.Add(user);
            }
            answer.Users = users;

            return Json(answer);
        }
    }
}
