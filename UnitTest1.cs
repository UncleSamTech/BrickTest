using System.ComponentModel;

namespace BrickTest
{
    public class UnitTest1
    {
        


        [Fact]
        public void PassingTest()
        {
            Assert.Equal(7, Add(4, 3));
        }

         [Fact]
         public void FailingTest()
        {
            Assert.Equal(8, Add(4, 4));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void OddTheory(int value)
        {
            Assert.True(isodd(value));
        }


        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void EvenTheory(int value)
        {
            Assert.True(iseven(value));
        }


        [Fact]
        public void check_dict() { 
        
            Dictionary<int,string> di = new Dictionary<int,string>();
            List<string> names = new List<string>();
            names.Add("a");
            names.Add("b");
            names.Add("c");
            for (int i = 0; i < 3; i++) { 
                di.Add(i, names[i]);
            }
            Assert.True(checkValue("a", di ,0));
            Assert.False(checkValue("ab", di, 1));
        }

        string value = "Not found";
        bool checkValue(string exp, Dictionary<int, string> map, int index) { 
            if (map.TryGetValue(index,out value)){
                return value == exp;
            }
            return false;
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        bool isodd(int x) { 
            return x % 2 != 0;
        }

        bool iseven(int x) { 
            return (x % 2 == 0);
        }



    }
}