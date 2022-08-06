using System;

class Program
{
    public static void Main(string[] args)
    {
        string nama, alamat;
        int umur;
        float beratBadan;
        bool isMenikah;

        alamat = "Jl. Raya";
        umur = 20;
        beratBadan = 70.5f;
        isMenikah = true;

        Console.Write("Silahkan Masukkan Nama Anda: ");
        nama = Console.ReadLine();
        Console.Write("Silahkan Masukkan Alamat Anda: ");
        alamat = Console.ReadLine();
        Console.Write("Silahkan Masukkan Umur Anda: ");
        int.TryParse(Console.ReadLine(), out umur);
        Console.Write("Silahkan Masukkan Berat Badan Anda: ");
        float.TryParse(Console.ReadLine(), out beratBadan);
        Console.Write("Apakah Anda Menikah? (true/false): ");
        bool.TryParse(Console.ReadLine(), out isMenikah);

        Console.WriteLine("Nama: {0}", nama);
        Console.WriteLine("Alamat: {0}", alamat);
        Console.WriteLine("Umur: {0}", umur);
        Console.WriteLine("Berat Badan: {0}", beratBadan);
        Console.WriteLine("Status Menikah: {0}", isMenikah == true ? "Menikah" : "Belum Menikah");

    }
}