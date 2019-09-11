using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using Dapper;

namespace Server
{
    public class Reader
    {
        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Assignments;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private string GetStudentsDB()
        {
            List<Student> list = new List<Student>();
            string result = "";
            using (IDbConnection conn = new SqlConnection(connString))
            {
                list = conn.Query<Student>("Select * from RMI").ToList();
            }

            foreach (var student in list)
            {
                result += $"{student.Name} {student.Email}&";
            }

            return result;
        }

        private string GetStudentTxt()
        {
            string[] lines = File.ReadAllLines("students.txt");
            string result = "";

            foreach (var student in lines)
            {
                result += $"{student}&";
            }


            return result;
        }

        public string GetStudents()
        {
            string result = GetStudentTxt() + GetStudentsDB();
            return result;
        }
    }
}