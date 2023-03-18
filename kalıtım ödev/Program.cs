using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menüye hoşgeldiniz...");
            Console.WriteLine("Seçmek istediğiniz birliği tuşlayınız");
            while (true)
            {
                Console.WriteLine("1- Sovyet");
                Console.WriteLine("2- Amerika");
                Console.WriteLine("3- Çıkış için q'ya basınız");
                string secilenIslem = Console.ReadLine();

                if (secilenIslem == "q")
                {
                    Console.WriteLine("Menüden çıkılıyor...");
                    break;
                }
                
                else if (secilenIslem == "1")
                {
                    Sovyet sovyet= new Sovyet();

                    while (true)
                    {
                        Console.WriteLine("Sovyet birliğine hoşgeldiniz...");
                        Console.WriteLine("Eklemek istediğiniz binayı seçiniz...");
                        Console.WriteLine("1- Jeneratör");
                        Console.WriteLine("2- Kışla");
                        Console.WriteLine("3- Hangar");
                        Console.WriteLine("4- Birlikten çıkmak için q'ya basınız");
                        string sovyetSecim = Console.ReadLine();

                        if (sovyetSecim == "q")
                        {
                            Console.WriteLine("Birlikten çıkışınız yapılıyor...");
                            break;
                        }

                        else if (sovyetSecim == "1")
                        {
                            Console.WriteLine("Jeneratör kuruluyor...");
                            sovyet.JFUNCTİON();

                        }

                        else if (sovyetSecim == "2")
                        {
                            Console.WriteLine("Kışla kuruluyor...");
                            sovyet.KFUNCTİON();
                        }

                        else if (sovyetSecim == "3")
                        {
                            Console.WriteLine("Hangar kuruluyor...");
                            sovyet.KFUNCTİON();
                        }

                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                        }

                        while (true)
                        {
                            Console.WriteLine("Durumunu görmek istediğiniz binayı seçiniz");
                            Console.WriteLine("1- Jeneratör");
                            Console.WriteLine("2- Kışla");
                            Console.WriteLine("3- Hangar");
                            Console.WriteLine("4- Bina kurmaya dönüş");
                            string durumSovyetSecim = Console.ReadLine();

                            if (durumSovyetSecim == "4")
                            {
                                Console.WriteLine("Çıkış yapılıyor...");
                                break;

                            }
                            else if (durumSovyetSecim == "1")
                            {
                                Console.Write("Jeneratör seviyesi:");
                                sovyet.JLEVEL();
                                Console.WriteLine("");
                                Console.Write("Jeneratör canı:");
                                sovyet.JHP();
                            }
                            else if (durumSovyetSecim == "2")
                            {
                                Console.Write("Kışla seviyesi:");
                                sovyet.KLEVEL();
                                Console.WriteLine("");
                                Console.Write("Kışla canı:");
                                sovyet.KHP();
                            }
                            else if (durumSovyetSecim == "3")
                            {
                                Console.Write("Hangar seviyesi:");
                                sovyet.HHP();
                                Console.WriteLine("");
                                Console.Write("Hangar canı:");
                                sovyet.HLEVEL();
                            }
                            else
                            {
                                Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                            }
                        }
                    }
                }

                else if (secilenIslem == "2")
                {
                    Amerika amerika =new Amerika();

                    while (true)
                    {
                        Console.WriteLine("Amerika birliğine hoşgeldiniz...");
                        Console.WriteLine("Eklemek istediğiniz binayı seçiniz...");
                        Console.WriteLine("1- Jeneratör");
                        Console.WriteLine("2- Kışla");
                        Console.WriteLine("3- Hangar");
                        Console.WriteLine("4- Birlikten çıkmak için q'ya basınız");
                        string amerikaSecim = Console.ReadLine();

                        if (amerikaSecim == "q")
                        {
                            Console.WriteLine("Birlikten çıkışınız yapılıyor...");
                            break();
                        }

                        else if (amerikaSecim == "1")
                        {
                            Console.WriteLine("Jeneratör kuruluyor...");
                            amerika.JFUNCTİON();
                        }

                        else if (amerikaSecim == "2")
                        {
                            Console.WriteLine("Kışla kuruluyor...");
                            amerika.KFUNCTİON();
                        }

                        else if (amerikaSecim == "3")
                        {
                            Console.WriteLine("Hangar kuruluyor...");
                            amerika.HFUNCTİON();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                        }

                        while (true)
                        {
                            Console.WriteLine("Durumunu görmek istediğiniz binayı seçiniz");
                            Console.WriteLine("1- Jeneratör");
                            Console.WriteLine("2- Kışla");
                            Console.WriteLine("3- Hangar");
                            Console.WriteLine("4- Bina kurmaya dönüş");
                            string durumAmerikaSecim = Console.ReadLine();

                            if (durumAmerikaSecim == "4")
                            {
                                Console.WriteLine("Çıkış yapılıyor...");
                                break;

                            }
                            else if (durumAmerikaSecim == "1")
                            {
                                Console.Write("Jeneratör seviyesi:");
                                amerika.JLEVEL();
                                Console.WriteLine("");
                                Console.Write("Jeneratör canı:");
                                amerika.JHP();
                            }
                            else if (durumAmerikaSecim == "2")
                            {
                                Console.Write("Kışla seviyesi:");
                                amerika.KLEVEL();
                                Console.WriteLine("");
                                Console.Write("Kışla canı:");
                                amerika.KHP();
                            }
                            else if (durumAmerikaSecim == "3")
                            {
                                Console.Write("Hangar seviyesi:");
                                amerika.HHP();
                                Console.WriteLine("");
                                Console.Write("Hangar canı:");
                                amerika.HLEVEL();
                            }
                            else
                            {
                                Console.WriteLine("Lütfen geçerli bir işlem giriniz!");

                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                }
            }
        }
    }
}