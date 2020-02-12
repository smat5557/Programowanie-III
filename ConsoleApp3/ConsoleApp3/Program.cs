using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;"
            using (var connection = new SqlConnection(con.String)) ;
            connection.Open();
            var comand = new SQLCommand
            cmdText"Insert into Employees(FirstName, LastName) values" 
            {
                cmdText"Select FirstName, LastName, HireDate from Employees where ID ={}";
            connection
        };

        command.Parameters.AddWithValue("id", 1);

        command.Connection.Open();
            var reader = command.ExecuteReader();

        while (reader.Read()) {

	{
            var date = (DateTime)reader[2];
            Console.WriteLine({0} {1}", reader["FirstName"], reader[1], date.ToShortDatesString() )

	};

        }
    }
}
