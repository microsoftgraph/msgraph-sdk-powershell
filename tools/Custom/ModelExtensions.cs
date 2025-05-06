using System;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Threading.Tasks;
using NamespacePrefixPlaceholder.PowerShell.Runtime;

namespace NamespacePrefixPlaceholder.PowerShell.ModelExtensions
{
    public static class ModelExtensions
    {
        public static async Task EnsurePropertiesAreReady(
            this object model,
            bool failOnExplicitNulls = false,
            int retries = 3,
            int delayMs = 1000,
            bool debug = false)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            var modelType = model.GetType();
            var isSetMethod = modelType.GetMethod("IsPropertySet", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            if (isSetMethod == null)
                return; // Skip if model doesn't support property tracking

            for (int attempt = 0; attempt < retries; attempt++)
            {
                bool allReady = true;
                foreach (var prop in modelType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    if (!prop.CanRead) continue;

                    bool isSet = (bool)isSetMethod.Invoke(model, new object[] { prop.Name });
                    object value = null;

                    try
                    {
                        value = prop.GetValue(model);
                    }
                    catch { /* Handle properties that might throw on get */ }

                    if (debug)
                        Console.WriteLine($"DEBUG: Property={prop.Name}, IsSet={isSet}, Value={(value == null ? "null" : value.ToString())}");

                    if (!isSet)
                        continue; // skip unset properties

                    if (value == null && failOnExplicitNulls)
                    {
                        allReady = false;
                        break;
                    }

                    if (value != null && IsDefault(value) && failOnExplicitNulls)
                    {
                        allReady = false;
                        break;
                    }

                    // Recursively check nested models
                    if (value != null && !IsSimple(value))
                    {
                        if (value is IEnumerable enumerable && !(value is string))
                        {
                            foreach (var item in enumerable)
                                await EnsurePropertiesAreReady(item, failOnExplicitNulls, 1, 0, debug);
                        }
                        else
                        {
                            await EnsurePropertiesAreReady(value, failOnExplicitNulls, 1, 0, debug);
                        }
                    }
                }

                if (allReady)
                    return;

                if (attempt < retries - 1)
                    await Task.Delay(delayMs);
            }

            throw new InvalidOperationException("One or more required properties were not ready after retries.");
        }

        private static bool IsSimple(object obj)
        {
            var type = obj.GetType();
            return type.IsPrimitive
                || type.IsEnum
                || type == typeof(string)
                || type == typeof(DateTime)
                || type == typeof(decimal)
                || type == typeof(Guid)
                || type == typeof(TimeSpan);
        }

        private static bool IsDefault(object obj)
        {
            var type = obj.GetType();
            object defaultValue = type.IsValueType ? Activator.CreateInstance(type) : null;
            return Equals(obj, defaultValue);
        }
    }
}
