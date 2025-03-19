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
                string sql = "INSERT INTO Patients (FirstName, LastName, Age, Gender, Phone, Address) VALUES (@FirstName, @LastName, @Age ,  @Gender, @Phone, @Address)";
                db.Execute(sql, patient);
            }
        }

        public void UpdatePatient(Patients patient)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "UPDATE Patients SET FirstName = @FirstName, LastName = @LastName,  Age = @Age, Gender = @Gender, Phone = @Phone, Address = @Address WHERE PatientId = @PatientId";
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
                string sql = "INSERT INTO doctors (FirstName, LastName, Specialization , Phone) VALUES (@FirstName, @LastName,@Specialization, @Phone)";
                db.Execute(sql, doctor);
            }
        }

        public void UpdateDoctor(Doctors doctor)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "UPDATE doctors SET FirstName = @FirstName, LastName = @LastName, Specialization = @Specialization, Phone = @Phone, WHERE DoctorId = @DoctorId";
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
        public DataTable GetDataTable(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString)) // Assuming you have a ConnectionString property
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (log, throw, etc.)
                        Console.WriteLine($"Error in GetDataTable: {ex.Message}");
                    }
                }
            }

            return dataTable;
        }





        //available Docotor

        public void AddAvailable (DoctorAvailable doctorAvailable)
        {
            using (IDbConnection db  = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO  doctor_availability (doctorId , availableDay , startTime , endTime ) Values (@doctorId , @availableDay , @startTime , @endTime) ";
                db.Execute(sql, doctorAvailable);
            }
        }

        public void UpdateAvailable (DoctorAvailable doctorAvailable)
        {
            using(IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "UPDATE doctor_availability SET doctorId = @doctorId ,  availableDay = @availableDay ,startTime = @startTime , endTime = @endTime where AvailableId = @AvailableId ";
                db.Execute(sql, doctorAvailable);
            }
        }

        public void DeleteAvailable(int availableId)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM doctor_availability where AvailableId = @AvailableId";
                db.Execute(sql, new { AvailableId = availableId });
            }
        }

        public List<DoctorAvailable> GetDoctorsWithAvailability(string query)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
               
                return db.Query<DoctorAvailable>(query).ToList();
            }
        }



        public List<DoctorAvailables> GetAvailableDoctors(int serviceId, DateTime selectedDate)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                // SQL query to fetch available doctors for the selected service and date
                string sqlQuery = @"
            SELECT d.*
            FROM Doctors d
            INNER JOIN DoctorServices ds ON d.DoctorId = ds.DoctorId
            WHERE ds.ServiceId = @ServiceId
            AND d.DoctorId NOT IN (
                SELECT a.DoctorId
                FROM Appointments a
                WHERE CAST(a.AppointmentDate AS DATE) = CAST(@SelectedDate AS DATE)
            )";

                var availableDoctors = db.Query<Doctors>(sqlQuery, new { ServiceId = serviceId, SelectedDate = selectedDate }).ToList();
                return availableDoctors;

        
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

        public decimal GetServicePrice(string serviceName)
        {
            using (var conn = new SqlConnection(connection.Conn("clinic_db")))
            {
                string query = "SELECT price FROM services WHERE serviceName = @serviceName";
                return conn.QueryFirstOrDefault<decimal>(query, new { serviceName });
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
        private void searchAppointments(string searchText)
        {
            using (IDbConnection db =  new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Appointments WHERE PatientName LIKE @search OR DoctorName LIKE @search";
                var data = db.Query<Appiontment>(query, new { search = "%" + searchText + "%" }).ToList();
            }
        }


        //payment
        public void InsertPayment(int appointmentId, decimal amountPaid, decimal totalCost, string paymentMethod)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "INSERT INTO Payments (AppointmentId, AmountPaid, TotalCost, PaymentMethod, PaymentDate) " +
                               "VALUES (@AppointmentId, @AmountPaid, @TotalCost, @PaymentMethod, @PaymentDate)";
                db.Execute(sqlQuery, new { appointmentId, amountPaid, totalCost, paymentMethod, PaymentDate = DateTime.Now });
            }
        }

        public void UpdatePayment(int paymentId, decimal amountPaid, decimal totalCost, string paymentMethod)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "UPDATE Payments SET " +
                               "AmountPaid = @AmountPaid, " +
                               "TotalCost = @TotalCost, " +
                               "PaymentMethod = @PaymentMethod, " +
                               "PaymentDate = @PaymentDate " +
                               "WHERE PaymentId = @PaymentId";
                db.Execute(sqlQuery, new { paymentId, amountPaid, totalCost, paymentMethod, PaymentDate = DateTime.Now });
            }
        }



        public int InsertAppointment(int patientId, int doctorId, int serviceId, DateTime appointmentDateTime, string status, string notes, decimal totalCost, decimal amountPaid, string paymentMethod)
        {
            using (var conn = new SqlConnection(connection.Conn("clinic_db")))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string insertAppointmentQuery = @"
                        INSERT INTO Appointments (patientId, doctorId, serviceId, appointmentDate, status, note, totalCost)
                        VALUES (@patientId, @doctorId, @serviceId, @appointmentDateTime, @status, @notes, @totalCost);
                        SELECT CAST(SCOPE_IDENTITY() as int);";

                        int appointmentId = conn.ExecuteScalar<int>(insertAppointmentQuery, new
                        {
                            patientId,
                            doctorId,
                            serviceId,
                            appointmentDateTime,
                            status,
                            notes,
                            totalCost
                        }, transaction);

                        //string insertPaymentQuery = @"
                        //INSERT INTO Payments (appointmentId, amount, paymentDate, paymentMethod, status)
                        //VALUES (@appointmentId, @amount, GETDATE(), @paymentMethod, 'Completed');";

                        //conn.Execute(insertPaymentQuery, new
                        //{
                        //    appointmentId,
                        //    amount = amountPaid,
                        //    paymentMethod,
                        //}, transaction);

                        //transaction.Commit();
                        return appointmentId;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error in InsertAppointment: " + ex.Message);
                        throw;
                    }
                }
            }
        }
        public static IEnumerable<dynamic> GetAppointmentsWithPayments()
        {
            using (var conn = new SqlConnection(connection.Conn("clinic")))
            {
                string query = @"
                SELECT a.appointmentId, a.patientId, a.doctorId, a.serviceId, a.appointmentDate,  a.status, a.note, a.totalCost,
                       p.paymentId, p.amount, p.paymentDate, p.paymentMethod, p.status
                FROM Appointments a
                LEFT JOIN Payments p ON a.appointmentId = p.appointmentId";

                return conn.Query(query);
            }
        }

    }


}

