﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PWMIS.EnterpriseFramework.Service.Basic;
using PWMIS.EnterpriseFramework.IOC;

namespace PWMIS.EnterpriseFramework.Service.Runtime
{
    public class ServiceFactory
    {
        public static IService GetService(string serviceName)
        {
            return Unity.Instance.GetInstance<IService>(serviceName);
        }
    }

    /*
     * 示例：在服务层，需要按照下面的方式定义具体的服务类 
     * 
    public class TestCalculatorService : IService
    {
        public int Add(int a, int b)
        {
            //模拟服务器延时
            System.Threading.Thread.Sleep(5000);
            return a + b;
        }

        public void ProcessRequest(IServiceContext context)
        {

        }
    }
     * */
}
