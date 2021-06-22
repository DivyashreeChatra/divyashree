using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Risk_System
{
    class Program
    {
        static void Main(string[] args)
        {
            TDSDataModel instance = new TDSDataModel();
            RDSDataModel _instance = new RDSDataModel();

            instance.SetTrade_ID("Excel1");
            string tradeid = instance.GetTrade_ID();

            instance.SetDate("22/06/2021");
            string date = instance.GetDate();

            instance.SetCounterparty_ID("C2001");
            string counterparty_id = instance.GetCounterparty_ID();

            instance.SetCurrent_trade_value(12212);
            int current_trade_value = instance.GetCurrent_trade_value();

            _instance.SetCounterpartyID("C4565");
            string counterpartyid = _instance.GetCounterpartyID();

            _instance.SetName("Divya");
            string name = _instance.GetName();

            System.Console.WriteLine("Trade ID: " +tradeid);
            System.Console.WriteLine("Date: "+date);
            System.Console.WriteLine("Current Trade Value: "+current_trade_value);
            System.Console.WriteLine("TDS CounterPartyID: "+counterparty_id);
            System.Console.WriteLine("RDS CounterPartyID: " + counterpartyid);
            System.Console.WriteLine("Name: " + name);
            System.Console.ReadLine();
        }
    }
}
