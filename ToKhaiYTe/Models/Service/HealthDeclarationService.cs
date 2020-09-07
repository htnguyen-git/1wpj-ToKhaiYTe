using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToKhaiYTe.Models.AddressInfo;
using ToKhaiYTe.Models.ViewModel;

namespace ToKhaiYTe.Models.Service
{
    public class HealthDeclarationService : IHealthDeclarationService
    {
        private readonly AppDbContext context;
        private readonly IAddressRepository addressService;

        public HealthDeclarationService(AppDbContext context, IAddressRepository addressService )
        {
            this.context = context;
            this.addressService = addressService;
        }
        public int SaveHealthDeclarationForm(MDFViewModel TClass)
        {
            int id = SaveMedicalDeclaration(TClass);
                SaveHistoryOfExposure(TClass, id);
                SavePhatologicalSign(TClass, id);
                SaveTravelInfomation(TClass, id);
            return id;
        }

        public int SaveMedicalDeclaration(MDFViewModel TClass)
        {
            MedicalDeclarationForm MDF = new MedicalDeclarationForm()
            {
                Fullname = TClass.Fullname,
                Email = TClass.Email,
                DoB = TClass.DoB,
                Gender = TClass.Gender,
                GateId = TClass.GateId,
                CMND = TClass.CMND,
                National = TClass.National,
                CurrentAddressDistrict = TClass.CurrentAddressDistrict,
                CurrentAddressProvince = TClass.CurrentAddressProvince,
                CurrentAddressStreet = TClass.CurrentAddressStreet,
                CurrentAddressWard = TClass.CurrentAddressWard,
                ListCountryhasGoneThrough = TClass.ListCountryhasGoneThrough,
                PhoneNumber = TClass.PhoneNumber,
                UsedVaccineList = TClass.UsedVaccineList
            };
            context.MedicalDeclarationForm.Add(MDF);
            context.SaveChanges();
            return MDF.Id;
        }
        public int SaveHistoryOfExposure(MDFViewModel TClass, int MedicalDeclarationId)
        {
            HistoryOfExposure HoE = new HistoryOfExposure()
            {
                ContactToAnimal = TClass.ContactToAnimal,
                ContactWithSickPeople = TClass.ContactWithSickPeople,
                IsPublished = true,
                IsDeleted = false,
                MedicalDeclarationFormId = MedicalDeclarationId
            };
            context.HistoryOfExposure.Add(HoE);
            return context.SaveChanges();
        }

        public int SavePhatologicalSign(MDFViewModel TClass, int MedicalDeclarationId)
        {
            PhatologicalSign PS = new PhatologicalSign()
            {
                Fever = TClass.Fever,
                Rash = TClass.Rash,
                SkinHaemorrhage = TClass.SkinHaemorrhage,
                SoreThroat = TClass.SoreThroat,
                Cough = TClass.Cough,
                Diarrhea = TClass.Diarrhea,
                DifficultOfBreathing = TClass.DifficultOfBreathing,
                Vomiting = TClass.Vomiting,
                MedicalDeclarationFormId = MedicalDeclarationId,
                IsPublished = true,
                IsDeleted = false
            };
            context.PhatologicalSign.Add(PS);
            return context.SaveChanges();
        }

        public int SaveTravelInfomation(MDFViewModel TClass, int MedicalDeclarationId)
        {
            TravelInfomation TI = new TravelInfomation()
            {
                EntryDate = TClass.EntryDate,
                SeatNumber = TClass.SeatNumber,
                DepartureProvince = TClass.DepartureProvince,
                AirPlane = TClass.AirPlane,
                AnotherVerhicle = TClass.AnotherVerhicle,
                Car = TClass.Car,
                DepartureCountry = TClass.DepartureCountry,
                DepartureDate = TClass.DepartureDate,
                DestinyLocationCountry = TClass.DestinyLocationCountry,
                DestinyLocationProvince = TClass.DestinyLocationProvince,
                Ships = TClass.Ships,
                TransportStationNumber = TClass.TransportStationNumber,
                MedicalDeclarationFormId = MedicalDeclarationId,
                IsPublished = true,
                IsDeleted = false
            };
            context.TravelInfomation.Add(TI);
            return context.SaveChanges();
        }

        public IEnumerable<ManagerIndexViewModel> GetsManagerIndexViewModel()
        {
            return from m in context.MedicalDeclarationForm
                   join g in context.Gate on m.GateId equals g.Id
                   where (m.IsDeleted == false && m.IsPublished == true)
                   orderby m.Id descending
                   select new ManagerIndexViewModel
                   {
                       
                       Gate = g.GateName,
                       Gender = m.Gender,
                       MedicalDelcarationFormId = m.Id,
                       Name = m.Fullname,
                       National = addressService.GetNameById(m.National, 1),
                       PhoneNumber = m.PhoneNumber,
                       Province = addressService.GetNameById(m.CurrentAddressProvince, 2),
                       Ward = addressService.GetNameById(m.CurrentAddressWard, 4),
                       District = addressService.GetNameById(m.CurrentAddressDistrict, 3),
                   };
                       
            
        }

        public ManagerFullInfoViewModel GetInfo(int MedicalDeclarationId)
        {
            return new ManagerFullInfoViewModel()
            {
                HistoryOfExposure = GetHistoryOfExposure(MedicalDeclarationId),
                MedicalDeclarationForm = GetMedicalDeclarationForm(MedicalDeclarationId),
                PhatologicalSign = GetPhatologicalSign(MedicalDeclarationId),
                TravelInfomation = GetTravelInfomation(MedicalDeclarationId)
            };
        }




        #region private
        private MedicalDeclarationForm GetMedicalDeclarationForm(int MedicalDeclarationFormId)
        {
            return (from m in context.MedicalDeclarationForm
                        where m.Id == MedicalDeclarationFormId
                        select new MedicalDeclarationForm
                        {
                            Id = MedicalDeclarationFormId,
                            Fullname = m.Fullname,
                            DoB = m.DoB,
                            Gender = m.Gender,
                            National = addressService.GetNameById(m.National, 1),
                            CMND = m.CMND,
                            ListCountryhasGoneThrough = m.ListCountryhasGoneThrough,
                            CurrentAddressDistrict = addressService.GetNameById(m.CurrentAddressDistrict, 3),
                            CurrentAddressProvince = addressService.GetNameById(m.CurrentAddressProvince, 2),
                            CurrentAddressWard = addressService.GetNameById(m.CurrentAddressWard, 4),
                            CurrentAddressStreet = m.CurrentAddressStreet,
                            PhoneNumber = m.PhoneNumber,
                            Email = m.Email,
                            UsedVaccineList = m.UsedVaccineList
                        }).FirstOrDefault();
        }
        private HistoryOfExposure GetHistoryOfExposure(int MedicalDeclarationFormId)
        {
            return context.HistoryOfExposure.FirstOrDefault(h => h.MedicalDeclarationFormId == MedicalDeclarationFormId);
        }
        private PhatologicalSign GetPhatologicalSign(int MedicalDeclarationFormId)
        {
            return context.PhatologicalSign.FirstOrDefault(p => p.MedicalDeclarationFormId == MedicalDeclarationFormId);
        }
        private TravelInfomation GetTravelInfomation(int MedicalDeclarationFormId)
        {
            return (from t in context.TravelInfomation
                    where t.MedicalDeclarationFormId == MedicalDeclarationFormId
                    select new TravelInfomation
                    {
                        AirPlane = t.AirPlane,
                        Car = t.Car,
                        Ships = t.Ships,
                        AnotherVerhicle = t.AnotherVerhicle,
                        TransportStationNumber = t.TransportStationNumber,
                        SeatNumber = t.SeatNumber,
                        DepartureDate = t.DepartureDate,
                        EntryDate = t.EntryDate,
                        DepartureCountry = addressService.GetNameById(t.DepartureCountry,1),
                        DestinyLocationCountry = addressService.GetNameById(t.DestinyLocationCountry,1),
                        DepartureProvince = t.DepartureProvince,
                        DestinyLocationProvince = t.DestinyLocationProvince
                        
                    }).FirstOrDefault();
        }
        #endregion
    }
}
