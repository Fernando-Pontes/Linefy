using System.Reflection;
using System.Text;

namespace Helper.Helper
{
    public static class Linefy
    {
        public static string ToLine<T>(T obj, char delimitador, bool gerarNomesColuna) where T : class
        {
            Type tipo = typeof(T);

            Console.WriteLine($"Lendo as propriedades de {tipo.Name}");
            StringBuilder sb = new StringBuilder();
            PropertyInfo[] properties = tipo.GetProperties();

            if (gerarNomesColuna)
            {
                for (int i = 0; i < properties.Length; i++)
                {

                    if (i != properties.Length - 1)
                        sb.Append(properties[i].Name + delimitador);
                    else
                        sb.AppendLine(properties[i].Name);
                }
            }
            string valor = string.Empty;

            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i].GetValue(obj) != null)
                    valor = properties[i].GetValue(obj).ToString();
                else
                    valor = string.Empty;

                if (i != properties.Length - 1)
                    sb.Append(valor + delimitador);
                else
                    sb.Append(properties[i].GetValue(obj));

            }
            Console.WriteLine(sb.ToString());
            return string.Empty;
        }
    }
}