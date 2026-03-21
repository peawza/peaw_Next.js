

using BusinessAPI.Repositories;
using static BusinessSQLDB.Models.StoredProcedure.TMS060Models;

namespace BusinessAPI.Services
{

    public interface ITMS060Service
    {
        Task<IEnumerable<stp_TMS060_GetParkingLotHistory_Result>> stp_TMS060_GetParkingLotHistory(stp_TMS060_GetParkingLotHistory_Criteria criteria);
    }
    public class TMS060Service : ITMS060Service
    {
        private readonly ITMS060Repositories _repository;

        public TMS060Service(ITMS060Repositories repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<stp_TMS060_GetParkingLotHistory_Result>> stp_TMS060_GetParkingLotHistory(stp_TMS060_GetParkingLotHistory_Criteria criteria)
        {
            try
            {
                //var mockData = new List<stp_TMS060_GetParkingLotHistory_Result>
//{
//            // Record 1: งาน Import - จอดเสร็จเรียบร้อยแล้ว
//            new stp_TMS060_GetParkingLotHistory_Result
//            {
//                No = 1,
//                ParkingLotName = "ช่องที่ 1",
//                ParkingStampDatetime = DateTime.Now.AddHours(-4).ToString("dd/MM/yyyy HH:mm"),
//                ParkingTruckNo = "73-9876",
//                CompanyName = "Yusen Logistic",
//                JobTypeName = "Import",
//                BillNo = "220510040826",
//                ContainerType = "20",
//                LoadingType = "In-WH",
//                FromParkingLotName = "Waiting Area",
//                ToParkingLotName = "ช่องที่ 1",
//                ParkingDatetime = DateTime.Now.AddHours(-4),
//                FinishDatetime = DateTime.Now.AddHours(-3),
//                Count_SMS = 1,
//                Send_SMS = "ไปจอดที่ช่อง 1",
//                CreateBy = "Admin",
//                CreateDatetime = DateTime.Now.AddHours(-5),
//                UpdateBy = "System",
//                UpdateDatetime = DateTime.Now.AddHours(-3)
//            },

//            // Record 2: งาน Move - ย้ายจากช่อง 7 ไปช่อง 2 (กำลังดำเนินการ)
//            new stp_TMS060_GetParkingLotHistory_Result
//            {
//                No = 2,
//                ParkingLotName = "ช่องที่ 2",
//                ParkingStampDatetime = DateTime.Now.AddHours(-2).ToString("dd/MM/yyyy HH:mm"),
//                ParkingTruckNo = "72-4567",
//                CompanyName = "Suzuyo (Thailand) Ltd.",
//                JobTypeName = "Move",
//                BillNo = "220510040827",
//                ContainerType = "40",
//                LoadingType = "Out-Door",
//                FromParkingLotName = "ช่องที่ 7",
//                ToParkingLotName = "ช่องที่ 2",
//                ParkingDatetime = DateTime.Now.AddHours(-2),
//                FinishDatetime = null, // ยังไม่เสร็จ
//                Count_SMS = 2,
//                Send_SMS = "กรุณาย้ายรถไปช่อง 2",
//                CreateBy = "Staff01",
//                CreateDatetime = DateTime.Now.AddHours(-2).AddMinutes(-30),
//                UpdateBy = null,
//                UpdateDatetime = null
//            },

//            // Record 3: งาน Export - เข้ามาจอดรอ
//            new stp_TMS060_GetParkingLotHistory_Result
//            {
//                No = 3,
//                ParkingLotName = "Lanes 5",
//                ParkingStampDatetime = DateTime.Now.AddMinutes(-45).ToString("dd/MM/yyyy HH:mm"),
//                ParkingTruckNo = "65-1122",
//                CompanyName = "UACJ Logistic",
//                JobTypeName = "Export",
//                BillNo = "220510040828",
//                ContainerType = "None",
//                LoadingType = "Out-Door",
//                FromParkingLotName = "Gate In",
//                ToParkingLotName = "Lanes 5",
//                ParkingDatetime = DateTime.Now.AddMinutes(-45),
//                FinishDatetime = null,
//                Count_SMS = 0,
//                Send_SMS = null,
//                CreateBy = "Guard",
//                CreateDatetime = DateTime.Now.AddMinutes(-50),
//                UpdateBy = null,
//                UpdateDatetime = null
//            },

//            // Record 4: ประวัติเก่า - เสร็จสิ้นแล้ว
//            new stp_TMS060_GetParkingLotHistory_Result
//            {
//                No = 4,
//                ParkingLotName = "ช่องที่ 10",
//                ParkingStampDatetime = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy HH:mm"),
//                ParkingTruckNo = "88-9999",
//                CompanyName = "Kusuhara (Thailand)",
//                JobTypeName = "Import",
//                BillNo = "220510040820",
//                ContainerType = "40",
//                LoadingType = "In-WH",
//                FromParkingLotName = "Waiting Area",
//                ToParkingLotName = "ช่องที่ 10",
//                ParkingDatetime = DateTime.Now.AddDays(-1).AddHours(10),
//                FinishDatetime = DateTime.Now.AddDays(-1).AddHours(11),
//                Count_SMS = 1,
//                Send_SMS = "เข้าช่องจอดได้",
//                CreateBy = "System",
//                CreateDatetime = DateTime.Now.AddDays(-1).AddHours(9),
//                UpdateBy = "System",
//                UpdateDatetime = DateTime.Now.AddDays(-1).AddHours(11)
//            }
        //};
        //        return mockData;

                return await _repository.stp_TMS060_GetParkingLotHistory(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
