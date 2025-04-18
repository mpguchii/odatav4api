using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ODataNetCore.Models;
using Sap.Data.Hana;

public class CustomerOrdersController : HanaODataController<CustomerOrders>
{
    public CustomerOrdersController(HanaConnection conn) : base(conn) { }

    [EnableQuery(PageSize = 100)]
    public async Task<IActionResult> Get(ODataQueryOptions<CustomerOrders> options)
    {
        var query = await ExecuteODataQueryAsync(
           "V_CUSTOMER_ORDERS_REPORT",
            options,
            (reader, selectedColumns) => {
                var order = new CustomerOrders
                {
                    ID = GetSafeLong(reader, "ID", selectedColumns),
                    NOTE = GetSafeString(reader, "NOTE", selectedColumns),
                    STATUS = GetSafeString(reader, "STATUS", selectedColumns),
                    PLANT = GetSafeString(reader, "PLANT", selectedColumns),
                    WORK_CENTER = GetSafeString(reader, "WORK_CENTER", selectedColumns),
                    ORDER_TYPE_ID = GetSafeString(reader, "ORDER_TYPE_ID", selectedColumns),
                    ORDER_TYPE_NAME = GetSafeString(reader, "ORDER_TYPE_NAME", selectedColumns),
                    ORDER_TYPE_TYPE = GetSafeString(reader, "ORDER_TYPE_TYPE", selectedColumns),
                    DATE_OPEN = GetSafeDateTime(reader, "DATE_OPEN", selectedColumns),
                    CUSTOMER_ID = GetSafeLong(reader, "CUSTOMER_ID", selectedColumns),
                    FANTASY_NAME = GetSafeString(reader, "FANTASY_NAME", selectedColumns),
                    BRAND_NAME = GetSafeString(reader, "BRAND_NAME", selectedColumns),
                    PHONE = GetSafeString(reader, "PHONE", selectedColumns),
                    COUNTRY = GetSafeString(reader, "COUNTRY", selectedColumns),
                    STATE = GetSafeString(reader, "STATE", selectedColumns),
                    CITY = GetSafeString(reader, "CITY", selectedColumns),
                    NEIGHBORHOOD = GetSafeString(reader, "NEIGHBORHOOD", selectedColumns),
                    STREET = GetSafeString(reader, "STREET", selectedColumns),
                    ZIPCODE = GetSafeString(reader, "ZIPCODE", selectedColumns),
                    CONTACT_FIRSTNAME = GetSafeString(reader, "CONTACT_FIRSTNAME", selectedColumns),
                    CONTACT_LASTNAME = GetSafeString(reader, "CONTACT_LASTNAME", selectedColumns),
                    EQUIPMENT_ID = GetSafeString(reader, "EQUIPMENT_ID", selectedColumns),
                    EQUIPMENT_NUMBER = GetSafeString(reader, "EQUIPMENT_NUMBER", selectedColumns),
                    EQUIPMENT_TYPE = GetSafeString(reader, "EQUIPMENT_TYPE", selectedColumns),
                    EQUIPMENT_SERIAL_NUMBER = GetSafeString(reader, "EQUIPMENT_SERIAL_NUMBER", selectedColumns),
                    MATERIAL = GetSafeString(reader, "MATERIAL", selectedColumns),
                    SYMPTOM_ID = GetSafeLong(reader, "SYMPTOM_ID", selectedColumns),
                    SYMPTOM_NAME = GetSafeString(reader, "SYMPTOM_NAME", selectedColumns),
                    SYMPTOM_OBJ_TECNICO = GetSafeString(reader, "SYMPTOM_OBJ_TECNICO", selectedColumns),
                    SYMPTOM_SAP = GetSafeString(reader, "SYMPTOM_SAP", selectedColumns),
                    TECHNICAL_OBJ_NAME = GetSafeString(reader, "TECHNICAL_OBJ_NAME", selectedColumns),
                    ORDER_OBS = GetSafeString(reader, "ORDER_OBS", selectedColumns),
                    WARRANTY_OBSERVATIONS = GetSafeString(reader, "WARRANTY_OBSERVATIONS", selectedColumns),
                    PRIORITY_ID = GetSafeInt(reader, "PRIORITY_ID", selectedColumns),
                    PRIORITY_NAME = GetSafeString(reader, "PRIORITY_NAME", selectedColumns),
                    USER_NAME = GetSafeString(reader, "USER_NAME", selectedColumns),
                    USER_REGISTRY = GetSafeString(reader, "USER_REGISTRY", selectedColumns),
                    USER_LOGIN = GetSafeString(reader, "USER_LOGIN", selectedColumns),
                    DATE_START = GetSafeDateTime(reader, "DATE_START", selectedColumns),
                    DATE_CLOSED = GetSafeDateTime(reader, "DATE_CLOSED", selectedColumns),
                    DIVERGENT_EQUIP_ID = GetSafeString(reader, "DIVERGENT_EQUIP_ID" , selectedColumns),
                    CHANGE_TAG = GetSafeBool(reader, "CHANGE_TAG", selectedColumns),
                    CARBONATING_INITIAL = GetSafeDecimal(reader, "CARBONATING_INITIAL", selectedColumns),
                    TEMPERATURE_INITIAL = GetSafeDecimal(reader, "TEMPERATURE_INITIAL", selectedColumns),
                    ICE = GetSafeBool(reader, "ICE", selectedColumns),
                    QTD_VALVE = GetSafeInt(reader, "QTD_VALVE", selectedColumns),
                    DATE_FILTER_CELLULOSE = GetSafeDateTime(reader, "DATE_FILTER_CELLULOSE", selectedColumns),
                    DATE_FILTER_COAL = GetSafeDateTime(reader, "DATE_FILTER_COAL", selectedColumns),
                    MECHANICAL_SANITIZATION = GetSafeBool(reader, "MECHANICAL_SANITIZATION", selectedColumns),
                    DATE_MECHANICAL_SANITIZATION = GetSafeDateTime(reader, "DATE_MECHANICAL_SANITIZATION", selectedColumns),
                    PEST_CONTROL = GetSafeBool(reader, "PEST_CONTROL", selectedColumns),
                    DATE_PEST_CONTROL = GetSafeDateTime(reader, "DATE_PEST_CONTROL", selectedColumns),
                    POTABILITY = GetSafeBool(reader, "POTABILITY", selectedColumns),
                    DATE_POTABILITY = GetSafeDateTime(reader, "DATE_POTABILITY", selectedColumns),
                    SANITIZATION = GetSafeBool(reader, "SANITIZATION", selectedColumns),
                    DATE_SANITIZATION = GetSafeDateTime(reader, "DATE_SANITIZATION", selectedColumns),
                    WATER_TANK_CLEAN = GetSafeBool(reader, "WATER_TANK_CLEAN", selectedColumns),
                    DATE_WATER_TANK_CLEAN = GetSafeDateTime(reader, "DATE_WATER_TANK_CLEAN", selectedColumns),
                    LATITUDE = GetSafeDouble(reader, "LATITUDE", selectedColumns),
                    LONGITUDE = GetSafeDouble(reader, "LONGITUDE", selectedColumns),
                    TECH_OBS = GetSafeString(reader, "TECH_OBS", selectedColumns),
                    DATE_BARREL_CO2 = GetSafeDateTime(reader, "DATE_BARREL_CO2", selectedColumns),
                    QTD_BARREL_CO2 = GetSafeInt(reader, "QTD_BARREL_CO2", selectedColumns),
                    QTD_BARREL_CHOPP30 = GetSafeInt(reader, "QTD_BARREL_CHOPP30", selectedColumns),
                    QTD_BARREL_CHOPP50 = GetSafeInt(reader, "QTD_BARREL_CHOPP50", selectedColumns),
                    CHOPP_30_EXP_DATE = GetSafeDateTime(reader, "CHOPP_30_EXP_DATE", selectedColumns),
                    CHOPP_50_EXP_DATE = GetSafeDateTime(reader, "CHOPP_50_EXP_DATE", selectedColumns),
                    CONTACT_PRESENT = GetSafeString(reader, "CONTACT_PRESENT", selectedColumns),
                    CONTACT_DOCNUM = GetSafeString(reader, "CONTACT_DOCNUM", selectedColumns),
                    IMAGE_ID_1 = GetSafeLong(reader, "IMAGE_ID_1", selectedColumns),
                    IMAGE_ID_2 = GetSafeLong(reader, "IMAGE_ID_2", selectedColumns),
                    SIGNATURE_ID = GetSafeLong(reader, "SIGNATURE_ID", selectedColumns),
                };

                ProcessDynamicFields(order, reader, "RATE", 10, new[] { "FLAVOR_ID", "FLAVOR_NAME", "QTD", "EXP_DATE" }, selectedColumns);
                ProcessDynamicFields(order, reader, "VALVE", 10, new[] { "FLAVOR_ID", "FLAVOR_NAME", "QTD", "EXP_DATE" }, selectedColumns);
                ProcessDynamicFields(order, reader, "CAUSE", 10, new[] { "ID", "NAME", "SAP" }, selectedColumns);
                ProcessDynamicFields(order, reader, "MEASURE", 10, new[] { "ID", "NAME", "SAP" }, selectedColumns);
                ProcessDynamicFields(order, reader, "COMPONENT", 10, new[] { "ID", "NAME", "QTD", "UNIT" }, selectedColumns);

                return order;
            });

        return Ok(query);
    }
}