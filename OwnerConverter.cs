using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using static LAB_movies_.Company;

namespace LAB_movies_
{
    public class OwnerConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LegalEntity);  // Проверка типа
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);

            // Пример: Проверка на наличие свойства `TaxId`, чтобы определить тип владельца
            if (jsonObject["TaxId"] != null)  // Предположим, что у Company есть поле TaxId
            {
                return jsonObject.ToObject<Company>(serializer);  // Десериализация в Company
            }
            else
            {
                return jsonObject.ToObject<Individual>(serializer);  // Десериализация в Individual
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);  // Стандартная сериализация
        }
    }
}
