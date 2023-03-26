using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utilities.Helper
{
    public static class Helper
    {
        public static string ConvertPassword(string password)
        {
            string pass = "";
            for(int i=0; i</*password.Length*/ 6; i++)
            {
                pass += "*";
            }
            return pass;
        }

        public static DateTime ConvertDateTime(DateTime date)
        {
            return DateTime.ParseExact(date.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public static string ToUrlSlug(string value)
        {

            //First to lower case
            value = value.ToLowerInvariant();

            //Remove all accents
            var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(value);
            value = Encoding.ASCII.GetString(bytes);

            //Replace spaces
            value = Regex.Replace(value, @"\s", "-", RegexOptions.Compiled);

            //Remove invalid chars
            value = Regex.Replace(value, @"[^a-z0-9\s-_]", "", RegexOptions.Compiled);

            //Trim dashes from end
            value = value.Trim('-', '_');

            //Replace double occurences of - or _
            value = Regex.Replace(value, @"([-_]){2,}", "$1", RegexOptions.Compiled);

            return value;
        }

        public static Expression<Func<TSource, bool>> MultiSearchOrder<TSource>(string[] columns, string value)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(TSource), "x"); // x=>  . ... demektir. parametre
            MethodInfo containsMethod = typeof(String).GetMethod("Contains", new Type[] { typeof(String) });
            Expression dynamiclambda = null;
            MethodCallExpression call = null;
            foreach (var propertyName in columns)
            {

                MemberExpression propertyAccess = NestedExpressionProperty(parameter, propertyName);
                call = Expression.Call(propertyAccess, containsMethod, Expression.Constant(value));
                if (null == dynamiclambda)
                {
                    dynamiclambda = call;
                }
                else
                {
                    dynamiclambda = Expression.Or(dynamiclambda, call);
                }
            }
            Expression<Func<TSource, bool>> predicate = Expression.Lambda<Func<TSource, bool>>(dynamiclambda, parameter);

            return predicate;

        }

        private static MemberExpression NestedExpressionProperty(Expression expression, string propertyName)
        {
            string[] parts = propertyName.Split('.');
            int partsL = parts.Length;

            return (partsL > 1)
                ?
                Expression.Property(
                    NestedExpressionProperty(
                        expression,
                        parts.Take(partsL - 1)
                            .Aggregate((a, i) => a + "." + i)
                    ),
                    parts[partsL - 1])
                :
                Expression.Property(expression, propertyName);
        }
    }
}
