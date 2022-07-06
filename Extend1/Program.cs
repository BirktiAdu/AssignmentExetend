

    
        int n;
        Circle c = new Circle();
        Rectangle r = new Rectangle();
        char res;
        do
        {
            Console.WriteLine("\t\t1. Calculate Area for Circle");
            Console.WriteLine("\t\t2. Calculate Perimeter for Circle");
            Console.WriteLine("\t\t3. Calculate Area for Rectangle");
            Console.WriteLine("\t\t4. Calculate Pereimeter for Rectangle");
            n = int.Parse(Console.ReadLine());

    if (n == 1)

    {
        Console.WriteLine("Enter radius: ");
        c.radius = Convert.ToDouble(Console.ReadLine());
        c.calculateArea();
        Console.WriteLine("Area= " + c.area);
    }

    else if (n == 2)
    {
        Console.WriteLine("Enter radius: ");
        c.radius = Convert.ToDouble(Console.ReadLine());
        c.calculateperimeter();
        Console.WriteLine("Perimeter= " + c.perimeter);
    }
    else if (n == 3)
    {
        Console.WriteLine("Enter length: ");
        r.length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter width: ");
        r.width = Convert.ToDouble(Console.ReadLine());
        r.calculateArea();
        Console.WriteLine("Area= " + r.area);
    }
    else if (n == 4)
    {
        Console.WriteLine("Enter length: ");
        r.length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter width: ");
        r.width = Convert.ToDouble(Console.ReadLine());
        r.calculateperimeter();
        Console.WriteLine("Perimeter= " + c.perimeter);
    }
    else
    {


        { Console.WriteLine("!!!"); }

    }
            Console.WriteLine("Do you want more? ('Y' for yes and 'N' for no'");
            res = Convert.ToChar(Console.ReadLine());
        } while (res == 'Y');





    


