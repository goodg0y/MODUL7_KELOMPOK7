using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7_KELOMPOK7
{

    internal class Film
    {
        public string judul { get; set; }
        public string sutradara { get; set; }
        public string genre { get; set; }
        public int tahun { get; set; }
        public double rating { get; set; }
        public string durasi { get; set; }
        public Boolean ditonton { get; set; } = true;
    }
    internal class FilmFavorit_103022400123
    {
       

        public static void ReadJSON()
        {
            string filePath = "jurnal7_1_103022400123.json";
            string jsonString = File.ReadAllText(filePath);
            Film data = JsonSerializer.Deserialize<Film>(jsonString);
            
            Console.WriteLine($"Judul : { data.judul} Sutradara { data.sutradara} Genre { data.genre} Tahun :  { data.tahun} Rating :  { data.rating} Durasi { data.durasi} Ditonton :  { data.ditonton}");
        }
    }
}
