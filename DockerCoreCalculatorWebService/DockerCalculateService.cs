using System;
using System.Xml.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml;


namespace DockerCoreCalculatorWebService
{
    public class DockerCalculateService : IDockerCalculateService
    {
        private ICalculatorChannel proxy;


        public async Task<int> AddAsync(int intA, int intB)
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                SendTimeout = TimeSpan.FromSeconds(10000),
                MaxBufferSize = int.MaxValue,
                MaxReceivedMessageSize = int.MaxValue,
                AllowCookies = true,
                ReaderQuotas = XmlDictionaryReaderQuotas.Max
            };

            binding.Security.Mode = BasicHttpSecurityMode.None;

            EndpointAddress address = new EndpointAddress("http://www.dneonline.com/calculator.asmx");

            ChannelFactory<ICalculatorChannel> factory = new ChannelFactory<ICalculatorChannel>(binding, address);

            this.proxy = factory.CreateChannel();

            var result = await this.proxy.AddAsync(intA, intB);

            return result;

        }


        public async Task<int> SubtractAsync(int intA, int intB)
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                SendTimeout = TimeSpan.FromSeconds(10000),
                MaxBufferSize = int.MaxValue,
                MaxReceivedMessageSize = int.MaxValue,
                AllowCookies = true,
                ReaderQuotas = XmlDictionaryReaderQuotas.Max
            };

            binding.Security.Mode = BasicHttpSecurityMode.None;

            EndpointAddress address = new EndpointAddress("http://www.dneonline.com/calculator.asmx");

            ChannelFactory<ICalculatorChannel> factory = new ChannelFactory<ICalculatorChannel>(binding, address);

            this.proxy = factory.CreateChannel();

            var result = await this.proxy.SubtractAsync(intA, intB);

            return result;
        }


        public async Task<int> MultiplyAsync(int intA, int intB)
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                SendTimeout = TimeSpan.FromSeconds(10000),
                MaxBufferSize = int.MaxValue,
                MaxReceivedMessageSize = int.MaxValue,
                AllowCookies = true,
                ReaderQuotas = XmlDictionaryReaderQuotas.Max
            };

            binding.Security.Mode = BasicHttpSecurityMode.None;

            EndpointAddress address = new EndpointAddress("http://www.dneonline.com/calculator.asmx");

            ChannelFactory<ICalculatorChannel> factory = new ChannelFactory<ICalculatorChannel>(binding, address);

            this.proxy = factory.CreateChannel();

            var result = await this.proxy.MultiplyAsync(intA, intB);

            return result;
        }


        public async Task<int> DivideAsync(int intA, int intB)
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                SendTimeout = TimeSpan.FromSeconds(10000),
                MaxBufferSize = int.MaxValue,
                MaxReceivedMessageSize = int.MaxValue,
                AllowCookies = true,
                ReaderQuotas = XmlDictionaryReaderQuotas.Max
            };

            binding.Security.Mode = BasicHttpSecurityMode.None;

            EndpointAddress address = new EndpointAddress("http://www.dneonline.com/calculator.asmx");

            ChannelFactory<ICalculatorChannel> factory = new ChannelFactory<ICalculatorChannel>(binding, address);

            this.proxy = factory.CreateChannel();

            var result = await this.proxy.DivideAsync(intA, intB);

            return result;
        }


        public string HelloGreeting(string s)
        {
            Console.WriteLine("Test Method Executed!");
            return s + " Welcome Aboard";
        }

    }
}