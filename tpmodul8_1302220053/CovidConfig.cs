using System.IO;
using System.Text.Json;

public class CovidConfig
{
    public string SatuanSuhu { get; private set; }
    public int BatasHariDeman { get; private set; }
    public string PesanDitolak { get; private set; }
    public string PesanDiterima { get; private set; }

    public CovidConfig()
    {
        LoadConfig();
    }

    private void LoadConfig()
    {
        const string configFile = "covid_config.json";

        if (File.Exists(configFile))
        {
            string json = File.ReadAllText(configFile);
            JsonDocument doc = JsonDocument.Parse(json);

            JsonElement root = doc.RootElement;
            SatuanSuhu = root.GetProperty("satuan_suhu").GetString();
            BatasHariDeman = root.GetProperty("batas_hari_deman").GetInt32();
            PesanDitolak = root.GetProperty("pesan_ditolak").GetString();
            PesanDiterima = root.GetProperty("pesan_diterima").GetString();
        }
        else
        {
            // Set nilai default jika file tidak ditemukan
            SatuanSuhu = "celcius";
            BatasHariDeman = 14;
            PesanDitolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
            PesanDiterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
        }

    }
    public void UbahSatuan()
    {
        SatuanSuhu = SatuanSuhu == "celcius" ? "fahrenheit" : "celcius";
    }
}
