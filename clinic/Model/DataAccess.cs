using Dapper;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Model
{
    public class DataAccess
    {
        private readonly string _connectionString = connection.Conn("clinic_db");

        //Patients 
        public void AddPatient(Patients patient)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Patients (FirstName, LastName, Age, Dob, Gender, Phone, Address) VALUES (@FirstName, @LastName,@Age, @Dob,  @Gender, @Phone, @Address)";
                db.Execute(sql, patient);
            }
        }

        public void UpdatePatient(Patients patient)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "UPDATE Patients SET FirstName = @FirstName, LastName = @LastName, Dob = @Dob, Age = @Age, Gender = @Gender, Phone = @Phone, Address = @Address WHERE PatientId = @PatientId";
                db.Execute(sql, patient);
            }
        }

        public void DeletePatient(int patientId)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Patients WHERE PatientId = @PatientId";
                db.Execute(sql, new { PatientId = patientId });
            }
        }

        public List<Patients> GetPatients()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Patients";
                return db.Query<Patients>(sql).AsList();
            }
        }

        //doctor
        public void AddDoctor(Doctors doctor)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO doctors (FirstName, LastName, Specialization , Phone, isAvailable) VALUES (@FirstName, @LastName,@Specialization, @Phone,  @isAvailable)";
                db.Execute(sql, doctor);
            }
        }

        public void UpdateDoctor(Doctors doctor)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "UPDATE doctors SET FirstName = @FirstName, LastName = @LastName, Specialization = @Specialization, Phone = @Phone, isAvailable = @isAvailable WHERE DoctorId = @DoctorId";
                db.Execute(sql, doctor);
            }
        }
        public void DeleteDoctor(int doctorId)
        {

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Doctors WHERE DoctorId = @DoctorId";
                db.Execute(sql, new { DoctorId = doctorId});
            }
        }

        public List<Doctors> GetDoctors()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM doctors";
                return db.Query<Doctors>(sql).AsList();
            }
        }

        //service 
        public void AddService(Services service)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO services (ServiceName, Description, Price, DoctorId) VALUES (@ServiceName, @Description, @Price, @DoctorId)";
                db.Execute(sql, service);
            }
        }

        public void UpdateService(Services service)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "UPDATE services SET ServiceName = @ServiceName, Description = @Description, Price = @Price, DoctorId = @DoctorId WHERE ServiceId = @ServiceId";
                db.Execute(sql, service);
            }
        }

        public void DeleteService(int serviceId)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM services WHERE ServiceId = @ServiceId";
                db.Execute(sql, new { ServiceId = serviceId });
            }
        }

        public List<Services> GetServices()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM services";
                return db.Query<Services>(sql).ToList();
            }
        }

        public Services GetServiceById(int serviceId)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM services WHERE ServiceId = @ServiceId";
                return db.QueryFirstOrDefault<Services>(query, new { ServiceId = serviceId });
            }
        }


        // appointment

        public void AdddAppointment(Appiontment appiontment)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO appointments (PatientId, DoctorId, AppointmentDate, Note, Status, ServiceID ) VALUES (@PatientId, @DoctorId, @AppointmentDate, @Note, @Status , @ServiceID) ";
                db.Execute(sql, appiontment);
            }
        }
        public void UpdateAppointment(Appiontment appiontment)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = @"
            UPDATE Appointments
            SET PatientId = @PatientId, 
                ServiceId = @ServiceId, 
                AppointmentDate = @AppointmentDate
            WHERE AppointmentId = @AppointmentId";

                db.Execute(sql, appiontment);
            }
        }

        public void DeleteAppointment(int appiontmentId)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM appointments WHERE AppointmentId = @AppointmentId";
                db.Execute(sql, new { AppointmentId = appiontmentId });
            }
        }
        public List<Appiontment> GetAppiontments()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = @"
            SELECT 
                a.AppointmentId, 
                p.PatientName, 
                s.ServiceName, 
                d.FirstName + ' ' + d.LastName AS DoctorName, 
                a.AppointmentDate
            FROM appointments a
            JOIN patients p ON a.patientId = p.patientId
            JOIN services s ON a.serviceId = s.serviceId
            JOIN doctors d ON s.doctorId = d.doctorId";
                return db.Query<Appiontment>(sql).ToList();
            }
        }


        //payment



    }


}

