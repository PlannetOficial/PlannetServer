using PlannetServer.Shared.Kernel.BuildingBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannetServer.Core.Aggregates.Categories
{
    public class CategoryId : TypedIdValueBase<int>
    {
        public CategoryId() { }
        public CategoryId(int value)
            : base(value) { }

        public static implicit operator CategoryId(int categoryId)
            => new CategoryId(categoryId);
    }
}
