using Abp.Application.Services.Dto;
using SovTech.Main.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovTech.Main
{
    public interface ICategoriesAppService
    {
        Task<ListResultDto<string>> GetAllCategories();
        Task<string> GetAllCategoriesDetails(InputDto input);
        Task<ListResultDto<PeopleDto>> GetPeople(InputDto input);
    }
}
