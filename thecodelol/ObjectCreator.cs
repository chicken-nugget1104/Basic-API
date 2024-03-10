using UnityEngine;

public enum ObjectType
{
    Cube,
    Capsule,
    Cylinder,
    VendingMachine
}

namespace MTM101BMDE
{
    public static class ObjectCreator
    {
        public static GameObject CreateObject(ObjectType objectType, Vector3 position, Quaternion rotation, MonoBehaviour script = null)
        {
            GameObject newObject = null;

            switch (objectType)
            {
                case ObjectType.Cube:
                    newObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    break;
                case ObjectType.Capsule:
                    newObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                    break;
                case ObjectType.Cylinder:
                    newObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                    break;
                case ObjectType.VendingMachine:
                    newObject = new GameObject("VendingMachine"); // Create an empty GameObject for vending machine
                    newObject.AddComponent<CustomVendingMachine>(); // Add CustomVendingMachine script to the GameObject
                    break;
                default:
                    Debug.LogError("Unsupported object type!");
                    break;
            }

            if (newObject != null)
            {
                newObject.transform.position = position;
                newObject.transform.rotation = rotation;

                // Attach the script if provided
                if (script != null)
                {
                    newObject.AddComponent(script.GetType());
                }
            }

            return newObject;
        }
    }
}
