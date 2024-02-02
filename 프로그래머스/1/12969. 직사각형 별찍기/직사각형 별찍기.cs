using System;
public class Example
//스네이크 게임과 틱택토 만들면서 썼던 맵 깔기가 생각난다.
//for문으로 *를 a만큼 찍고 b만큼 /n 줄을 넘기게 만들기.
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        //*찍기가 끝나면 b만큼 줄 바꿔주기
        for(int j = 0; j < b; j++)
        {
            //a만큼 *을 찍기
            for(int i = 0; i < a; i++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}