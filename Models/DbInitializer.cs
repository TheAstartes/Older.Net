﻿using System.Linq;

namespace TheShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Motocykle.Any())
            {
                context.AddRange(             
                new Motocykl { Marka = "BMW", Model = "R Nine T Racer", RokProdukcji = 2018, Pojemnosc = "1,1170cc", RodzajSilnika = "czterosuwowy twin-bokser", Moc = "110KM(81kW)", Opis = "Brak opisu BMW", Cena = 51200M, ZdjecieUrl = "images/BMW.jpg", LogoUrl = "BMW-logo.png", JestMotocyklemTygodnia = true },
                new Motocykl { Marka = "Ducati", Model = "Monster 797", RokProdukcji = 2018, Pojemnosc = "803cc", RodzajSilnika = "L-twin", Moc = "73KM(54kW)", Opis = "Brak opisu Ducati", Cena = 40400M, ZdjecieUrl = "images/Ducati.jpg", LogoUrl = "Ducati-logo.png", JestMotocyklemTygodnia = true },
                new Motocykl { Marka = "Kawasaki", Model = "Ninja 650", RokProdukcji = 2019, Pojemnosc = "649cc", RodzajSilnika = "czterosuwowy,2-cylindry", Moc = "50,2kW", Opis = "Cena nieznana", ZdjecieUrl = "images/Kawasaki.jpg", LogoUrl = "Kawasaki-logo.png", JestMotocyklemTygodnia = true },
                new Motocykl { Marka = "KTM", Model = "690 Enduro R", RokProdukcji = 2018, Pojemnosc = "690cc", RodzajSilnika = "czterosuwowy,1-cylindrowy", Moc = "49kW", Opis = "Brak opisu KTM", Cena = 42000M, ZdjecieUrl = "images/KTM.jpg", LogoUrl = "KTM-logo.png", JestMotocyklemTygodnia = true },
                new Motocykl { Marka = "Timberslend", Model = "ST 93 RIPPER", RokProdukcji = 2019, Opis = "Brak opisu Timberslend", Cena = 17200M, ZdjecieUrl = "images/Timbersled.jpg", LogoUrl = "Timbersled-logo.png", JestMotocyklemTygodnia = true },
                new Motocykl { Marka = "Triumph", Model = "Rocket 3 Roadster phantom black", RokProdukcji = 2018, Pojemnosc = "2294cc", RodzajSilnika = "DOHC,slnik rzedowy 3-cylindrowy", Moc = "148KM(109kW)", Opis = "Brak opisu Triumph", Cena = 59500M, ZdjecieUrl = "images/Triumph.jpg", LogoUrl = "Triumph-logo.png", JestMotocyklemTygodnia = true },
                new Motocykl { Marka = "Yeti SnowMX", Model = "137 MT BASE", RokProdukcji = 2019, Opis = "Brak opisu BMW", Cena = 30000M, ZdjecieUrl = "Yeti-SnowMX.jpg", LogoUrl = "Yeti-snowMX-logo.png", JestMotocyklemTygodnia = true }
                    );
            }
            context.SaveChanges();
        }
    }
}
