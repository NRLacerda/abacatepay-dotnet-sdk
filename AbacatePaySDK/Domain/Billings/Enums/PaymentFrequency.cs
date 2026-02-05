using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace AbacatePaySDK.Domain.Billings.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PaymentFrequency
    {
        [EnumMember(Value = "ONE_TIME")]
        OneTime,

        [EnumMember(Value = "MULTIPLE_PAYMENTS")]
        MultiplePayments
    }

}
