using System;
using System.Configuration;
using System.Windows.Forms;

namespace ALDReporting.CustomClass
{
    public static class HelperMethods
    {
        public static void HideShowRecipe(TabControl tabControl,TabPage tabToHide)
        {
            bool recipeHide = Convert.ToBoolean(ConfigurationManager.AppSettings["recipeHide"]);
            if (recipeHide)
            {
                tabToHide.Hide();
                tabControl.TabPages.Remove(tabToHide);
            }
        }

    }
}
