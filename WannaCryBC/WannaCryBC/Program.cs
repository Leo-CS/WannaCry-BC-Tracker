using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace WannaCryBC
{
    class Program
    {
        [DataContract]
        public class USD
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class JPY
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class CNY
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class SGD
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class HKD
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class CAD
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class NZD
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class AUD
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class CLP
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class GBP
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class DKK
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class SEK
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class ISK
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class CHF
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class BRL
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class EUR
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class RUB
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class PLN
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class THB
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class KRW
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class TWD
        {
            [DataMember]
            public double __invalid_name__15m { get; set; }
            [DataMember]
            public double last { get; set; }
            [DataMember]
            public double buy { get; set; }
            [DataMember]
            public double sell { get; set; }
            [DataMember]
            public string symbol { get; set; }
        }

        [DataContract]
        public class RootObject
        {
            [DataMember]
            public USD USD { get; set; }
            [DataMember]
            public JPY JPY { get; set; }
            [DataMember]
            public CNY CNY { get; set; }
            [DataMember]
            public SGD SGD { get; set; }
            [DataMember]
            public HKD HKD { get; set; }
            [DataMember]
            public CAD CAD { get; set; }
            [DataMember]
            public NZD NZD { get; set; }
            [DataMember]
            public AUD AUD { get; set; }
            [DataMember]
            public CLP CLP { get; set; }
            [DataMember]
            public GBP GBP { get; set; }
            [DataMember]
            public DKK DKK { get; set; }
            [DataMember]
            public SEK SEK { get; set; }
            [DataMember]
            public ISK ISK { get; set; }
            [DataMember]
            public CHF CHF { get; set; }
            [DataMember]
            public BRL BRL { get; set; }
            [DataMember]
            public EUR EUR { get; set; }
            [DataMember]
            public RUB RUB { get; set; }
            [DataMember]
            public PLN PLN { get; set; }
            [DataMember]
            public THB THB { get; set; }
            [DataMember]
            public KRW KRW { get; set; }
            [DataMember]
            public TWD TWD { get; set; }
        }


        public static void GetBitCoinExchangeRates(float earned)
        {
            string url = "https://blockchain.info/ticker";

            WebClient client = new WebClient();
            string json = client.DownloadString(url);

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(RootObject));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            RootObject obj = (RootObject)ser.ReadObject(stream);
            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     Bitcoin payed :  {0} ", Math.Round(earned, 2));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("     EUR value     :  {0} ", Math.Round(obj.EUR.last * earned, 2));
            Console.WriteLine("     USD value     :  {0} ", Math.Round(obj.USD.last * earned, 2));
            Console.WriteLine("     GBP value     :  {0} ", Math.Round(obj.GBP.last * earned, 2));
        }

         
        public static float GetBitCoinValue()
        {
            string url = "https://blockchain.info/q/getreceivedbyaddress/13AM4VW2dhxYgXeQepoHkHSQuy6NgaEb94|12t9YDPgwueZ9NyMgw519p7AA8isjr6SMw|115p7UMMngoj1pMvkpHijcRdfJNXj6LrLn";
            float value;

            WebClient client = new WebClient();
            string reply = client.DownloadString(url);

            value = float.Parse(reply, CultureInfo.InvariantCulture.NumberFormat) / 100000000;

            return value;
        }


        public static string ShiftString(string t)
        {
            return t.Substring(1, t.Length - 1) + t.Substring(0, 1);
        }


        static void Main(string[] args)
        {
            float earned;
            string leo = "                      LEO Cyber Security";

            Console.SetWindowSize(40, 10);
            Console.CursorVisible = false;
            Console.Title = "WannaCry Revenue Ticker";

            while (true)
            {
                //Console.ForegroundColor = ConsoleColor.White;
                earned = GetBitCoinValue();
                GetBitCoinExchangeRates(earned);
                Console.WriteLine("");
                Console.Write(leo);
                string buf = leo;
                for (int x = 0; x < 222; x++)
                {
                    buf = ShiftString(buf);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\r{0}", buf);
                    Console.SetWindowSize(40, 10);
                    System.Threading.Thread.Sleep(150);
                }
            }
        }
    }
}
