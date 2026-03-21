namespace BusinessAPI.Model
{
    public class CommonModels
    {

        #region Common_SystemConfigs


        public class Common_SystemConfigs_Criteria
        {
            public List<string> ConfigCodes { get; set; } = new();

        }

        public class Common_SystemConfigs_Result
        {
            public string ConfigCode { get; set; } = null!;

            public string? ConfigDesc { get; set; }

            public string? ValueVarchar { get; set; }

            public string? ValueVarchar2 { get; set; }

            public string? ValueVarchar3 { get; set; }

            public int? ValueInt { get; set; }

            public DateOnly? ValueDate { get; set; }

        }

        #endregion

    }
}
