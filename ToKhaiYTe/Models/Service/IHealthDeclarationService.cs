using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models.Service
{
    public interface IHealthDeclarationService<T> where T:class
    {
        int SaveMedicalDeclaration(T TClass);
        int SaveTravelInfomation(T TClass, int MedicalDeclarationId);
        int SavePhatologicalSign(T TClass, int MedicalDeclarationId);
        int SaveHistoryOfExposure(T TClass , int MedicalDeclarationId);
        int SaveHealthDeclarationForm(T TClass);
    }
}
