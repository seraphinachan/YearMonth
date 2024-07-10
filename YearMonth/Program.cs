// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

// Console.WriteLine("Hello, World!");

public class YearMonth
{
    // 읽기 전용 속성
    public int Year { get; private set; }
    public int Month { get; private set; }

    // 생성자
    public YearMonth(int year, int month)
    {
        Year = year;
        Month = month;
    }

    // Is21Century 속성
    public bool Is21Century => Year >= 2001 && Year <= 2100;

    // AddOneMonth 메서드
    public YearMonth AddOneMonth()
    {
        int newYear = Year;
        int newMonth = Month;

        if (newMonth > 12)
        {
            newYear++;
            newMonth = 1;
        }

        return new YearMonth(newYear, newMonth);
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public void ArrayYearMonth()
    {
        // YearMonth를 요소로 갖는 배열을 정의하고 다섯 개의 YearMonth 객체를 초깃값으로 지정
        YearMonth[] yearMonths = new YearMonth[]
        {
        new YearMonth(2001, 1),
        new YearMonth(2002, 2),
        new YearMonth(2003, 3),
        new YearMonth(2004, 4),
        new YearMonth(2005, 5)
        };

        // 배열의 요소(YearMonth 객체)를 모두 열거하고 그 값을 콘솔에 출력
        foreach (var ym in yearMonths)
        {
            Console.WriteLine(ym.ToString());
        }

        // ArrayIs21Century 메서드를 호출해서 처음 발견된 21세기 데이터의 연도를 표시 
        if (ArrayIs21Century != null)
        {
            Console.WriteLine(yearMonths[0]);
        }
        else
        {
            Console.WriteLine("21세기 데이터는 없습니다."); // 발견되지 않았다면 표시
        }
    }

    // 배열에 저장된 모든 YearMonth의 1개월 후를 구하고 그 결과를 새로운 배열에 추가
    public YearMonth[] AddOneMonthToAll(YearMonth[] yearMonths)
    {
        YearMonth[] newYearMonths = new YearMonth[yearMonths.Length];

        for (int i = 0; i < yearMonths.Length; i++)
        {
            newYearMonths[i] = yearMonths[i].AddOneMonth();
        }

        return newYearMonths;
    }

    // 배열에서 처음 발견한 21세기의 YearMonth 객체를 반환하는 메서드, 발견하지 않았다면 null을 반환
    // `void`는 반환값이 없다는 의미
    public YearMonth ArrayIs21Century(YearMonth[] yearMonths)
    {
        foreach (var ym in yearMonths)
        {
            if (ym.Is21Century != null)
            {
                return ym;
            }
        }
        return null; // 루프가 끝난 후 21세기 YearMonth 객체를 찾지 못한 경우 null 반환
    }
}
