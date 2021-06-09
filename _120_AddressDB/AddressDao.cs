using _61_AddressClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120_AddressDB
{
    /*
    Dao : Data Access Object
          데이터베이스(테이블)을 접속/정보요청/관리
    */
    class AddressDao
    {
        // SQL-Server(MS-SQL)에 접속하는 객체
        private SqlConnection conn = null;
        // 접속시 서버의 인증을 받기 위해 사용하는
        // 접속주소, 스키마, 계정, 암호
        private string connInfo =
            "Server=localhost;database=Test_DB;" +
            "uid=Test_Login;pwd=p1234";
        public AddressDao()
        {
            conn = new SqlConnection(connInfo);// 접속객체생성
            try
            {
                conn.Open();        // SQL-Server에 접속
                if(conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("SQL-Server에 접속 성공");
                    Console.ReadKey();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // 소멸자 
        // 객체가 CLR내의 GC에 의해서 사라지기 직전에 자동으로 호출
        ~AddressDao()
        {
            if (conn != null)
                conn.Close();
        }

        public void insertAddress(Address addr)
        {
            try
            {
                // using구문이 끝날 때 cmd객체의 메모리를 소멸
                // IDisposable인터페이스를 상속받아서
                // Dispose()에 리소스 해제기능이 있는데
                // using 구문이 끝날 때는 자동으로 Dispose()
                // 를 호출하여 리소스를 정리한다
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO dbo.Address" + "\r\n" +
                                      "VALUES(@이름,@전화,@주소)";
                    cmd.Parameters.AddWithValue("@이름", addr.Name);
                    cmd.Parameters.AddWithValue("@전화", addr.Phone);
                    cmd.Parameters.AddWithValue("@주소", addr.Addr);
                    int cnt = cmd.ExecuteNonQuery(); // 서버로 sql전송 후 실행
                    Console.WriteLine(cnt + "행이 적용되었습니다");
                    Console.ReadKey();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        public Address searchAddress(string name)
        {
            Address addr = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM dbo.Address" + "\r\n" +
                                      "WHERE name=@이름";
                    cmd.Parameters.AddWithValue("@이름", name);

                    // 실행 후 결과값을 저장
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    string[] datas = new string[reader.FieldCount];
                    if (reader.Read())// 검색값이 존재한다면
                    {                        
                        //FieldCount: cnt, name, phone, addr = 4개
                        for (int i = 0; i < reader.FieldCount; i++)
                            datas[i] = reader.GetValue(i).ToString();

                        addr = new Address();
                        addr.Name = datas[1];
                        addr.Phone = datas[2];
                        addr.Addr = datas[3];
                    }

                    reader.Close();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            return addr;
        }

        public void updateAddress(string name, Address addr)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE dbo.Address SET" + "\r\n" +
                                      "name=@이름, phone=@전화, addr=@주소" + "\r\n" +
                                      "WHERE name=@검색이름";
                    cmd.Parameters.AddWithValue("@이름", addr.Name);
                    cmd.Parameters.AddWithValue("@전화", addr.Phone);
                    cmd.Parameters.AddWithValue("@주소", addr.Addr);
                    cmd.Parameters.AddWithValue("@검색이름", name);
                    int cnt = cmd.ExecuteNonQuery();
                    Console.WriteLine(cnt + "행에 적용되었습니다");
                    Console.ReadKey();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        public void deleteAddress(string name)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM dbo.Address" + "\r\n" +
                                      "WHERE name=@이름";
                    cmd.Parameters.AddWithValue("@이름", name);
                    int cnt = cmd.ExecuteNonQuery();
                    Console.WriteLine(cnt + "행에 적용되었습니다");
                    Console.ReadKey();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        public ArrayList searchAllAddress()
        {
            ArrayList addrList = new ArrayList();

            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM dbo.Address";

                    SqlDataReader reader = cmd.ExecuteReader();
                    // 다음행에 읽어야 할 내용이 존재한다면 
                    // true를 리턴하고 다음행으로 커서를 이동.
                    // 더 이상 읽어야 할 내용이 다음에 없다면 false를 리턴
                    string[] datas = new string[reader.FieldCount];
                    while (reader.Read())
                    {                        
                        for (int i = 0; i < reader.FieldCount; i++)
                            datas[i] = reader.GetValue(i).ToString();

                        Address addr = new Address();
                        addr.Name = datas[1];
                        addr.Phone = datas[2];
                        addr.Addr = datas[3];
                        addrList.Add(addr);
                    }

                    reader.Close();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            return addrList;
        }
    }
}
