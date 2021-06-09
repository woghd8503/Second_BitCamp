using _120_AddressDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_AddressClass
{
    class AddressManager
    {
        AddressDao addrDao = new AddressDao();

        public void initAddress()
        {

        }
        public void insertAddress()
        {
            Console.WriteLine("---주소 입력---");
            Console.Write("이름 입력 >> ");
            string name = Console.ReadLine();
            Console.Write("전화 입력 >> ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력 >> ");
            string addr = Console.ReadLine();

            Address address = new Address();
            address.Name = name;
            address.Phone = phone;
            address.Addr = addr;

            addrDao.insertAddress(address);
        }
        public Address searchAddress(string title)
        {
            Console.WriteLine("------{0}------", title);
            Console.Write("검색할 이름 입력 >> ");
            string name = Console.ReadLine();

            Address address = addrDao.searchAddress(name);

            return address;
        }
        public void searchAddress()
        {
            Address address = searchAddress("주소 검색");
            if (address != null)
                address.showInfo();
            else
                Console.WriteLine("검색 대상이 없습니다...");

            Console.ReadLine();
        }
        public void updateAddress()
        {
            Console.Write("수정 대상 이름: ");
            string uName = Console.ReadLine();
            Address _address = addrDao.searchAddress(uName);
            if (_address != null)
            {
                _address.showInfo();

                Console.Write("수정 이름: ");
                string name = Console.ReadLine();
                Console.Write("수정 전화: ");
                string phone = Console.ReadLine();
                Console.Write("수정 주소: ");
                string addr = Console.ReadLine();

                Address address = new Address();
                address.Name = name;
                address.Phone = phone;
                address.Addr = addr;
                addrDao.updateAddress(uName, address);

                Console.ReadLine();
            }

        }
        public void deleteAddress()
        {
            Console.Write("삭제 대상 이름: ");
            string dName = Console.ReadLine();
            Address _address = addrDao.searchAddress(dName);
            if (_address != null)
            {
                _address.showInfo();
                Console.Write("진짜 삭제하시겠습니까(y/n) >> ");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                    addrDao.deleteAddress(dName);
                else
                    Console.WriteLine("삭제가 취소되었습니다~");
            }
            else
                Console.WriteLine("삭제 대상이 없습니다...");

            Console.ReadLine();
        }
        public void printAllAddress()
        {
            ArrayList arrList = addrDao.searchAllAddress();
            for (int i = 0; i < arrList.Count; i++)
            {
                Address address = (Address)arrList[i];
                address.showInfo(i + 1);
            }
            Console.ReadLine();
        }
        public void programExit()
        {
            Console.Write("프로그램 종료~");
            Console.ReadLine();
        }
    }
}
