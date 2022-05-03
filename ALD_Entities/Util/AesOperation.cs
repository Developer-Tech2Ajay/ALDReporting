using System;
using System.Linq;

namespace Entities
{
    public class AesOperation
    {
        public static void CheckUser(string user)
        {
            var machineName = System.Environment.MachineName;
            if (!Constants.machineNames.Contains(machineName,StringComparer.OrdinalIgnoreCase))
                throw new InvalidException(user);
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
