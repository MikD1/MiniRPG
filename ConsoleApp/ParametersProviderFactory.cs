using System;

namespace ConsoleApp
{
    public static class ParametersProviderFactory
    {
        public static IParametersProvider GetTestParametersProvider()
        {
            return new TestParametersProvider();
        }
        public static IParametersProvider GetAppConfigParametersProvider()
        {
            return new AppConfigParametersProvider();
        }
    }
}
