using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALD_Entities.AuditReport
{
    public class AuditReport
    {
        public int SrNo { get; set; }
        public int ID { get; set; }
        public DateTime AuditDateTime { get; set; }
        public string OperationDetails { get; set; }
        public string Username { get; set; }
        public string UserGroup { get; set; }
        public string Comment { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        
    }
}