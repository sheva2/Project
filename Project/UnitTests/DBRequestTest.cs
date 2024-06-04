using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Project.Data;
namespace UnitTests
{
   public class DBRequestTest
    {
        [Fact]
        public void SelectTest()
        {
            string email = "some@email";
            List<User> users = DBRequest.Select<User>("Users", new List<QueryParametr> { new QueryParametr($"[Id]=0", Operator.NONE) });
            Assert.Empty(users);
        }
        [Fact]
        public void SelectExercise()
        {
            string email = "some@email";
           List<Exercise> exercises = DBRequest.Select<Exercise>("Exercises", new List<QueryParametr> { new QueryParametr($"[Name]='dssad'", Operator.NONE) });
            Assert.Equal("dssad", exercises[0].Name);
        }
    }
}
