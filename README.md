# test-zaposlenici
Opis testnog zadatka : U Visual Studiu napraviti novi ASP.NET Web Forms ili MVC projekt koji će imati samo jednu formu (zasposlenici).  

Na formi se treba nalaziti tablica sa popisom zaposlenika (korisitit JavaScript komponentu DataTables za prezentaciju). Popis zaposlenika   se dohvaća AJAX-om sa webservisa (WebAPI). Podatke nije potrebno dovlačiti iz baze nego se može direktno iz webservisa vratiti neki fiksni  popis.
Ispod tablice se nalazi gumb “Dodaj zaposlenika”, klikom na njega otvara se dijalog na kojem se nalazi forma na kojoj se unosi:  
•             Ime zaposlenika (max 30 znakova)  
•             Prezime zaposlenika (max 30 znakova)  
•             Datum rođenja  
Na dijalogu se nalazi I gumb “Spremi”, ukoliko je korisnik ispunio sva polja neka samo iskoči poruka “SPREMLJENO!”  

Rješenje uključuje:   
Potrebno je samo pokrenuti aplikaciju i localDb se sam migrate-a i seed-a  
1. client-side validation (HTML) i server side validation-Regex protiv scriptanja  
2. Zaposlenici se spremaju u bazu podataka (Entity Framework)  
3. Zaposlenicima je prikazana starost umjesto datuma rođenja  
4. Zaposlenici mogu biti stari od 18-65 godina (client & server side)  
5. Global filter da se ne ponavlja if(!ModelState.IsValid)  
6. ZaposleniciRepository  
