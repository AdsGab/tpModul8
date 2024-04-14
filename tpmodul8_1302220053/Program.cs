using System;
class program()
{
    static void Main(String[] args)
    {
        CovidConfig config = new CovidConfig();
        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.SatuanSuhu}: ");
        double suhu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Berapa hari yang lalu (Perkiraan) anda terakhir memiliki gejala deman? : ");
        int hari = Convert.ToInt32(Console.ReadLine());
        if ((config.SatuanSuhu == "celcius" && (suhu >= 36.5 && suhu <= 37.5)) ||(config.SatuanSuhu == "fahrenheit" && (suhu >= 97.7 && suhu <= 99.5)))
        {
            if (hari < config.BatasHariDeman)
            {
                Console.WriteLine(config.PesanDiterima);
            }
            else
            {
                Console.WriteLine(config.PesanDitolak);
            }
        }
        else
        {
            Console.WriteLine(config.PesanDitolak);
        }

        config.UbahSatuan();
        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.SatuanSuhu}: ");
        double suhuFahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Berapa hari yang lalu (Perkiraan) anda terakhir memiliki gejala deman? : ");
        int hari2 = Convert.ToInt32(Console.ReadLine());
        if ((config.SatuanSuhu == "celcius" && (suhuFahrenheit >= 36.5 && suhuFahrenheit <= 37.5)) || (config.SatuanSuhu == "fahrenheit" && (suhuFahrenheit >= 97.7 && suhuFahrenheit <= 99.5)))
        {
            if (hari2 < config.BatasHariDeman)
            {
                Console.WriteLine(config.PesanDiterima);
            }
            else
            {
                Console.WriteLine(config.PesanDitolak);
            }
        }
        else
        {
            Console.WriteLine(config.PesanDitolak);
        }
    }
}