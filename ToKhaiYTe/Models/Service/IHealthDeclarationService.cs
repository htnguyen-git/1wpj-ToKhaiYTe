using System.Collections.Generic;
using System.Threading.Tasks;
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
       
        Task<IEnumerable<ManagerIndexViewModel>> GetsManagerIndexViewModel(string sortOrder, int? pageIndex);
        ManagerFullInfoViewModel GetInfo(int MedicalDeclarationId);
        
        IEnumerable<ManagerIndexViewModel> Search(ManagerSearchViewModel modelToSearch);
    }
}
