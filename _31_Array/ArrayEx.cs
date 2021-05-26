using System;

namespace _31_Array
{
    //배열: 같은 타입변수들이 연속되어 있다.
    class ArrayEx
    {
        static void Main(string[] args)
        {
            // 배열의 선언(변수공간 할당)과 초기화
            int[] numArr = { 11, 99, 82, 83, 15 };
            string[] nameArr = {"홍길동", "임꺽정", "장길산",
                                  "일지매", "차돌바위"};
            for (int i = 0; i < numArr.Length; i++)
                Console.Write(numArr[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < nameArr.Length; i++)
                Console.Write(nameArr[i] + " ");
            Console.WriteLine();
            Console.WriteLine(numArr[2]);
            Console.WriteLine(nameArr[1]);
        }
    }
}

