using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace DockerCoreCalculatorWebService
{
    [ServiceContract]
    public interface IDockerCalculateService
    {

        [OperationContract]
        string HelloGreeting(string s);

        [OperationContract]
        Task<int> AddAsync(int intA, int intB);

        //System.Threading.Tasks.Task<int> AddAsync(int intA, int intB);

        [OperationContract]
        Task<int> SubtractAsync(int intA, int intB);

        [OperationContract]
        Task<int> MultiplyAsync(int intA, int intB);

        [OperationContract]
        Task<int> DivideAsync(int intA, int intB);

    }
}



