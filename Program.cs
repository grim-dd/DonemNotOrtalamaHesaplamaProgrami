//Programlama I Dersi Ortalama Hesaplama
using System;

Console.Write("Programlama Vize Notunuzu Giriniz : ");
double ProgVizeNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("Programlama Final Notunuzu Giriniz : ");
double ProgFinalNotu = Convert.ToDouble(Console.ReadLine());
double ProgOrtalama = (ProgVizeNotu * 0.4) + (ProgFinalNotu * 0.6);
Console.WriteLine("Programlama Dersinin Ortalaması : " + ProgOrtalama);

//Veri Tabanı Dersi Ortalama Hesaplama
Console.Write("Veri Tabanı Vize Notunuzu Giriniz : ");
double VeriVizeNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("VeriTabanı Final Notunuzu Giriniz : ");
double VeriFinalNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("Veri Tabanı Quiz Notunuzu Giriniz : ");
double VeriQuizNotu = Convert.ToDouble(Console.ReadLine());
double VeriOrtalama = (VeriVizeNotu * 0.4) + (VeriFinalNotu * 0.6) + (VeriQuizNotu * 0.15);
Console.WriteLine("Veri Tabanı Dersinin Ortalaması : " + VeriOrtalama);

//Herkes İçin Siber Güvenlik Dersi Ortalama Hesaplama
Console.Write("Herkes İçin Siber Güvenlik Vize Notunuzu Giriniz : ");
double SiberVizeNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("Herkes İçin Siber Güvenlik Final Notunuzu Giriniz : ");
double SiberFinalNotu = Convert.ToDouble(Console.ReadLine());
double SiberOrtalama = (SiberVizeNotu * 0.4) + (SiberFinalNotu * 0.6);
Console.WriteLine("Herkes İçin Siber Güvenlik Dersinin Ortalaması : " + SiberOrtalama);

//Bilgisayar Donanımı Dersi Ortalama Hesaplama
Console.Write("Bilgisayar Donanımı Vize Notunuzu Giriniz : ");
double DonVizeNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("Bilgisayar Donanımı Final Notunuzu Giriniz : ");
double DonFinalNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("Bilgisayar Donanımı 1. Quiz Notunuzu Giriniz : ");
double DonQuizNotu1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Bilgisayar Donanımı 2. Quiz Notunuzu Giriniz : ");
double DonQuizNotu2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Bilgisayar Donanımı 3. Quiz Notunuzu Giriniz : ");
double DonQuizNotu3 = Convert.ToDouble(Console.ReadLine());
double DonOrtalama = (DonVizeNotu * 0.3) + (DonFinalNotu * 0.4) + (DonQuizNotu1 * 0.10) + (DonQuizNotu2 * 0.10) + (DonQuizNotu3 * 0.10);
Console.WriteLine("Bilgisayar Donanımı Dersinin Ortalaması : " + DonOrtalama);

//Yapay Zeka Okuryazarlığı Dersi Ortalama Hesaplama
Console.Write("Yapay Zeka Okuryazarlığı Vize Notunuzu Giriniz : ");
double YapayVizeNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("Yapay Zeka Okuryazarlığı Final Notunuzu Giriniz : ");
double YapayFinalNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("Yapay Zeka Okuryazarlığı Quiz Ortalamanızı Giriniz : ");
double YapayQuizNotu = Convert.ToDouble(Console.ReadLine());
double YapayOrtalama = (YapayVizeNotu * 0.35) + (YapayFinalNotu * 0.5) + (YapayQuizNotu * 0.15);
Console.WriteLine("Yapay Zeka Okuryazarlığı Ortalaması : " + YapayOrtalama);

//Atatürk İlkeleri ve İnkılap Tarihi I Dersi Ortalama Hesaplama
Console.Write("Atatürk İlkeleri ve İnkılap Tarihi I Vize Notunuzu Giriniz : ");
double InkVizeNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("Atatürk İlkeleri ve İnkılap Tarihi I Final Notunuzu Giriniz : ");
double InkFinalNotu = Convert.ToDouble(Console.ReadLine());
double InkOrtalama = (InkVizeNotu * 0.4) + (InkFinalNotu * 0.6);
Console.WriteLine("Atatürk İlkeleri ve İnkılap Tarihi I Dersinin Ortalaması : " + InkOrtalama);

//Türk Dili I Dersi Ortalama Hesaplama
Console.Write("Türk Dili I Vize Notunuzu Giriniz : ");
double TurkVizeNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("Türk Dili I Final Notunuzu Giriniz : ");
double TurkFinalNotu = Convert.ToDouble(Console.ReadLine());
double TurkOrtalama = (TurkVizeNotu * 0.4) + (TurkFinalNotu * 0.6);
Console.WriteLine("Türk Dili I Dersinin Ortalaması : " + TurkOrtalama);

//İngilizce I Dersi Ortalama Hesaplama
Console.Write("İngilizce I Vize Notunuzu Giriniz : ");
double IngVizeNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("İngilizce I Final Notunuzu Giriniz : ");
double IngFinalNotu = Convert.ToDouble(Console.ReadLine());
double IngOrtalama = (IngVizeNotu * 0.4) + (IngFinalNotu * 0.6);
Console.WriteLine("İngilizce I Dersinin Ortalaması : " + IngOrtalama);

//Matematik Dersi Ortalama Hesaplama
Console.Write("Matematik Vize Notunuzu Giriniz : ");
double MatVizeNotu = Convert.ToDouble(Console.ReadLine());
Console.Write("Matematik Final Notunuzu Giriniz : ");
double MatFinalNotu = Convert.ToDouble(Console.ReadLine());
double MatOrtalama = (MatVizeNotu * 0.4) + (MatFinalNotu * 0.6);
Console.WriteLine("Matematik Dersinin Ortalaması : " + MatOrtalama);

ProgOrtalama= 5 * dortluk_sisteme_cevirme(ProgOrtalama);
DonOrtalama= 4 * dortluk_sisteme_cevirme(DonOrtalama);
VeriOrtalama= 5 * dortluk_sisteme_cevirme(VeriOrtalama);
SiberOrtalama= 2 * dortluk_sisteme_cevirme(SiberOrtalama);
YapayOrtalama= 2 * dortluk_sisteme_cevirme(YapayOrtalama);
InkOrtalama= 2 * dortluk_sisteme_cevirme(InkOrtalama);
TurkOrtalama= 2 * dortluk_sisteme_cevirme(TurkOrtalama);
MatOrtalama= 5 * dortluk_sisteme_cevirme(MatOrtalama);
IngOrtalama= 3 * dortluk_sisteme_cevirme(IngOrtalama);



double genel_ortalama = (ProgOrtalama + DonOrtalama + VeriOrtalama + SiberOrtalama + YapayOrtalama + InkOrtalama + TurkOrtalama + MatOrtalama + IngOrtalama) / 30;
Console.WriteLine("Genel Ortalamanız: " + genel_ortalama);
static double dortluk_sisteme_cevirme(double x)
{
    if (x >= 84)
    {

        return 4;
    }
    else if (x >= 77)
    {
        return 3.7;
    }
    else if (x >= 71)
    {
        return 3.3;
    }
    else if (x >= 66)
    {
        return 3;
    }
    else if (x >= 61)
    {
        return 2.7;
    }
    else if (x >= 56)
    {
        return 2.3;
    }
    else if (x >= 50)
    {
        return 2;
    }
    else if (x >= 46)
    {
        return 1.7;
    }
    else if (x >= 40)
    {
        return 1.3;
    }
    else if (x >= 33)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}