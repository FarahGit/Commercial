using Microsoft.Practices.Unity;
using System;

namespace GCA.Core
{
    public static class UnityExtension
    {
        public static void RegisterTypeForNavigation<T>(this IUnityContainer container)
        {
            container.RegisterType(typeof(Object), typeof(T), typeof(T).FullName);
        }
    }
}
