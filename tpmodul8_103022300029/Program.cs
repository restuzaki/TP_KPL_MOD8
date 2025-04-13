using System;
using tpmodul8_103022300029;

class Program
{
    static void Main()
    {
        CovidConfig config = new CovidConfig();

        config.UbahSatuan();

        config = new CovidConfig();

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int hari = Convert.ToInt32(Console.ReadLine());

        bool suhuNormal = false;

        Console.WriteLine($"Suhu kamu: {suhu} {config.satuan_suhu}");
        Console.WriteLine($"Hari sejak demam: {hari}, batas: {config.batas_hari_deman}");


        if (config.satuan_suhu == "celcius")
            suhuNormal = suhu >= 36.5 && suhu <= 37.5;
        else if (config.satuan_suhu == "fahrenheit")
            suhuNormal = suhu >= 97.7 && suhu <= 99.5;

        if (suhuNormal && hari < config.batas_hari_deman)
            Console.WriteLine(config.pesan_diterima);
        else
            Console.WriteLine(config.pesan_ditolak);
    }
}