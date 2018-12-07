using System;
using System.Collections.Generic;
using System.Linq;

namespace Domaci_Rad_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var StringNo = "ne";
            var StringYes = "da";
            var StringName = "ime";
            var StringAdress = "adresa";
            var StringNumber = "broj";

            Console.WriteLine("Dobro dosli u domaci#2");

            var Book = new List<Tuple<string, string, int>>();
            {
                new Tuple<string, string, int>("ime", "ulica", 1);
            };

            char x;
            int n = 0;

            r: Console.WriteLine("\t~Meni~\n1.)Dodati novu osobu\n2.)Promijeniti ime\n3.)Promijeniti adresu\n4.)Promijeniti broj\n5.)Pretraziti po broju\n6.)Pretraziti po imenu\n7.)Ispis svih clanova\n8.)Brisanje upisa\n9.)Izlaz iz progama\n");
            Console.WriteLine("Sto zelite napraviti sa adresarom: ");

            x = char.Parse(Console.ReadLine());

            switch (x)
            {
                case '1':
                    string d1;
                    Console.WriteLine("Jeste li sigurni da zelite unijeti novog clana?(da/ne)");
                    dk1: d1 = Console.ReadLine();
                    if (String.Compare(d1, StringNo, ignoreCase: true) == 0)
                    {
                        goto r;
                    }
                    else if (String.Compare(d1, StringYes, ignoreCase: true) == 0)
                    {
                        string tmpNAME;
                        string tmpNUMBER;
                        string tmpADRESS;



                        Console.WriteLine("Upisite novog clana u adresar:\n");
                        Console.WriteLine("Ime i prezime:");
                        tmpNAME = Console.ReadLine();
                        Console.WriteLine("Adresa:");
                        tmpADRESS = Console.ReadLine();
                        Console.WriteLine("Broj:");
                        kfirst: string tmPNUMBER = "";
                        tmpNUMBER = Console.ReadLine();

                        for (int i = 0; i < (tmpNUMBER.Length); i++)
                        {

                            if (tmpNUMBER[i] != ' ')
                            {
                                tmPNUMBER = tmPNUMBER + tmpNUMBER[i];

                            }
                        }

                        Console.WriteLine("Provjera unikatnosti...");
                        int Unique = int.Parse(tmPNUMBER);

                        var FoundTupleNumberCheck = Book.Find(i => i.Item3 == Unique);
                        if (FoundTupleNumberCheck == null)
                        {
                            int Decision;
                            Console.WriteLine("Korisnik ce se dodati u adresar?\nMoze(1)\t\tOtkazi(0)");
                            dkk1: Decision = int.Parse(Console.ReadLine());
                            if (Decision == 1)
                            {
                                Book.Add(new Tuple<string, string, int>(tmpNAME, tmpADRESS, Unique));
                                Book.Sort(Comparer<Tuple<string, string, int>>.Default);
                                goto r;
                            }
                            else if (Decision == 0)
                            {
                                Console.WriteLine("Postupak se ponistava");
                                goto r;
                            }
                            else
                            {
                                Console.WriteLine("NLrivi unos, pokusajte ponovo:");
                                goto dkk1;
                            }
                        }
                        else
                        {

                            Console.WriteLine("Broj je vec unesen, pokusajte ponovo:");

                            goto kfirst;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pogresan unos,pokusajte ponovno:");
                        goto dk1;
                    }
                    break;

                case '2':
                    {
                        string d2;
                        Console.WriteLine("Jeste li sigurni da zelite promijeniti ime clana?(da/ne)");
                        dk2: d2 = Console.ReadLine();
                        if (String.Compare(d2, StringNo, ignoreCase: true) == 0)
                        {
                            goto r;
                        }
                        else if (String.Compare(d2, StringYes, ignoreCase: true) == 0)
                        {
                            string TmpName;
                            string NewName;
                            Console.WriteLine("Upisite ime clana ciji ime zelite promijeniti");
                            TmpName = Console.ReadLine();
                            Console.WriteLine("Upisite novo ime");
                            NewName = Console.ReadLine();
                            var FoundTupleName = Book.Find(s => s.Item1 == TmpName);
                            Book.Add(new Tuple<string, string, int>(NewName, FoundTupleName.Item2, FoundTupleName.Item3));
                            Book.Sort(Comparer<Tuple<string, string, int>>.Default);
                            Book.RemoveAll(item => item.Item1 == TmpName);


                            goto r;
                        }
                        else
                        {
                            Console.WriteLine("Pogresan unos,pokusajte ponovno:");
                            goto dk2;
                        }
                    }
                    break;

                case '3':
                    {
                        string d3;
                        Console.WriteLine("Jeste li sigurni da zelite promijeniti adresu clana?(da/ne)");
                        dk3: d3 = Console.ReadLine();
                        if (String.Compare(d3, StringNo, ignoreCase: true) == 0)
                        {
                            goto r;
                        }
                        else if (String.Compare(d3, StringYes, ignoreCase: true) == 0)
                        {
                            string TmpAdress;
                            string NewAdress;
                            Console.WriteLine("Upisite adresu clana ciji adresu zelite promijeniti");
                            TmpAdress = Console.ReadLine();
                            Console.WriteLine("Upisite novu adresu");
                            NewAdress = Console.ReadLine();
                            var FoundTupleAdress = Book.Find(s => s.Item2 == TmpAdress);
                            Book.Add(new Tuple<string, string, int>(FoundTupleAdress.Item1, NewAdress, FoundTupleAdress.Item3));
                            Book.Sort(Comparer<Tuple<string, string, int>>.Default);
                            Book.RemoveAll(item => item.Item2 == TmpAdress);

                            goto r;
                        }
                        else
                        {
                            Console.WriteLine("Pogresan unos,pokusajte ponovno:");
                            goto dk3;
                        }
                    }
                    break;

                case '4':
                    {
                        string d4;
                        Console.WriteLine("Jeste li sigurni da zelite promijeniti broj clana?(da/ne)");
                        dk4: d4 = Console.ReadLine();
                        if (String.Compare(d4, StringNo, ignoreCase: true) == 0)
                        {
                            goto r;
                        }
                        else if (String.Compare(d4, StringYes, ignoreCase: true) == 0)
                        {
                            int TmpNumber;
                            string NewPosNumber;
                            Console.WriteLine("Upisite broj clana ciji broj zelite promijeniti");
                            TmpNumber = int.Parse(Console.ReadLine());
                            dkk4: Console.WriteLine("Upisite novi broj");
                            string RealNewNumber = "";
                            NewPosNumber = Console.ReadLine();
                            Console.WriteLine("Problem?");
                            for (int h = 0; h < (NewPosNumber.Length); h++)
                            {

                                if (NewPosNumber[h] != ' ')
                                {
                                    RealNewNumber = RealNewNumber + NewPosNumber[h];

                                }
                            }
                            int UniqueNewNumber = int.Parse(RealNewNumber);
                            Console.WriteLine("Problem??");
                            Console.WriteLine("Provjera unikatnosti...");
                            var FoundTupleRealNumberCheck = Book.Find(i => i.Item3 == UniqueNewNumber);
                            Console.WriteLine("Problem???");
                            if (FoundTupleRealNumberCheck == null)
                            {
                                int Decision2;
                                Console.WriteLine("Korisnik ce se dodati u adresar?\nMoze(1)\t\tOtkazi(0)");
                                dkk41: Decision2 = int.Parse(Console.ReadLine());
                                if (Decision2 == 1)
                                {
                                    var FoundTupleNumber = Book.Find(i => i.Item3 == TmpNumber);
                                    Book.Add(new Tuple<string, string, int>(FoundTupleNumber.Item1, FoundTupleNumber.Item2, UniqueNewNumber));
                                    Book.Sort(Comparer<Tuple<string, string, int>>.Default);
                                    Book.RemoveAll(item => item.Item3 == TmpNumber);
                                    goto r;
                                }
                                else if (Decision2 == 0)
                                {
                                    Console.WriteLine("Postupak se ponistava");
                                    goto r;
                                }
                                else
                                {
                                    Console.WriteLine("Krivi unos, pokusajte ponovo");
                                    goto dkk41;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Broj nije unikatan, pokusajte ga unijeti ponovo:");
                                goto dkk4;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Pogresan unos,pokusajte ponovno:");
                            goto dk4;
                        }
                    }
                    break;
                case '5':
                    {
                        string d5;
                        Console.WriteLine("Jeste li sigurni da zelite pronaci clana po broju?(da/ne)");
                        dk5: d5 = Console.ReadLine();
                        if (String.Compare(d5, StringNo, ignoreCase: true) == 0)
                        {
                            goto r;
                        }
                        else if (String.Compare(d5, StringYes, ignoreCase: true) == 0)
                        {
                            int tmp6;
                            k6: Console.WriteLine("Koga zelite pronaci:(upisite broj)");
                            tmp6 = int.Parse(Console.ReadLine());


                            var FoundTuple1 = Book.Find(i => i.Item3 == tmp6);
                            if (FoundTuple1 == null)
                            {
                                Console.WriteLine("Clan nije pronaden,pokusajte ponovo");
                                goto k6;
                            }
                            else
                            {

                                Console.WriteLine("{0} - {1} - 0{2}", FoundTuple1.Item1.ToString(), FoundTuple1.Item2.ToString(), FoundTuple1.Item3);
                                goto r;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Pogresan unos,pokusajte ponovno:");
                            goto dk5;
                        }
                    }
                    break;
                case '6':
                    {
                        string d6;
                        Console.WriteLine("Jeste li sigurni da zelite pronaci clana po imenu?(da/ne)");
                        dk6: d6 = Console.ReadLine();
                        if (String.Compare(d6, StringNo, ignoreCase: true) == 0)
                        {
                            goto r;
                        }
                        else if (String.Compare(d6, StringYes, ignoreCase: true) == 0)
                        {
                            string tmp1;
                            k81: Console.WriteLine("Koga zelite pronaci:(upisite ime)");
                            tmp1 = Console.ReadLine();


                            var FoundTuple = Book.Find(s => s.Item1 == tmp1);
                            if (FoundTuple == null)
                            {
                                Console.WriteLine("Clan nije pronaden,pokusajte ponovo");
                                goto k81;
                            }
                            else
                            {
                                Console.WriteLine("{0} - {1} - 0{2}", FoundTuple.Item1.ToString(), FoundTuple.Item2.ToString(), FoundTuple.Item3);
                                goto r;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Pogresan unos,pokusajte ponovno:");
                            goto dk6;
                        }
                    }
                    break;

                case '7':
                    {
                        string d7;
                        Console.WriteLine("Jeste li sigurni da zelite ispisati sve clanove i njihove informacije?(da/ne)");
                        dk7: d7 = Console.ReadLine();
                        if (String.Compare(d7, StringNo, ignoreCase: true) == 0)
                        {
                            goto r;
                        }
                        else if (String.Compare(d7, StringYes, ignoreCase: true) == 0)
                        {
                            Console.WriteLine("\nIspis clanova adresara:");

                            foreach (var tuple in Book)
                            {
                                Console.WriteLine(" {0} \n {1} \n 0{2}  \n ", tuple.Item1.ToString(), tuple.Item2.ToString(), tuple.Item3);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Pogresan unos,pokusajte ponovno:");
                            goto dk7;
                        }
                    }

                    goto r;
                    break;

                case '8':
                    {
                        string d8;
                        Console.WriteLine("Jeste li sigurni da zelite nekoga izbrisati?(da/ne)");
                        dk8: d8 = Console.ReadLine();
                        if (String.Compare(d8, StringNo, ignoreCase: true) == 0)
                        {
                            goto r;
                        }
                        else if (String.Compare(d8, StringYes, ignoreCase: true) == 0)
                        {
                            string x8;

                            Console.WriteLine("Po cemu zelite naci clana kojeg zelite izbrisati:(ime/adresa/broj)");
                            k8: x8 = Console.ReadLine();
                            if (String.Compare(x8, StringName, ignoreCase: true) == 0)
                            {
                                string TempName;
                                kname: Console.WriteLine("Koga zelite izbaciti:(upisite ime)");
                                TempName = Console.ReadLine();


                                var FoundTuple2 = Book.Find(s => s.Item1 == TempName);
                                if (FoundTuple2 == null)
                                {
                                    Console.WriteLine("Clan nije pronaden,pokusajte ponovo");
                                    goto kname;
                                }
                                else
                                {
                                    string tmp81;
                                    Console.WriteLine("{0} - {1} - 0{2}", FoundTuple2.Item1.ToString(), FoundTuple2.Item2.ToString(), FoundTuple2.Item3);
                                    Console.WriteLine("Zelite li izbrisati ovog korisnika:(da/ne)");

                                    k811: tmp81 = Console.ReadLine();
                                    if (String.Compare(tmp81, StringYes, ignoreCase: true) == 0)
                                    {
                                        Book.RemoveAll(item => item.Item1 == TempName);
                                    }
                                    else if (String.Compare(tmp81, StringYes, ignoreCase: true) == 0)
                                    {
                                        goto r;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Pogresan unos,pokusajte ponovo");
                                        goto k811;
                                    }
                                }
                            }
                            else if (String.Compare(x8, StringAdress, ignoreCase: true) == 0)
                            {
                                string TempAdress;
                                kadress: Console.WriteLine("Koga zelite izbaciti:(upisite adresu)");
                                TempAdress = Console.ReadLine();


                                var FoundTuple3 = Book.Find(s => s.Item2 == TempAdress);
                                if (FoundTuple3 == null)
                                {
                                    Console.WriteLine("Clan nije pronaden,pokusajte ponovo");
                                    goto kadress;
                                }
                                else
                                {
                                    string tmp81;
                                    Console.WriteLine("{0} - {1} - 0{2}", FoundTuple3.Item1.ToString(), FoundTuple3.Item2.ToString(), FoundTuple3.Item3);
                                    Console.WriteLine("Zelite li izbrisati ovog korisnika:(da/ne)");

                                    k811: tmp81 = Console.ReadLine();
                                    if (String.Compare(tmp81, StringYes, ignoreCase: true) == 0)
                                    {
                                        Book.RemoveAll(item => item.Item2 == TempAdress);
                                    }
                                    else if (String.Compare(tmp81, StringYes, ignoreCase: true) == 0)
                                    {
                                        goto r;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Pogresan unos,pokusajte ponovo");
                                        goto k811;
                                    }
                                }
                            }
                            else if (String.Compare(x8, StringNumber, ignoreCase: true) == 0)
                            {
                                int TempNum;
                                knumber: Console.WriteLine("Koga zelite izbaciti:(upisite broj)");
                                TempNum = int.Parse(Console.ReadLine());


                                var FoundTuple4 = Book.Find(i => i.Item3 == TempNum);
                                if (FoundTuple4 == null)
                                {
                                    Console.WriteLine("Clan nije pronaden,pokusajte ponovo");
                                    goto knumber;
                                }
                                else
                                {
                                    string tmp81;
                                    Console.WriteLine("{0} - {1} - 0{2}", FoundTuple4.Item1.ToString(), FoundTuple4.Item2.ToString(), FoundTuple4.Item3);
                                    Console.WriteLine("Zelite li izbrisati ovog korisnika:(da/ne)");

                                    k811: tmp81 = Console.ReadLine();
                                    if (String.Compare(tmp81, StringYes, ignoreCase: true) == 0)
                                    {
                                        Book.RemoveAll(item => item.Item3 == TempNum);
                                    }
                                    else if (String.Compare(tmp81, StringYes, ignoreCase: true) == 0)
                                    {
                                        goto r;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Pogresan unos,pokusajte ponovo");
                                        goto k811;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Pogresan unos,pokusajte ponovo");
                                goto k8;
                            }


                            goto r;
                        }
                        else
                        {
                            Console.WriteLine("Pogresan unos,pokusajte ponovno:");
                            goto dk8;
                        }
                    }
                    break;

                case '9':
                    break;

                default:
                    Console.WriteLine("Nepoznat unos!\nPokusajte ponovo");

                    goto r;
                    break;

            }
        }
    }
}





