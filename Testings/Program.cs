using System.Diagnostics;

namespace Testings;

public class Program
{
    public static void Main()
    {
        var tree = new PlatformsTree();
        var sw = new Stopwatch();
        var platform_1 = "Яндекс.Директ";
        var locations_1 = new[] { "/ru" };

        var platform_2 = "Ревдинский рабочий";
        var locations_2 = new[] { "/ru/srvd/revda", "/ru/srvd/pervik" };

        var platform_3 = "Крутая реклама";
        var locations_3 = new[] { "/ru/srvd" };

        var platform_4 = "Абоба";
        var locations_4 = new[] { "/ru/srvd/revda/abob/kill/sis/mam/pop/loh/dog/wow" };

        sw.Start();
        tree.AddElement(platform_1, locations_1);

        tree.AddElement(platform_2, locations_2);

        tree.AddElement(platform_3, locations_3);

        tree.AddElement(platform_4, locations_4);
        sw.Stop();
        Console.WriteLine($"добавление: {sw.ElapsedTicks}");
        sw.Reset();

        sw.Start();
        var test1 = tree.GetElements("/ru/srvd/revda");
        sw.Stop();
        Console.WriteLine($"1 получение: {sw.ElapsedTicks}");
        sw.Reset();

        sw.Start();
        var test2 = tree.GetElements("/ru/srvd/revda");
        sw.Stop();
        Console.WriteLine($"2 получение: {sw.ElapsedTicks}");
        sw.Reset();

        sw.Start();
        var test3 = tree.GetElements("/ru/srvd/revda/abob/kill/sis/mam/pop/loh/dog/wow");
        sw.Stop();
        Console.WriteLine($"3 получение: {sw.ElapsedTicks}");
        sw.Reset();

        sw.Start();
        var test4 = tree.GetElements("/ru/srvd/revda/abob/kill/sis/mam/pop/loh/dog/wow");
        sw.Stop();
        Console.WriteLine($"4 получение: {sw.ElapsedTicks}");
        foreach (var test in test4)
        {
            Console.WriteLine(test);
        }
        sw.Reset();

        sw.Start();
        var test5 = tree.GetElements("/ru/srvd/revda/abob/kill/sis/mam/pop/loh/dog/wow");
        sw.Stop();
        Console.WriteLine($"5 получение: {sw.ElapsedTicks}");
        sw.Reset();
    }
}