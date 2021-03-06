using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Models.Responses;
using NormativeCalculator.Database;
using NormativeCalculator.Core.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NormativeCalculator.Common.Helper;

namespace NormativeCalculator.Infrastructure.Interfaces
{
   public interface IIngredientService
    {
        public Task<PagedList<IngredientDto>> Get(PaginationParams paginationParams);

        public Task<IngredientDto> GetById(int id);

        public Task<IEnumerable<GetTop10UsedIngredientsResponse>> GetTop10UsedIngredients(UnitMeasure MeasureUnit, int MinQuantity, int MaxQuantity);

      
    }
}
