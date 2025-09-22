using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNotes
{
    public class StudentDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Ogrenciler;integrated security=true");

        public List<Student> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from OgrenciList", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student student = new Student
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = Convert.ToString(reader["name"]),
                    Surname = Convert.ToString(reader["surname"]),
                    Number = Convert.ToString(reader["number"]),
                    Class = Convert.ToString(reader["class"]),
                };
                students.Add(student);
            }
            reader.Close();
            _connection.Close();
            return students;

        }

        public void ConnectionControl()
        {
            if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Student student)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into OgrenciList values(@name, @surname, @number, @class)", _connection);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@surname", student.Surname);
            command.Parameters.AddWithValue("@number", student.Number);
            command.Parameters.AddWithValue("@class", student.Class);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Update(Student student)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update OgrenciList set Name=@name, Surname=@surname, Number=@number, Class=@class where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@surname", student.Surname);
            command.Parameters.AddWithValue("@number", student.Number);
            command.Parameters.AddWithValue("@class", student.Class);
            command.Parameters.AddWithValue("@id", student.Id);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Remove(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from OgrenciList where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }

    }
}
