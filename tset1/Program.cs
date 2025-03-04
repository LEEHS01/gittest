using System;

class Program
{
    static void Main()
    {
        int number;
        while (true)
        {
            Console.Write("5자리 숫자를 입력하세요: ");
            string input = Console.ReadLine();

            // 입력 검증 (숫자인지 + 5자리인지)
            if (int.TryParse(input, out number) && input.Length == 5)
            {
                break; // 유효한 입력이면 루프 종료
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다. 5자리 숫자를 입력하세요.");
            }
        }

        // 자연수 판별 (1 이상이어야 함)
        if (number > 0)
        {
            Console.WriteLine($"{number}은(는) 자연수입니다.");
        }
        else
        {
            Console.WriteLine($"{number}은(는) 자연수가 아닙니다.");
        }
    }
}

