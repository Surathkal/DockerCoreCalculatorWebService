using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;


namespace DockerCoreCalculatorWebService
{

    public interface ICalculatorChannel : ICalculatorService, IClientChannel
    {
    }

}
