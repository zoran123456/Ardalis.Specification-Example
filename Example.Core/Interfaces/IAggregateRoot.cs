using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Interfaces
{
    /// <summary>
    /// Not important for example on using ISpecification, however it is recommended that creation of Repositories are enforced by Aggregate Roots (only Aggregate Roots should have repositories)
    /// https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design#enforce-one-aggregate-root-per-repository
    /// </summary>
    public interface IAggregateRoot
    {
    }
}
