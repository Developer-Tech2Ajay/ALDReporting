namespace Entities
{
    public class Recipe_Report
    {
        public int ID { get; set; }
        public string Soak_Time { get; set; }
        public string EventName { get; set; }
        public string RAMP_RATE_MIN { get; set; }
        public string SOAK_TEMP { get; set; }
        public string DEV_CNT_TC { get; set; }
        public string DEV_CNT_TC_Checkbox { get; set; }
        public string DEV_CNT_TC_C { get; set; }
        public string DEV_LD_TC_Checkbox { get; set; }
        public string DEV_LD_TC_C { get; set; }
        public string PRESS_mBar { get; set; }
        public string GAS_FLOW { get; set; }
        public string N2_FLOW { get; set; }
        public string PULS_TIME { get; set; }
        public string INERT_TIME { get; set; }

    }

    public class RecipeDetails
    {
        public string Recipe_Name { get; set; }
        public string RecipeDateTime { get; set; }
        public string CARB { get; set; }

    }
}
