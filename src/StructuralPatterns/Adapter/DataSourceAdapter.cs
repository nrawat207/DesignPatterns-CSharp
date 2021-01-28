using System.Collections.Generic;

namespace StructuralPatterns.Adapter
{
    public class DataSourceAdapter : IDataSource
    {
        private DataService dataService;

        public DataSourceAdapter()
        {
            dataService = new DataService();
        }

        public List<string> GetData()
        {
            var dataList = new List<string>();
            foreach (var item in dataService.GetResults())
            {
                dataList.Add(item);
            }

            return dataList;
        }
    }
}
