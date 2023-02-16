using Newtonsoft.Json;
using OrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderSystem.Controllers
{
    public class OrderController : ApiController
    {
        System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        [Authorize]
        [HttpPost]
        [Route("GetOrders")]
        public IHttpActionResult GetOrders(Orders order)
        {
            int order_id = order.OrderId;
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Orders WHERE order_id = " + order_id + ";", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            OrderAnswer answer = new OrderAnswer();
            List<Orders> orders = new List<Orders>();

            foreach (System.Data.DataRow order_row in dt.Rows)
            {
                Orders _order = new Orders();
                _order.OrderId = (int)order_row[0];
                _order.UserId = (int)order_row[1];
                _order.OrderDate = (DateTime)order_row[2];

                orders.Add(_order);
            }
            answer.Orders = orders;
            return Json(answer);
        }

        [Authorize]
        [HttpPost]
        [Route("GetOrdersSum")]
        public IHttpActionResult GetOrdersSum(OrdersTotal orderSum)
        {
            int user_id = orderSum.UserId;
            SqlCommand cmd = new SqlCommand(@"SELECT SUM(total_amount) FROM Orders WHERE user_id = " + user_id + " between " + orderSum.From + " AND " +  orderSum.To + ";", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            OrderSumAnswer answer = new OrderSumAnswer();
            answer.OrderSum = (float)dt.Rows[0][0];

            return Json(answer);
        }
    }
}
