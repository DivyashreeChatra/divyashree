using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Risk_System
{
    class RDSDataModel
    {
        private string CounterpartyID;
        private string Name;


        public string GetCounterpartyID()
        {
            return this.CounterpartyID;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetCounterpartyID(string counterpartyid)
        {
            this.CounterpartyID = counterpartyid;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
    }
}
