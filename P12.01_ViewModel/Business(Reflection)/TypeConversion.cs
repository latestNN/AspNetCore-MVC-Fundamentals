using System.Reflection;

namespace P12._01_ViewModel.Business_Reflection_
{
    public static class TypeConversion<T, T2>
    {
        public static TResult Conversion<T, TResult>(T model) where TResult : class, new()
        {
            TResult result = new TResult();
            typeof(T).GetProperties().ToList().ForEach(p =>
            {
                PropertyInfo property = typeof(TResult).GetProperty(p.Name);
                property.SetValue(result, p.GetValue(model));
            });

            return result;
        }
    }
}
 