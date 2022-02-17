using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RabbitMQForms
{
    public class Configuration
    {
        private static Configuration instance;
        public string RabbitMQConnectionString { get; internal set; }
        public string ExchangeName { get; internal set; }

        private Configuration()
        {
            RabbitMQConnectionString = ConfigurationManager.ConnectionStrings["RabbitMqConnection"].ConnectionString;
            ExchangeName = ConfigurationManager.AppSettings["exchangeName"];
        }
        
        public static Configuration GetInstance()
        {
            if(instance == null)
            {
                instance = new Configuration();
            }
            return instance;
        }
    }
}
