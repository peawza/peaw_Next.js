namespace BusinessSQLDB.Models.StoredProcedure
{
    public class TMS030Models
    {
        #region sp_TMS030_GetCombo_Customer

        public partial class sp_TMS030_GetCombo_Customer_Criteria
        {


        }
        public class sp_TMS030_GetCombo_Customer_Result
        {
            public int Value { get; set; }


            public string Display { get; set; }
        }


        #endregion

        #region sp_TMS030_GetCombo_TransportCompany

        public partial class sp_TMS030_GetCombo_TransportCompany_Criteria
        {

        }

        public class sp_TMS030_GetCombo_TransportCompany_Result
        {
            public int Value { get; set; }

            public string Display { get; set; }
        }
        #endregion

        #region sp_TMS030_GetCombo_JobType

        public partial class sp_TMS030_GetCombo_JobType_Criteria
        {

        }

        public class sp_TMS030_GetCombo_JobType_Result
        {
            public string Value { get; set; }

            public string Display { get; set; }
        }
        #endregion

        #region sp_TMS030_GetCombo_JobStatus

        public partial class sp_TMS030_GetCombo_JobStatus_Criteria
        {

        }

        public class sp_TMS030_GetCombo_JobStatus_Result
        {
            public string Value { get; set; }

            public string Display { get; set; }

            public string? MapStatus { get; set; }
        }
        #endregion

    }
}
