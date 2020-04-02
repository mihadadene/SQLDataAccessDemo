using Dapper;

using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {                      
            using (IDbConnection cnx = new System.Data.SqlClient.SqlConnection(Helper.CnxVal("SampleDB")))
            {                
                //var output =  cnx.Query<Person>($"select * from People where LastName = '{ lastName }' ").ToList();
                var output = cnx.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
                
            }
        }

        public List<Person> GetAllPeople()
        {
            using (IDbConnection cnx = new System.Data.SqlClient.SqlConnection(Helper.CnxVal("SampleDB")))
            {      
                 var output = cnx.Query<Person>("dbo.People_GetAllPeople").ToList();
                
                return output;
            }
           
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
             using (IDbConnection cnx = new System.Data.SqlClient.SqlConnection(Helper.CnxVal("SampleDB")))
            {
                List<Person> people = new List<Person>
                {
                    new Person { LastName = lastName, FirstName = firstName, EmailAddress = emailAddress, PhoneNumber = phoneNumber }
                };

                cnx.ExecuteAsync("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber" , people );
         
             }
        }

        public void DeletePerson(string lastName)
        {
            using (IDbConnection cnx = new System.Data.SqlClient.SqlConnection(Helper.CnxVal("SampleDB")))
            {                
                 cnx.ExecuteAsync("dbo.People_Delete @LastName", new { LastName = lastName });
            }
        }
   
    }
}
