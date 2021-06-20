using _98_polymorphism_Address;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_AddressClass
{
    class AddressFile
    {
        const int GENERAL = 0;
        const int UNIVERSAL = 1;
        const int COMPANY = 2;

        public void loadFileAddress(ArrayList arrList)
        {
            StreamReader sr = null;

            try   
            {
                sr = new StreamReader("address.txt");
                Address address = null;
                int step = 0, kind=0;
                while (sr.Peek() >= 0) // 읽을 내용이 있다
                {
                    string str = sr.ReadLine();
                    if(step == 0)
                    {
                        if (str == "general")
                        {
                            kind = GENERAL;
                            address = new Address();
                        }
                        else if (str == "universal")
                        {
                            kind = UNIVERSAL;
                            address = new UnivAddress();
                        }                            
                        else if (str == "company")
                        {
                            kind = COMPANY;
                            address = new CompanyAddress();
                        }                            

                        step++;
                    }else if (step == 1)
                    {
                        address.Name = str;  
                        step++;
                    }else if(step == 2)
                    {
                        address.Phone = str;
                        step++;
                    }else if(step == 3)
                    {
                        address.Addr = str;
                        step++;
                    }else if(step == 4)
                    {
                        if (kind == GENERAL)
                        {
                            arrList.Add(address);
                            step = 0;
                        }
                        else if (kind == UNIVERSAL)
                        {
                            ((UnivAddress)address).Major = str;
                            step++;
                        }
                        else if (kind == COMPANY)
                        {
                            ((CompanyAddress)address).Company = str;
                            step++;
                        }
                    }else if(step == 5)
                    {
                        if(kind == UNIVERSAL)
                            ((UnivAddress)address).Year = str;
                        else if(kind == COMPANY)
                            ((CompanyAddress)address).Job = str;

                        step++;
                    }else if(step == 6)
                    {
                        arrList.Add(address);
                        step = 0;
                    }
                }
            }
            catch (Exception e)  // 예외 에러를 잡는다
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally // 정상/예외든 무조건 마무리한다
            {
                if (sr != null)
                    sr.Close();
            }
        }

        public void saveFileAddress(ArrayList arrList)
        {
            StreamWriter sw = new StreamWriter("address.txt");
            for (int i = 0; i < arrList.Count; i++)
            {
                Address address = (Address)arrList[i];
                if(address is UnivAddress)
                {
                    sw.WriteLine("universal");
                    sw.WriteLine(address.Name);
                    sw.WriteLine(address.Phone);
                    sw.WriteLine(address.Addr);
                    sw.WriteLine(((UnivAddress)address).Major);
                    sw.WriteLine(((UnivAddress)address).Year);
                    sw.WriteLine();
                }
                else if(address is CompanyAddress)
                {
                    sw.WriteLine("company");
                    sw.WriteLine(address.Name);
                    sw.WriteLine(address.Phone);
                    sw.WriteLine(address.Addr);
                    sw.WriteLine(((CompanyAddress)address).Company);
                    sw.WriteLine(((CompanyAddress)address).Job);
                    sw.WriteLine();
                }
                else
                {
                    sw.WriteLine("general");
                    sw.WriteLine(address.Name);
                    sw.WriteLine(address.Phone);
                    sw.WriteLine(address.Addr);
                    sw.WriteLine();
                }
            }
            sw.Close();
        }

    }
}
