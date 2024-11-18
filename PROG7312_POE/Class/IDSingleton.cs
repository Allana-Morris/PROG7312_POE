namespace PROG7312_POE.Class
{
    public class IDSingleton
    {
        public static int idcount = 0;

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor
        /// </summary>
        public IDSingleton()
        {
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Method to increase idcount
        /// </summary>
        public void IDPlus()
        {
            idcount++;
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//