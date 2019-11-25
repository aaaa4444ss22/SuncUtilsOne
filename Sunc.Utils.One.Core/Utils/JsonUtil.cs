
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Sunc.Utils.One.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunc.Utils.One.Core.Utils
{
    /// <summary>
    /// Json序列化工具
    /// </summary>
    public class JsonUtil
    {
        private static readonly JsonSerializerSettings _settings;
        private static readonly ILog log = LogManager.GetLogger(typeof(JsonUtil));

        private JsonUtil() { }

        static JsonUtil()
        {
            _settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        public static string ToJson(object value, JsonSerializerSettings settings = null)
        {
            string json = null;
            try
            {
                json = JsonConvert.SerializeObject(value
                   , settings.IsNotNull() ? settings : _settings);
            }
            catch (Exception e)
            {
                log.Error(e.Message);
            }
            return json;
        }
    }
}
