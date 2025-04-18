using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataNetCore.Models;
using Sap.Data.Hana;

public class PlantsController : ODataController
{
    private readonly HanaConnection _conn;

    public PlantsController(HanaConnection conn)
    {
        _conn = conn;
    }

    [EnableQuery(PageSize = 100)]
    public async Task<IActionResult> Get()
    {
        try
        {
            await _conn.OpenAsync();
            using var cmd = new HanaCommand(
                @"SELECT DISTINCT CUSTOMER_ORDER_PLANT AS PLANT 
                 FROM ""ITS_VTM_PRD"".""CUSTOMER_ORDERS""",
                _conn);

            using var reader = (HanaDataReader)await cmd.ExecuteReaderAsync();
            var plants = new List<Plant>();

            while (await reader.ReadAsync())
            {
                plants.Add(new Plant
                {
                    PLANT = GetSafeString(reader, "PLANT")
                });
            }

            return Ok(plants.AsQueryable());
        }
        finally
        {
            await _conn.CloseAsync();
        }
    }

    private static string GetSafeString(HanaDataReader reader, string column)
    {
        return reader[column] as string ?? string.Empty;
    }
}