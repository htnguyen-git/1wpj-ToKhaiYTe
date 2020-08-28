using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models.Service
{
    public class HealthDeclarationService : IHealthDeclarationService<MDFViewModel>
    {
        private readonly AppDbContext context;
        public HealthDeclarationService(AppDbContext context)
        {
            this.context = context;
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
            return context.SaveChanges();
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
    }
}
