using UnityEngine;

namespace MTM101BMDE
{
    public class BigScreenModifier : MonoBehaviour
    {
        public void ModifyGrades(string[] newGrades)
        {
            // Access the big screen component and modify its grades
            BigScreen bigScreen = FindObjectOfType<BigScreen>();

            if (bigScreen != null)
            {
                bigScreen.grades = newGrades;
            }
            else
            {
                Debug.LogError("Big screen not found!");
            }
        }
    }
}