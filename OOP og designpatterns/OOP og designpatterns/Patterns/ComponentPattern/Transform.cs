namespace OOP_og_designpatterns
{
    /// <summary>
    /// Et Specefikt komponent, som alle gameobjects skal have, for at kunne eksistere 
    /// i spilverdenen
    /// </summary>
    class Transform
    {
        public int x;
        public int y;

        public void Move()
        {
            x = 0;
            y = 0;
            System.Console.WriteLine(GetType() + ": I'm Moving");
        }

    }
}