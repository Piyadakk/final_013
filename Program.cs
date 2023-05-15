class Program {
    static void Main(string[] args){
        float Vmax = float.Parse(Console.ReadLine());
        float Vdrink = float.Parse(Console.ReadLine());
        float Vfill = float.Parse(Console.ReadLine());

        while(true) {
            int tfill = int.Parse(Console.ReadLine());
            int tday = int.Parse(Console.ReadLine());
            int tdrink = int.Parse(Console.ReadLine());

            float left = Vmax - Vdrink;
            float water = Vmax+Vfill;

            if (tdrink <= tday && tday >= tfill);
                else
    if (Vmax != 0) {
        Console.WriteLine("Enough Water, {0} left", Vmax);
    } else {
        Console.WriteLine("Not Enough Water");
    }if (Vmax == -1) {
        Console.WriteLine("Overflow", Vfill);
     }

        }
    }

 }

    

    
