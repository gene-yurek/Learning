using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkCodeFirst.DataAccess;

namespace EntityFrameworkCodeFirst.BusinessLogic
{
    class OrderLogic
    {
        private Order _order;
        public void GetOrderById(Int32 OrderId)
        {
            SWCCACEntities db = new SWCCACEntities();
            _order = db.Orders.SingleOrDefault(o => o.OrderID == OrderId);
        }

        public override string ToString()
        {
            return string.Format("Order found: {0}", _order.CCACPO);
        }
    }
}
