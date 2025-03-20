using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace clinic.Model
{
    public class DataAccessBase
    {
        private readonly string _connectionString = connection.Conn("clinic_db");


        // appointment

        public void UpdateAppointment(Appointment appointment)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = @"
                UPDATE appointments
                SET PatientId = @PatientId,
                    DoctorId = @DoctorId,
                    ServiceId = @ServiceId,
                    AppointmentDate = @AppointmentDate,
                    Status = @Status,
                    Note = @Note
                WHERE AppointmentId = @AppointmentId;";

                db.Execute(sql, appointment);
            }
        }
    }
}