using System.Collections.Generic;

namespace StructuralPatterns.Adapter
{
    public interface IDataSource
    {
        List<string> GetData();
    }
}
