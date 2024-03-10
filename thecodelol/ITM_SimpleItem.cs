using UnityEngine;

namespace MTM101BMDE
{
    public class ITM_SimpleItem : Item
    {
        public override bool Use(PlayerManager pm)
        {
            pm.plm.staminaRise = 7;
            pm.plm.runSpeed -= 6;
            pm.plm.walkSpeed += 4;
            return true; // Return true to indicate that the item was successfully used
        }
    }
}