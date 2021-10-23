using Ardalis.Specification;
using System.Linq;

namespace Example.Core.ProductAggregate.Specifications
{
    public class SearchProductByNameSpec : Specification<Models.Product>
    {
        public SearchProductByNameSpec(string productName)
        {
            Query.Where(x => x.Name.ToLower().Contains(productName.ToLower()))
             .OrderBy(x => x.Name)
                .ThenBy(x => x.Description);
        }

    }
}
