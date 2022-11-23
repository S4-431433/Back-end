using S4_BmBackend.DTO;

namespace S4_BmBackend.Logic
{
    public class TestLogic
    {
        public List<Test> testdata = new();
        public Test Data(int one, int two, double three, double four, double five)
        {
            Test data = new(one, two, three, four, five);
            testdata.Add(data);
            return data;
        }
    }
}
