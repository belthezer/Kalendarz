using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;

public class Aplikacja {
	private Kalendarz kalendarz;

        //konstruktor wczytujący kalendarz z pliku
	public Aplikacja(string plik) {
		throw new System.Exception("Not implemented");
	}
	public Aplikacja() {
		throw new System.Exception("Not implemented");
	}
	public void Dodaj(Wpis nowy) {
		throw new System.Exception("Not implemented");
	}
        //metoda wywoływana przy zamykaniu programu. Musi zapytać o zapisanie zmian i ewentualnie je zapisać do wskazanego katalogu
	public void Zamknij() {
		throw new System.Exception("Not implemented");
	}
        //metoda zwracająca miesiąc (tyle ile będzie przycisków w gui) bitmap, które potem będą skalowane na przyciskach. Niech nie-zajęte godziny nie zajmują zbyt dużo miejsca. Godziny zajęte powinny zajmować przestrzeń proporcjonalną do czasu ich trwania. Wystarczą same kolory, bez tytułów.
	public List<Bitmap> Miesiac(Data_dzien pierwszy) {
		throw new System.Exception("Not implemented");
	}
        //metoda zwracająca bitmapę(być może w praniu zmienimy to na coś innego)  wybranego dnia. Podobnie jak powyżej, ale z napisanymi godzinami i tytułami wpisów
	public Bitmap Dzien(Data_dzien data) {
		throw new System.Exception("Not implemented");
	}
        //zapis okresu do pliku. Musi zapytać gdzie zapisać
	public void Eksport(Data_dzien poczatek, Data_dzien koniec) {
		throw new System.Exception("Not implemented");
	}


}
