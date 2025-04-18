using System.ComponentModel.DataAnnotations;

namespace ODataNetCore.Models
{
    public class CustomerOrders
    {
        [Key]
        public long ID { get; set; }
        public string NOTE { get; set; }
        public string STATUS { get; set; }
        public string PLANT { get; set; }
        public string WORK_CENTER { get; set; }
        public string ORDER_TYPE_ID { get; set; }
        public string ORDER_TYPE_NAME { get; set; }
        public string ORDER_TYPE_TYPE { get; set; }
        public DateTime? DATE_OPEN { get; set; }
        public long? CUSTOMER_ID { get; set; }
        public string FANTASY_NAME { get; set; }
        public string BRAND_NAME { get; set; }
        public string PHONE { get; set; }
        public string COUNTRY { get; set; }
        public string STATE { get; set; }
        public string CITY { get; set; }
        public string NEIGHBORHOOD { get; set; }
        public string STREET { get; set; }
        public string ZIPCODE { get; set; }
        public string CONTACT_FIRSTNAME { get; set; }
        public string CONTACT_LASTNAME { get; set; }
        public string EQUIPMENT_ID { get; set; }
        public string EQUIPMENT_NUMBER { get; set; }
        public string EQUIPMENT_TYPE { get; set; }
        public string EQUIPMENT_SERIAL_NUMBER { get; set; }
        public string MATERIAL { get; set; }
        public long? SYMPTOM_ID { get; set; }
        public string SYMPTOM_NAME { get; set; }
        public string SYMPTOM_OBJ_TECNICO { get; set; }
        public string SYMPTOM_SAP { get; set; }
        public string TECHNICAL_OBJ_NAME { get; set; }
        public string ORDER_OBS { get; set; }
        public string WARRANTY_OBSERVATIONS { get; set; }
        public int? PRIORITY_ID { get; set; }
        public string PRIORITY_NAME { get; set; }
        public string USER_NAME { get; set; }
        public string USER_REGISTRY { get; set; }
        public string USER_LOGIN { get; set; }
        public DateTime? DATE_START { get; set; }
        public DateTime? DATE_CLOSED { get; set; }
        public string DIVERGENT_EQUIP_ID { get; set; }
        public bool? CHANGE_TAG { get; set; }
        public decimal? CARBONATING_INITIAL { get; set; }
        public decimal? TEMPERATURE_INITIAL { get; set; }
        public bool? ICE { get; set; }
        public int? QTD_VALVE { get; set; }
        public DateTime? DATE_FILTER_CELLULOSE { get; set; }
        public DateTime? DATE_FILTER_COAL { get; set; }
        public bool? MECHANICAL_SANITIZATION { get; set; }
        public DateTime? DATE_MECHANICAL_SANITIZATION { get; set; }
        public bool? PEST_CONTROL { get; set; }
        public DateTime? DATE_PEST_CONTROL { get; set; }
        public bool? POTABILITY { get; set; }
        public DateTime? DATE_POTABILITY { get; set; }
        public bool? SANITIZATION { get; set; }
        public DateTime? DATE_SANITIZATION { get; set; }
        public bool? WATER_TANK_CLEAN { get; set; }
        public DateTime? DATE_WATER_TANK_CLEAN { get; set; }
        public double? LATITUDE { get; set; }
        public double? LONGITUDE { get; set; }
        public string TECH_OBS { get; set; }
        public DateTime? DATE_BARREL_CO2 { get; set; }
        public int? QTD_BARREL_CO2 { get; set; }
        public int? QTD_BARREL_CHOPP30 { get; set; }
        public int? QTD_BARREL_CHOPP50 { get; set; }
        public DateTime? CHOPP_30_EXP_DATE { get; set; }
        public DateTime? CHOPP_50_EXP_DATE { get; set; }
        public string CONTACT_PRESENT { get; set; }
        public string CONTACT_DOCNUM { get; set; }
        public string RATE_1_FLAVOR_ID { get; set; }
        public string RATE_1_FLAVOR_NAME { get; set; }
        public decimal? RATE_1_QTD { get; set; }
        public DateTime? RATE_1_EXP_DATE { get; set; }
        public string RATE_2_FLAVOR_ID { get; set; }
        public string RATE_2_FLAVOR_NAME { get; set; }
        public decimal? RATE_2_QTD { get; set; }
        public DateTime? RATE_2_EXP_DATE { get; set; }


        public string RATE_3_FLAVOR_ID { get; set; }
        public string RATE_3_FLAVOR_NAME { get; set; }
        public decimal? RATE_3_QTD { get; set; }
        public DateTime? RATE_3_EXP_DATE { get; set; }

        public string RATE_4_FLAVOR_ID { get; set; }
        public string RATE_4_FLAVOR_NAME { get; set; }
        public decimal? RATE_4_QTD { get; set; }
        public DateTime? RATE_4_EXP_DATE { get; set; }


        public string RATE_5_FLAVOR_ID { get; set; }
        public string RATE_5_FLAVOR_NAME { get; set; }
        public decimal? RATE_5_QTD { get; set; }
        public DateTime? RATE_5_EXP_DATE { get; set; }


        public string RATE_6_FLAVOR_ID { get; set; }
        public string RATE_6_FLAVOR_NAME { get; set; }
        public decimal? RATE_6_QTD { get; set; }
        public DateTime? RATE_6_EXP_DATE { get; set; }


        public string RATE_7_FLAVOR_ID { get; set; }
        public string RATE_7_FLAVOR_NAME { get; set; }
        public decimal? RATE_7_QTD { get; set; }
        public DateTime? RATE_7_EXP_DATE { get; set; }


        public string RATE_8_FLAVOR_ID { get; set; }
        public string RATE_8_FLAVOR_NAME { get; set; }
        public decimal? RATE_8_QTD { get; set; }
        public DateTime? RATE_8_EXP_DATE { get; set; }

        public string RATE_9_FLAVOR_ID { get; set; }
        public string RATE_9_FLAVOR_NAME { get; set; }
        public decimal? RATE_9_QTD { get; set; }
        public DateTime? RATE_9_EXP_DATE { get; set; }


        public string RATE_10_FLAVOR_ID { get; set; }
        public string RATE_10_FLAVOR_NAME { get; set; }
        public decimal? RATE_10_QTD { get; set; }
        public DateTime? RATE_10_EXP_DATE { get; set; }

        public string VALVE_1_FLAVOR_ID { get; set; }
        public string VALVE_1_FLAVOR_NAME { get; set; }
        public int? VALVE_1_QTD { get; set; }
        public DateTime? VALVE_1_EXP_DATE { get; set; }

        public string VALVE_2_FLAVOR_ID { get; set; }
        public string VALVE_2_FLAVOR_NAME { get; set; }
        public int? VALVE_2_QTD { get; set; }
        public DateTime? VALVE_2_EXP_DATE { get; set; }

        public string VALVE_3_FLAVOR_ID { get; set; }
        public string VALVE_3_FLAVOR_NAME { get; set; }
        public int? VALVE_3_QTD { get; set; }
        public DateTime? VALVE_3_EXP_DATE { get; set; }

        public string VALVE_4_FLAVOR_ID { get; set; }
        public string VALVE_4_FLAVOR_NAME { get; set; }
        public int? VALVE_4_QTD { get; set; }
        public DateTime? VALVE_4_EXP_DATE { get; set; }

        public string VALVE_5_FLAVOR_ID { get; set; }
        public string VALVE_5_FLAVOR_NAME { get; set; }
        public int? VALVE_5_QTD { get; set; }
        public DateTime? VALVE_5_EXP_DATE { get; set; }

        public string VALVE_6_FLAVOR_ID { get; set; }
        public string VALVE_6_FLAVOR_NAME { get; set; }
        public int? VALVE_6_QTD { get; set; }
        public DateTime? VALVE_6_EXP_DATE { get; set; }

        public string VALVE_7_FLAVOR_ID { get; set; }
        public string VALVE_7_FLAVOR_NAME { get; set; }
        public int? VALVE_7_QTD { get; set; }
        public DateTime? VALVE_7_EXP_DATE { get; set; }

        public string VALVE_8_FLAVOR_ID { get; set; }
        public string VALVE_8_FLAVOR_NAME { get; set; }
        public int? VALVE_8_QTD { get; set; }
        public DateTime? VALVE_8_EXP_DATE { get; set; }

        public string VALVE_9_FLAVOR_ID { get; set; }
        public string VALVE_9_FLAVOR_NAME { get; set; }
        public int? VALVE_9_QTD { get; set; }
        public DateTime? VALVE_9_EXP_DATE { get; set; }

        public string VALVE_10_FLAVOR_ID { get; set; }
        public string VALVE_10_FLAVOR_NAME { get; set; }
        public int? VALVE_10_QTD { get; set; }
        public DateTime? VALVE_10_EXP_DATE { get; set; }

        public string CAUSE_ID_1 { get; set; }
        public string CAUSE_NAME_1 { get; set; }
        public string CAUSE_SAP_1 { get; set; }

        public string CAUSE_ID_2 { get; set; }
        public string CAUSE_NAME_2 { get; set; }
        public string CAUSE_SAP_2 { get; set; }

        public string CAUSE_ID_3 { get; set; }
        public string CAUSE_NAME_3 { get; set; }
        public string CAUSE_SAP_3 { get; set; }

        public string CAUSE_ID_4 { get; set; }
        public string CAUSE_NAME_4 { get; set; }
        public string CAUSE_SAP_4 { get; set; }

        public string CAUSE_ID_5 { get; set; }
        public string CAUSE_NAME_5 { get; set; }
        public string CAUSE_SAP_5 { get; set; }

        public string CAUSE_ID_6 { get; set; }
        public string CAUSE_NAME_6 { get; set; }
        public string CAUSE_SAP_6 { get; set; }

        public string CAUSE_ID_7 { get; set; }
        public string CAUSE_NAME_7 { get; set; }
        public string CAUSE_SAP_7 { get; set; }

        public string CAUSE_ID_8 { get; set; }
        public string CAUSE_NAME_8 { get; set; }
        public string CAUSE_SAP_8 { get; set; }

        public string CAUSE_ID_9 { get; set; }
        public string CAUSE_NAME_9 { get; set; }
        public string CAUSE_SAP_9 { get; set; }

        public string CAUSE_ID_10 { get; set; }
        public string CAUSE_NAME_10 { get; set; }
        public string CAUSE_SAP_10 { get; set; }


        public string MEASURE_ID_1 { get; set; }
        public string MEASURE_NAME_1 { get; set; }
        public string MEASURE_SAP_1 { get; set; }

        public string MEASURE_ID_2 { get; set; }
        public string MEASURE_NAME_2 { get; set; }
        public string MEASURE_SAP_2 { get; set; }

        public string MEASURE_ID_3 { get; set; }
        public string MEASURE_NAME_3 { get; set; }
        public string MEASURE_SAP_3 { get; set; }

        public string MEASURE_ID_4 { get; set; }
        public string MEASURE_NAME_4 { get; set; }
        public string MEASURE_SAP_4 { get; set; }

        public string MEASURE_ID_5 { get; set; }
        public string MEASURE_NAME_5 { get; set; }
        public string MEASURE_SAP_5 { get; set; }

        public string MEASURE_ID_6 { get; set; }
        public string MEASURE_NAME_6 { get; set; }
        public string MEASURE_SAP_6 { get; set; }

        public string MEASURE_ID_7 { get; set; }
        public string MEASURE_NAME_7 { get; set; }
        public string MEASURE_SAP_7 { get; set; }

        public string MEASURE_ID_8 { get; set; }
        public string MEASURE_NAME_8 { get; set; }
        public string MEASURE_SAP_8 { get; set; }

        public string MEASURE_ID_9 { get; set; }
        public string MEASURE_NAME_9 { get; set; }
        public string MEASURE_SAP_9 { get; set; }

        public string MEASURE_ID_10 { get; set; }
        public string MEASURE_NAME_10 { get; set; }
        public string MEASURE_SAP_10 { get; set; }

        public long? COMPONENT_ID_1 { get; set; }
        public string COMPONENT_NAME_1 { get; set; }
        public decimal? COMPONENT_QTD_1 { get; set; }
        public string COMPONENT_UNIT_1 { get; set; }

        public long? COMPONENT_ID_2 { get; set; }
        public string COMPONENT_NAME_2 { get; set; }
        public decimal? COMPONENT_QTD_2 { get; set; }
        public string COMPONENT_UNIT_2 { get; set; }

        public long? COMPONENT_ID_3 { get; set; }
        public string COMPONENT_NAME_3 { get; set; }
        public decimal? COMPONENT_QTD_3 { get; set; }
        public string COMPONENT_UNIT_3 { get; set; }

        public long? COMPONENT_ID_4 { get; set; }
        public string COMPONENT_NAME_4 { get; set; }
        public decimal? COMPONENT_QTD_4 { get; set; }
        public string COMPONENT_UNIT_4 { get; set; }

        public long? COMPONENT_ID_5 { get; set; }
        public string COMPONENT_NAME_5 { get; set; }
        public decimal? COMPONENT_QTD_5 { get; set; }
        public string COMPONENT_UNIT_5 { get; set; }

        public long? COMPONENT_ID_6 { get; set; }
        public string COMPONENT_NAME_6 { get; set; }
        public decimal? COMPONENT_QTD_6 { get; set; }
        public string COMPONENT_UNIT_6 { get; set; }

        public long? COMPONENT_ID_7 { get; set; }
        public string COMPONENT_NAME_7 { get; set; }
        public decimal? COMPONENT_QTD_7 { get; set; }
        public string COMPONENT_UNIT_7 { get; set; }

        public long? COMPONENT_ID_8 { get; set; }
        public string COMPONENT_NAME_8 { get; set; }
        public decimal? COMPONENT_QTD_8 { get; set; }
        public string COMPONENT_UNIT_8 { get; set; }

        public long? COMPONENT_ID_9 { get; set; }
        public string COMPONENT_NAME_9 { get; set; }
        public decimal? COMPONENT_QTD_9 { get; set; }
        public string COMPONENT_UNIT_9 { get; set; }

        public long? COMPONENT_ID_10 { get; set; }
        public string COMPONENT_NAME_10 { get; set; }
        public decimal? COMPONENT_QTD_10 { get; set; }
        public string COMPONENT_UNIT_10 { get; set; }

        public long IMAGE_ID_1 { get; set; }
        public long IMAGE_ID_2 { get; set; }
        public long SIGNATURE_ID { get; set; }

    }
}
