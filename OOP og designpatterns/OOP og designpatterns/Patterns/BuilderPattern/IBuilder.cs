namespace OOP_og_designpatterns
{
    /// <summary>
    /// All builders must have this interface
    /// </summary>
    interface IBuilder 
    {
        void BuildObject();
        void MakeComponentA();
        void MakeComponentB();
        GameObject GetResult();

    }
}