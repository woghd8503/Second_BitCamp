using System;

namespace _120_AddressDB
{
    //Dao : Data Access Object
    //    데이터베이스(테이블)을 접속/정보요청/관리
    class AddressDao
    {
        // SQL-Sever(MS-SQL)에 접속하는 객체
        
        private SqlConnection conn = null;
        // 접속시 서버의 인증을 받기 위해 사용하는
        // 접속주소 
        private string connInfo = "Server=localhost;datebase=Test_DB;" + "uid=Test_Login;pwd=p1234"; // 접속객체 생성
        public AddressDao()
        {
            conn = new SqlConnection(connInfo);
            try
            {
                conn.Open(); // SQL-Server에 접속
                if(conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("SQL-Server에 접속 성공");
                    Console.ReadKey();
                }

            }catch(Exception e)
            {

            }
            finally
            {
                Console.Writeline(e.Message);
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
                //using구문이 끝날 때 cmd객체의 메모리를 소멸
                //IDisposable 인터페이스를 상속받아서
                //Dispose()에 리소스 해제기능이 있는데
                //using 구문이 끝날 때는 자동으로 Dispose()
                //를 호출하여 리소스를 정리한다.
                using(sqlCommand cmd = new sqlCommand())
                {
                    cmd.Connection =conn;
                    cmd.CommandTest = "InSERT INTO dbo.Addresss" + "\r\n" + "VALUES()" + "VALUES(@이름,@전화,@주소)";
                    cmd.Parmeters.AddWithValue("@이름", addr.Name);
                    cmd.Parmeters.AddWithValue("@전화", addr.Phone);
                    cmd.Parmeters.AddWithValue("@주소", addr.Addr);
                    int cnt = cmd.ExecuteNonQuery(); // 서보로 sql전송 후 실행
                    Console.WriteLine(cnt + "행이적용되었습니다.");
                    Console.ReadLine();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
           
        }
        public Address searchAddress(string  name)
        {
            try
            {
                using (sqlCommand cmd = new sqlCommand())
                {
                    AddressDao addr = null;
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM dbo.Address" + "\r\n" + "WHERE name=@이름";
                    cmd.Parameters.AddWithValue("@이름", name);
                    // 실행 후 결과값을 저장
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read())// 검색값이 존재한다면
                    {

                        //실행 후 결과값을 저장
                        string[] datas = new string[reader.FileCount];

                        // FieldCount: cnt, name, phone, addr = 4ro
                        for(int i =0; i<reader.FileCount; i++)
                            datas[i] = reader.GetValue(i).ToString();

                        addr = new AddressDao();
                        addr.Name = datas[1];
                        addr.Phone = datas[1];
                        addr.Addr = datas[1];
                    }
                    if(datas.Length > 0)
                    {

                    }

                    return addr;
                }
                }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            return Addr;
        }

        public void updateAddress(string name, AddressDao addr)
        {

        }
    }
}
