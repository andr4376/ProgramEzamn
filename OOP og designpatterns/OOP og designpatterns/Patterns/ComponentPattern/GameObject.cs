using System;
using System.Collections.Generic;

namespace OOP_og_designpatterns
{

    /// <summary>
    /// Game object er i dette tilfælde vores "Composite" - altså den klasse som holder styr på alle
    /// components, og sørger for at de alle får kaldt deres funktionaliteter
    /// I dette tilfælde, kaldes komponenternes funktionaliteter vha. Interfaces
    /// </summary>
    class GameObject : DecoratorComponent
    {
        private List<DecoratorComponent> components = new List<DecoratorComponent>();

        private Transform transform;
        /*
• Specific component
• Er en specifik implementering at komponent. Det kan
f.eks være:
• CollisionBox, SpriteRenderer, Transform osv.

            man brugere mindre ressourcer på at tilgå dem ved at tilknytte specefikke komponenter
            som alle game objects skal have

            GameObject er kun et composite, man kan have flere, som kan have andre specefikke komponenter
            eller ingen. 
         * */
        public Transform Transform
        {
            get { return transform; }
        }

        public List<DecoratorComponent> GetComponentList
        {
            get { return components; }
        }

        public GameObject()
        {
            transform = new Transform();
        }

        public void AddComponent(DecoratorComponent component)
        {
            components.Add(component);
        }

        public DecoratorComponent GetComponent(string component)
        {
            foreach (DecoratorComponent comp in components)
            {
                if (comp.GetType().ToString() == "OOP_og_designpatterns." + component)
                {
                    return comp;
                }
            }
            return null;
        }

        /// <summary>
        /// Based on type
        /// </summary>
        /// <typeparam name="TComponentType"></typeparam>
        /// <returns></returns>
        public TComponentType GetComponent<TComponentType>()
        {
            foreach (DecoratorComponent comp in components)
            {
                if (comp is TComponentType)
                {
                    return  (TComponentType)Convert.ChangeType(comp, typeof(TComponentType));
                }

            }
                return (TComponentType)Convert.ChangeType(null, typeof(TComponentType));
        }

        public void RemoveComponent(DecoratorComponent component)
        {
            components.Remove(component);
        }


        public void RemoveComponent<T>()
        {
            foreach (DecoratorComponent comp in components)
            {
                if (comp is T)
                {
                    components.Remove(comp);
                }

            }
        }

        public void DoSomething()
        {
            foreach (var component in components)
            {
                if (component is IDoSomething)
                {
                    (component as IDoSomething).DoSomething();
                }
            }

            foreach (var component in components)
            {
                if (component is IDoAnotherThing)
                {
                    (component as IDoAnotherThing).DoAnotherThing();
                }
            }
        }


        public override string ToString()
        {
            return "Im a gameobject, on the coordinate: " + transform.x + "," + transform.y+"  I have "+components.Count+" Components!";
        }

    }
}