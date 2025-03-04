using Dapper;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //staff
        
        public void AddStaff(Staff staff)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Staff (Name,Password,Role,Image) VALUES (@Name,@Password,@Role,@Image)";
                db.Execute(sql, staff);
                
            }
        }

        public void UpdateStaff(Staff staff) 
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "UPDATE staff SET Name = @Name , Password = @Password , Role = @Role";
                db.Execute(sql, staff);
            }
        }   
        public void DeleteStaff(int Id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM staff WHERE Id = @Id";
                db.Execute(sql, new { id = Id });
            }
        }

        public List<Staff> GetStaff()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM staff";
                return db.Query<Staff>(sql).AsList();
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
                string sql = "SELECT * FROM doctors Where IsAvailable = 1";
                return db.Query<Doctors>(sql).AsList();
            }
        }
 

        //available Docotor

        public void AddAvailable (DoctorAvailable doctorAvailable)
        {
            using (IDbConnection db  = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO   ";
            }
        }
        public List<DoctorAvailable> GetAvailableDoctors()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string query = @"
            SELECT d.doctorId, d.firstName, d.lastName, d.specialization, d.phone, da.availableDay, da.startTime, da.endTime
            FROM doctors d
            INNER JOIN doctor_availability da ON d.doctorId = da.doctorId
            WHERE d.isAvailable = 1";

                return db.Query<DoctorAvailable>(query).ToList();
            }
        }

        public List<DoctorAvailable> GetDoctorsByDay(string day)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string query = @"
            SELECT d.doctorId, d.firstName, d.lastName, d.specialization, d.phone, da.availableDay, da.startTime, da.endTime
            FROM doctors d
            INNER JOIN doctor_availability da ON d.doctorId = da.doctorId
            WHERE d.isAvailable = 1 AND da.availableDay = @Day";

                return db.Query<DoctorAvailable>(query , new { Day = day }).ToList();
            }
        }

        public List<DoctorAvailable> GetDoctorsByTime(string day , TimeSpan time)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string query = @"
            SELECT d.doctorId, d.firstName, d.lastName, d.specialization, d.phone, da.availableDay, da.startTime, da.endTime
            FROM doctors d
            INNER JOIN doctor_availability da ON d.doctorId = da.doctorId
            WHERE d.isAvailable = 1 
            AND da.availableDay = @Day
            AND @Time BETWEEN da.startTime AND da.endTime";
                return db.Query<DoctorAvailable>(query, new { Day = day  , Time = time}).ToList();
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
                string sql = "UPDATE appointments  SET PatientId = @PatientId,  ServiceId = @ServiceId, Status = @Status, Note = @Note, AppointmentDate = @AppointmentDate WHERE AppointmentId = @AppointmentId";
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
            SELECT a.AppointmentId, a.PatientId, a.DoctorId, a.AppointmentDate, a.Status, a.ServiceId, a.Note,
                   p.firstName + ' ' + p.lastName AS PatientName, 
                   d.firstName + ' ' + d.lastName AS DoctorName, 
                   s.serviceName AS ServiceName
            FROM appointments a
            INNER JOIN patients p ON a.PatientId = p.patientId
            INNER JOIN doctors d ON a.DoctorId = d.doctorId
            INNER JOIN services s ON a.ServiceId = s.serviceId";

                var result = db.Query<Appiontment>(sql).ToList();
                return result;
            }
        }


        //payment



    }


}

