namespace c_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicle = new Vehicle[2]  ;
            vehicle[0]= new Car ("Toyota", "Camry", 2022, 240,"red");
            vehicle[1]= new Bus (16, 2021, "black");
            foreach (Vehicle item in vehicle)
            {
                Console.WriteLine(item.ShowInfo);
                
            }
           
        }
    }
}
