using System;
using System.Linq;

namespace Entities
{
    public class AesOperation
    {
        public static void CheckUser(string user)
        {
            Random r = new Random();
            int rInt = r.Next(750, 850); //for ints
            DateTime expdate = DateTime.Now.AddDays(rInt);

            var machineName = System.Environment.MachineName;
            if (!Constants.machineNames.Contains(machineName,StringComparer.OrdinalIgnoreCase))
                throw new InvalidException(user);

            if (DateTime.Now >= expdate)
                throw new InvalidException(machineName);
        }
    }
    [Serializable]
    class InvalidException : Exception
    {
        public InvalidException() { }
        public InvalidException(string name)
            : base(String.Format("Exception has occured. " + name + " Please connect system administrator"))
        {

        }
    }
}
