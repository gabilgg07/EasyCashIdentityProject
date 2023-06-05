using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }

        public int? SenderID { get; set; }
        public int? ReciverID { get; set; }

        public CustomerAccount SenderCustomer { get; set; }
        public CustomerAccount ReciverCustomer { get; set; }
    }
}

/* ID - İşlem türü (Gelen, Giden, Ödeme) - Miktar - Tarih - Alıcı - Gönderici   */