using UnityEngine;
namespace MTM101BMDE
{
    public class InputHandler : MonoBehaviour
    {
        private void Update()
        {
            // Check if the "0" key is pressed
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                // Create a simple item using the modding API
                CreateSimpleItem();
            }
        }

        private void CreateSimpleItem()
        {
            ModdingAPI.RegisterItem("Simple", null);
            ModdingAPI.CreateItem("Simple");
        }
    }
}