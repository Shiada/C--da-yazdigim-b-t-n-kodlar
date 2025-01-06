Console.WriteLine("=========================================================================================================");
Console.WriteLine("==========================================Diyarbakır Halk Lokantası=========================================");
Console.WriteLine("===========================================================================================================");
Console.WriteLine("Sıralanmış ürünler arasından istediğiniz ürün için belirlenen rakamı tuşlayınız ");
Console.WriteLine("-----1/Çorbalar-----");
Console.WriteLine("-----2/Kahveler-----");
Console.WriteLine("-----3/Salatalar-----");


int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("-----1/Mercimek çorbası-----");
    Console.WriteLine("-----2/Tarhana çorbası-----");
    Console.WriteLine("-----3/Domates çorbası-----");
    int ç = Convert.ToInt32(Console.ReadLine());

    if (ç == 1)
    {

        Console.WriteLine("-----1/Tam mercimek çorbası-----");
        Console.WriteLine("-----2/Orta mercimek çorbası-----");
        Console.WriteLine("-----3/Az mercimek çorbası-----");
        int m = Convert.ToInt32(Console.ReadLine());

        if (m == 1)
        {
            Console.WriteLine("Siparişiniz tam mercimek çorbası olarak alınmıştır");
        }
        else if (m == 2)
        {
            Console.WriteLine("Siparişiniz orta mercimek çorbası olarak alınmıştır");

        }
        else if (m == 3)
        {
            Console.WriteLine("Siparişiniz az mercimek çorbası olarak alınmıştır");
        }
        else
        {
            Console.WriteLine("geçerli bir rakam tuşlayınız");
        }


    }
    else if (ç == 2)
    {
        Console.WriteLine("-----1/Tam tarhana çorbası-----");
        Console.WriteLine("-----2/Orta tarhana çorbası-----");
        Console.WriteLine("-----3/Az tarhana çorbası-----");
        int m = Convert.ToInt32(Console.ReadLine());
        if (m == 1)
        {
            Console.WriteLine("Siparişiniz tam tarhana çorbası olarak alınmıştır");
        }
        else if (m == 2)
        {
            Console.WriteLine("Siparişiniz orta tarhana çorbası olarak alınmıştır");

        }
        else if (m == 3)
        {
            Console.WriteLine("Siparişiniz az tarhana çorbası olarak alınmıştır");
        }
        else
        {
            Console.WriteLine("Geçerli bir rakam tuşlayınız");
        }

    }
    else if (ç == 3)
    {
        Console.WriteLine("-----1/Tam domates çorbası-----");
        Console.WriteLine("-----2/Orta domates çorbası-----");
        Console.WriteLine("-----3/Az domates çorbası-----");
        int m = Convert.ToInt32(Console.ReadLine());

        if (m == 1)
        {
            Console.WriteLine("Siparişiniz tam domates çorbası olarak alınmıştır");
        }
        else if (m == 2)
        {
            Console.WriteLine("Siparişiniz orta domates çorbası olarak alınmıştır");

        }
        else if (m == 3)
        {
            Console.WriteLine("Siparişiniz az domates çorbası olarak alınmıştır");
        }
        else
        {
            Console.WriteLine("Geçerli bir rakam tuşlayınız");
        }

    }
    else
    {
        Console.WriteLine("Geçerli bir rakam tuşlayınız");
    }
}

else if (a == 2)
{
    Console.WriteLine("-----1/türk kahvesi------");
    Console.WriteLine("-----2/menengiç kahve-----");
    Console.WriteLine("-----3/dibek kahve-----");
    int k = Convert.ToInt32(Console.ReadLine());


    if (k == 1)
    {
        Console.WriteLine("-----1/şekerli-----");
        Console.WriteLine("-----2/az şekerli-----");
        Console.WriteLine("-----3/orta şekerli-----");
        int ş = Convert.ToInt32(Console.ReadLine());

        if (ş == 1)
        {
            Console.WriteLine("Siparişiniz şekerli türk kahvesi olarak alınmıştır");

        }
        else if (ş == 2)
        {
            Console.WriteLine("Siparişiniz az şekerli türk kahvesi olarak alınmıştır");

        }
        else if (ş == 3)
        {
            Console.WriteLine("Siparişiniz orta şekerli türk kahvesi olarak alınmıştır");

        }
        else
        {
            Console.WriteLine("Geçerli bir rakam tuşlayınız");
        }


    }
    else if (k == 2)
    {
        Console.WriteLine("-----1/şekerli-----");
        Console.WriteLine("-----2/az şekerli-----");
        Console.WriteLine("-----3/orta şekerli-----");
        int ş = Convert.ToInt32(Console.ReadLine());

        if (ş == 1)
        {
            Console.WriteLine("1-siparişiniz şekerli menegiç kahvesi olarak alınmıştır");

        }
        else if (ş == 2)
        {
            Console.WriteLine("Siparişiniz az şekerli menegiç kahvesi olarak alınmıştır");

        }
        else if (ş == 3)
        {
            Console.WriteLine("Siparişiniz orta şekerli menegiç kahvesi olarak alınmıştır");

        }
        else
        {
            Console.WriteLine("Geçerli bir rakam tuşlayınız");
        }




    }
    else if (k == 3)
    {
        Console.WriteLine("-----1/şekerli-----");
        Console.WriteLine("-----2/az şekerli-----");
        Console.WriteLine("-----3/orta şekerli-----");
        int ş = Convert.ToInt32(Console.ReadLine());

        if (ş == 1)
        {
            Console.WriteLine("Siparişiniz şekerli dibek kahvesi olarak alınmıştır");

        }
        else if (ş == 2)
        {
            Console.WriteLine("Siparişiniz az şekerli dibek kahvesi olarak alınmıştır");

        }
        else if (ş == 3)
        {
            Console.WriteLine("Siparişiniz orta şekerli dibek kahvesi olarak alınmıştır");

        }
        else
        {
            Console.WriteLine("Geçerli bir rakam tuşlayınız");
        }

    }
    else
    {
        Console.WriteLine("geçerli bir rakam tuşlayınız");
    }
}

else if (a == 3)
{
    Console.WriteLine("-----1/Çoban salatası-----");
    Console.WriteLine("-----2/Rus salatası-----");
    Console.WriteLine("-----3/Mevsimlik salatası-----");
    int s = Convert.ToInt32(Console.ReadLine());

    if (s == 1)
    {
        Console.WriteLine("-----1/Yağsız-----");
        Console.WriteLine("-----2/Yağlı-----");
        Console.WriteLine("-----3/Bol yağlı-----");
        int y = Convert.ToInt32(Console.ReadLine());

        if (y == 1)
        {
            Console.WriteLine("Siparişiniz yağsız Çoban salatası olarak alınmıştır");

        }
        else if (y == 2)
        {
            Console.WriteLine("Siparişiniz yağlı Çoban salatası olarak alınmıştır");

        }
        else if (y == 3)
        {
            Console.WriteLine("Siparişiniz bol yağlı Çoban salatasıolarak alınmıştır");

        }
        else

            Console.WriteLine("Geçerli bir rakam tuşlayınız");


    }
    else if (s == 2)
    {
        Console.WriteLine("-----1/Yağsız-----");
        Console.WriteLine("-----2/Yağlı-----");
        Console.WriteLine("-----3/Bol yağlı-----");
        int y = Convert.ToInt32(Console.ReadLine());
        if (y == 1)
        {
            Console.WriteLine("Siparişiniz yağsız rus salatası olarak alınmıştır");

        }
        else if (y == 2)
        {
            Console.WriteLine("Siparişiniz yağlı rus salatası olarak alınmıştır");

        }
        else if (y == 3)
        {
            Console.WriteLine("Siparişiniz bol yağlı rus salatasıolarak alınmıştır");

        }
        else

            Console.WriteLine("Geçerli bir rakam tuşlayınız");


    }
    else if (s == 3)
    {
        Console.WriteLine("-----1/Yağsız-----");
        Console.WriteLine("-----2/Yağlı-----");
        Console.WriteLine("-----3/Bol yağlı-----");
        int t = Convert.ToInt32(Console.ReadLine());
        if (t == 1)
        {
            Console.WriteLine("Siparişiniz yağsız mevsimlik olarak alınmıştır");

        }
        else if (t == 2)
        {
            Console.WriteLine("Siparişiniz yağlı mevsimlik olarak alınmıştır");

        }
        else if (t == 3)
        {
            Console.WriteLine("Siparişiniz bol yağlı mevsimlik olarak alınmıştır");

        }
        else
        {
            Console.WriteLine("Geçerli bir rakam tuşlayınız");

        }
    
    }
    else
    {
            Console.WriteLine("Lütfen geçerli bir sayı giriniz");
    }
    
}
