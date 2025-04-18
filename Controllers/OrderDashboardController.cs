using Microsoft.AspNetCore.OData.Query;
using Sap.Data.Hana;
using ODataNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ODataNetCore.Controllers
{
    public class OrderDashboardController : HanaODataController<OrderDashboard>
    {
        public OrderDashboardController(HanaConnection conn) : base(conn) { }

        [EnableQuery(PageSize = 100)]
        public async Task<IActionResult> Get(ODataQueryOptions<OrderDashboard> options)
        {
            var query = await ExecuteODataQueryAsync(
           "V_ORDER_DASHBOARD",
            options,
             (reader, selectedColumns) => {
                var dash = new OrderDashboard
                {
                    PERIOD = GetSafeString(reader, "PERIOD", selectedColumns),
                    PLANT = GetSafeString(reader, "PLANT", selectedColumns),
                    TOTAL_ORDERS = GetSafeLong(reader, "TOTAL_ORDERS", selectedColumns),
                    OPEN_ORDERS = GetSafeInt(reader, "OPEN_ORDERS", selectedColumns),
                    CLOSED_ORDERS = GetSafeInt(reader, "CLOSED_ORDERS", selectedColumns),
                    OPEN_ZKR3 = GetSafeInt(reader, "OPEN_ZKR3", selectedColumns),
                    OPEN_ZKR5 = GetSafeInt(reader, "OPEN_ZKR5", selectedColumns),
                    OPEN_ZKR6 = GetSafeInt(reader, "OPEN_ZKR6", selectedColumns),
                    CLOSED_ZKR3 = GetSafeInt(reader, "CLOSED_ZKR3", selectedColumns),
                    CLOSED_ZKR5 = GetSafeInt(reader, "CLOSED_ZKR5", selectedColumns),
                    CLOSED_ZKR6 = GetSafeInt(reader, "CLOSED_ZKR6", selectedColumns),
                    DIVERGENT_ORDERS = GetSafeInt(reader, "DIVERGENT_ORDERS", selectedColumns)
                };

                return dash;
            });

            return Ok(query);
        }
    }
}