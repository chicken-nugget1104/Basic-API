using UnityEngine;

namespace MTM101BMDE
{

    [System.Serializable]
    public class CustomSubtitle
    {
        public string text;
        public Color color;
        public bool encrypted;

        public CustomSubtitle(string text, Color color, bool encrypted)
        {
            this.text = text;
            this.color = color;
            this.encrypted = encrypted;
        }
    }
}