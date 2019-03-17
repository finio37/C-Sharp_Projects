using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizatorStrukturProjekt8
{
    public partial class Form1 : Form
    {
        //indexy
        public static int bs_i, bs_j;

        //granice - drzewo binarne
        public static int bs_dolna_gr;
        public static int bs_gorna_gr;
        
        public int bs_iloscw_int;
        public static string bs_duplikat;
        public static int bs_porownanie = 0;
        public static int bs_wartosc_elementu_int;
        

        public static int bs_k;
        public static bool bs_stan;
        public bs_DrzewoBinarne<int,int> bs_drzewo;
        public bs_WezelDrzewa<int, int> bs_wez;
        public static int bs_szukana_wartosc_int;
        public static int bs_element_do_skasowania;
        public bs_Lista<int> bs_lista_elementow = new bs_Lista<int>();
        public Stack<int> bs_Stos = new Stack<int>(bs_wielkosc_stosu);
        public static int bs_dolna_granica_listy_int;
        public static int bs_gorna_granica_listy_int;
        public static int bs_wylosowany_zakres;
        public static int bs_dodawany_element_int;
        public static int bs_element_do_znalezienia_int;
        public static int bs_element_do_usuniecia_int;
        public static int bs_dolna_granica_stosu_int;
        public static int bs_gorna_granica_stosu_int;
        public static int bs_element_do_dodania_do_drzewa;
        public static int bs_wielkosc_stosu;
        int[] bs_tablica_stosu = new int[100];
        public static int bs_liczba_do_polozenia_na_stosie_int;
        Random bs_element_losowy = new Random();
        
        public static int bs_zlozonosc_dla_listy_bs_czy_utworzono_liste = 0;
        public static int bs_licznik_DodajDoListy=0;
        public static int[] bs_sumy_czastkowe_dodawanie_elementu = new int[1000];
        public static int bs_licznik_zwieksz_pojemnosc=0;
        public static int bs_licznik_znajdz_element = 0;
        public static int bs_licznik_usun_element=0;
        public static int bs_srodkowy;
        
        public static List<int> bs_licznik_dodawania_do_listy = new List<int>();
        public static List<int> bs_lista_zwiekszenie_pojemnosci = new List<int>();
        public static List<int> bs_lista_licznika_znajdz_element = new List<int>();
        public static List<int> bs_lista_usun_element = new List<int>();
        public static bool[] bs_StanTabPage = { true, false, false,false };
        public static int bs_licznik_insert;
        public static List<int> bs_lista_licznika_insert = new List<int>();
        public static int bs_licznik_insert_dodanie_jednego_elementu=0;
        public static int bs_licznik_infix=0;
        public static List<int> bs_lista_infix = new List<int>();
        public static int bs_licznik_prefix = 0;
        public static List<int> bs_lista_prefix = new List<int>();
        public static int bs_licznik_postfix = 0;
        public static List<int> bs_lista_postfix = new List<int>();
        public static int bs_licznik_peek;
        public static List<int> bs_lista_peek = new List<int>();
        public static int bs_licznik_pop;
        public static List<int> bs_lista_pop = new List<int>();
        public static int bs_licznik_push;
        public static List<int> bs_lista_push = new List<int>();

        private bool bs_przycisk_wypisz_drzewo_infixowo_was_Clicked = false;
        private bool bs_przycisk_wypisz_drzewo_prefixowo_was_Clicked = false;
        private bool bs_przycisk_wypisz_drzewo_postfixowo_was_Clicked = false;
        public Form1()
        {
            InitializeComponent();
            this.SetAutoSizeMode(System.Windows.Forms.AutoSizeMode.GrowAndShrink);

            //wylaczenia minimalizacji i maksymalizacji okna
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        //klasa listy
        #region 
        
        public class bs_Lista<T>
        {
            private const int bs_domysla_pojemnosc = 4;

            private T[] bs_elementy;
           
            private int bs_rozmiar_tablicy;
            //private int _version;
            private const int MaxArrayLength=100;

            static T[] bs_pusta_tablica = new T[0];
            
           //konstruktor tworzacy pusta tablice typu T
            public bs_Lista()
            {
                bs_elementy = bs_pusta_tablica;
            }
            //konstruktor tworzacy tablice typu T o domyslnej wielkosci 
            public bs_Lista(int bs_pojemnosc)
            {

                if (bs_pojemnosc == 0)
                    bs_elementy = bs_pusta_tablica;
                else
                    bs_elementy = new T[bs_pojemnosc];
            }

            //bs_Pojemnosc - metoda ustawiajaca pojemnosc tablicy
            #region
            public int bs_Pojemnosc
            {
                get
                {

                    return bs_elementy.Length;
                }
                set
                {
                    if (value != bs_elementy.Length)
                    {
                        
                        
                        if (value > 0)
                        {
                            
                            T[] bs_nowe_elementy = new T[value];
                            if (bs_rozmiar_tablicy > 0)
                            {
                                
                                
                                Array.Copy(bs_elementy, 0, bs_nowe_elementy, 0, bs_rozmiar_tablicy);
                            }
                            bs_elementy = bs_nowe_elementy;
                        }
                        else
                        {
                            
                            bs_elementy = bs_pusta_tablica;
                        }
                    }
                }
            }
            #endregion
            //metoda zwracajaca komunikat czy utworzono liste
            public string bs_czy_utworzono_liste(int bs_wielkosc)
            {
                string bs_komunikat = "";

                bs_komunikat = "Utworzono liste.Ilosc: " + bs_wielkosc.ToString();
                
                return bs_komunikat;
            }
           
            public int bs_ilosc_elementow
            {
                get
                {

                    return bs_rozmiar_tablicy;
                }
            }
            //definicja indeksatora        
            public T this[int index]
            {
                get
                {

                    return bs_elementy[index];
                }

                set
                {

                    bs_elementy[index] = value;
                    //_version++;
                }
            }
            //dodawanie elementow typu T do listy
            public void bs_DodajElementDoListy(T bs_element)
            {
                //zwiekszenie pojemnosci tablicy
                if (bs_rozmiar_tablicy == bs_elementy.Length) bs_zwieksz_pojemnosc(bs_rozmiar_tablicy + 1);
                for (int bs_i = 0; bs_i < bs_elementy.Length; bs_i++)
                {

                    bs_licznik_DodajDoListy = bs_licznik_DodajDoListy + 1;
                    bs_licznik_dodawania_do_listy.Add(bs_licznik_DodajDoListy);
                    
                }
                //dodanie zadanego elementu typu T na koncu listy
                bs_elementy[bs_rozmiar_tablicy++] = bs_element;
                //_version++;
            }
           
            //tutaj odbywa się zwiekszanie pojemnosci tablicy typu T
            private void bs_zwieksz_pojemnosc(int bs_min)
            {
                
                if (bs_elementy.Length < bs_min)
                {
                    bs_licznik_zwieksz_pojemnosc += 1;
                    bs_lista_zwiekszenie_pojemnosci.Add(bs_licznik_zwieksz_pojemnosc);
                    int bs_nowa_pojemnosc = bs_elementy.Length == 0 ? bs_domysla_pojemnosc : bs_elementy.Length * 2;

                    if ((uint)bs_nowa_pojemnosc > MaxArrayLength)
                    {
                        bs_licznik_zwieksz_pojemnosc += 1;
                        bs_lista_zwiekszenie_pojemnosci.Add(bs_licznik_zwieksz_pojemnosc);
                        bs_nowa_pojemnosc = MaxArrayLength; 
                    }
                    if (bs_nowa_pojemnosc < bs_min)
                    {
                        bs_licznik_zwieksz_pojemnosc += 1;
                        bs_lista_zwiekszenie_pojemnosci.Add(bs_licznik_zwieksz_pojemnosc);
                        bs_nowa_pojemnosc = bs_min; 
                    }
                    bs_Pojemnosc = bs_nowa_pojemnosc;
                }
            }
            
            #region
            //tu odbywa się wyszukiwanie elementu tablicy
            public T bs_Znajdz_Element(Predicate<T> match)
            {

                
                for (int i = 0; i < bs_rozmiar_tablicy; i++)
                {
                    bs_licznik_znajdz_element += 1;
                   
                    if (match(bs_elementy[i]))
                    {
                        bs_licznik_znajdz_element += 1;
                        
                        return bs_elementy[i];
                    }
                }
                return default(T);
            }
            #endregion








            public int bs_index_listy(T bs_element)
            {
                return Array.IndexOf(bs_elementy, bs_element, 0, bs_rozmiar_tablicy);
            }
            //usuwanie elementu typu T tablicy
            public bool bs_usun_element(T bs_element)
            {
                int bs_index = bs_index_listy(bs_element);
                if (bs_index >= 0)
                {
                    bs_licznik_usun_element++;
                    bs_lista_usun_element.Add(bs_licznik_usun_element);
                    bs_usun_przy(bs_index);
                    return true;
                }

                return false;
            }

             
            
            public void bs_usun_przy(int bs_index)
            {
                
                bs_rozmiar_tablicy--;
                if (bs_index < bs_rozmiar_tablicy)
                {
                    bs_licznik_usun_element++;

                    Array.Copy(bs_elementy, bs_index + 1, bs_elementy, bs_index, bs_rozmiar_tablicy - bs_index);
                }
                bs_elementy[bs_rozmiar_tablicy] = default(T);
                //_version++;
            }
            

            
            public void Sort()
            {
                Sort(0, bs_ilosc_elementow, null);
            }

            
            public void Sort(IComparer<T> comparer)
            {
                Sort(0, bs_ilosc_elementow, comparer);
            }

             
            public void Sort(int index, int count, IComparer<T> comparer)
            {

                Array.Sort<T>(bs_elementy, index, count, comparer);
                //_version++;
            }

            
           
        }
        #endregion
        //klasa stosu
        #region
        public class Stack<T> 
        {
            //definicja tablicy typu T i jej rozmiaru
            private T[] bs_tablica_typu_T;     
            private int bs_rozmiar_tablicy;           
            

            

            private const int bs_domyslna_pojemnosc = 4;
            static T[] bs_pusta_tablica = new T[0];

            //konstruujemy pusta tablice
            public Stack()
            {
                bs_tablica_typu_T = bs_pusta_tablica;
                bs_rozmiar_tablicy = 0;
             
            }

            //konstruujemy tablice typu T o domyslnej pojemnosci
            public Stack(int bs_pojemnosc)
            {

                bs_tablica_typu_T = new T[bs_pojemnosc];
                bs_rozmiar_tablicy = 0;
              
            }

            
            public int bs_ilosc
            {
                get { return bs_rozmiar_tablicy; }
            }

           
            public void Clear()
            {
                Array.Clear(bs_tablica_typu_T, 0, bs_rozmiar_tablicy); // Don't need to doc this but we clear the elements so that the gc can reclaim the references.
                bs_rozmiar_tablicy = 0;
               
            }
            public string bs_czy_utworzono_stos(int wielkosc)
            {
                string bs_komunikat = "";

                bs_komunikat = "Utworzono stos.Ilosc: " + wielkosc.ToString();
                return bs_komunikat;
            }
            

           
            public void CopyTo(T[] array, int arrayIndex)
            {
                

                Array.Copy(bs_tablica_typu_T, 0, array, arrayIndex, bs_rozmiar_tablicy);
                Array.Reverse(array, arrayIndex, bs_rozmiar_tablicy);
            }

            
            public T Peek()
            {

                bs_licznik_peek++;
                for (int bs_i = 0; bs_i < bs_tablica_typu_T.Length; bs_i++)
                {
                    bs_lista_peek.Add(bs_licznik_peek);
                }
                return bs_tablica_typu_T[bs_rozmiar_tablicy - 1];
            }

            
            public T Pop()
            {
                bs_licznik_pop++;
              
                T bs_element = bs_tablica_typu_T[--bs_rozmiar_tablicy];

                bs_tablica_typu_T[bs_rozmiar_tablicy] = default(T);     
                return bs_element;
            }

            
            public void Push(T bs_element)
            {
                if (bs_rozmiar_tablicy == bs_tablica_typu_T.Length)
                {
                    bs_licznik_push++;
                    for (int bs_i = 0; bs_i < bs_tablica_typu_T.Length; bs_i++)
                    {
                        bs_lista_push.Add(bs_licznik_push);
                    }
                    T[] newArray = new T[(bs_tablica_typu_T.Length == 0) ? bs_domyslna_pojemnosc : 2 * bs_tablica_typu_T.Length];
                    Array.Copy(bs_tablica_typu_T, 0, newArray, 0, bs_rozmiar_tablicy);
                    bs_tablica_typu_T = newArray;
                }

                bs_tablica_typu_T[bs_rozmiar_tablicy++] = bs_element;
                bs_licznik_push++;
                for (int bs_i = 0; bs_i < bs_tablica_typu_T.Length; bs_i++)
                {
                    bs_lista_push.Add(bs_licznik_push);
                }
                
            }

            
       }
        #endregion
        //klasa wezel drzewa
        
        #region

        public class bs_WezelDrzewa<BT,TV>  where BT:struct,IComparable<BT>
        {
            public BT bs_Dane { get; set; }
            public TV bs_wartosc { get; set; }
            public bs_WezelDrzewa<BT, TV> bs_Lewa_Galaz;
            public bs_WezelDrzewa<BT, TV> bs_Prawa_Galaz;
            
            
            public bs_WezelDrzewa() { }
            public bs_WezelDrzewa(BT bs_dane)
            {
                if (typeof(BT).Equals(typeof(Int32)))
                {
                    bs_Dane = bs_dane;
                    
                }
            }
            public bs_WezelDrzewa(BT bs_dane,TV v)
            {
                
                if (typeof(BT).Equals(typeof(Int32)))
                {
                    bs_Dane = bs_dane;
                    bs_wartosc = v;
                }

            }
            
            
            
           
        }
        public class bs_DrzewoBinarne<BT,TV> where BT : struct,IComparable<BT>
        {
            private bs_WezelDrzewa<BT, TV> bs_korzen_drzewa;
            public int bs_licznik_elementow;
            public bs_DrzewoBinarne()
            {
                bs_korzen_drzewa = null;
            }
            public bs_DrzewoBinarne(BT bs_wartosc_korzenia)
            {
                if (typeof(BT).Equals(typeof(Int32)))
                {
                    bs_korzen_drzewa = bs_utworz_wezel(bs_wartosc_korzenia);
                }
            }
            
            private static bs_WezelDrzewa<BT,TV> bs_utworz_wezel(BT bs_dane)
            {
                bs_WezelDrzewa<BT,TV> bs_wezel = new bs_WezelDrzewa<BT,TV>();

                bs_wezel.bs_Dane = bs_dane;
                return bs_wezel;
            }
           
            public void insert(BT bs_dane)
            {
                bs_WezelDrzewa<BT,TV> bs_bierzacy = bs_korzen_drzewa;
                bs_WezelDrzewa<BT,TV> bs_nastepny = bs_korzen_drzewa;



                while (!(bs_bierzacy == null))
                {
                    bs_licznik_insert++;
                    bs_lista_licznika_insert.Add(bs_licznik_insert);
                    bs_nastepny = bs_bierzacy;
                    bs_porownanie = bs_bierzacy.bs_Dane.CompareTo(bs_dane);
                    bs_bierzacy = bs_porownanie < 0 ? bs_bierzacy.bs_Prawa_Galaz : bs_bierzacy.bs_Lewa_Galaz;

                   
                }

                if (bs_porownanie == 0)
                {
                    bs_licznik_insert++;
                    bs_lista_licznika_insert.Add(bs_licznik_insert);

                    bs_duplikat = "Wystapil duplikat, ktory nie bedzie dodany";
                }
                else
                    if (bs_porownanie < 0)
                    {
                        bs_licznik_insert++;
                        bs_lista_licznika_insert.Add(bs_licznik_insert);
                        bs_nastepny.bs_Prawa_Galaz = bs_utworz_wezel(bs_dane);
                    }
                    else
                    {
                        bs_licznik_insert++;
                        bs_lista_licznika_insert.Add(bs_licznik_insert);
                        bs_nastepny.bs_Lewa_Galaz = bs_utworz_wezel(bs_dane);
                    }

                
            }
            public string bs_Insert(BT bs_wartosc)
            {
                string bs_czy_dodano = "";
                bs_WezelDrzewa<BT, TV> bs_wezel = new bs_WezelDrzewa<BT, TV>(bs_wartosc);
                bs_czy_dodano=bs_Insert(bs_wezel);
                return bs_czy_dodano;
            }
            public string bs_Insert(bs_WezelDrzewa<BT,TV> bs_wezel)
            {
                
                string bs_czy_dodano = "";
                if (bs_wezel == null)
                {
                    bs_licznik_insert_dodanie_jednego_elementu++;
                    bs_czy_dodano = "Nie dodano elementu";
                }
                else if (bs_korzen_drzewa == null)
                {
                    bs_licznik_insert_dodanie_jednego_elementu++;
                    bs_korzen_drzewa = bs_wezel;
                    bs_czy_dodano = "Korzen byl pusty.Dodano jeden element";
                }
                else 
                {
                    bs_licznik_insert_dodanie_jednego_elementu++;
                    bs_Insert(bs_wezel,ref bs_korzen_drzewa);
                    bs_czy_dodano = "Korzen nie byl pusty. Dodano element";
                }
                return bs_czy_dodano;

            }
            private void bs_Insert(bs_WezelDrzewa<BT,TV> bs_wezel,ref bs_WezelDrzewa<BT,TV> bs_rodzic)
            {
                if (bs_rodzic == null)
                {
                    bs_rodzic = bs_wezel;
                }
                else
                {
                    if (bs_wezel.bs_Dane.CompareTo(bs_rodzic.bs_Dane) < 0)
                    {
                        bs_Insert(bs_wezel,ref bs_rodzic.bs_Lewa_Galaz);
                    }
                    else if (bs_wezel.bs_Dane.CompareTo(bs_rodzic.bs_Dane) > 0)
                    {
                        bs_Insert(bs_wezel,ref bs_rodzic.bs_Prawa_Galaz);
                    }
                    
                }
            }
           
            private string bs_wypisz_drzewo_infix(bs_WezelDrzewa<BT,TV> bs_wezel)
            {
                
                string bs_wynik = "";
                if (bs_wezel != null)
                {
                    bs_licznik_infix++;
                    
                    bs_wynik += bs_wypisz_drzewo_infix(bs_wezel.bs_Lewa_Galaz);
                    
                    bs_wynik += Convert.ToString(bs_wezel.bs_Dane);
                    
                    bs_wynik += bs_wypisz_drzewo_infix(bs_wezel.bs_Prawa_Galaz);
                    

                }
                for (int bs_i = 0; bs_i <= 10; bs_i++)
                {
                    bs_lista_infix.Add(bs_licznik_infix);
                }
                    return bs_wynik;
            }
            public string bs_wypisz_drzewo_binarne_infixowo()
            {
                string bs_wynik = "";
                bs_wynik += bs_wypisz_drzewo_infix(bs_korzen_drzewa);
                return bs_wynik;
            }
            private string bs_wypisz_drzewo_pref(bs_WezelDrzewa<BT,TV> bs_wezel)
            {
                string bs_wynik = "";
                if ((bs_wezel != null))
                {
                    bs_licznik_prefix++;
                    
                    bs_wynik += Convert.ToString(bs_wezel.bs_Dane);
                    bs_wynik += bs_wypisz_drzewo_pref(bs_wezel.bs_Lewa_Galaz);
                   
                    bs_wynik += bs_wypisz_drzewo_pref(bs_wezel.bs_Prawa_Galaz);
                }
                for (int bs_i = 0; bs_i <= 10; bs_i++)
                {
                    bs_lista_prefix.Add(bs_licznik_prefix);
                }
                    return bs_wynik;

            }
            public string bs_wypisz_drzewo_prefixowo()
            {
                string bs_wynik = "";
                bs_wynik += bs_wypisz_drzewo_pref(bs_korzen_drzewa);
                return bs_wynik;
            }
            private string bs_wypisz_drzewo_postfix(bs_WezelDrzewa<BT,TV> bs_wezel)
            {
                string bs_wynik = "";
                if ((bs_wezel != null))
                {
                    bs_licznik_postfix++;
                    bs_wynik += bs_wypisz_drzewo_postfix(bs_wezel.bs_Lewa_Galaz);
                    
                    bs_wynik += bs_wypisz_drzewo_postfix(bs_wezel.bs_Prawa_Galaz);
                    bs_wynik += Convert.ToString(bs_wezel.bs_Dane);
                }
                for (int bs_i = 0; bs_i <= 10; bs_i++)
                {
                    bs_lista_postfix.Add(bs_licznik_postfix);
                }
                    return bs_wynik;
            }
            public string bs_wypisz_drzewo_postfixowo()
            {
                string bs_wynik = "";
                bs_wynik += bs_wypisz_drzewo_postfix(bs_korzen_drzewa);
               
                return bs_wynik;
            }
            private bs_WezelDrzewa<BT,TV> bs_znajdz(BT key,bool Ex = true)
            {
                bs_WezelDrzewa<BT,TV> bierz = bs_korzen_drzewa;
                while (bierz != null)
                {
                    int compare = bierz.bs_Dane.CompareTo(key);
                    if (compare == 0)
                        return bierz;
                    else if (compare < 0)
                        bierz = bierz.bs_Prawa_Galaz;
                    else
                        bierz = bierz.bs_Lewa_Galaz;
                }
                if (Ex == true)
                {
                    throw new KeyNotFoundException();
                }
                else return null;
            }
            
            public string bs_wypisz_komunikat(BT bs_szukana)
            {
                string bs_czy_znaleziono = "";
               
                var w = bs_znajdz(bs_szukana,false);
                
               
                if (w == null)
                {
                    bs_czy_znaleziono = "Nie ma takiego elementu";
                }
                else
                {
                    bs_czy_znaleziono = "Znaleziono element.Ten element to:  "+bs_szukana_wartosc_int.ToString();
                }
                   
                return bs_czy_znaleziono;
            }
            public bs_WezelDrzewa<BT, TV> FindMin(bs_WezelDrzewa<BT, TV> bs_wezel)
            {

                return FindMin(bs_korzen_drzewa);

            } 
            
        }
        #endregion
        //metody obslugujace zdarzenie click
        #region
        //metoda tworzaca drzewo binarne
        private void bs_utworz_drzewo_binarne_Click(object sender, EventArgs e)
        {
            
            try
            {
                bs_dolna_gr = Convert.ToInt32(bs_dolna_granica_txb.Text);
                bs_gorna_gr = Convert.ToInt32(bs_gorna_granica_tbx.Text);
                bs_iloscw_int = Convert.ToInt32(bs_ilosc_wezlow_tbx.Text);

                bs_drzewo = new bs_DrzewoBinarne<int, int>(bs_iloscw_int);
                for (bs_i = 0; bs_i <= 10; bs_i++)
                {
                    bs_j = bs_element_losowy.Next(bs_dolna_gr, bs_gorna_gr);
                    bs_drzewo.insert(bs_j);

                }
                bs_drzewo_komunikat_czy_utworzono.Text = "Drzewo zostało utworzone";
                bs_wypisz_infixowo.Enabled = true;
                bs_wypisz_drzewo_prefixowo.Enabled = true;
                bs_drzewo_postfixowo.Enabled = true;
                bs_odszukaj_element.Enabled = true;
                bs_dodaj_element_do_drzewa.Enabled = true;
                bs_szukana_wartosc.Enabled = true;
                bs_dodaj_element_txb.Enabled = true;
                bs_utworz_drzewo_binarne.Enabled = false;
                
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_dolna_granica_txb,"Wypełnij wszystkie trzy pola");
                return;
            }
        }
        
        private void bs_wypisz_infixowo_Click(object sender, EventArgs e)
        {
            bs_przycisk_wypisz_drzewo_infixowo_was_Clicked = true;
            
            bs_wynik_drzewa.Text = bs_drzewo.bs_wypisz_drzewo_binarne_infixowo();
            
        }

        private void bs_wypisz_drzewo_prefixowo_Click(object sender, EventArgs e)
        {
            bs_przycisk_wypisz_drzewo_prefixowo_was_Clicked = true;
            bs_wynik_drzewa.Text = bs_drzewo.bs_wypisz_drzewo_prefixowo();
        }

        private void bs_drzewo_postfixowo_Click(object sender, EventArgs e)
        {
            bs_przycisk_wypisz_drzewo_postfixowo_was_Clicked = true;
            bs_wynik_drzewa.Text = bs_drzewo.bs_wypisz_drzewo_postfixowo();
        }
        //metoda szukania elementu w drzewie binarnym
        private void bs_odszukaj_element_Click(object sender, EventArgs e)
        {
            try
            {
                bs_szukana_wartosc_int = Convert.ToInt32(bs_szukana_wartosc.Text);
                bs_znaleziona_wartosc.Text = bs_drzewo.bs_wypisz_komunikat(bs_szukana_wartosc_int);
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_szukana_wartosc,"Pole nie moze byc puste");
                return;
            }
        }

        private void bs_skasuj_elbst_Click(object sender, EventArgs e)
        {
           
            
        }
        //metoda tworzenia listy
        private void bs_utworz_liste_Click(object sender, EventArgs e)
        {
            try
            {
                bs_dolna_granica_listy_int = Convert.ToInt32(bs_dolna_granica_listy.Text);
                bs_gorna_granica_listy_int = Convert.ToInt32(bs_gorna_granica_listy.Text);
                bs_wylosowany_zakres = bs_element_losowy.Next(bs_dolna_granica_listy_int, bs_gorna_granica_listy_int);
                bs_lista_elementow = new bs_Lista<int>(bs_wylosowany_zakres);
                bs_komunikat_o_utworzeniu.Text = bs_lista_elementow.bs_czy_utworzono_liste(bs_wylosowany_zakres);
                for (int bs_i = 0; bs_i < bs_wylosowany_zakres; bs_i++)
                {
                    bs_k = bs_element_losowy.Next(bs_dolna_granica_listy_int, bs_gorna_granica_listy_int);
                    bs_lista_elementow.bs_DodajElementDoListy(bs_k);
                    bs_wyswietlenie_elementow_listy.Text += bs_lista_elementow[bs_i].ToString();
                }
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_dolna_granica_listy, "Pola dolnej i górnej granicy nie mogą być puste");
                return;
            }
        }
        //dodanie elementu do listy
        private void bs_dodaj_element_Click(object sender, EventArgs e)
        {
            bs_wyswietlenie_elementow_listy.Text = "";
            try
            {
                bs_dodawany_element_int = Convert.ToInt32(bs_element_do_dodania_txb.Text);
                bs_lista_elementow.bs_DodajElementDoListy(bs_dodawany_element_int);
                for (bs_i = 0; bs_i < bs_lista_elementow.bs_ilosc_elementow; bs_i++)
                {
                    bs_wyswietlenie_elementow_listy.Text += bs_lista_elementow[bs_i].ToString();

                }
                bs_czy_dodano.Text = "Dodano element";
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_element_do_dodania_txb,"Pole nie moze byc puste");
                return;
            }
        }
        //moteda przeszukaj liste
        private void bs_przeszukaj_liste_Click(object sender, EventArgs e)
        {
            try
            {
                bs_element_do_znalezienia_int = Convert.ToInt32(bs_element_do_znalezienia_txb.Text);
                bs_czy_znaleziono.Text = "";
                int bs_wynik_int;
                bs_wyswietlenie_znalezionego_elementu.Text = bs_lista_elementow.bs_Znajdz_Element(x => x == bs_element_do_znalezienia_int).ToString();
                bs_wynik_int = Convert.ToInt32(bs_wyswietlenie_znalezionego_elementu.Text);
                if (bs_wynik_int == 0)
                {
                    bs_czy_znaleziono.Text = "Nie znaleziono";
                    bs_wyswietlenie_znalezionego_elementu.Text = "";
                }
                else
                {
                    bs_czy_znaleziono.Text = "Znaleziono";
                }
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_element_do_znalezienia_txb,"Pole nie może być puste");
                return;
            }
        }
        //moteda isEmpty - czy lista jest pusta
        private void bs_isEmpty_Click(object sender, EventArgs e)
        {
            czy_jest_pusta_lbl.Text = "";
            if (bs_lista_elementow.bs_ilosc_elementow != 0)
            {
                czy_jest_pusta_lbl.Text = "Zawiera elementy";
            }
            else if (bs_lista_elementow.bs_ilosc_elementow == 0)
            {
                czy_jest_pusta_lbl.Text = "Jest pusta";
            }
        }
        //metoda sortowania listy
        private void bs_posortuj_Click(object sender, EventArgs e)
        {
            try
            {
                bs_wyswietlenie_elementow_listy.Text = "";
                bs_lista_elementow.Sort();
                for (int bs_i = 0; bs_i < bs_lista_elementow.bs_ilosc_elementow; bs_i++)
                {
                    bs_wyswietlenie_elementow_listy.Text += bs_lista_elementow[bs_i].ToString();
                }
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_wyswietlenie_elementow_listy,"Pole nie może być puste");
                return;
            }
            

        }
        //metoda usuwania elementu listy
        private void bs_usun_element_Click(object sender, EventArgs e)
        {
            bs_wyswietlenie_elementow_listy.Text = "";
            try
            {
                bs_element_do_usuniecia_int = Convert.ToInt32(bs_element_do_usuniecia_txb.Text);
                bs_lista_elementow.bs_usun_element(bs_element_do_usuniecia_int);
                bs_komunikat_o_usunieciu.Text = "Element usunieto";
                for (bs_i = 0; bs_i < bs_lista_elementow.bs_ilosc_elementow; bs_i++)
                {
                    bs_wyswietlenie_elementow_listy.Text += bs_lista_elementow[bs_i].ToString();

                }
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_element_do_usuniecia_txb,"Pole nie moze być puste");
                return;
            }
        }
        //metoda tworzaca stos
        private void bs_utworz_stos_Click(object sender, EventArgs e)
        {
            int bs_wylosowany_element_stosu;

            try
            {
                
                bs_dolna_granica_stosu_int = Convert.ToInt32(bs_dolna_granica_stosu_txb.Text);
                bs_gorna_granica_stosu_int = Convert.ToInt32(bs_gorna_granica_stosu_txb.Text);
                bs_wielkosc_stosu = bs_element_losowy.Next(bs_dolna_granica_stosu_int, bs_gorna_granica_stosu_int);


                bs_komunikat_o_utworzeniu_stosu.Text = bs_Stos.bs_czy_utworzono_stos(bs_wielkosc_stosu);
                for (int bs_i = 0; bs_i < bs_wielkosc_stosu; bs_i++)
                {
                    bs_wylosowany_element_stosu = bs_element_losowy.Next(bs_dolna_granica_stosu_int, bs_gorna_granica_stosu_int);
                    bs_Stos.Push(bs_wylosowany_element_stosu);
                    bs_Stos.CopyTo(bs_tablica_stosu, bs_i);
                    bs_wyswietl_stos.Text += bs_tablica_stosu[bs_i].ToString();

                }
                bs_usun_element_ze_stosu.Enabled = true;
                bs_czy_stos_jest_pusty.Enabled = true;
                bs_dodaj_do_stosu.Enabled = true;
                bs_odczytaj_wierzcholek_stosu.Enabled = true;
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_dolna_granica_stosu_txb,"Pola dolnej i górnej granicy stosu nie mogą być puste");
                return;
            }
        }
        //metoda dodajaca element do stosu
        private void bs_dodaj_do_stosu_Click(object sender, EventArgs e)
        {
            
            bs_komunikat_czy_dodano_do_stosu.Text = "";
            try
            {
                bs_liczba_do_polozenia_na_stosie_int = Convert.ToInt32(bs_liczba_do_polozenia_na_stosie.Text);

                bs_Stos.Push(bs_liczba_do_polozenia_na_stosie_int);
                bs_Stos.CopyTo(bs_tablica_stosu, bs_Stos.bs_ilosc);
                bs_komunikat_czy_dodano_do_stosu.Text = "Dodano liczbę";
                bs_wyswietl_stos.Text += bs_tablica_stosu[bs_Stos.bs_ilosc].ToString();
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_liczba_do_polozenia_na_stosie,"Pole nie może być puste");
                return;
            }
         
        }
        //metoda usuwajaca element ze stosu
        private void bs_usun_element_ze_stosu_Click(object sender, EventArgs e)
        {
            bs_wyswietl_stos.Text = "";
            bs_komunikat_czy_usunieto_ze_stosu.Text = "";
            
                bs_Stos.Pop();

                bs_komunikat_czy_usunieto_ze_stosu.Text = "Usunieto";
                for (int bs_i = 0; bs_i < bs_Stos.bs_ilosc; bs_i++)
                {

                    bs_wyswietl_stos.Text += bs_tablica_stosu[bs_i].ToString();

                }
                if (bs_Stos.bs_ilosc == 0)
                {
                    bs_usun_element_ze_stosu.Enabled = false;
                    bs_czy_stos_jest_pusty.Enabled = false;
                    bs_dodaj_do_stosu.Enabled = false;
                    bs_odczytaj_wierzcholek_stosu.Enabled = false;
                }
          
        }
        //metoda odczytujaca wierzcholek stosu
        private void bs_odczytaj_wierzcholek_stosu_Click(object sender, EventArgs e)
        {
            bs_komunikat_odczytania_stosu.Text = "";
            int bs_odczytana_wartosc;
            bs_odczytana_wartosc=bs_Stos.Peek();
            
            bs_komunikat_odczytania_stosu.Text = "Odczytano: " + bs_odczytana_wartosc.ToString();

        }
        //metoda isEmpty - czy stos jest pusty
        private void bs_czy_stos_jest_pusty_Click(object sender, EventArgs e)
        {
            bs_komunikat_czy_stos_jest_pusty.Text = "";
            if (!(bs_Stos.bs_ilosc == 0))
            {
                bs_komunikat_czy_stos_jest_pusty.Text = "Jest pełny";
            }
            else
            {
                bs_komunikat_czy_stos_jest_pusty.Text = "Jest pusty";
            }
        }
        //prezentacja zlozonosci obliczeniowej listy
        private void bs_prezentacja_zlozonosci_Click(object sender, EventArgs e)
        {
            try
            {
                bs_wykresy_zlozonosci_listy.Series["bs_index"].Points.Clear();
                bs_wykresy_zlozonosci_listy.Series["bs_dodawanie"].Points.Clear();
                bs_wykresy_zlozonosci_listy.Series["bs_znajdywanie"].Points.Clear();
                bs_wykresy_zlozonosci_listy.Series["bs_usuwanie"].Points.Clear();
                bs_panel_lista_operacje.Visible = false;
                bs_panel_lista_prezentacja.Visible = true;
                for (int bs_i = 0; bs_i < bs_lista_elementow.bs_ilosc_elementow; bs_i++)
                {
                    int bs_y = bs_i;
                    bs_tabela_listy_grid.Rows.Add();
                    bs_tabela_listy_grid.Rows[bs_i].Cells[0].Value = bs_i;
                    bs_wykresy_zlozonosci_listy.Series["bs_index"].Points.AddXY(bs_i, bs_y);

                    bs_y = bs_licznik_dodawania_do_listy[bs_i];
                    bs_tabela_listy_grid.Rows.Add();
                    bs_tabela_listy_grid.Rows[bs_i].Cells[1].Value = bs_licznik_dodawania_do_listy[bs_i].ToString();
                    bs_wykresy_zlozonosci_listy.Series["bs_dodawanie"].Points.AddXY(bs_licznik_dodawania_do_listy[bs_i], bs_y);


                    bs_tabela_listy_grid.Rows.Add();
                    bs_tabela_listy_grid.Rows[bs_i].Cells[2].Value = bs_licznik_znajdz_element.ToString();
                    bs_wykresy_zlozonosci_listy.Series["bs_znajdywanie"].Points.AddXY(bs_i, bs_licznik_znajdz_element);

                    bs_tabela_listy_grid.Rows.Add();
                    bs_tabela_listy_grid.Rows[bs_i].Cells[3].Value = bs_licznik_usun_element.ToString();
                    bs_wykresy_zlozonosci_listy.Series["bs_usuwanie"].Points.AddXY(bs_i, bs_licznik_usun_element);
                }
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_komunikat_lista,"Aby zobaczyc wyniki, wykonaj wszystkie opcje");
                return;
            }
        }

        private void bs_powrot_do_operacji_Click(object sender, EventArgs e)
        {
            bs_panel_lista_operacje.Visible = true;
            bs_panel_lista_prezentacja.Visible = false;
        }
        //metoda dodawania elementu do drzewa
        private void bs_dodaj_element_do_drzewa_Click(object sender, EventArgs e)
        {
            try
            {
                bs_element_do_dodania_do_drzewa = Convert.ToInt32(bs_dodaj_element_txb.Text);
                bs_informacja_czy_dodano_element_do_drzewa.Text = bs_drzewo.bs_Insert(bs_element_do_dodania_do_drzewa);
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_dodaj_element_txb,"Pole nie może być puste");
                return;
            }


        }

        #endregion

        
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabControl1.TabPages[0])
            {
                e.Cancel = true;
            }
            else if (e.TabPage == tabControl1.TabPages[1])
            {
                if (bs_StanTabPage[1])
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (e.TabPage == tabControl1.TabPages[2])
            {
                if (bs_StanTabPage[2])
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (e.TabPage == tabControl1.TabPages[3])
            {
                if (bs_StanTabPage[3])
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void bs_rdb_drzewo_binarne_CheckedChanged(object sender, EventArgs e)
        {
            bs_StanTabPage[3] = false;
            bs_StanTabPage[2] = false;
            bs_StanTabPage[1] = true;
            bs_StanTabPage[0] = false;


            //bs_nowa_wyplata.Visible = false;
            tabControl1.SelectedTab = bs_drzewo_binarne;
        }

        private void bs_rdb_stos_CheckedChanged(object sender, EventArgs e)
        {
            bs_StanTabPage[3] = false;
            bs_StanTabPage[2] = true;
            bs_StanTabPage[1] = false;
            bs_StanTabPage[0] = false;
            tabControl1.SelectedTab = bs_stos;
        }

        private void bs_rdb_lista_jednokierunkowa_CheckedChanged(object sender, EventArgs e)
        {
            bs_StanTabPage[3] = true;
            bs_StanTabPage[2] = false;
            bs_StanTabPage[1] = false;
            bs_StanTabPage[0] = false;

            tabControl1.SelectedTab = bs_lista;
        }

        private void bs_dolna_granica_listy_TextChanged(object sender, EventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_dolna_granica_listy_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_gorna_granica_listy_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_element_do_dodania_txb_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_element_do_znalezienia_txb_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_element_do_usuniecia_txb_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_dolna_granica_stosu_txb_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_gorna_granica_stosu_txb_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_liczba_do_polozenia_na_stosie_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }
        //prezentacja zlozonosci stosu
        private void bs_prezentacja_zlozonosci_algorytmow_stosu_Click(object sender, EventArgs e)
        {
            try
            {
                bs_stos_wykres.Series["bs_index_stos"].Points.Clear();
                bs_stos_wykres.Series["bs_dodawanie"].Points.Clear();
                bs_stos_wykres.Series["bs_znajdywanie"].Points.Clear();
                bs_stos_wykres.Series["bs_usuwanie"].Points.Clear();
                bs_panel_operacje_na_stosie.Visible = false;
                bs_panel_stos_prezentacja.Visible = true;
                for (int bs_i = 0; bs_i < bs_Stos.bs_ilosc; bs_i++)
                {
                    int bs_y = bs_i;
                    bs_stos_tabela.Rows.Add();
                    bs_stos_tabela.Rows[bs_i].Cells[0].Value = bs_i.ToString();
                    bs_stos_wykres.Series["bs_index_stos"].Points.AddXY(bs_i, bs_y);


                    bs_stos_tabela.Rows.Add();
                    bs_stos_tabela.Rows[bs_i].Cells[1].Value = bs_lista_peek[bs_i].ToString();
                    bs_stos_wykres.Series["bs_dodawanie"].Points.AddXY(bs_i, bs_lista_peek[bs_i]);

                    bs_stos_tabela.Rows.Add();
                    bs_stos_tabela.Rows[bs_i].Cells[2].Value = bs_licznik_pop.ToString();
                    bs_stos_wykres.Series["bs_znajdywanie"].Points.AddXY(bs_i, bs_licznik_pop);

                    bs_y = bs_lista_push[bs_i];
                    bs_stos_tabela.Rows.Add();
                    bs_stos_tabela.Rows[bs_i].Cells[3].Value = bs_lista_push[bs_i].ToString();
                    bs_stos_wykres.Series["bs_usuwanie"].Points.AddXY(bs_i, bs_y);
                }
                //bs_komunikat_o_utworzeniu_stosu.Visible = false;
                // bs_komunikat_czy_dodano_do_stosu.Visible = false;
                // bs_komunikat_czy_usunieto_ze_stosu.Visible = false;
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_komunikat_stos,"Najpierw zastosuj wszystkie opcje");
                return;
            }
        }

        private void bs_powrot_do_operacj_na_stosie_Click(object sender, EventArgs e)
        {
            bs_panel_operacje_na_stosie.Visible = true;
            bs_panel_stos_prezentacja.Visible = false;
        }

        private void bs_prezentacja_zlozonosci_drzewo_Click(object sender, EventArgs e)
        {
            /*if ((bs_przycisk_wypisz_drzewo_infixowo_was_Clicked == true) && (bs_przycisk_wypisz_drzewo_prefixowo_was_Clicked == true) && (bs_przycisk_wypisz_drzewo_postfixowo_was_Clicked == true))
            {
                bs_prezentacja_zlozonosci_drzewo.Enabled = true;
            }
            else
            {
                bs_prezentacja_zlozonosci_drzewo.Enabled = false;
            }*/
            try
            {
                bs_drzewo_panel_operacje.Visible = false;
                bs_drzewo_panel_prezentacja.Visible = true;
                for (bs_i = 0; bs_i <= 10; bs_i++)
                {

                    int bs_y = bs_i;
                    bs_tabela_grid_drzewo.Rows.Add();
                    bs_tabela_grid_drzewo.Rows[bs_i].Cells[0].Value = bs_i.ToString();
                    bs_wykres_drzewo.Series["bs_index"].Points.AddXY(bs_i, bs_y);

                    bs_y = bs_lista_licznika_insert[bs_i];
                    bs_tabela_grid_drzewo.Rows.Add();
                    bs_tabela_grid_drzewo.Rows[bs_i].Cells[1].Value = bs_lista_licznika_insert[bs_i].ToString();
                    bs_wykres_drzewo.Series["bs_insert_drzewo"].Points.AddXY(bs_lista_licznika_insert[bs_i], bs_y);

                    bs_y = bs_licznik_insert_dodanie_jednego_elementu;
                    bs_tabela_grid_drzewo.Rows.Add();
                    bs_tabela_grid_drzewo.Rows[bs_i].Cells[2].Value = bs_licznik_insert_dodanie_jednego_elementu.ToString();
                    bs_wykres_drzewo.Series["bs_dodanie_elementu"].Points.AddXY(bs_i, bs_y);


                    //bs_y = bs_lista_infix[bs_i];
                    bs_tabela_grid_drzewo.Rows.Add();
                    bs_tabela_grid_drzewo.Rows[bs_i].Cells[3].Value = bs_lista_infix[bs_i].ToString();
                    bs_wykres_drzewo.Series["koszt_infix"].Points.AddXY(bs_i, bs_lista_infix[bs_i]);

                    // bs_y = bs_lista_prefix[bs_i];
                    bs_tabela_grid_drzewo.Rows.Add();
                    bs_tabela_grid_drzewo.Rows[bs_i].Cells[4].Value = bs_lista_prefix[bs_i].ToString();
                    bs_wykres_drzewo.Series["koszt_prefix"].Points.AddXY(bs_i, bs_lista_prefix[bs_i]);

                    //bs_y = bs_lista_postfix[bs_i];
                    bs_tabela_grid_drzewo.Rows.Add();
                    bs_tabela_grid_drzewo.Rows[bs_i].Cells[5].Value = bs_lista_postfix[bs_i].ToString();
                    bs_wykres_drzewo.Series["koszt_postfix"].Points.AddXY(bs_i, bs_lista_postfix[bs_i]);

                    //bs_j = bs_element_losowy.Next(bs_dolna_gr, bs_gorna_gr);
                    // bs_drzewo.insert(bs_j);

                }
            }
            catch (Exception)
            {
                bs_error1.SetError(bs_komunikat_prezentacja_drzewo,"Najpierw kliknij we wszystkie przyciski wypisania drzewa");
                return;
            }
        }

        private void bs_powrot_do_operacji_drzewo_Click(object sender, EventArgs e)
        {
            bs_drzewo_panel_operacje.Visible = true;
            bs_drzewo_panel_prezentacja.Visible = false;
        }

        private void bs_dolna_granica_txb_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_ilosc_wezlow_tbx_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_gorna_granica_tbx_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_komunikat_prezentacja_drzewo_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_komunikat_stos_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_komunikat_lista_MouseDown(object sender, MouseEventArgs e)
        {
            bs_error1.Dispose();
        }

        private void bs_powrot_do_menu_1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
