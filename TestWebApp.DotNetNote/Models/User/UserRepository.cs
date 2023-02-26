using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace TestWebApp.DotNetNote.Models.User
{
    public class UserRepository : IUserRepository
    {
        private IConfiguration _config;
        private SqlConnection con;

        public UserRepository(IConfiguration config)
        {
            _config = config;


            var connectionString = _config.GetSection("ConnectionString").Value;

            //appsetting.json 파일에 설정된 데이터베이스 연결 문자 읽어오기
            con = new SqlConnection(connectionString);
        }


        /// <summary>
        /// 회원 가입
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="passwrod"></param>
        public void AddUser(string userID, string passwrod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "WriteUsers";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserId", userID);
            cmd.Parameters.AddWithValue("@Password", passwrod);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        /// <summary>
        /// 특정회원정보
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public UserViewModel GetUserByUserID(string userID)
        {
            UserViewModel r = new UserViewModel();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "Select * From Users Where UserID = @UserID";
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@UserID", userID);

            con.Open();

            IDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                r.Id = dr.GetInt32(0);
                r.UserID = dr.GetString(0);
                r.Password = dr.GetString(0);
            }

            con.Close();
            return r;
        }

        /// <summary>
        /// 회원정보수정
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <exception cref="System.NotImplementedException"></exception>

        public void ModifyUser(int uid, string userId, string password)
        {
            SqlCommand cmd = new SqlCommand(); 
            cmd.Connection=con;
            cmd.CommandText = "ModifyUsers";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@UID", uid);

            con.Open();
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// 아이디와 암호가 동일한 사용자면 참(true) 그렇지 않으면 거짓
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsCorrectUser(string userID, string password)
        {
            bool result = false;

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Users "
                            + "Where UserID = @UserID And = @Password";

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.Parameters.AddWithValue("@Password", password);

            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                result = true; 
            }
            con.Close();

            return result;

        }
    }
}
