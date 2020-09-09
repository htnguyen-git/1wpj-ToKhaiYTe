using System.Collections.Generic;
using ToKhaiYTe.Models.ViewModel;

namespace ToKhaiYTe.Models.Service
{
    public interface IHealthDeclarationService
    {
        int SaveMedicalDeclaration(MDFViewModel TClass);
        int SaveTravelInfomation(MDFViewModel TClass, int MedicalDeclarationId);
        int SavePhatologicalSign(MDFViewModel TClass, int MedicalDeclarationId);
        int SaveHistoryOfExposure(MDFViewModel TClass , int MedicalDeclarationId);
        int SaveHealthDeclarationForm(MDFViewModel TClass);
        /// <summary>
        /// SortOrder: id_desc, id
        /// </summary>
        /// <param name="SortOrder"></param>
        /// <returns></returns>
        IEnumerable<ManagerIndexViewModel> GetsManagerIndexViewModel(string SortOrder);
        ManagerFullInfoViewModel GetInfo(int MedicalDeclarationId);
        
        IEnumerable<ManagerIndexViewModel> Search(ManagerSearchViewModel modelToSearch);
    }
}
