using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using NamespacePrefixPlaceholder.PowerShell.Runtime;

namespace NamespacePrefixPlaceholder.PowerShell.ModelExtensions
{
    public static class ModelExtensions
    {
        /// <summary>
        /// Ensures that all properties marked as set on the model have meaningful values.
        /// </summary>
        /// <param name="model">The model object (must implement IsPropertySet(string)).</param>
        /// <param name="failOnExplicitNulls">If true, properties explicitly set to null will be considered invalid (strict mode).</param>
        /// <param name="retries">Number of retries for late-bound properties.</param>
        /// <param name="delayMs">Delay (ms) between retries.</param>
        public static async Task EnsurePropertiesAreReady(
            this object model,
            bool failOnExplicitNulls = false,
            int retries = 3,
            int delayMs = 1000)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            // Ensure the model supports IsPropertySet(string)
            var isPropertySetMethod = model.GetType().GetMethod("IsPropertySet", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (isPropertySetMethod == null)
                throw new InvalidOperationException($"{model.GetType().Name} does not implement IsPropertySet(string)");

            var props = model.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            for (int attempt = 0; attempt <= retries; attempt++)
            {
                var unready = props
                    .Where(p => IsUnready(model, p, isPropertySetMethod, failOnExplicitNulls))
                    .ToList();

                if (!unready.Any())
                    return; // Ready!

                if (attempt < retries)
                    await Task.Delay(delayMs);
            }

            // Final check before throwing
            var stillUnready = props
                .Where(p => IsUnready(model, p, isPropertySetMethod, failOnExplicitNulls))
                .Select(p => p.Name)
                .ToList();

            if (stillUnready.Any())
            {
                throw new InvalidOperationException(
                    $"Model '{model.GetType().Name}' has properties marked as set but not initialized properly: {string.Join(", ", stillUnready)}"
                );
            }
        }

        private static bool IsUnready(object model, PropertyInfo prop, MethodInfo isPropertySetMethod, bool failOnExplicitNulls)
        {
            try
            {
                // Ensure method matches expected signature
                var parameters = isPropertySetMethod.GetParameters();
                if (parameters.Length != 1 || parameters[0].ParameterType != typeof(string))
                {
                    Console.WriteLine($"WARNING: IsPropertySet signature mismatch for type {model.GetType().Name}");
                    return false;
                }

                bool isSet = (bool)isPropertySetMethod.Invoke(model, new object[] { prop.Name });
                if (!isSet) return false;

                object value = prop.GetValue(model);
                Console.WriteLine($"DEBUG: {prop.Name} = {value}, IsSet: {isSet}");

                if (value == null)
                    return failOnExplicitNulls;

                return IsDefault(value);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Failed to check IsPropertySet for {prop.Name} — {ex.Message}");
                return false;
            }
        }


        private static bool IsDefault(object value)
        {
            Type type = value.GetType();
            if (!type.IsValueType) return false;
            object defaultValue = Activator.CreateInstance(type);
            return value.Equals(defaultValue);
        }
    }
}
