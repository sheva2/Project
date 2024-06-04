using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Project.Data;
using Xunit;
namespace UnitTests
{
    public class QueryCreatorTest
    {
        [Fact]
        public void CreateSelectTest()
        {
            string email = "some@email";
            string query= QueryCreator.CreateSelect("Users", new List<QueryParametr> { new QueryParametr($"[Email]='{email}'", Operator.NONE) });
            Assert.Equal("Select * from dbo.[Users] where [Email]='some@emai' ", query);
        }
        [Fact]
        public void CreateInsertTest()
        {
            string email = "some@email";
            User user = new User("login", "password", email);
            string query = QueryCreator.CreateInsert("Users",user);
            Assert.Equal("Insert Into dbo.[Users] (Id,Name,SecondName,Pantronymic,Email,TelephoneNumber,IsCoach,IsAdmin,Login) Values(@Id,@Name,@SecondName,@Pantronymic,@Email,@TelephoneNumber,@IsCoach,@IsAdmin,@Login)", query);
        }
        [Fact]
        public void CreateInsertTest2()
        {
            TrainingProgramm tr = new TrainingProgramm();
            string query = QueryCreator.CreateInsert("TrainingProgramms", tr,true);
            File.WriteAllText("path.txt", query);
            Assert.Equal("Insert Into dbo.[TrainingProgramms] ([Name],) Values(@Name,@SecondName,@Pantronymic,@Email,@TelephoneNumber,@IsCoach,@IsAdmin,@Login)", query);
        }
        [Fact]
        public void CreateUpdateTest()
        {
            string email = "some@email";
            User user = new User("login", "password", email);
            string query = QueryCreator.CreateUpdate("Users", user);
            Assert.Equal("Update dbo.[Users] Set [Name]=@Name,[SecondName]=@SecondName,[Patronymic]=@Patronymic,[Email]=@Email,[TelephoneNumber]=@TelephoneNumber,[IsCoach]=@IsCoach,[AvatarId]=@AvatarId,[IsAdmin]=@IsAdmin,[Password]=@Password,[Login]=@Login where [Id]=@Id", query);
        }
    }
}
