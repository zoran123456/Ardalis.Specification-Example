using Ardalis.Specification;
using System.Linq;

namespace Example.Core.ProductAggregate.Specifications
{
    public class SearchProductByDescSpec : Specification<Models.Product>
    {
        public SearchProductByDescSpec(string productName)
        {
            Query.Where(x => x.Description.ToLower().Contains(productName.ToLower()))
             .OrderBy(x => x.Name)
                .ThenBy(x => x.Description);
        }

    }
}
