// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

class YearMonth
{
    // 읽기 전용 속성
    public int Year { get; }
    public int Month { get; }

    // 생성자
    public YearMonth(int year, int month)
    {
        // 1부터 12까지의 범위에 있는지 확인
        if (month < 1 || month > 12)
        {

        }
    }

    // Is21Century 속성
    public bool Is21Century
    {
        get
        {
            return Year >= 2001 && Year <= 2100;
        }
    }

    // AddOneMonth 메서드
    public YearMonth AddOneMonth()
    {
        int newYear = Year;
        int newMonth = Month;

        if (newMonth > 12)
        {
            newMonth = 1;
            newYear++;
        }

        return YearMonth(newYear, newMonth);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
