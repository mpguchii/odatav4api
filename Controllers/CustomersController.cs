using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ODataNetCore.Models;
using Sap.Data.Hana;

public class CustomersController : HanaODataController<Customer>
{
    public CustomersController(HanaConnection conn) : base(conn) { }

    [EnableQuery(PageSize = 100)]
    public async Task<IActionResult> Get(ODataQueryOptions<Customer> options)
    {
        var query = await ExecuteODataQueryAsync(
           "V_CUSTOMERS",
            options,
            (reader, selectedColumns) => {
                var customer = new Customer
                {
                    CUSTOMER_ID = GetSafeLong(reader, "CUSTOMER_ID", selectedColumns),
                    FANTASY_NAME = GetSafeString(reader, "FANTASY_NAME", selectedColumns),
                    BRAND_NAME = GetSafeString(reader, "BRAND_NAME", selectedColumns),
                    COUNTRY = GetSafeString(reader, "COUNTRY", selectedColumns),
                    STATE = GetSafeString(reader, "STATE", selectedColumns),
                    CITY = GetSafeString(reader, "CITY", selectedColumns),
                    NEIGHBORHOOD = GetSafeString(reader, "NEIGHBORHOOD", selectedColumns),
                    STREET = GetSafeString(reader, "STREET", selectedColumns),
                    ZIPCODE = GetSafeString(reader, "ZIPCODE", selectedColumns),
                    CONTACT_LASTNAME = GetSafeString(reader, "CONTACT_LASTNAME", selectedColumns),
                    CONTACT_FIRSTNAME = GetSafeString(reader, "CONTACT_FIRSTNAME", selectedColumns),
                    PHONE = GetSafeString(reader, "PHONE", selectedColumns),
                    TOTAL_ORDERS = GetSafeLong(reader, "TOTAL_ORDERS", selectedColumns),
                    OPEN_ORDERS = GetSafeInt(reader, "OPEN_ORDERS", selectedColumns),
                    CLOSED_ORDERS = GetSafeInt(reader, "CLOSED_ORDERS", selectedColumns),
                    ZKR3_ORDERS = GetSafeInt(reader, "ZKR3_ORDERS", selectedColumns),
                    ZKR5_ORDERS = GetSafeInt(reader, "ZKR5_ORDERS", selectedColumns),
                    ZKR6_ORDERS = GetSafeInt(reader, "ZKR6_ORDERS", selectedColumns),
                    OPEN_ZKR3 = GetSafeInt(reader, "OPEN_ZKR3", selectedColumns),
                    OPEN_ZKR5 = GetSafeInt(reader, "OPEN_ZKR5", selectedColumns),
                    OPEN_ZKR6 = GetSafeInt(reader, "OPEN_ZKR6", selectedColumns),
                    CLOSED_ZKR3 = GetSafeInt(reader, "CLOSED_ZKR3", selectedColumns),
                    CLOSED_ZKR5 = GetSafeInt(reader, "CLOSED_ZKR5", selectedColumns),
                    CLOSED_ZKR6 = GetSafeInt(reader, "CLOSED_ZKR6", selectedColumns),
                    LAST_ORDER_ID = GetSafeLong(reader, "LAST_ORDER_ID", selectedColumns),
                    LAST_ORDER_DATE_OPEN = GetSafeDateTime(reader, "LAST_ORDER_DATE_OPEN", selectedColumns),
                    LAST_QTD_CO2_BARREL = GetSafeInt(reader, "LAST_QTD_CO2_BARREL", selectedColumns),
                    LAST_QTD_BARREL_CHOPP30 = GetSafeInt(reader, "LAST_QTD_BARREL_CHOPP30", selectedColumns),
                    LAST_QTD_BARREL_CHOPP50 = GetSafeInt(reader, "LAST_QTD_BARREL_CHOPP50", selectedColumns)
                };

                return customer;
            });

        return Ok(query);
    }
}